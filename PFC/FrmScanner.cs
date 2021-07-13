using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

using TwainLib;


using System.IO;

namespace PFC
{
    public partial class FrmScanner : Form ,  IMessageFilter
    {
        private Twain tw;
        public FrmScanner()
        {
            InitializeComponent();
            tw = new Twain();
            tw.Init(this.Handle);
        }

        

        private void buttonX4_Click(object sender, EventArgs e)
        {
            FrmLargerImages frm = new FrmLargerImages(pictureBox1.Image);
            frm.ShowDialog();
        }

        private void btnchooseScanner_Click(object sender, EventArgs e)
        {
            tw.Select();
        }

        private void FrmScanner_Load(object sender, EventArgs e)
        {

        }



        bool IMessageFilter.PreFilterMessage(ref Message m)
        {
            TwainCommand cmd = tw.PassMessage(ref m);
            if (cmd == TwainCommand.Not)
                return false;

            switch (cmd)
            {
                case TwainCommand.CloseRequest:
                    {
                        EndingScan();
                        tw.CloseSrc();
                        break;
                    }
                case TwainCommand.CloseOk:
                    {
                        EndingScan();
                        tw.CloseSrc();
                        break;
                    }
                case TwainCommand.DeviceEvent:
                    {
                        break;
                    }
                case TwainCommand.TransferReady:
                    {
                        ArrayList pics = tw.TransferPictures();
                        EndingScan();
                        tw.CloseSrc();
                        picnumber++;
                        for (int i = 0; i < pics.Count; i++)
                        {
                            IntPtr img = (IntPtr)pics[i];
                            //PicForm newpic = new PicForm(img);
                            //newpic.MdiParent = this;
                            //int picnum = i + 1;
                            //newpic.Text = "ScanPass" + picnumber.ToString() + "_Pic" + picnum.ToString();
                            //newpic.Show();
                        }
                        break;
                    }
            }

            return true;
        }

        private void EndingScan()
        {
            if (msgfilter)
            {
                Application.RemoveMessageFilter(this);
                msgfilter = false;
                this.Enabled = true;
                this.Activate();
            }
        }

        private bool msgfilter;
     
        private int picnumber = 0;




 
    }
}
