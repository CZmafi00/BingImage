using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingImage
{
    ///<summary>
    ///Class contains available resolutions for wide screens and mobile screens.  
    ///</summary>
    public class BingImageResolutions
    {
        ///<summary>
        ///Available wide screen resolutions.  
        ///</summary>          
        public static class WideScreenRes_16_9
        {
            public static string _640x360 = "_640x360";
            public static string _720x405 = "_720x405";
            public static string _854x480 = "_854x480";
            public static string _960x540 = "_960x540";
            public static string _1024x576 = "_1024x576";
            public static string _1280x720 = "_1280x720";
            public static string _1366x768 = "_1366x768";
            public static string _1920x1080 = "_1920x1080";
        }
        ///<summary>
        ///Available mobile screen resolutions.   
        ///</summary>
        public static class MobileScreen_9_16
        {
            public static string _720x1280 = "_720x1280";
            public static string _768x1366 = "_768x1366";
            public static string _900x1600 = "_900x1600";
            public static string _1080x1920 = "_1080x1920";
        }
    }
}
