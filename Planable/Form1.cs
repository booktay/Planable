using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Media;

namespace Planable
{    

    public partial class Index : MaterialForm
    {
        Form2 form2 = new Form2();
        public Index()
        {
            InitializeComponent();
            parent();
            form2.ShowDialog();            
        }

        void loopsound()
        {
            SoundPlayer audio = new SoundPlayer(global::Planable.Properties.Resources.bgs);
            audio.PlayLooping();
        }

        void parent()
        {
            pbPlay1.Parent = pbBg;
            pbPlay2.Parent = pbBg;
            pbPlay3.Parent = pbBg;
            pbFlag.Parent = pbBg;
        }        

        int iBg = 1, pctIndex1 = 1, pctIndex2 = 1, pctIndex3 = 1, rank = 0;
        int[] point = new int[3];        

        private int Changebg(int n)
        {
            if (n == 1)
            {
                pbBg.Image = global::Planable.Properties.Resources.bg;
                n = 2;           
            }
            else if (n == 2)
            {
                pbBg.Image = global::Planable.Properties.Resources.bg2;
                n = 1;
            }
            return n;
        }

        private void timeBg_Tick(object sender, EventArgs e)
        {
            iBg = Changebg(iBg);
        }

        private int Changepl(int n, PictureBox pbTemp)
        {
            PictureBox pb = pbTemp;
            switch (n)
            {
                case 1:
                    pb.Image = global::Planable.Properties.Resources.plane1;
                    break;
                case 2:
                    pb.Image = global::Planable.Properties.Resources.plane2;
                    break;
                case 3:
                    pb.Image = global::Planable.Properties.Resources.plane3;
                    break;
                case 4:
                    pb.Image = global::Planable.Properties.Resources.plane4;
                    break;
                case 5:
                    pb.Image = global::Planable.Properties.Resources.plane5;
                    break;
                case 6:
                    pb.Image = global::Planable.Properties.Resources.plane6;
                    break;
                case 7:
                    pb.Image = global::Planable.Properties.Resources.plane7;
                    break;
                case 8:
                    pb.Image = global::Planable.Properties.Resources.plane8;
                    break;
                case 9:
                    pb.Image = global::Planable.Properties.Resources.plane9;
                    break;

            }
            return n + 1;
        }      

        private void timePlay1_Tick(object sender, EventArgs e)
        {            
            if (pctIndex1 > 9) pctIndex1 = 1;         
            else pctIndex1 = Changepl(pctIndex1, pbPlay1);
        }

        private void Index_KeyUp(object sender, KeyEventArgs e)
        {
            if (timeRace.Enabled == true)
            {
                if (e.KeyCode == Keys.D && cbPl1.Checked == false)
                {
                    pbPlay1.Left += 10;
                    point[0] += 10;
                }
                else if (e.KeyCode == Keys.J && cbPl2.Checked == false)
                {
                    pbPlay2.Left += 10;
                    point[1] += 10;
                }
                else if (e.KeyCode == Keys.Right && cbPl3.Checked == false)
                {
                    pbPlay3.Left += 10;
                    point[2] += 10;
                }
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Siwanont Sittinam\n ID : 5810504574\n Kasetsart University\n Faculty : Computer Engineering\n", "Planable Copyright", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void timePlay2_Tick(object sender, EventArgs e)
        {
            if (pctIndex2 > 9) pctIndex2 = 1;
            else pctIndex2 = Changepl(pctIndex2, pbPlay2);
        }

        private void timePlay3_Tick(object sender, EventArgs e)
        {
            if (pctIndex3 > 9) pctIndex3 = 1;
            else pctIndex3 = Changepl(pctIndex3, pbPlay3);
        }

        public string[] name = new string[3] { "Com 1", "Com 2", "Com 3" };        

        private void checkRank()
        {
            if (point[0] > point[1] && point[0] > point[2])
            {
                rank = 0;
            }
            else if (point[1] > point[0] && point[1] > point[2])
            {
                rank = 1;
            }
            else if (point[2] > point[0] && point[2] > point[1])
            {
                rank = 2;
            }
            mlP.Text = "Plane player : " + name[rank] + " are rank 1!!";
        }

        private void checkWin(PictureBox pbTemp, int i)
        {
            PictureBox pb = pbTemp;
            if (pbTemp.Location.X > 1010)
            {
                mlP.Text = "Plane Player : " + name[i - 1] + " is WIN !!!";
                timeRace.Stop();
                SoundPlayer audio = new SoundPlayer(global::Planable.Properties.Resources.win);
                audio.Play();
            }
        }
      
        private void CheckedChange(CheckBox cb, int i, string get)
        {
            if (cb.Checked)
            {
                name[i] = "Com " + (i + 1);
                cb.Text = "Com " + (i + 1);
            }
            else
            {                
                name[i] = get;
                cb.Text = get;
            }            
        }    

        private int checkBot()
        {
            int[] numRand = new int[3] { 0, 0, 0 };
            Random r = new Random();
            if (cbPl1.Checked)
            {
                numRand[0] = 1;
                if (cbPl2.Checked)
                {
                    numRand[1] = 2;
                    if (cbPl3.Checked) numRand[2] = 3;
                    else numRand[2] = 0;
                }
                else
                {
                    numRand[1] = 0;
                    if (cbPl3.Checked) numRand[2] = 3;
                    else numRand[2] = 0;
                }
            }
            else
            {
                numRand[0] = 0;
                if (cbPl2.Checked)
                {
                    numRand[1] = 2;
                    if (cbPl3.Checked) numRand[2] = 3;
                    else numRand[2] = 0;
                }
                else
                {
                    numRand[1] = 0;
                    if (cbPl3.Checked) numRand[2] = 3;                    
                    else numRand[2] = 0;                    
                }
            }
            return numRand[r.Next(0, numRand.Length)];
        }

        private void timeRace_Tick(object sender, EventArgs e)
        {            
            int player = checkBot();
            checkRank();            
            switch (player)
            {
                case 1:
                    pbPlay1.Left += 15;
                    point[0] += 15;
                    break;
                case 2:
                    pbPlay2.Left += 15;
                    point[1] += 15;
                    break;
                case 3:
                    pbPlay3.Left += 15;
                    point[2] += 15;
                    break;
            }
            checkWin(pbPlay1, 1);
            checkWin(pbPlay2, 2);
            checkWin(pbPlay3, 3);
        }

        private void reset(PictureBox pbtemp, int i)
        {
            pbtemp.Left = 15;
            name[i] = "Com " + (i + 1);
            point[i] = 0;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if(bStart.Text == "Start")
            {
                loopsound();
                CheckedChange(cbPl1, 0, form2.Value1);
                CheckedChange(cbPl2, 1, form2.Value2);
                CheckedChange(cbPl3, 2, form2.Value3);
                timeRace.Start();
                bStart.Text = "Restart";
            }
            else if(bStart.Text == "Restart")
            {
                bStart.Text = "Start";
                timeRace.Stop();
                mlP.Text = "Plane State";                
                reset(pbPlay1, 0);
                reset(pbPlay2, 1);
                reset(pbPlay3, 2);
            }         
        }
    }
}
