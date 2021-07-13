using TwainControl;
using Atalasoft.Twain;
namespace PFC
{
    partial class FrmScanner
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel10 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtScannerName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnchooseScanner = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel10.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.groupPanel2);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(808, 655);
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
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.groupPanel10);
            this.groupPanel2.Controls.Add(this.groupPanel3);
            this.groupPanel2.Controls.Add(this.pictureBox12);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Location = new System.Drawing.Point(28, 21);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(751, 599);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 0;
            this.groupPanel2.Text = "عملیات اسکن";
            // 
            // groupPanel10
            // 
            this.groupPanel10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupPanel10.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel10.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel10.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel10.Controls.Add(this.buttonX2);
            this.groupPanel10.IsShadowEnabled = true;
            this.groupPanel10.Location = new System.Drawing.Point(60, 505);
            this.groupPanel10.Name = "groupPanel10";
            this.groupPanel10.Size = new System.Drawing.Size(253, 61);
            // 
            // 
            // 
            this.groupPanel10.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel10.Style.BackColorGradientAngle = 90;
            this.groupPanel10.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel10.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel10.Style.BorderBottomWidth = 1;
            this.groupPanel10.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel10.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel10.Style.BorderLeftWidth = 1;
            this.groupPanel10.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel10.Style.BorderRightWidth = 1;
            this.groupPanel10.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel10.Style.BorderTopWidth = 1;
            this.groupPanel10.Style.CornerDiameter = 4;
            this.groupPanel10.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel10.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel10.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel10.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel10.TabIndex = 9;
            this.groupPanel10.Text = "عملیات";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.BackColor = System.Drawing.Color.Transparent;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::PFC.Properties.Resources.amor;
            this.buttonX2.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.buttonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX2.Location = new System.Drawing.Point(22, 3);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.buttonX2.Size = new System.Drawing.Size(185, 30);
            this.buttonX2.TabIndex = 6;
            this.buttonX2.Text = "ذخیره نمودن تصویر";
            // 
            // groupPanel3
            // 
            this.groupPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel3.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.buttonX4);
            this.groupPanel3.Controls.Add(this.pictureBox1);
            this.groupPanel3.Controls.Add(this.TxtScannerName);
            this.groupPanel3.Controls.Add(this.labelX3);
            this.groupPanel3.Controls.Add(this.btnchooseScanner);
            this.groupPanel3.Controls.Add(this.labelX2);
            this.groupPanel3.Location = new System.Drawing.Point(74, 68);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(593, 421);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel3.TabIndex = 2;
            this.groupPanel3.Text = "اسکن";
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.BackColor = System.Drawing.Color.Transparent;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Image = global::PFC.Properties.Resources.clean;
            this.buttonX4.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.buttonX4.Location = new System.Drawing.Point(27, 354);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.buttonX4.Size = new System.Drawing.Size(203, 30);
            this.buttonX4.TabIndex = 8;
            this.buttonX4.Text = "نمایش تصویر در سایز بزرگتر";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::PFC.Properties.Resources.Desert;
            this.pictureBox1.Location = new System.Drawing.Point(47, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TxtScannerName
            // 
            this.TxtScannerName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtScannerName.Border.Class = "TextBoxBorder";
            this.TxtScannerName.Location = new System.Drawing.Point(59, 55);
            this.TxtScannerName.Name = "TxtScannerName";
            this.TxtScannerName.ReadOnly = true;
            this.TxtScannerName.Size = new System.Drawing.Size(406, 21);
            this.TxtScannerName.TabIndex = 4;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(471, 57);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(38, 16);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "اسکنر :";
            // 
            // btnchooseScanner
            // 
            this.btnchooseScanner.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnchooseScanner.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnchooseScanner.Image = global::PFC.Properties.Resources.AlienAqua_scanner;
            this.btnchooseScanner.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnchooseScanner.Location = new System.Drawing.Point(273, 18);
            this.btnchooseScanner.Name = "btnchooseScanner";
            this.btnchooseScanner.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btnchooseScanner.Size = new System.Drawing.Size(115, 20);
            this.btnchooseScanner.TabIndex = 2;
            this.btnchooseScanner.Text = "انتخاب اسکنر";
            this.btnchooseScanner.Click += new System.EventHandler(this.btnchooseScanner_Click);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(394, 23);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(164, 16);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "لطفا  اسکنر مربوطه را انتخاب کنید ";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::PFC.Properties.Resources.AlienAqua_scanner_2;
            this.pictureBox12.Location = new System.Drawing.Point(17, 3);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(49, 44);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 1;
            this.pictureBox12.TabStop = false;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(222, 14);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(397, 16);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "کلیه فرم های اطلاعاتی را می توانید با استفاده از کادر زیر اسکن کرده و وارد برنامه" +
                " کنید";
            // 
            // FrmScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 655);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "FrmScanner";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "اسکنر";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmScanner_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.groupPanel10.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.PictureBox pictureBox12;
        private DevComponents.DotNetBar.LabelX labelX1;
        private Atalasoft.Twain.Acquisition acquisition;
        private Device device = null;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtScannerName;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnchooseScanner;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel10;
        private DevComponents.DotNetBar.ButtonX buttonX2;
    }
}