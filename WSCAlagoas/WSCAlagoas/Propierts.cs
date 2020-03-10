using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSCAlagoas
{
    class ImagePic
    {
        public System.Drawing.Image Image { get; set; }
        public System.Drawing.Point Location { get; set; }
        public string Name { get; set; }
        public ImagePic(System.Drawing.Image image, System.Drawing.Point location, string name)
        {
            Image = image;
            Location = location;
            Name = name;
        }
    }
    class ImageIn
    {
        public System.Drawing.Image Image { get; set; }
        public string Name { get; set; }
        public ImageIn(System.Drawing.Image image, string name)
        {
            Image = image;
            Name = name;
        }
    }
}
