using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcWebApp.Models
{
    public class Gallery
    {
        public IList<Progression> Progressions { get; set; }
        public IList<Thumbnail> Thumbnails { get; set; }
    }
}