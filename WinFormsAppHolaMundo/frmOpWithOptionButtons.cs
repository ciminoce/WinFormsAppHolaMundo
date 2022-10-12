using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsAppHolaMundo.Properties;

namespace WinFormsAppHolaMundo
{
    public partial class frmOpWithOptionButtons : Form
    {
        public frmOpWithOptionButtons()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.BackColor == Color.Transparent)
            {
                this.Width += 400;
                pictureBox5.BackColor = Color.OrangeRed;
                pictureBox5.Image = Resources.arrow_pointing_left_36px;

            }
            else
            {
                this.Width -= 400;
                pictureBox5.BackColor = Color.Transparent;
                pictureBox5.Image = Resources.advance_36px;
            }
        }
    }
}
