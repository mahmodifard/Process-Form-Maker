using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Txt;
using Radio;
using mLabels;
using mCheckBox;
using pictureBox;
using GroupBoxs;
using mHLine;

using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;
using ThoughtWorks.QRCode.Codec.Util;
using System.IO;
using CtrlCloneTst;
using System.Collections;
using System.Drawing.Printing;

namespace PFC
{
    [Serializable]
    public partial class FrmForProducer : Form
    {
        public bool ISControlOn5050 = false;
        public string SelectedObjectType = "";
        public static object SelectedObject;
        private RectTrackerSharp.RectTracker refTracker;
        public static ActionRecovery actionRecover;
        public ToolBox ToolBox;

        public static int generalX;
        public static int generalY;

        public FrmForProducer()
        {
            InitializeComponent();
            ToolBox = new ToolBox();
            actionRecover = new ActionRecovery(GrpBadaneh, this, ToolBox);

        }


        public void MouseDowns(object sender, MouseEventArgs e)
        {
            SelectedObject = sender;

            if (GrpBadaneh.Controls.Contains(refTracker))
                GrpBadaneh.Controls.Remove(refTracker);

            if (this.Controls.Contains(refTracker))
                this.Controls.Remove(refTracker);
            if (sender.GetType() == typeof(DevComponents.DotNetBar.Controls.GroupPanel))
                return;

            generalX = ((GComponents.GeneralComponent)SelectedObject).Location.X;
            generalY = ((GComponents.GeneralComponent)SelectedObject).Location.Y;
            try
            {
                ((GComponents.GeneralComponent)sender).BackColor = System.Drawing.Color.Transparent;
                try
                {
                    if (!(((GComponents.GeneralComponent)sender).GetType() == typeof(myGroupBoxs)))
                        ((GComponents.GeneralComponent)sender).BringToFront();
                }
                catch { }

                refTracker = new RectTrackerSharp.RectTracker(((GComponents.GeneralComponent)sender));
            }
            catch
            {
                if (this.Controls.Contains(refTracker))
                    this.Controls.Remove(refTracker);
                refTracker = new RectTrackerSharp.RectTracker(GrpBadaneh);

                this.Controls.Add(refTracker);
                refTracker.BringToFront();

                return;
            }


            GrpBadaneh.Controls.Add(refTracker);
            refTracker.BringToFront();

        }

        public void MouseUps(object sender, MouseEventArgs e)
        {
            SelectedObject = sender;

            ((GComponents.GeneralComponent)sender).BackColor = System.Drawing.Color.Transparent;
            try
            {
                if (!(((GComponents.GeneralComponent)sender).GetType() == typeof(myGroupBoxs)))
                    ((GComponents.GeneralComponent)sender).BringToFront();
            }
            catch { }
            if (((GComponents.GeneralComponent)sender).GetType() == typeof(myHLine))
            {
                ((myHLine)sender).setBorderWidths((((myHLine)sender).getBorderWidth()));
            }

        }
        // ----------------------------------------------------

        void CreateControl(string ControlType)
        {
            GComponents.GeneralComponent Gcom = null;

            switch (ControlType)
            {
                case "txt":
                    {
                        Gcom = new Txt.TxtBox();

                    }
                    break;

                case "radio":
                    {
                        Gcom = new RadioControll();
                        Gcom.setText(Text);

                    }
                    break;

                case "check":
                    {
                        Gcom = new myCheckBox();
                        Gcom.setText(Text);

                    }
                    break;

                case "picture":
                    {
                        Gcom = new myPic();

                    }
                    break;

                case "hline":
                    {

                        Gcom = new myHLine();
                        ((myHLine)Gcom).setBorderWidths(2);

                    }
                    break;

                case "label":
                    {
                        Gcom = new myLabel();
                    }
                    break;
                case "group":
                    {
                        Gcom = new myGroupBoxs();

                    }
                    break;

            }

            Gcom.Click += new EventHandler(ShowPropertiesOfSelectedControl);
            Gcom.MouseDown += new System.Windows.Forms.MouseEventHandler(MouseDowns);
            Gcom.MouseUp += new System.Windows.Forms.MouseEventHandler(MouseUps);
            Gcom.Location = new Point(50, 50);
            Gcom.Name = "t" + ToolBox.Generalcomponent.Count;
            Gcom.caption = Gcom.Name;
            Gcom.ContextMenuStrip = contextMenuStrip2;
            Gcom.Font = GrpBadaneh.Font;
            Gcom.BackColor = System.Drawing.Color.Transparent;

            ToolBox.Generalcomponent.Add(Gcom);
            GrpBadaneh.Controls.Add(Gcom);
            if (Gcom.GetType() != typeof(myGroupBoxs))
                Gcom.BringToFront();

            actionRecover.doing(1, Gcom);
            SelectedObject = Gcom;

        }

