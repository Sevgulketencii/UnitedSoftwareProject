using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PostApi.DataAccessLayer
{
    public class Post
    {
        [Key]
        public int postId { get; set; }
        public string postTitle { get; set; }
        public string postDescription { get; set; }
        public DateTime postDate { get; set; }
        public string postImgUrl { get; set; }
        public bool postStatus { get; set; }
        public int User { get; set; }
        public virtual List<FoodPost> FPost {get; set;}
    }
}
