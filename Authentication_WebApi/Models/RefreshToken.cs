using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication_WebApi.Models
{
    public class RefreshToken
    {
        [Key]
        public int TokenId { get; set; }

        [Required]
        public string Token { get; set; }

        [Required]
        public DateTime Expiration { get; set; }
    }
}
