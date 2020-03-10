using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace WSCAlagoas
{
    internal class Game
    {
        public List<ImagePic> BasePic { get; set; }
        public List<ImageIn> ImagesIn { get; set; }
        public List<ImagePic> ShowPics { get; set; }
        public int Pontos { get; set; }
        public Game(List<ImageIn> images)
        {
            ImagesIn = images;
        }
        public void CreateGame()
        {
            BasePic = new List<ImagePic>();
            foreach (ImageIn image in ImagesIn)
            {
                int count = 0;
                while (count < 2)
                {
                    Random random = new Random();
                    var pic = new ImagePic(
                        image.Image,
                        new Point(random.Next(0, 8), random.Next(1, 9)),
                        image.Name);
                    if (pic.Location == new Point(0, 0)) pic.Location = new Point(1, 0);
                    if (Validate(pic))
                    {
                        BasePic.Add(pic);
                        count++;
                    }
                }
            }
        }
        private bool Validate(ImagePic imagePic)
        {
            bool valid = true;
            if (BasePic.Count(cont => cont.Location == imagePic.Location) != 0)
                valid = false;
            else if (BasePic.Count(cont => cont.Name == imagePic.Name) == 2)
                valid = false;
            return valid;
        }
        public void doubleSelected(PictureBox picture1, PictureBox picture2)
        {
            var obj = new List<ImagePic>()
            {
                BasePic.FirstOrDefault(pic => pic.Location.X + pic.Location.Y == GetInt.Get(picture1.Name)),
                BasePic.FirstOrDefault(pic => pic.Location.X + pic.Location.Y == GetInt.Get(picture2.Name))
            };
            var names = new string[] { obj[0].Name, obj[1].Name };
            if (names[0] == names[1])
            {
                ShowPics.Add(obj.FirstOrDefault(objs => objs.Location.X + objs.Location.Y == GetInt.Get(picture1.Name)));
                ShowPics.Add(obj.FirstOrDefault(objs => objs.Location.X + objs.Location.Y == GetInt.Get(picture2.Name)));
            }
        }
    }
}
