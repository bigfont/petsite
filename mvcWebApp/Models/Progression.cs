using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcWebApp.Models
{
    public class Progression
    {
        /// <summary>
        /// Gets the name of the progression.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets the site-root relative paths of each image in the progression.
        /// E.g. "Images/SampleImage.jpg" or "Images/SomeDir/SampleImage.jpg"
        /// </summary>
        public string[] ImagePaths { get; set; }
    }
}