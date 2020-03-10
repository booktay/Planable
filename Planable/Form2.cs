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

namespace Planable
{
    public partial class Form2 : MaterialForm
    {
        public string[] name = new string[3] { "Com 1", "Com 2", "Com 3" };

        public Form2()
        {
            InitializeComponent();
        }

        void nameGet()
        {
            if (textName1.Text != "") name[0] = textName1.Text;
            if (textName2.Text != "") name[1] = textName2.Text;
            if (textName3.Text != "") name[2] = textName3.Text;
        }

        public string Value1
        {
            get {
                return name[0];
            }
        }

        public string Value2
        {
            get
            {
                return name[1];
            }
        }

        public string Value3
        {
            get
            {
                return name[2];
            }
        }

        public void materialFlatButton1_Click(object sender, EventArgs e)
        {
            nameGet();
            this.Close();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            nameGet();
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }
    }
}
