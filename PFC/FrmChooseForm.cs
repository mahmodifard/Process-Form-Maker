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
    public partial class FrmChooseForm : Form
    {
        FrmShowContent FrmShowcontent;
        public FrmChooseForm(FrmShowContent frm)
        {
            InitializeComponent();
            FrmShowcontent = frm;
        }

        private void BtnChooseForm_Click(object sender, EventArgs e)
        {
            if (DgAllForm.SelectedRows.Count != 0)
            {
                FrmShowcontent.Sazman = DgAllForm.SelectedRows[0].Cells[1].Value.ToString();
                FrmShowcontent.FormName = DgAllForm.SelectedRows[0].Cells[0].Value.ToString();
                FrmShowcontent.Serial = DgAllForm.SelectedRows[0].Cells[2].Value.ToString();
                FrmShowcontent.SerializedFile = dBPFCDataSet.FormInfo[DgAllForm.SelectedRows[0].Index].SeializedFile;
                this.Close();
            }
        }

        private void FrmChooseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBPFCDataSet.FormInfo' table. You can move, or remove it, as needed.
            this.formInfoTableAdapter.Fill(this.dBPFCDataSet.FormInfo);

        }
    }
}
