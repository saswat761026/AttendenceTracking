using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracking.Entities
{
    public class LoginCredentials
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Serial_Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mid Required")]
        public string Mid { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password Required")]
        public string Password { get; set; }
        
    }
}
