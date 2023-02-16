using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitedWorkProject.Models
{
    public class PostModel
    {
        public int postId { get; set; }
        public string postTitle { get; set; }
        public string postDescription { get; set; }
        public DateTime postDate { get; set; }
        public string postImgUrl { get; set; }
        public bool postStatus { get; set; }
        public int User { get; set; }
    }
}
