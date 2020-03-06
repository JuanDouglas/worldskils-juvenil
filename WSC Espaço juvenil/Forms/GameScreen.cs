using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSC_Espaço_juvenil.Forms
{
    public partial class GameScreen : Form
    {
        public List<PicImage> PicImages { get; set; }

        public GameScreen(string nome)
        {
            InitializeComponent();
            lblNome.Text = nome;
            PicImages = new List<PicImage>();
            povoa();
            pic1.Image = PicImages.FirstOrDefault(x => x.pic == 1).Image;
            pic2.Image = PicImages.FirstOrDefault(x => x.pic == 2).Image;
            pic3.Image = PicImages.FirstOrDefault(x => x.pic == 3).Image;
            pic4.Image = PicImages.FirstOrDefault(x => x.pic == 4).Image;
            pic5.Image = PicImages.FirstOrDefault(x => x.pic == 5).Image;
            pic6.Image = PicImages.FirstOrDefault(x => x.pic == 6).Image;
            pic7.Image = PicImages.FirstOrDefault(x => x.pic == 7).Image;
            pic8.Image = PicImages.FirstOrDefault(x => x.pic == 8).Image;
            pic9.Image = PicImages.FirstOrDefault(x => x.pic == 9).Image;
            pic10.Image = PicImages.FirstOrDefault(x => x.pic == 10).Image;
            pic11.Image = PicImages.FirstOrDefault(x => x.pic == 11).Image;
            pic12.Image = PicImages.FirstOrDefault(x => x.pic == 12).Image;
            pic13.Image = PicImages.FirstOrDefault(x => x.pic == 13).Image;
            pic14.Image = PicImages.FirstOrDefault(x => x.pic == 14).Image;
            pic15.Image = PicImages.FirstOrDefault(x => x.pic == 15).Image;
            pic16.Image = PicImages.FirstOrDefault(x => x.pic == 16).Image;

        }

        private void pic_Click(object sender, EventArgs e)
        {
            var pic = (PictureBox)sender;
            string tipo;
            string texto;
            switch (pic.Name)
            {
                case "Computador":
                    tipo = Properties.Resources.solu;
                    texto = Properties.Resources.DetailsSolu;
                    break;
                case "Refrigeracao":
                    tipo = Properties.Resources.refrigeração;
                    texto = Properties.Resources.DetailRefrigeracao;
                    break;
                case "Moda":
                    tipo = Properties.Resources.solu;
                    texto = Properties.Resources.DetailsSolu;
                    break;
                //case "Computador":
                //    tipo = Properties.Resources.solu;
                //    texto = Properties.Resources.DetailsSolu;
                //    break;
                //case "Computador":
                //    tipo = Properties.Resources.solu;
                //    texto = Properties.Resources.DetailsSolu;
                //    break;
                //case "Computador":
                //    tipo = Properties.Resources.solu;
                //    texto = Properties.Resources.DetailsSolu;
                //    break;
                //case "Computador":
                //    tipo = Properties.Resources.solu;
                //    texto = Properties.Resources.DetailsSolu;
                //    break;
                //case "Computador":
                //    tipo = Properties.Resources.solu;
                //    texto = Properties.Resources.DetailsSolu;
                //    break;
                default:
                    tipo = "not found";
                    texto = "not found";
                    break;
            }
            new PopUpDetails(pic.Image, tipo, texto).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void povoa()
        {r
            Images.Add(ilustrator.Image);
            Images.Add(Computador.Image);
            Images.Add(Redes.Image);
            Images.Add(Cadeira.Image);
            Images.Add(Moda.Image);
            Images.Add(Robo.Image);
            Images.Add(Refrigeracao.Image);
            do
            {
                var random = new Random();
                int pic = random.Next(0, 16);

                if (PicImages.Exists(x => x.pic == pic) == false)
                {
                    bool adicionou = false;
                    do
                    {
                        Bitmap image = new Bitmap(Images[random.Next(0, Images.Count)]);
                        var pesq = PicImages.Where(x => x.Image == image);
                        if (pesq.Count() < 2)
                        {
                            adicionou = true;
                            PicImages.Add(new PicImage { Image = image, pic = pic });
                        }
                    } while (adicionou == false);

                }

            } while (Images.Count < 16);
        }
    }
}