        private void CreateTextBox_Click(object sender, EventArgs e)
        {
            CreateControl("txt");
        }
        private void CreateRadioButton_Click(object sender, EventArgs e)
        {
            CreateControl("radio");

        }
        private void CreateLabel_Click(object sender, EventArgs e)
        {
            CreateControl("label");
        }
        private void CreateCheckBox_Click(object sender, EventArgs e)
        {
            CreateControl("check");

        }

        public void ShowPropertiesOfSelectedControl(object SelectedControl, EventArgs e)
        {
            SelectedObject = SelectedControl;

            GrpMatn.Visible = true;
            Grpfont.Visible = true;
            GrpForColor.Visible = true;
            GrpLineAlign.Visible = false;
            GrpProperties.Height = 398;

            if (SelectedControl.GetType() == typeof(TxtBox))
            {
                GrpMatn.Visible = false;
                Grpfont.Visible = false;
                GrpForColor.Visible = false;
                GrpLineAlign.Visible = false;
                GrpProperties.Height = 254;

            }
            else if (SelectedObject.GetType() == typeof(myHLine))
            {
                SelectedObjectType = "hline";

                GrpMatn.Visible = false;
                Grpfont.Visible = false;
                GrpForColor.Visible = false;
                GrpLineAlign.Visible = true;
                GrpProperties.Height = 310;

            }
            else
            {
                TxtMatn.Text = ((GComponents.GeneralComponent)SelectedControl).getText();
                GrpLineAlign.Visible = false;
            }


            TxtName.Text = ((GComponents.GeneralComponent)SelectedControl).caption;
            Top.Text = ((GComponents.GeneralComponent)SelectedControl).Top.ToString();
            Left.Text = ((GComponents.GeneralComponent)SelectedControl).Left.ToString();
            width.Text = ((GComponents.GeneralComponent)SelectedControl).Width.ToString();
            Height.Text = ((GComponents.GeneralComponent)SelectedControl).Height.ToString();

        }


        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (SelectedObjectType == "group")
            {
                PasZamineh.Visible = true;
            }
            else
                PasZamineh.Visible = false;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            CreateControl("group");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CreateControl("picture");
        }

        private void groupPanel13_Click(object sender, EventArgs e)
        {
            CreateControl("hline");

        }

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
          
