namespace PFC
{
    partial class FrmChooseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.DgAllForm = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.BtnChooseForm = new DevComponents.DotNetBar.ButtonX();
            this.dBPFCDataSet = new PFC.DBPFCDataSet();
            this.formInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formInfoTableAdapter = new PFC.DBPFCDataSetTableAdapters.FormInfoTableAdapter();
            this.formNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formSazmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formSerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgAllForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPFCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.BtnChooseForm);
            this.groupPanel1.Controls.Add(this.DgAllForm);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(511, 372);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            // 
            // DgAllForm
            // 
            this.DgAllForm.AllowUserToAddRows = false;
            this.DgAllForm.AllowUserToDeleteRows = false;
            this.DgAllForm.AllowUserToResizeColumns = false;
            this.DgAllForm.AllowUserToResizeRows = false;
            this.DgAllForm.AutoGenerateColumns = false;
            this.DgAllForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgAllForm.BackgroundColor = System.Drawing.Color.White;
            this.DgAllForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.formNameDataGridViewTextBoxColumn,
            this.formSazmanDataGridViewTextBoxColumn,
            this.formSerialDataGridViewTextBoxColumn});
            this.DgAllForm.DataSource = this.formInfoBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgAllForm.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgAllForm.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DgAllForm.Location = new System.Drawing.Point(17, 20);
            this.DgAllForm.Name = "DgAllForm";
            this.DgAllForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgAllForm.Size = new System.Drawing.Size(475, 308);
            this.DgAllForm.TabIndex = 0;
            // 
            // BtnChooseForm
            // 
            this.BtnChooseForm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnChooseForm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnChooseForm.Location = new System.Drawing.Point(18, 334);
            this.BtnChooseForm.Name = "BtnChooseForm";
            this.BtnChooseForm.Size = new System.Drawing.Size(227, 23);
            this.BtnChooseForm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnChooseForm.TabIndex = 1;
            this.BtnChooseForm.Text = "انتخاب فرم";
            this.BtnChooseForm.Click += new System.EventHandler(this.BtnChooseForm_Click);
            // 
            // dBPFCDataSet
            // 
            this.dBPFCDataSet.DataSetName = "DBPFCDataSet";
            this.dBPFCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formInfoBindingSource
            // 
            this.formInfoBindingSource.DataMember = "FormInfo";
            this.formInfoBindingSource.DataSource = this.dBPFCDataSet;
            // 
            // formInfoTableAdapter
            // 
            this.formInfoTableAdapter.ClearBeforeFill = true;
            // 
            // formNameDataGridViewTextBoxColumn
            // 
            this.formNameDataGridViewTextBoxColumn.DataPropertyName = "FormName";
            this.formNameDataGridViewTextBoxColumn.HeaderText = "نام فرم";
            this.formNameDataGridViewTextBoxColumn.Name = "formNameDataGridViewTextBoxColumn";
            // 
            // formSazmanDataGridViewTextBoxColumn
            // 
            this.formSazmanDataGridViewTextBoxColumn.DataPropertyName = "FormSazman";
            this.formSazmanDataGridViewTextBoxColumn.HeaderText = "سازمان";
            this.formSazmanDataGridViewTextBoxColumn.Name = "formSazmanDataGridViewTextBoxColumn";
            // 
            // formSerialDataGridViewTextBoxColumn
            // 
            this.formSerialDataGridViewTextBoxColumn.DataPropertyName = "FormSerial";
            this.formSerialDataGridViewTextBoxColumn.HeaderText = "سریال فرم";
            this.formSerialDataGridViewTextBoxColumn.Name = "formSerialDataGridViewTextBoxColumn";
            // 
            // FrmChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 372);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmChooseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انتخاب فرم";
            this.Load += new System.EventHandler(this.FrmChooseForm_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgAllForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPFCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX BtnChooseForm;
        private DevComponents.DotNetBar.Controls.DataGridViewX DgAllForm;
        private DBPFCDataSet dBPFCDataSet;
        private System.Windows.Forms.BindingSource formInfoBindingSource;
        private DBPFCDataSetTableAdapters.FormInfoTableAdapter formInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn formNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formSazmanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formSerialDataGridViewTextBoxColumn;
    }
}