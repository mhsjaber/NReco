using NReco.VideoConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VideoConverter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
            ffMpeg.ConvertMedia(@"C:\Users\Jaber\Videos\2017-05-20 12-14-27.flv", @"D:\video.mp4", Format.mp4);
            ffMpeg.GetVideoThumbnail(@"C:\Users\Jaber\Videos\2017-05-20 12-14-27.flv", @"D:\video_thumbnail.jpg");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}