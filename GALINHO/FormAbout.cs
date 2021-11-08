using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GALINHO
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.A)

                label1.Top = label1.Top -1 ;
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {

        }

        private void FormAbout_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FormAbout_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)

                label1.Top = label1.Top - 1;
        }
    }
}
