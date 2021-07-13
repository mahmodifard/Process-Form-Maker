using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using System.Collections;

namespace PFC
{
    public partial class FrmImageProcess : Form
    {
        public MyArrayList MyArray;
        public int NumOfComponent = 0;
        public string TableName;
        public ArrayList Captions;
        public string FormSerial;
        public FrmImageProcess(MyArrayList MyArray1, string Path, int Count, int NumOFCom, string TName, ArrayList Cap, string FS)
        {
            InitializeComponent();
            MyArray = MyArray1;
            LblFoldrPath.Text = Path;
            LblFileCount.Text = Count.ToString();
            NumOfComponent = NumOFCom;
            TableName = TName;

            Captions = Cap;
            FormSerial = FS;


            TreeNode Parent = new TreeNode(new FileInfo(Path).Name);
            foreach (var item in Directory.GetFiles(Path))
            {
                TreeNode tr = new TreeNode(new FileInfo(item).Name);
                tr.Tag = item;
                //FileInfo f = new FileInfo("");

                Parent.Nodes.Add(tr);


            }
            treeView1.Nodes.Add(Parent);
            treeView1.ExpandAll();
        }

        private void FrmImageProcess_Load(object sender, EventArgs e)
        {

        }

        private void BtnStartPreProcess_Click(object sender, EventArgs e)
        {
            // ------------------------------------------------------
            //Matlab code that will segment all elements of form.
            SegmentPFC.SegmentPFC f = new SegmentPFC.SegmentPFC();
            String Pathes = LblFoldrPath.Text;
            MWNumericArray compCount = new MWNumericArray(NumOfComponent);
            int cnt = 0;
            foreach (var item in System.IO.Directory.GetFiles(Pathes))
            {
                FileInfo f1 = new FileInfo(item);
                if (f1.Extension == ".tif")
                    cnt++;
            }


            MWNumericArray pcount = new MWNumericArray(cnt);
            MWCharArray path = new MWCharArray(Pathes);
            f.segmentationImage(path, pcount, compCount);
            // ------------------------------------------------------


            // Insert all element in table in database
            Datalayer.InsertFormImageElements(Pathes, TableName, Captions, FormSerial);
            // ------------------------------------------




            # region Should Delete after code above tested
            //foreach (var Directory in System.IO.Directory.GetDirectories(Pathes))
            //{
            //    string Command = "insert into [" + TableName + "] (";
            //    string values = " values (";
            //    System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(new DBPFCDataSetTableAdapters.FormInfoTableAdapter().Connection.ConnectionString);
            //    System.Data.SqlClient.SqlCommand Com = new System.Data.SqlClient.SqlCommand(Command);
            //    Conon=con.ConnectionString;
            //    Images.Clear();
            //    foreach (var File in System.IO.Directory.GetFiles(Directory))
            //    {

            //        Images.Add(Image.FromFile(File));

            //    }

            //    Command += "FormSerial ,";
            //    values += "@FormSerial ,";
            //    Com.Parameters.Add("@FormSerial", SqlDbType.NVarChar);

            //    for (int i = 0; i < Captions.Count; i++)
            //    {
            //        Command += "" + Captions[i] + ",";
            //        values += "@" + Captions[i] + ",";
            //        Com.Parameters.Add("@" + Captions[i] + "", SqlDbType.Image);

            //    }
            //    Command = Command.Remove(Command.Length - 1);
            //    values = values.Remove(values.Length - 1);

            //    Command += " ) ";
            //    values += " ) ";
            //    Command += values;

            //    Com.CommandText = Command;


            //    Com.Parameters[0].Value = FormSerial;
            //    for (int i = 1; i < Com.Parameters.Count; i++)
            //    {
            //        MemoryStream m = new MemoryStream();
            //        Bitmap b = (Bitmap)Images[i-1];
            //        b.Save(m, System.Drawing.Imaging.ImageFormat.Tiff);
            //        Com.Parameters[i].Value = m.ToArray();
            //    }
            //    Com.Connection = con;
            //    con.Open();
            //    try
            //    {
            //        Com.ExecuteNonQuery();
            //    }
            //    catch (Exception ee)
            //    {
            //        MessageBox.Show(ee.ToString());
            //    }
            //    con.Close();




            //}

#endregion





        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                try
                {
                    FrmLargerImages frm = new FrmLargerImages(Image.FromFile(treeView1.SelectedNode.Tag.ToString()));
                    frm.ShowDialog();
                }
                catch
                {

                }
            }
        }
    }
}
