using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nuTestBorje.Models
{
    public class UrlModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string ActuallUrl { get; set; }
        public string description { get; set; }
        public DateTime UploadDate { get; set; }
        public int OrderIndex { get; set; }
        public bool Active { get; set;  }
        //public List<UrlModel> listUrl = new List<UrlModel>();
    }
}