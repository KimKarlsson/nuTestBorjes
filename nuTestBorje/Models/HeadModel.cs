using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nuTestBorje.Models
{
    public class HeadModel
    {
        public List<UrlModel> Url = new List<UrlModel>();
        public List<ImgModel> Img = new List<ImgModel>();
        public List<ChartModel> Chart = new List<ChartModel>();
        public List<VidModel> Vid = new List<VidModel>();
    }
}