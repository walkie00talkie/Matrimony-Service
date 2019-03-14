using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace login_new.Models
{
    [MetadataType(typeof(usermetadata))]
    public partial class reg
    {

    }

    public class usermetadata
    {
        [Display(Name = "Id")]

        [Required(AllowEmptyStrings = false , ErrorMessage = "Id required")]
        public int Id { get; set; }

        [Display(Name = "pwd")]
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "password required")]
        [MinLength(6,ErrorMessage = "Must be need 6 characters")]
        public string pwd { get; set; }
    }
}