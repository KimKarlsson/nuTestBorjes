using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nuTestBorje.Models
{
    public class HeadModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public UrlModel UrlSlide { get; set; }
        public ImgModel ImgSlide { get; set; }
        public VidModel VidSlide { get; set; }
        public ChartModel ChartSlide { get; set; }
    }
}