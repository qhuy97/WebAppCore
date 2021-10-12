using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebAppCore.Infrastructure.SharedKernel;

namespace WebAppCore.Data.Entities
{
    public class Tag : DomainEntity<string>
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        [MaxLength(150)]
        public string Type { get; set; }
    }
}
