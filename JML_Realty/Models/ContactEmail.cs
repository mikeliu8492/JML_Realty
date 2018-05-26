using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JML_Realty.Models
{
    public class ContactEmail
    {
        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress), Display(Name = "From")]
        [Required]
        public string FromEmail { get; set; }

        [Display(Name = "Subject")]
        public string EmailSubject { get; set; }

        [Display(Name = "Message")]
        [DataType(DataType.MultilineText)]
        public string EmailBody { get; set; }
    }
}