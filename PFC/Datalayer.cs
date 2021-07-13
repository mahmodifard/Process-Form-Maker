using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Collections;

namespace PFC
{
    class Datalayer
    {
        public static string ConnectionStr = "";
        public static void CreateFormInformaion(string FormName, string FormSazman, string FormSerial, string SerializedFile)
        {
            DBPFCDataSetTableAdapters.FormInfoTableAdapter Finfo = new DBPFCDataSetTableAdapters.FormInfoTableAdapter();
            Finfo.Insert(FormName, FormSazman, FormSerial, SerializedFile);
 
        }

        public static void CreateAllSazmanTables(string Commnad)
        {
            SqlConnection con =new DBPFCDataSetTableAdapters.FormInfoTableAdapter().Connection ;
            SqlCommand com = new SqlCommand(Commnad, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
 

        }
        public static void ShowAllSazmanform(string Tabelname,string Serial,System.Windows.Forms.DataGridView DGV)
        {

            SqlConnection con = new DBPFCDataSetTableAdapters.FormInfoTableAdapter().Connection;
            SqlCommand com = new SqlCommand("select * from [" + Tabelname + "Content] where FormSerial='" + Serial + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DGV.DataSource = dt;
            

        }
        public static void InsertFormImageElements(string Pathes,string TableName,System.Collections.ArrayList Captions,string FormSerial)
        {
            ArrayList Images = new ArrayList();
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(new DBPFCDataSetTableAdapters.FormInfoTableAdapter().Connection.ConnectionString);
            System.Data.SqlClient.SqlCommand Com = new System.Data.SqlClient.SqlCommand();
                
            foreach (var Directory in System.IO.Directory.GetDirectories(Pathes))
            {
                string Command = "insert into [" + TableName + "] (";
                string values = " values (";
               
                Images.Clear();
                foreach (var File in System.IO.Directory.GetFiles(Directory))
                {

                    Images.Add(Image.FromFile(File));

                }

                Command += "FormSerial ,";
                values += "@FormSerial ,";
                Com.Parameters.Add("@FormSerial", SqlDbType.NVarChar);

                for (int i = 0; i < Captions.Count; i++)
                {
                    Command += "" + Captions[i] + ",";
                    values += "@" + Captions[i] + ",";
                    Com.Parameters.Add("@" + Captions[i] + "", SqlDbType.Image);

                }
                Command = Command.Remove(Command.Length - 1);
                values = values.Remove(values.Length - 1);

                Command += " ) ";
                values += " ) ";
                Command += values;

                Com.CommandText = Command;


                Com.Parameters[0].Value = FormSerial;
                for (int i = 1; i < Com.Parameters.Count; i++)
                {
                    MemoryStream m = new MemoryStream();
                    Bitmap b = (Bitmap)Images[i - 1];
                    b.Save(m, System.Drawing.Imaging.ImageFormat.Tiff);
                    Com.Parameters[i].Value = m.ToArray();
                }
                Com.Connection = con;
                con.Open();
                try
                {
                    Com.ExecuteNonQuery();
                }
                catch (Exception ee)
                {
                    
                }
                con.Close();







            }

        }
            
    }
}
