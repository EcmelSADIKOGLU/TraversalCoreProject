using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Destination
    {
        [Key]
        public int DestinationID { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public string Image2URL { get; set; }
        public string Description { get; set; }
        public string CoverImageURL { get; set; }
        public string Details1 { get; set; }
        public string Details2 { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }

        //Comment
        public List<Comment> Comments { get; set; }

    }
}
