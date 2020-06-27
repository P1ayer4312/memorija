using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorija
{
    public partial class Form1 : Form
    {
        private int[] clock;
        // chuvanje na selektiranite polinja
        private PictureBox slika1;
        private PictureBox slika2;
        // niza od site polinja
        private PictureBox[] slikiSite;
        // 0 = zachuvaj go poleto vo slika1, 1 = zachuvaj go poleto vo slika2, 3 = onevozmozhi gi polinjata privremeno
        private int state;
        // brojach koj broi ushte kolku polinja treba da bidat otvoreni za kraj na igrata
        private int counter;
        // niza od iminja na slikite
        private string[] niza;

        public Form1()
        {
            InitializeComponent();
            slika1 = null;
            slika2 = null;
            state = 0;
            counter = 0;
            clock = new int[] { 0, 0 };
            niza = null;
            //zachuvuvanje na site polinja vo slikiSite nizata
            slikiSite = new PictureBox[] { p00, p01, p02, p03, p10, p11, p12, p13, p20, p21, p22, p23, p30, p31, p32, p33 };
            this.BackgroundImage = Image.FromFile(".\\img\\background.jpg");
            Reset();
        }

        public void Reset()
        {
            int size = 15;
            int pick = 0;
            counter = 0;
            clock[0] = 0; 
            clock[1] = 0;
            label1.Text = "00:00";
            timer1.Enabled = true;
            Random random = new Random();
            state = 0;
            niza = new string[] {"1.jpg", "2.jpg", "3.jpg", "4.jpg","5.jpg", "6.jpg", "7.jpg", "8.jpg",
                                "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg", "7.jpg", "8.jpg" };
            for (int i = 0; i < 16; i++)
            {
                slikiSite[i].BackgroundImage = Image.FromFile(".\\img\\cover.jpg");
                pick = random.Next(0, size);
                slikiSite[i].Tag = ".\\img\\" + niza[pick];
                slikiSite[i].AccessibleDescription = "0";
                //slikiSite[i].BackgroundImage = Image.FromFile(slikiSite[i].Tag.ToString());
                niza[pick] = niza[size--];
            }
        }

        public void Check(PictureBox pb)
        {
            pb.AccessibleDescription = "1";
            if (state == 0)
            {
                slika1 = pb;
                state = 1;
            }
            else
            {
                slika2 = pb;
                if (!slika1.Tag.ToString().Equals(slika2.Tag.ToString()))
                {
                    ShortPause.Enabled = true;
                    state = 3;
                }
                else
                {
                    counter++;
                    if (counter == 8)
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("You won!\nTime: " + label1.Text, "Congrats");
                        return;
                    }
                    state = 0;
                }
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            // proveruva dali e kliknato na otvoreno pole ili prethodnite
            // polinja se seushte otvoreni i ja pauzira igrata privremeno
            if (state == 3 || pb.AccessibleDescription.Equals("1")) return;
            pb.BackgroundImage = Image.FromFile(pb.Tag.ToString());
            Check(pb);
        }

        private void ShortPause_Tick(object sender, EventArgs e)
        {
            // zatvoranje na polinjata
            slika1.BackgroundImage = Image.FromFile(".\\img\\cover.jpg");
            slika2.BackgroundImage = Image.FromFile(".\\img\\cover.jpg");
            slika1.AccessibleDescription = "0";
            slika2.AccessibleDescription = "0";
            state = 0;
            slika1 = null;
            ShortPause.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // logika za vremeto
            if (clock[0] == 60)
            {
                clock[0] = 0;
                clock[1]++;
            }
            label1.Text = String.Format("{0:D2}:{1:D2}", clock[1], clock[0]);
            clock[0]++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // postavuvanje na custom font
            PrivateFontCollection font = new PrivateFontCollection();
            font.AddFontFile(".\\img\\MinecraftRegular-Bmg3.otf");
            label1.Font = new Font(font.Families[0], 20);
            label2.Font = new Font(font.Families[0], 20);
            button1.Font = new Font(font.Families[0], 12);
        }
    }
}
