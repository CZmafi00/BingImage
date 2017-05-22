using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingImage
{
    public static class BingImageUtilities
    {
        ///<summary>
        ///Returns uri for downloading image binary. 
        ///</summary>
        public static string GetUri(this BingImage image)
        {
            string urlBase = "http://bing.com";
            string uri = image.Images[0].Url;

            return urlBase + uri;
        }
        ///<summary>
        ///Sets resolution of the image. 
        ///</summary>
        /// <param name="resolution">Image resolution. We recommend using BingImageResolutions string values.</param>
        public static void SetResolution(this BingImage image, string resolution)
        {
            string imageUrl = image.Images[0].Url;
            int indexOfSeparator = imageUrl.LastIndexOf("_");
            int indexOfExtension = imageUrl.LastIndexOf(".");

            string extension = imageUrl.Substring(indexOfExtension);
            imageUrl = imageUrl.Remove(indexOfSeparator);

            image.Images[0].Url = imageUrl + resolution + extension;
        }
    }
}
