using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using mHLine;
using System.IO;

namespace PFC
{
    public partial class FrmShowContent : Form
    {
        public FrmShowContent()
        {
            InitializeComponent();
        }
        public string FormName, Sazman, Serial, SerializedFile;
        ToolBox ToolB = new ToolBox();

        private void buttonX2_Click(object sender, EventArgs e)
        {

            // --------------
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            FrmChooseForm frm = new FrmChooseForm(this);
            frm.ShowDialog();
            if (Serial != null)
            {

                // ---------------
                //  System.IO.File.WriteAllText("c:\\temp.txt",SerializedFile);


                System.IO.FileStream fs = new System.IO.FileStream(Application.StartupPath + "\\SerialiezedFile\\" + Serial + ".txt", System.IO.FileMode.Open);

                System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                MyArrayList ansors = (MyArrayList)formatter.Deserialize(fs);
                fs.Close();



                for (int i = 0; i < ansors.Count; i++)
                {
                    Anasor onsor = (Anasor)ansors[i];
                    string ControlType = onsor.type;

                    Hashtable Ht = onsor._hashtable;

                    // _____________________________________________________________________


                    switch (ControlType)
                    {
                        case "Txt.TxtBox":
                            {
                                TextBox Gcom = new TextBox();
                                Gcom.Top = Convert.ToInt32(Ht["Top"]);
                                Gcom.Left = Convert.ToInt32(Ht["Left"]);
                                Gcom.Width = Convert.ToInt32(Ht["Width"]);
                                Gcom.Height = Convert.ToInt32(Ht["Height"]);
                                Gcom.Name = Ht["caption"].ToString();
                                ToolB.Generalcomponent.Add(Gcom);
                                GrpContent.Controls.Add(Gcom);
                                // Gcom.BackColor = Color.Transparent;
                                Gcom.ForeColor = Color.Black;
                                Gcom.Text = Ht["Text"].ToString();

                            }
                            break;

                        case "Radio.RadioControll":
                            {
                                RadioButton Gcom = new RadioButton();
                                Gcom.Top = Convert.ToInt32(Ht["Top"]);
                                Gcom.Left = Convert.ToInt32(Ht["Left"]);
                                Gcom.Width = Convert.ToInt32(Ht["Width"]);
                                Gcom.Height = Convert.ToInt32(Ht["Height"]);
                                Gcom.Name = Ht["caption"].ToString();
                                ToolB.Generalcomponent.Add(Gcom);
                                Gcom.BackColor = Color.Transparent;
                                Gcom.ForeColor = Color.Black;
                                GrpContent.Controls.Add(Gcom);
                                Gcom.Text = Ht["Text"].ToString();
                            }
                            break;

                        case "mCheckBox.myCheckBox":
                            {
                                CheckBox Gcom = new CheckBox();
                                Gcom.Top = Convert.ToInt32(Ht["Top"]);
                                Gcom.Left = Convert.ToInt32(Ht["Left"]);
                                Gcom.Width = Convert.ToInt32(Ht["Width"]);
                                Gcom.Height = Convert.ToInt32(Ht["Height"]);
                                Gcom.Name = Ht["caption"].ToString();
                                ToolB.Generalcomponent.Add(Gcom);
                                Gcom.BackColor = Color.Transparent;
                                Gcom.ForeColor = Color.Black;
                                GrpContent.Controls.Add(Gcom);
                                Gcom.Text = Ht["Text"].ToString();
                            }
                            break;

                        case "pictureBox.myPic":
                            {
                                PictureBox Gcom = new PictureBox();
                                Gcom.Top = Convert.ToInt32(Ht["Top"]);
                                Gcom.Left = Convert.ToInt32(Ht["Left"]);
                                Gcom.Width = Convert.ToInt32(Ht["Width"]);
                                Gcom.Height = Convert.ToInt32(Ht["Height"]);
                                Gcom.Name = Ht["caption"].ToString();
                                ToolB.Generalcomponent.Add(Gcom);
                                Gcom.BackColor = Color.Transparent;
                                Gcom.ForeColor = Color.Black;
                                GrpContent.Controls.Add(Gcom);
                                Gcom.Text = Ht["Text"].ToString();
                            }
                            break;

                        case "mHLine.myHLine":
                            {
                                myHLine Gcom = new myHLine();
                                ((myHLine)Gcom).state = Convert.ToBoolean(Ht["LineState"]);
                                ((myHLine)Gcom).setBorderWidths(Convert.ToInt32(Ht["Borderwidth"]));
                                GrpContent.Controls.Add(Gcom);

                            }
                            break;

                        case "mLabels.myLabel":
                            {
                                Label Gcom = new Label();
                                Gcom.Top = Convert.ToInt32(Ht["Top"]);
                                Gcom.Left = Convert.ToInt32(Ht["Left"]);
                                Gcom.Width = Convert.ToInt32(Ht["Width"]);
                                Gcom.Height = Convert.ToInt32(Ht["Height"]);
                                Gcom.Name = Ht["caption"].ToString();
                                ToolB.Generalcomponent.Add(Gcom);
                                Gcom.BackColor = Color.Transparent;
                                Gcom.ForeColor = Color.Black;
                                GrpContent.Controls.Add(Gcom);
                                Gcom.Text = Ht["Text"].ToString();
                            }
                            break;
                        case "GroupBoxs.myGroupBoxs":
                            {
                                GroupBoxs.myGroupBoxs Gcom = new GroupBoxs.myGroupBoxs();
                                Gcom.Top = Convert.ToInt32(Ht["Top"]);
                                Gcom.Left = Convert.ToInt32(Ht["Left"]);
                                Gcom.Width = Convert.ToInt32(Ht["Width"]);
                                Gcom.Height = Convert.ToInt32(Ht["Height"]);
                                Gcom.Name = Ht["caption"].ToString();
                                ToolB.Generalcomponent.Add(Gcom);
                                Gcom.BackColor = Color.Transparent;
                                Gcom.ForeColor = Color.Black;
                                GrpContent.Controls.Add(Gcom);
                                Gcom.Text = Ht["Text"].ToString();
                            }
                            break;
                    }




                    Datalayer.ShowAllSazmanform(FormName, Serial, DGAll);


                }

                // _____________________________________________________________________

            }

        }
    }
}
