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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {

            FrmForProducer frm = new FrmForProducer();
                frm.MdiParent = this;
                frm.Show();
            }

        private void buttonItem15_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            TwainGui.MainFrame fm = new TwainGui.MainFrame();
            fm.Show();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //buttonItem14_Click(sender, e);
            this.Text = ribbonControl1.Height.ToString();
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            TwainGui.MainFrame frm = new TwainGui.MainFrame();
            frm.Show();
        }

        private void buttonItem30_Click(object sender, EventArgs e)
        {

            TwainLib.Twain tw = new TwainLib.Twain();
            tw.Select();

        }

        private void buttonItem20_Click(object sender, EventArgs e)
        {
            CreateDataBase frm = new CreateDataBase();
            frm.MdiParent = this;
            frm.Show();
        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {
            FrmShowContent frm = new FrmShowContent();
            frm.MdiParent = this;
            frm.Show();
        }
      

    }
}
