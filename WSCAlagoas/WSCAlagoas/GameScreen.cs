using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSCAlagoas
{
    public partial class GameScreen : Form
    {
        private Game Game { get; set; }
        private List<PictureBox> Pictures { get; set; }
        private List<PictureBox> Selected { get; set; }
        public GameScreen()
        {
            InitializeComponent();
            Pictures = new List<PictureBox>();
            Selected = new List<PictureBox>();
            Pictures.Add(pic1);
            Pictures.Add(pic2);
            Pictures.Add(pic3);
            Pictures.Add(pic4);
            Pictures.Add(pic5);
            Pictures.Add(pic6);
            Pictures.Add(pic7);
            Pictures.Add(pic8);
            Pictures.Add(pic9);
            Pictures.Add(pic10);
            Pictures.Add(pic11);
            Pictures.Add(pic12);
            Pictures.Add(pic13);
            Pictures.Add(pic14);
            Pictures.Add(pic15);
            Pictures.Add(pic16);
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            Game = new Game(new List<ImageIn>
            {
                new ImageIn(Properties.Resources.camiseta,"Camiseta"),
                new ImageIn(Properties.Resources.carro,"Carro"),
                new ImageIn(Properties.Resources.computador,"Computador"),
                new ImageIn(Properties.Resources.illustrator,"Ilustrator"),
                new ImageIn(Properties.Resources.madeira,"Madeira"),
                new ImageIn(Properties.Resources.redes,"Redes"),
                new ImageIn(Properties.Resources.robo,"Robo"),
                new ImageIn(Properties.Resources.refrigerador,"Refrigerador"),
            });
            Game.CreateGame();
            FillPic();
        }
        private void FillPic() {
            foreach(ImagePic images in Game.BasePic)
            {
                var number = images.Location.X + images.Location.Y;
                var pic = Pictures.FirstOrDefault(picture => GetInt.Get(picture.Name) == number);
                pic.Image = images.Image;
            }
        }
        private void FillShowPic()
        {
            foreach (ImagePic images in Game.BasePic)
            {
                var number = images.Location.X + images.Location.Y;
                var pic = Pictures.FirstOrDefault(picture => GetInt.Get(picture.Name) == number);
                pic.Image = images.Image;
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            FillShowPic();
            var pic = (PictureBox)sender;
            if (Selected.Count < 2) 
                Selected.Add(pic);
            if (Selected.Count == 2)
            {
                Game.doubleSelected(Selected[0], Selected[1]);
                Selected = new List<PictureBox>();
            }
        }
        private void btnJogar_Click(object sender, EventArgs e)
        {
            foreach (PictureBox picture in Pictures)
                picture.Image = null;
        }
    }
}
