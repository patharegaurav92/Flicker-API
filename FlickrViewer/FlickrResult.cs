using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickrViewer
{
   class FlickrResult
   {
      public string Title { get; set; }
      public string URL { get; set; }

        public static explicit operator FlickrResult(List<FlickrResult> v)
        {
            throw new NotImplementedException();
        }
    }
}
