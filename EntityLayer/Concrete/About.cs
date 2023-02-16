using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string AboutTittle { get; set; }
        public string AboutDescription { get; set; }
        public string AboutImgUrl { get; set; }
        public string AboutStatus { get; set; }
    }
}
