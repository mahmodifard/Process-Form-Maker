using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using GComponents;
using Radio;
using mCheckBox;
using pictureBox;
using mLabels;
using MathWorks.MATLAB.NET.Arrays;


namespace PFC
{
    public partial class CreateDataBase : Form
    {
        public CreateDataBase()
        {
            InitializeComponent();
            MyArray = new MyArrayList();
        }

        private void BtnScanner_Click(object sender, EventArgs e)
        {



            //  TwainGui.MainFrame frm = new TwainGui.MainFrame();
            //   frm.Show();
        }
        public MyArrayList MyArray;
        private void BtnChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                try
                {
                    MyArrayList ansors = (MyArrayList)formatter.Deserialize(fs);
                    MyArray = ansors;
                    LblFormname.Text = ansors.formName;
                    LblSazmanName.Text = "jija";
                    formSS = ansors.formSerial;
                    fs.Close();
                    //show messagebox
                }
                catch
                {
                    //show error of invalid file
                }



            }
        }
        int NumOfComponent = 0;
        ArrayList captions = new ArrayList();

        string formSS = "";
        private void BtnCreateTable_Click(object sender, EventArgs e)
        {

            string TableCommand = "create table [" + LblFormname.Text + "] ( FormSerial nvarchar(50) not null , ";
            string TypeOfFields = "create table [" + LblFormname.Text + "Types] ( FormSerial nvarchar(50) not null ,";
            string TableCommnadContent = "create table [" + LblFormname.Text + "Content] ( FormSerial nvarchar(50) not null ,";

            string TypeCommand = "insert into [" + LblFormname.Text + "Types]  (FormSerial,";
            string TypeValues = "values ('" + formSS + "'," ;
            string File = "";
            NumOfComponent = 0;
            captions.Clear();
            for (int i = 0; i < MyArray.Count; i++)
            {
                Anasor onsor = (Anasor)MyArray[i];
                string ControlType = onsor.type;

                Hashtable Ht = onsor._hashtable;

                // _____________________________________________________________________


                switch (ControlType)
                {
                    case "Txt.TxtBox":
                        {
                            TableCommand += "[" + Ht["caption"].ToString() + "]  image ,";
                            TypeOfFields += "[" + Ht["caption"].ToString() + "]  nvarchar(50) ,";
                            TableCommnadContent += "[" + Ht["caption"].ToString() + "]  ntext ,";
                            File += Ht["caption"] + " " + Ht["Left2"] + " " + Ht["Top2"] + " " + Ht["Width2"] + " " + Ht["Height2"] + " " + System.Environment.NewLine;
                            NumOfComponent++;
                            captions.Add(Ht["caption"].ToString());


                            TypeCommand += "[" + Ht["caption"].ToString() + "],";
                            TypeValues += "'string',";
                        }
                        break;

                    case "Radio.RadioControll":
                        {
                            TableCommand += "[" + Ht["caption"].ToString() + "]  image ,";
                            TypeOfFields += "[" + Ht["caption"].ToString() + "]  nvarchar(50) ,";
                            TableCommnadContent += "[" + Ht["caption"].ToString() + "]  ntext ,";
                            File += Ht["caption"] + " " + Ht["Left2"] + " " + Ht["Top2"] + " " + Ht["Width2"] + " " + Ht["Height2"] + " " + System.Environment.NewLine;
                            NumOfComponent++;
                            captions.Add(Ht["caption"].ToString());
                            TypeCommand += "[" + Ht["caption"].ToString() + "],";
                            TypeValues += "'bool',";

                        }
                        break;

                    case "mCheckBox.myCheckBox":
                        {
                            TableCommand += "[" + Ht["caption"].ToString() + "]  image ,";
                            TypeOfFields += "[" + Ht["caption"].ToString() + "]  nvarchar(50) ,";
                            TableCommnadContent += "[" + Ht["caption"].ToString() + "]  ntext ,";
                            File += Ht["caption"] + " " + Ht["Left2"] + " " + Ht["Top2"] + " " + Ht["Width2"] + " " + Ht["Height2"] + " " + System.Environment.NewLine;
                            NumOfComponent++;
                            captions.Add(Ht["caption"].ToString());

                            TypeCommand += "[" + Ht["caption"].ToString() + "],";
                            TypeValues += "'bool',";

                        }
                        break;

                    case "pictureBox.myPic":
                        {
                            TableCommand += "[" + Ht["caption"].ToString() + "]  image ,";
                            TypeOfFields += "[" + Ht["caption"].ToString() + "]  nvarchar(50) ,";
                            TableCommnadContent += "[" + Ht["caption"].ToString() + "]  ntext ,";
                            File += Ht["caption"] + " " + Ht["Left2"] + " " + Ht["Top2"] + " " + Ht["Width2"] + " " + Ht["Height2"] + " " + System.Environment.NewLine;
                            NumOfComponent++;
                            captions.Add(Ht["caption"].ToString());

                            TypeCommand += "[" + Ht["caption"].ToString() + "],";
                            TypeValues += "'image',";

                        }
                        break;

                }


                // _____________________________________________________________________

            }


            TypeCommand = TypeCommand.Remove(TypeCommand.Length - 1);
            TypeValues = TypeValues.Remove(TypeValues.Length - 1);

            TypeCommand += ") ";
            TypeValues += ") ";

            TypeCommand += TypeValues;
            TableCommnadContent = TableCommnadContent.Substring(0, TableCommnadContent.Length - 1);
            TableCommand = TableCommand.Substring(0, TableCommand.Length - 1);
            TypeOfFields = TypeOfFields.Substring(0, TypeOfFields.Length - 1);


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, File);
            }

            TableCommand += ")";
            TypeOfFields += ")";
            TableCommnadContent += ")";
            int k = TableCommnadContent.LastIndexOf(",") - 1;


            try
            {
                Datalayer.CreateAllSazmanTables(TableCommand);
                Datalayer.CreateAllSazmanTables(TypeOfFields);
                Datalayer.CreateAllSazmanTables(TableCommnadContent);

                Datalayer.CreateAllSazmanTables(TypeCommand);
            }
            catch
            {
                //database is exist and shoud change if they want ....
            }

        }

        private void BtnChooseDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtFoldrPath.Text = folderBrowserDialog1.SelectedPath + "\\";
                BTnStartImgProcess.Enabled = true;
            }
            else
                BTnStartImgProcess.Enabled = false;
        }

        private void BTnStartImgProcess_Click(object sender, EventArgs e)
        {
            FrmImageProcess frm = new FrmImageProcess(MyArray, TxtFoldrPath.Text, System.IO.Directory.GetFiles(TxtFoldrPath.Text).Count(), NumOfComponent, LblFormname.Text, captions, formSS);
            frm.Show();
            this.Close();
        }

        private void CreateDataBase_Load(object sender, EventArgs e)
        {

        }



    }
}
