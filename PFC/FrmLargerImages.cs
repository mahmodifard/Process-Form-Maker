using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PFC
{
    public partial class FrmLargerImages : Form
    {
        public FrmLargerImages(Image Img)
        {
            InitializeComponent();
            pictureBox1.Image = Img;
        }
    }
}
