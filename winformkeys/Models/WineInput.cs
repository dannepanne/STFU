using Microsoft.ML.Data;
using Microsoft.ML.Transforms.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformkeys.Models
{
    public class WineInput
    {
        [ImageType(ImageSettings.imageHeight, ImageSettings.imageWidth)]
        
        public Bitmap Image { get; set; }
    }
}
