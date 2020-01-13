using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneForAll.Core.Extension;
using OneForAll.Core.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneForAll.Core.Test
{
    [TestClass()]
    public class CollectionExtensionTest
    {
        [TestMethod()]
        public void FindChildrenTest()
        {
            var parent = new Tree()
            {
                Id = 1,
                ParentId = 0
            };
            var list = new List<Tree>()
            {
                new Tree() { Id = 2, ParentId = 1, Name = "姓名1" },
                new Tree() { Id = 3, ParentId = 1, Name = "姓名2" },
                new Tree() { Id = 4, ParentId = 1, Name = "姓名3" },
                new Tree() { Id = 5, ParentId = 2, Name = "姓名4" },
            };
            var children = CollectionHelper.FindChildren<Tree, int>(list, parent, false);
            var children2 = list.FindChildren<Tree, int>(parent, true);
        }
    }

    public class Tree : IEntity<int>, IParent<int>
    {
        public int Id { get; set; }

        public int ParentId { get; set; }
        public string Name { get; set; }
    }
}