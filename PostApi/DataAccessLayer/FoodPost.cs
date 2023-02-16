using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PostApi.DataAccessLayer
{
    public class FoodPost
    {
        [Key]
        public int FoodPostId { get; set; }
        public string FPostDescription{ get; set; }
        public DateTime FPosttDate{ get; set; }
        public bool FPostStatus{ get; set; }
        public Post Post { get; set; }
    }
}
