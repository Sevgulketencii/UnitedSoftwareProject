using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnitedWorkProject.Models
{
    public class PostModel
    {
        public int postId { get; set; }
        [Required(ErrorMessage ="Boş Geçilemez")]
        public string postTitle { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        public string postDescription { get; set; }
        public DateTime postDate { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        public string postImgUrl { get; set; }
        public bool postStatus { get; set; }
        public int User { get; set; }
    }
}
