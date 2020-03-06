using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSC_Espaço_juvenil.Properties;

namespace WSC_Espaço_juvenil.Forms
{
    public partial class GameScreen : Form
    {
        public List<PicImage> PicImages { get; set; }
        private List<PicImage> Images { get; set; }
        private List<PictureBox> picgame { get; set; }
        private bool Jogando { get; set; }
        private int Pontos { get; set; }
        public GameScreen(string nome)
        {
            InitializeComponent();
            lblNome.Text = nome;
            PicImages = new List<PicImage>();
            Images = new List<PicImage>();
            picgame = new List<PictureBox>();
            CriaOJogo();
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
                case "Carro":
                    tipo = Properties.Resources.auto;
                    texto = Properties.Resources.DetailAuto;
                    break;
                case "Robo":
                    tipo = Properties.Resources.robotica;
                    texto = Properties.Resources.DetailRobotica;
                    break;
                case "Cadeira":
                    tipo = Properties.Resources.moveis;
                    texto = Properties.Resources.DetailMoveis;
                    break;
                case "Ilustrator":
                    tipo = Properties.Resources.design;
                    texto = Properties.Resources.DetailDesigner;
                    break;
                case "Redes":
                    tipo = Properties.Resources.redesd;
                    texto = Properties.Resources.DetailRedes;
                    break;
                default:
                    tipo = "not found";
                    texto = "not found";
                    break;
            }
            new PopUpDetails(pic.Image, tipo, texto).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jogando = true;
            limpaOJogo();
        }
        private void limpaOJogo()
        {
            pic1.Image = null;
            pic2.Image = null;
            pic3.Image = null;
            pic4.Image = null;
            pic5.Image = null;
            pic6.Image = null;
            pic7.Image = null;
            pic8.Image = null;
            pic9.Image = null;
            pic10.Image = null;
            pic11.Image = null;
            pic12.Image = null;
            pic13.Image = null;
            pic14.Image = null;
            pic15.Image = null;
            pic16.Image = null;
        }
        private void CriaOJogo()
        {
            Jogando = false;
            povoa();
            enchePic();
            foreach (PictureBox picture in picgame)
            {
                picture.Image = PicImages.FirstOrDefault(x => x.pic == GetInt(picture.Name) - 1).Image;
            }
        }
        private void enchePic()
        {
            picgame.Add(pic1);
            picgame.Add(pic2);
            picgame.Add(pic3);
            picgame.Add(pic4);
            picgame.Add(pic5);
            picgame.Add(pic6);
            picgame.Add(pic7);
            picgame.Add(pic8);
            picgame.Add(pic9);
            picgame.Add(pic10);
            picgame.Add(pic11);
            picgame.Add(pic12);
            picgame.Add(pic13);
            picgame.Add(pic14);
            picgame.Add(pic15);
            picgame.Add(pic16);
        }
        private void povoa()
        {
            Images.Add(new PicImage { Image = Robo.Image, Name = Robo.Name });
            Images.Add(new PicImage { Image = Carro.Image, Name = Carro.Name });
            Images.Add(new PicImage { Image = Computador.Image, Name = Computador.Name });
            Images.Add(new PicImage { Image = ilustrator.Image, Name = ilustrator.Name });
            Images.Add(new PicImage { Image = Moda.Image, Name = Moda.Name });
            Images.Add(new PicImage { Image = Redes.Image, Name = Redes.Name });
            Images.Add(new PicImage { Image = Refrigeracao.Image, Name = Refrigeracao.Name });
            Images.Add(new PicImage { Image = Cadeira.Image, Name = Cadeira.Name });
            PicImages = new List<PicImage>();
            while (PicImages.Count < 16 == true)
            {
                var random = new Random();
                int pic = random.Next(0, 16);
                if (PicImages.Exists(x => x.pic == pic) == false)
                {
                    bool adicionou = false;
                    do
                    {
                        PicImage image = new PicImage();
                        image = Images[random.Next(0, Images.Count)];
                        var pesq = PicImages.Where(x => x.Name.Equals(image.Name));
                        if (pesq.Count() < 2)
                        {
                            adicionou = true;
                            PicImages.Add(new PicImage { Image = image.Image, pic = pic, Name = image.Name });
                        }
                    } while (adicionou == false);
                }
            }
        }
        private int GetInt(string text)
        {
            string textInt = "";
            string numbers = "123456789";
            foreach (char letra in text)
            {
                foreach (char number in numbers)
                {
                    if (letra == number)
                    {
                        textInt += letra;
                    }
                }
            }
            return int.Parse(textInt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CriaOJogo();
        }

        private void picGame_Click(object sender, EventArgs e)
        {
            if (Jogando && picgame.Count(x => x.Image != null) < 2)
            {
                var pic = (PictureBox)sender;
                pic.Image = PicImages.FirstOrDefault(x => x.pic == GetInt(pic.Name) - 1).Image;
                var picname = (PictureBox)sender;
                if (true)
                {
                    Pontos++;
                }
                lblPontos.Text = Pontos.ToString();
            }
            else
            {
                limpaOJogo();
            }
        }
    }
}
