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
        static PictureBox[] keszitok = new PictureBox[3];
        static Label[] keszitoklabel = new Label[3];

        public Form1()
        {
            InitializeComponent();
        }

        //KIV KÉP ELHELYEZÉSE KEZD
            //KIVÁLASZTOTT BÁBÚ ELHELYEZÉSE
        private void jatekterklikk(object sender, EventArgs e)
        {
            PictureBox klikkelt = sender as PictureBox;

            int sor = Convert.ToInt32(klikkelt.Name.Split('_')[1]);
            int oszlop = Convert.ToInt32(klikkelt.Name.Split('_')[2]);

            if (jelenlegikep.BackgroundImage != null)
            {
                jatekter[sor, oszlop].BackgroundImage = jelenlegikep.BackgroundImage;
                jatekter[sor, oszlop].Name = jelenlegikep.Name;
                jatekter[sor, oszlop].Enabled = false;
            }
            else
            {
                MessageBox.Show("Kérem válasszon egy bábút");
            }
            

            if(jatekter[sor, oszlop].BackgroundImage == jelenlegikep.BackgroundImage)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (babuk[i, j].BackgroundImage == jelenlegikep.BackgroundImage)
                        {
                            babuk[i, j].Visible = false;
                        }
                    }
                }
                jelenlegikep.BackgroundImage = null;
            }

            jatekterEllenorzes();
        }

        private void jatekterEllenorzes()
        {
            List<string> babuKod = new List<string>();
            List<string> babuKodAtloBal = new List<string>();
            List<string> babuKodAtloJobb = new List<string>();


            //BAL ÁTLÓ ELLENÖRZÉS
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j && jatekter[i, j].BackgroundImage != null)
                    {
                        babuKodAtloBal.Add(jatekter[i, j].Name);
                    }
                }
                if (babuKodAtloBal.Count == 4)
                {
                    kodEllenorzes(babuKod, babuKodAtloBal, babuKodAtloJobb);
                    break;
                }
            }

            //JOBB ÁTLÓ ELLENÖRZÉS
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i + j == 3 && jatekter[i, j].BackgroundImage != null)
                    {
                        babuKodAtloJobb.Add(jatekter[i, j].Name);
                    }
                }
                if (babuKodAtloJobb.Count == 4)
                {
                    kodEllenorzes(babuKod, babuKodAtloBal, babuKodAtloJobb);
                    break;
                }
            }

            //VÍZSZINTES ELLENÖRZÉS
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (jatekter[i, j].BackgroundImage != null)
                    {
                        babuKod.Add(jatekter[i, j].Name);
                    }
                }
                if (babuKod.Count == 4)
                {
                    kodEllenorzes(babuKod, babuKodAtloBal, babuKodAtloJobb);
                    break;
                }
                else
                {
                    babuKod.Clear();
                }
            }

            //FÜGGŐLEGES ELLENÖRZÉS
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (jatekter[j, i].BackgroundImage != null)
                    {
                        babuKod.Add(jatekter[j, i].Name);
                    }
                }
                if (babuKod.Count == 4)
                {
                    kodEllenorzes(babuKod, babuKodAtloBal, babuKodAtloJobb);
                    break;
                }
                else
                {
                    babuKod.Clear();
                }
            }
            

            
        }

        //A LISTÁBA TÖLTÖTT BINÁRIS SZÁMOK ELLENÖRZÉSE
        private void kodEllenorzes(List<string> babuKod, List<string> babuKodAtloBal, List<string> babuKodAtloJobb)
        {
            string[,] kodTabla = new string[4, 4];
                //LISTA 2D TÖMBBEN
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (babuKod.Count == 4)
                    {
                        kodTabla[i, j] = babuKod[i].Substring(j, 1);
                    }
                    else if (babuKodAtloBal.Count == 4)
                    {
                        kodTabla[i, j] = babuKodAtloBal[i].Substring(j, 1);
                    }
                    else if (babuKodAtloJobb.Count == 4)
                    {
                        kodTabla[i, j] = babuKodAtloJobb[i].Substring(j, 1);
                    }
                }
            }
                //2D TÖMB OSZLOPOS NÉZETE
            string ell = "";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    ell += $"{kodTabla[j,i]}";
                }
            }
            if (ell.Contains("0000"))
            {
                MessageBox.Show("nyert");
            }
            else if (ell.Contains("1111"))
            {
                MessageBox.Show("nyert");
            }

        }

        //KIVÁLASZTOTT BÁBÚ
        private void babuklikk(object sender, EventArgs e)
        {
            PictureBox klikkelt = sender as PictureBox;

            int sor = Convert.ToInt32(klikkelt.Name.Split('_')[1]);
            int oszlop = Convert.ToInt32(klikkelt.Name.Split('_')[2]);

            jelenlegikep.BackgroundImage = babuk[sor, oszlop].BackgroundImage;
            jelenlegikep.Name = Convert.ToString(klikkelt.Name.Split('_')[3]);
        }

        //KIVÁLASZTOTT BÁBÚ ELHELYEZÉSE VÉGE

        //START KEZD
        private void start_BTN_Click(object sender, EventArgs e)
        {
            jatekosnevellenorzes();
        }
        //START VÉGE

        private void jatekterletrehozas()
        {
            label1.Visible = false;
            label2.Visible = false;
            start_BTN.Visible = false;
            jatekos1_TBOX.Visible = false;
            jatekos2_TBOX.Visible = false;
            pictureBox1.Visible = false;
            label3.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
            richTextBox1.Visible = false;
            button2.Visible = false;

            int x = 286;
            int y = 30;


            //JÁTÉK TÉR
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    PictureBox kep1 = new PictureBox();
                    kep1.Size = new Size(100, 100);
                    kep1.Location = new Point(x + 6, y);
                    kep1.BackColor = Color.White;
                    kep1.MouseClick += new MouseEventHandler(jatekterklikk);
                    kep1.Name = $"jatek_{i}_{j}";
                    this.Controls.Add(kep1);
                    jatekter[i, j] = kep1;

                    x += 106;
                }

                x = 286;
                y += 106;
            }
            //JÁTÉK TÉR

            x = 76;
            y = 500;
            int f = 0;
            
            //BÁBÚFELSOROLÁS
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    PictureBox babu = new PictureBox();
                    babu.Size = new Size(100, 100);
                    babu.Name = $"babu_{i}_{j}_{tulajdonsag(f)}";
                    babu.BackgroundImage = keplista.Images[f];
                    babu.Location = new Point(x + 6, y);
                    babu.MouseClick += new MouseEventHandler(babuklikk);
                    babuk[i, j] = babu;
                    this.Controls.Add(babu);
                    f++;
                    x += 106;
                }
                x = 76;
                y += 106;
            }
            //BÁBÚFELSOROLÁS

            this.MaximumSize = new Size(1000, 1000);
            this.Size = new Size(1000, 900);
            jelenlegipicture();
        }

        private object tulajdonsag(int f)
        {
            return $"{f / 8 % 2}{f / 4 % 2}{f / 2 % 2}{f % 2}";
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

            jelenlegikep = new PictureBox();
            jelenlegikep.Location = new Point(100, 200);
            jelenlegikep.Size = new Size(100, 100);
            this.Controls.Add(jelenlegikep);
        }

        private void jatekosnevellenorzes()
        {
            nev1 = jatekos1_TBOX.Text;
            nev2 = jatekos2_TBOX.Text;
            /*
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
                
            }
            */
            jatekterletrehozas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            button2.Visible = false;
        }

        //KÉSZÍTŐK KEZD
        private void button3_Click(object sender, EventArgs e)
        {
            PictureBox picturebox1 = new PictureBox();
            picturebox1.Location = new Point(-6, -4);
            picturebox1.Size = new Size(212, 508);
            picturebox1.BackColor = Color.White;
            pictureBox1.Visible = false;
            picturebox1.Image = imageList1.Images["koppany.jpg"];
            picturebox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picturebox1);
            PictureBox picturebox2 = new PictureBox();
            picturebox2.Location = new Point(160, -12);
            picturebox2.Size = new Size(212, 508);
            picturebox2.BackColor = Color.White;
            pictureBox1.Visible = false;
            picturebox2.Image = imageList1.Images["ricsko.jpg"];
            picturebox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picturebox2);
            PictureBox picturebox3 = new PictureBox();
            picturebox3.Location = new Point(350, -2);
            picturebox3.Size = new Size(212, 508);
            picturebox3.BackColor = Color.White;
            pictureBox1.Visible = false;
            picturebox3.Image = imageList1.Images["adrian.jpg"];
            picturebox3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picturebox3);
            Label kopi = new Label();
            kopi.Location = new Point(45, 45);
            this.Controls.Add(kopi);
            kopi.BringToFront();
            kopi.Text = "kopi";
            kopi.ForeColor = Color.White;
            Label ricsi = new Label();
            ricsi.Location = new Point(244, 26);
            this.Controls.Add(ricsi);
            ricsi.BringToFront();
            ricsi.Text = "ricsi";
            ricsi.ForeColor = Color.White;
            Label adrian = new Label();
            adrian.Location = new Point(400, 35);
            this.Controls.Add(adrian);
            adrian.BringToFront();
            adrian.Text = "adrian";
            adrian.ForeColor = Color.White;
            label3.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            jatekos1_TBOX.Visible = false;
            jatekos2_TBOX.Visible = false;
            start_BTN.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            keszitok[0] = picturebox1;
            keszitok[1] = picturebox2;
            keszitok[2] = picturebox3;
            keszitoklabel[0] = ricsi;
            keszitoklabel[1] = kopi;
            keszitoklabel[2] = adrian;
            richTextBox1.Visible = false;
            button2.Visible = false;
        }
        //KÉSZÍTŐK VÉGE

        //X BUTTON KEZD
        private void button4_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label2.Visible = true;
            label1.Visible = true;
            jatekos1_TBOX.Visible = true;
            jatekos2_TBOX.Visible = true;
            start_BTN.Visible = true;
            button1.Visible = true;
            button3.Visible = true;
            pictureBox1.Visible = true;
            keszitok[0].Visible = false;
            keszitok[1].Visible = false;
            keszitok[2].Visible = false;
            keszitoklabel[0].Visible = false;
            keszitoklabel[1].Visible = false;
            keszitoklabel[2].Visible = false;
            button4.Visible = false;
        }
        //X BUTTON VÉGE
    }
}