                if (e.KeyCode == Keys.Enter)
                {
                    if (TxtName.Text[0] >= 'a' && TxtName.Text[0] < 'z')
                    {
                       
                            TxtName.Text = TxtName.Text.Replace(" ", "");
                            actionRecover.doing(2, (GComponents.GeneralComponent)SelectedObject);
                            ((GComponents.GeneralComponent)SelectedObject).caption = TxtName.Text;
                       
                        
                    }
                    else
                       MessageBox.Show("farsi nanevis")  ;//farsi nanevis
                }
            
       

        }


        private void Top_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                actionRecover.doing(2, (GComponents.GeneralComponent)SelectedObject);
                ((GComponents.GeneralComponent)SelectedObject).Top = Convert.ToInt32(Top.Text);

            }
        }

        private void Left_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                actionRecover.doing(2, (GComponents.GeneralComponent)SelectedObject);
                ((GComponents.GeneralComponent)SelectedObject).Left = Convert.ToInt32(Left.Text);

            }
        }

        private void width_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                actionRecover.doing(2, (GComponents.GeneralComponent)SelectedObject);
                ((GComponents.GeneralComponent)SelectedObject).Width = Convert.ToInt32(width.Text);

            }
        }

        private void Height_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                actionRecover.doing(2, (GComponents.GeneralComponent)SelectedObject);
                ((GComponents.GeneralComponent)SelectedObject).Height = Convert.ToInt32(Height.Text);

            }

        }

        private void TxtMatn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                actionRecover.doing(2, (GComponents.GeneralComponent)SelectedObject);
                ((GComponents.GeneralComponent)SelectedObject).setText(TxtMatn.Text);


            }
        }

        private void BtnChooseFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                actionRecover.doing(2, (GComponents.GeneralComponent)SelectedObject);
                ((GComponents.GeneralComponent)SelectedObject).setFont(fontDialog1.Font);
            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                actionRecover.doing(2, (GComponents.GeneralComponent)SelectedObject);
                ((GComponents.GeneralComponent)SelectedObject).setForeColor(colorDialog1.Color);

            }
        }

        private void comboBoxEx3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                actionRecover.doing(2, (GComponents.GeneralComponent)SelectedObject);
                if (comboBoxEx3.SelectedIndex == 1)
                    ((myHLine)SelectedObject).setVertical();
                else
                    ((myHLine)SelectedObject).setHorizental();

            }
        }

        private void comboBoxEx3_SelectedIndexChanged(object sender, EventArgs e)
        {
            actionRecover.doing(2, (GComponents.GeneralComponent)SelectedObject);
            if (GrpBadaneh.Controls.Contains(refTracker))
                GrpBadaneh.Controls.Remove(refTracker);

            if (SelectedObject.GetType() == typeof(myHLine))
                if (comboBoxEx3.SelectedIndex == 1)
                    ((myHLine)SelectedObject).setVertical();
                else
                    ((myHLine)SelectedObject).setHorizental();

            refTracker = new RectTrackerSharp.RectTracker(((myHLine)SelectedObject));
            GrpBadaneh.Controls.Add(refTracker);
        }


        private void ctr_z(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.Z))
                actionRecover.undo(refTracker);
            else if (e.Control && (e.KeyCode == Keys.Y))
                actionRecover.redo(refTracker);

        }


        private void PasZamineh_Click(object sender, EventArgs e)
        {
            if (SelectedObject != null)
            {
                actionRecover.doing(2, ((GComponents.GeneralComponent)SelectedObject));
                ((GComponents.GeneralComponent)SelectedObject).SendToBack();
            }
        }

        private void RooZamineh_Click(object sender, EventArgs e)
        {
            if (SelectedObject != null)
            {
                actionRecover.doing(2, ((GComponents.GeneralComponent)SelectedObject));
                ((GComponents.GeneralComponent)SelectedObject).BringToFront();
            }

        }




        private void FormOnvan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                GrpBadaneh.Text = FormOnvan.Text;

        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedObject != null)
            {

                actionRecover.doing(3, ((GComponents.GeneralComponent)SelectedObject));
                ToolBox.Generalcomponent.Remove((GComponents.GeneralComponent)SelectedObject);
                GrpBadaneh.Controls.Remove((GComponents.GeneralComponent)SelectedObject);

                if (GrpBadaneh.Controls.Contains(refTracker))
                {
                    GrpBadaneh.Controls.Remove(refTracker);
                }


            }
        }

        private void FormColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormColor.SelectedIndex == 0)
            {

            }
            else
            {

            }
        }

        private void FormSzie_SelectedIndexChanged(object sender, EventArgs e)
        {
            //a5
            if (FormSzie.SelectedIndex == 0)
            {
                GrpBadaneh.Width = 420;

                GrpBadaneh.AutoScrollMinSize = new Size(0, 959);

            }
            else if (FormSzie.SelectedIndex == 1)
            {


            }
            //a4
            else if (FormSzie.SelectedIndex == 2)
            {
                GrpBadaneh.Width = 500;

                GrpBadaneh.AutoScrollMinSize = new Size(0, 842);


            }
            else if (FormSzie.SelectedIndex == 3)
            {

            }
            //a3
            else if (FormSzie.SelectedIndex == 4)
            {
                GrpBadaneh.AutoScrollMinSize = new Size(842, 1191);

            }
            else if (FormSzie.SelectedIndex == 5)
            {

            }
        }


        public static Point FTL, FTR, FDL;
        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (serialText.Text == "")
            {
                serialText.Focus();
            }
            else if (FormOnvan.Text == "")
            {
                FormOnvan.Focus();
            }
            else
            {

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    System.IO.FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                    MyArrayList ansors = new MyArrayList();

                    ansors.widthDistance = flage2.Location.X - flage1.Location.X;
                    ansors.heightDistance = flage3.Location.Y - flage1.Location.Y;
                    ansors.formName = FormOnvan.Text;
                    FTL = flage1.Location;
                    FTR = flage2.Location;
                    FDL = flage3.Location;

                    ansors.formSazman = "G5";
                    ansors.formSerial = serialText.Text;

                    using (stream)
                    {
                        for (int i = 0; i < ToolBox.Generalcomponent.Count; i++)
                        {
                            Anasor Onsor = new Anasor();
                            Onsor.name = ((GComponents.GeneralComponent)ToolBox.Generalcomponent[i]).Name;
                            Onsor.type = ((GComponents.GeneralComponent)ToolBox.Generalcomponent[i]).GetType().ToString();

                            Onsor._hashtable = CBFormCtrl.GetProperty((GComponents.GeneralComponent)ToolBox.Generalcomponent[i]);
                            ansors.Add(Onsor);
                        }
                        formatter.Serialize(stream, ansors);
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.Close();
                    }
                

//                    Datalayer.CreateFormInformaion(ansors.formName, ansors.formSazman, ansors.formSerial, File.ReadAllText(saveFileDialog1.FileName));
                    Datalayer.CreateFormInformaion(ansors.formName, ansors.formSazman, ansors.formSerial,"");
                    if(!Directory.Exists(Application.StartupPath + "\\SerialiezedFile"))
                        Directory.CreateDirectory(Application.StartupPath + "\\SerialiezedFile");

                    FileInfo fi = new FileInfo(saveFileDialog1.FileName);
                    System.IO.File.Copy(saveFileDialog1.FileName  ,Application.StartupPath + "\\SerialiezedFile\\" + serialText.Text + ".txt");
                   
                }
            }
        }


        private void buttonX3_Click(object sender, EventArgs e)
        {
            FileStream fs=  null ;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fs = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate);
            }
            System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            MyArrayList ansors = (MyArrayList)formatter.Deserialize(fs);
            fs.Close();
            for (int i = 0; i < ansors.Count; i++)
            {
                Anasor onsor = (Anasor)ansors[i];
                string ControlType = onsor.type;
                GComponents.GeneralComponent Gcom = null;
                Hashtable Ht = onsor._hashtable;

                // _____________________________________________________________________


                switch (ControlType)
                {
                    case "Txt.TxtBox":
                        {
                            Gcom = new Txt.TxtBox();
                        }
                        break;

                    case "Radio.RadioControll":
                        {
                            Gcom = new RadioControll();

                        }
                        break;

                    case "mCheckBox.myCheckBox":
                        {
                            Gcom = new myCheckBox();


                        }
                        break;

                    case "pictureBox.myPic":
                        {
                            Gcom = new myPic();

                        }
                        break;

                    case "mHLine.myHLine":
                        {
                            Gcom = new myHLine();
                            ((myHLine)Gcom).state = Convert.ToBoolean(Ht["LineState"]);
                            ((myHLine)Gcom).setBorderWidths(Convert.ToInt32(Ht["Borderwidth"]));
                        }
                        break;

                    case "mLabels.myLabel":
                        {
                            Gcom = new myLabel();
                        }
                        break;
                    case "GroupBoxs.myGroupBoxs":
                        {
                            Gcom = new myGroupBoxs();
                            Gcom.setText(Ht["Text"].ToString());
                        }
                        break;
                }
                Gcom.Top = Convert.ToInt32(Ht["Top"]);
                Gcom.Left = Convert.ToInt32(Ht["Left"]);
                Gcom.Width = Convert.ToInt32(Ht["Width"]);
                Gcom.Height = Convert.ToInt32(Ht["Height"]);
                Gcom.caption = Ht["caption"].ToString();
                Gcom.Name = Gcom.caption;
                Gcom.setText(Ht["Text"].ToString());
                Gcom.setFont((Font)Ht["Font"]);
                Gcom.setForeColor((System.Drawing.Color)Ht["ForeColor"]);

                //ControlFactory.SetControlProperties(Gcom, onsor._hashtable);

                Gcom.Click += new EventHandler(ShowPropertiesOfSelectedControl);
                Gcom.MouseDown += new System.Windows.Forms.MouseEventHandler(MouseDowns);
                Gcom.MouseUp += new System.Windows.Forms.MouseEventHandler(MouseUps);
                //Gcom.Location = new Point(50, 50);
                //Gcom.Name = "t" + ToolBox.Generalcomponent.Count;
                ////Gcom.caption = Gcom.Name;
                //Gcom.ContextMenuStrip = contextMenuStrip2;
                //Gcom.Font = GrpBadaneh.Font;
                //Gcom.BackColor = System.Drawing.Color.Transparent;

                ToolBox.Generalcomponent.Add(Gcom);
                GrpBadaneh.Controls.Add(Gcom);
                if (Gcom.GetType() != typeof(myGroupBoxs))
                    Gcom.BringToFront();

                actionRecover.doing(1, Gcom);
                SelectedObject = Gcom;

                // _____________________________________________________________________

            }

        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            return GrpBadaneh.Size;
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
           // this.GrpBadaneh.PreferredSize = new System.Drawing.Size();
            Graphics g = GrpBadaneh.CreateGraphics();
            g.CopyFromScreen(GrpBadaneh.Location.X, GrpBadaneh.Location.Y, GrpBadaneh.Location.X + GrpBadaneh.Width, GrpBadaneh.Location.Y + GrpBadaneh.Height, GrpBadaneh.Size);

         //   PrintControl.ControlPrint c = new PrintControl.ControlPrint();

         //   c.SetControl(GrpBadaneh);


       //     c.Print();
            
            CaptureScreen();

        }
        Bitmap memoryImage;
        Object o;
        Object o1;
        Object o2;
        private void CaptureScreen()
        {
            if (this.GrpBadaneh.Controls.Contains(refTracker))
                this.GrpBadaneh.Controls.Remove(refTracker);
            this.GrpBadaneh.BackColor = System.Drawing.Color.White;
            o = this.GrpBadaneh.Style.BackColor;
            o1 = this.GrpBadaneh.Style.BackColor2;
            o2 = this.GrpBadaneh.Style.Border;

            this.GrpBadaneh.Style.BackColor = System.Drawing.Color.White;
            this.GrpBadaneh.Style.BackColor2 = System.Drawing.Color.White;
            this.GrpBadaneh.Style.Border = DevComponents.DotNetBar.eStyleBorderType.None;
            this.GrpBadaneh.Refresh();

            Graphics myGraphics = GrpBadaneh.CreateGraphics();
           

            Size s = GrpBadaneh.Size;
            memoryImage = new Bitmap(s.Width + 5, s.Height + 5, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(GrpBadaneh.Location.X - this.Location.X - 3, GrpBadaneh.Location.Y - this.Location.Y + 170, 0, 0, s);
            memoryImage.Save("c:\\output.jpg");
            System.Diagnostics.Process.Start("c:\\output.jpg");

            this.GrpBadaneh.Style.BackColor = ((System.Drawing.Color) o);
            this.GrpBadaneh.Style.BackColor2 = ((System.Drawing.Color)o1);
            this.GrpBadaneh.Style.Border = (DevComponents.DotNetBar.eStyleBorderType)o2;
            this.GrpBadaneh.BackColor = System.Drawing.Color.Transparent;
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            actionRecover.undo(refTracker);
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            actionRecover.redo(refTracker);
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (SelectedObject != null)
            {
                actionRecover.doing(3, ((GComponents.GeneralComponent)SelectedObject));
                ToolBox.Generalcomponent.Remove((GComponents.GeneralComponent)SelectedObject);
                GrpBadaneh.Controls.Remove((GComponents.GeneralComponent)SelectedObject);

                if (GrpBadaneh.Controls.Contains(refTracker))
                {
                    GrpBadaneh.Controls.Remove(refTracker);
                }

            }
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            if (SelectedObject != null)
            {
                actionRecover.doing(2, ((GComponents.GeneralComponent)SelectedObject));
                ((GComponents.GeneralComponent)SelectedObject).SendToBack();
            }
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            if (SelectedObject != null)
            {
                actionRecover.doing(2, ((GComponents.GeneralComponent)SelectedObject));
                ((GComponents.GeneralComponent)SelectedObject).BringToFront();
            }
        }

        private void groupPanel9_Click(object sender, EventArgs e)
        {

        }

        private void TxtName_Leave(object sender, EventArgs e)
        {
         
        }

        private void TxtMatn_Leave(object sender, EventArgs e)
        {
            //if (TxtName.Text.Split(' ').Count() < 2)
            //{
            //    actionRecover.doing(2, (GComponents.GeneralComponent)SelectedObject);
            //    ((GComponents.GeneralComponent)SelectedObject).caption = TxtName.Text;
            //}
            //else
            //    MessageBox.Show("22");

        }

    }
}
