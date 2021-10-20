using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quarto_SZR_LA_KKG
{
    public partial class Form1 : Form
    {
        static PictureBox[,] jatekter = new PictureBox[4, 4];
        static PictureBox[,] babuk = new PictureBox[2, 8];
        static string nev1 = "";
        static string nev2 = "";
        static PictureBox jelenlegikep;

        public Form1()
        {
            InitializeComponent();
        }

        private void klikk(object sender, EventArgs e)
        {
            PictureBox klikkelt = sender as PictureBox;

            int sor = Convert.ToInt32(klikkelt.Name.Split('_')[1]);
            int oszlop = Convert.ToInt32(klikkelt.Name.Split('_')[2]);

            MessageBox.Show($"{Convert.ToString(sor)} , {Convert.ToString(oszlop)}");

            jelenlegikep.Image = babuk[sor, oszlop].Image;
        }

        private void start_BTN_Click(object sender, EventArgs e)
        {
            jatekosnevellenorzes();
        }

        private void jatekterletrehozas()
        {
            label1.Visible = false;
            label2.Visible = false;
            start_BTN.Visible = false;
            jatekos1_TBOX.Visible = false;
            jatekos2_TBOX.Visible = false;

            int x = 286;
            int y = 30;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {


                    PictureBox kep1 = new PictureBox();
                    kep1.Size = new Size(100, 100);
                    kep1.Location = new Point(x + 6, y);
                    kep1.BackColor = Color.White;

                    this.Controls.Add(kep1);
                    jatekter[i, j] = kep1;

                    x += 106;
                }

                x = 286;
                y += 106;
            }

            x = 76;
            y = 500;
            int f = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    PictureBox babu = new PictureBox();
                    babu.Size = new Size(100, 100);
                    babuk[i, j] = babu;
                    babu.Name = $"babu_{i}_{j}";
                    babu.BackgroundImage = keplista.Images[f];
                    f++;
                    babu.Location = new Point(x + 6, y);
                    this.Controls.Add(babu);
                    babu.MouseClick += new MouseEventHandler(klikk);
                    x += 106;
                }
                x = 76;
                y += 106;
            }

            this.MaximumSize = new Size(1000, 1000);
            this.Size = new Size(1000, 900);
            jelenlegipicture();
        }

        private void jelenlegipicture()
        {

            Label labeljelen = new Label();
            labeljelen.Location = new Point(75, 140);
            labeljelen.Text = "Jelenlegi bábú";
            labeljelen.Font = new Font("Arial", 14, FontStyle.Bold);
            labeljelen.ForeColor = System.Drawing.Color.White;
            labeljelen.Size = new Size(200, 50);
            this.Controls.Add(labeljelen);

            PictureBox jelenlegikep = new PictureBox();
            jelenlegikep.Location = new Point(100, 200);
            jelenlegikep.Size = new Size(100, 100);

            this.Controls.Add(jelenlegikep);

        }

        private void jatekosnevellenorzes()
        {
            nev1 = jatekos1_TBOX.Text;
            nev2 = jatekos2_TBOX.Text;

            if(Convert.ToString(nev1) == "")
            {
                MessageBox.Show("Add meg az első játékos nevét!");
            }
            else if(Convert.ToString(nev2) == "")
            {
                MessageBox.Show("Add meg a második játékos nevét!");
            }
            else 
            {
                jatekterletrehozas();
            }
        }
    }
}
