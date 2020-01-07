using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OneForAll.Core.DDD
{
    public class Entity<TType>
    {
        [Key]
        [Required]
        public virtual TType Id { get; set; }
    }
}
