using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace OneForAll.Core.Security
{
    /// <summary>
    /// 帮助类：AES加密解密
    /// </summary>
    public static class AESHelper
    {

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="input">要加密的内容</param>
        /// <param name="key">密钥（16或者32位）</param>
        /// <returns>Base64转码后的密文</returns>
        public static string Encrypt(string input, string key)
        {
            if (key.Length != 16 || key.Length != 32)
            {
                throw new Exception("The secret key length must be 16 bits or 32 bits");
            }
            var keyArray = Encoding.UTF8.GetBytes(key);
            var toEncryptArray = Encoding.UTF8.GetBytes(input);
            var rDel = new RijndaelManaged();   
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB; 
            rDel.Padding = PaddingMode.PKCS7;
            var cTransform = rDel.CreateEncryptor();
            var resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="input">要解密的内容</param>
        /// <param name="key">密钥（16或者32位）</param>
        /// <returns>解密后的明文</returns>
        public static string Decrypt(string input, string key)
        {
            if (key.Length != 16 || key.Length != 32)
            {
                throw new Exception("The secret key length must be 16 bits or 32 bits");
            }
            var keyArray = Encoding.UTF8.GetBytes(key);
            var toEncryptArray = Convert.FromBase64String(input);
            var rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB;
            rDel.Padding = PaddingMode.PKCS7;
            var cTransform = rDel.CreateDecryptor();
            var resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Encoding.UTF8.GetString(resultArray);
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="input">要加密的内容</param>
        /// <param name="key">密钥（16或者32位）</param>
        /// <returns>Base64转码后的密文</returns>
        public static string ToAES(this string input, string key)
        {
            return Encrypt(input, key);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="input">要解密的内容</param>
        /// <param name="key">密钥（16或者32位）</param>
        /// <returns>解密后的明文</returns>
        public static string FromAES(this string input, string key)
        {
            return Decrypt(input, key);
        }
    }
}
