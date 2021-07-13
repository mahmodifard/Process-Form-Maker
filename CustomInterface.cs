using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Globalization;
using Atalasoft.Twain;

namespace PFC
{
	/// <summary>
	/// Summary description for Barcode.
	/// </summary>
	public class CustomInterface : System.Windows.Forms.Form
	{
		private Atalasoft.Twain.Device _device;

		private System.Windows.Forms.GroupBox groupBarcode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboPixelType;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboResolution;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numPages;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cboBrightness;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboContrast;
		private System.Windows.Forms.CheckBox chkAutoBorder;
		private System.Windows.Forms.CheckBox chkAutoDeskew;
		private System.Windows.Forms.CheckBox chkAutoRotate;
		private System.Windows.Forms.CheckBox chkBarcodeEnabled;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numBarcodeRetries;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numBarcodeSearch;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cboBarcodeSearchMode;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckedListBox listBarcodeSearch;
		private System.Windows.Forms.Button btnScan;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.NumericUpDown numTimeout;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CustomInterface(Device device)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this._device = device;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBarcode = new System.Windows.Forms.GroupBox();
			this.listBarcodeSearch = new System.Windows.Forms.CheckedListBox();
			this.label10 = new System.Windows.Forms.Label();
			this.numTimeout = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.cboBarcodeSearchMode = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.numBarcodeSearch = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.numBarcodeRetries = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.chkBarcodeEnabled = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cboPixelType = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cboResolution = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.numPages = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkAutoRotate = new System.Windows.Forms.CheckBox();
			this.chkAutoDeskew = new System.Windows.Forms.CheckBox();
			this.chkAutoBorder = new System.Windows.Forms.CheckBox();
			this.cboContrast = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cboBrightness = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnScan = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBarcode.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numTimeout)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numBarcodeSearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numBarcodeRetries)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numPages)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBarcode
			// 
			this.groupBarcode.Controls.Add(this.listBarcodeSearch);
			this.groupBarcode.Controls.Add(this.label10);
			this.groupBarcode.Controls.Add(this.numTimeout);
			this.groupBarcode.Controls.Add(this.label9);
			this.groupBarcode.Controls.Add(this.cboBarcodeSearchMode);
			this.groupBarcode.Controls.Add(this.label8);
			this.groupBarcode.Controls.Add(this.numBarcodeSearch);
			this.groupBarcode.Controls.Add(this.label7);
			this.groupBarcode.Controls.Add(this.numBarcodeRetries);
			this.groupBarcode.Controls.Add(this.label6);
			this.groupBarcode.Controls.Add(this.chkBarcodeEnabled);
			this.groupBarcode.Location = new System.Drawing.Point(250, 18);
			this.groupBarcode.Name = "groupBarcode";
			this.groupBarcode.Size = new System.Drawing.Size(271, 302);
			this.groupBarcode.TabIndex = 7;
			this.groupBarcode.TabStop = false;
			this.groupBarcode.Text = "Barcode";
			// 
			// listBarcodeSearch
			// 
			this.listBarcodeSearch.Location = new System.Drawing.Point(17, 191);
			this.listBarcodeSearch.Name = "listBarcodeSearch";
			this.listBarcodeSearch.Size = new System.Drawing.Size(233, 94);
			this.listBarcodeSearch.TabIndex = 10;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(17, 173);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(97, 19);
			this.label10.TabIndex = 9;
			this.label10.Text = "Search Priorities:";
			// 
			// numTimeout
			// 
			this.numTimeout.Location = new System.Drawing.Point(154, 144);
			this.numTimeout.Name = "numTimeout";
			this.numTimeout.Size = new System.Drawing.Size(76, 20);
			this.numTimeout.TabIndex = 8;
			this.numTimeout.ValueChanged += new System.EventHandler(this.numTimeout_ValueChanged);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(17, 144);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(54, 20);
			this.label9.TabIndex = 7;
			this.label9.Text = "Timeout:";
			// 
			// cboBarcodeSearchMode
			// 
			this.cboBarcodeSearchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBarcodeSearchMode.Location = new System.Drawing.Point(154, 114);
			this.cboBarcodeSearchMode.Name = "cboBarcodeSearchMode";
			this.cboBarcodeSearchMode.Size = new System.Drawing.Size(99, 21);
			this.cboBarcodeSearchMode.TabIndex = 6;
			this.cboBarcodeSearchMode.SelectedIndexChanged += new System.EventHandler(this.cboBarcodeSearchMode_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(17, 114);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 21);
			this.label8.TabIndex = 5;
			this.label8.Text = "Search Mode:";
			// 
			// numBarcodeSearch
			// 
			this.numBarcodeSearch.Location = new System.Drawing.Point(154, 85);
			this.numBarcodeSearch.Name = "numBarcodeSearch";
			this.numBarcodeSearch.Size = new System.Drawing.Size(46, 20);
			this.numBarcodeSearch.TabIndex = 4;
			this.numBarcodeSearch.ValueChanged += new System.EventHandler(this.numBarcodeSearch_ValueChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(17, 85);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(145, 20);
			this.label7.TabIndex = 3;
			this.label7.Text = "Maximum Search Priorities:";
			// 
			// numBarcodeRetries
			// 
			this.numBarcodeRetries.Location = new System.Drawing.Point(154, 56);
			this.numBarcodeRetries.Name = "numBarcodeRetries";
			this.numBarcodeRetries.Size = new System.Drawing.Size(46, 20);
			this.numBarcodeRetries.TabIndex = 2;
			this.numBarcodeRetries.ValueChanged += new System.EventHandler(this.numBarcodeRetries_ValueChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(17, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(101, 20);
			this.label6.TabIndex = 1;
			this.label6.Text = "Maximum Retries:";
			// 
			// chkBarcodeEnabled
			// 
			this.chkBarcodeEnabled.Location = new System.Drawing.Point(17, 30);
			this.chkBarcodeEnabled.Name = "chkBarcodeEnabled";
			this.chkBarcodeEnabled.Size = new System.Drawing.Size(75, 17);
			this.chkBarcodeEnabled.TabIndex = 0;
			this.chkBarcodeEnabled.Text = "Enabled";
			this.chkBarcodeEnabled.CheckedChanged += new System.EventHandler(this.chkBarcodeEnabled_CheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(19, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pixel Type:";
			// 
			// cboPixelType
			// 
			this.cboPixelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboPixelType.Location = new System.Drawing.Point(106, 20);
			this.cboPixelType.Name = "cboPixelType";
			this.cboPixelType.Size = new System.Drawing.Size(115, 21);
			this.cboPixelType.TabIndex = 1;
			this.cboPixelType.SelectedIndexChanged += new System.EventHandler(this.cboPixelType_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(19, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Resolution:";
			// 
			// cboResolution
			// 
			this.cboResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboResolution.Location = new System.Drawing.Point(106, 56);
			this.cboResolution.Name = "cboResolution";
			this.cboResolution.Size = new System.Drawing.Size(115, 21);
			this.cboResolution.TabIndex = 3;
			this.cboResolution.SelectedIndexChanged += new System.EventHandler(this.cboResolution_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(19, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 19);
			this.label3.TabIndex = 4;
			this.label3.Text = "Number of pages to scan::";
			// 
			// numPages
			// 
			this.numPages.Location = new System.Drawing.Point(174, 91);
			this.numPages.Minimum = new System.Decimal(new int[] {
																	 1,
																	 0,
																	 0,
																	 -2147483648});
			this.numPages.Name = "numPages";
			this.numPages.Size = new System.Drawing.Size(45, 20);
			this.numPages.TabIndex = 5;
			this.numPages.Value = new System.Decimal(new int[] {
																   1,
																   0,
																   0,
																   -2147483648});
			this.numPages.ValueChanged += new System.EventHandler(this.numPages_ValueChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkAutoRotate);
			this.groupBox1.Controls.Add(this.chkAutoDeskew);
			this.groupBox1.Controls.Add(this.chkAutoBorder);
			this.groupBox1.Controls.Add(this.cboContrast);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cboBrightness);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(19, 136);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(211, 184);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Image Processing";
			// 
			// chkAutoRotate
			// 
			this.chkAutoRotate.Location = new System.Drawing.Point(24, 149);
			this.chkAutoRotate.Name = "chkAutoRotate";
			this.chkAutoRotate.Size = new System.Drawing.Size(130, 17);
			this.chkAutoRotate.TabIndex = 6;
			this.chkAutoRotate.Text = "Automatic Rotation";
			this.chkAutoRotate.CheckedChanged += new System.EventHandler(this.chkAutoRotate_CheckedChanged);
			// 
			// chkAutoDeskew
			// 
			this.chkAutoDeskew.Location = new System.Drawing.Point(24, 117);
			this.chkAutoDeskew.Name = "chkAutoDeskew";
			this.chkAutoDeskew.Size = new System.Drawing.Size(132, 22);
			this.chkAutoDeskew.TabIndex = 5;
			this.chkAutoDeskew.Text = "Automatic Deskew";
			this.chkAutoDeskew.CheckedChanged += new System.EventHandler(this.chkAutoDeskew_CheckedChanged);
			// 
			// chkAutoBorder
			// 
			this.chkAutoBorder.Location = new System.Drawing.Point(24, 90);
			this.chkAutoBorder.Name = "chkAutoBorder";
			this.chkAutoBorder.Size = new System.Drawing.Size(162, 17);
			this.chkAutoBorder.TabIndex = 4;
			this.chkAutoBorder.Text = "Automatic Border Detection";
			this.chkAutoBorder.CheckedChanged += new System.EventHandler(this.chkAutoBorder_CheckedChanged);
			// 
			// cboContrast
			// 
			this.cboContrast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboContrast.Location = new System.Drawing.Point(94, 58);
			this.cboContrast.Name = "cboContrast";
			this.cboContrast.Size = new System.Drawing.Size(80, 21);
			this.cboContrast.TabIndex = 3;
			this.cboContrast.SelectedIndexChanged += new System.EventHandler(this.cboContrast_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 16);
			this.label5.TabIndex = 2;
			this.label5.Text = "Contrast:";
			// 
			// cboBrightness
			// 
			this.cboBrightness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBrightness.Location = new System.Drawing.Point(94, 32);
			this.cboBrightness.Name = "cboBrightness";
			this.cboBrightness.Size = new System.Drawing.Size(80, 21);
			this.cboBrightness.TabIndex = 1;
			this.cboBrightness.SelectedIndexChanged += new System.EventHandler(this.cboBrightness_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 21);
			this.label4.TabIndex = 0;
			this.label4.Text = "Brightness:";
			// 
			// btnScan
			// 
			this.btnScan.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnScan.Location = new System.Drawing.Point(90, 334);
			this.btnScan.Name = "btnScan";
			this.btnScan.Size = new System.Drawing.Size(99, 28);
			this.btnScan.TabIndex = 8;
			this.btnScan.Text = "&Scan";
			this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(352, 334);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(99, 28);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "&Cancel";
			// 
			// CustomInterface
			// 
			this.AcceptButton = this.btnScan;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(541, 379);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnScan);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.numPages);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cboResolution);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboPixelType);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBarcode);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CustomInterface";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Scan Settings";
			this.Load += new System.EventHandler(this.CustomInterface_Load);
			this.groupBarcode.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numTimeout)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numBarcodeSearch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numBarcodeRetries)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numPages)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void CustomInterface_Load(object sender, System.EventArgs e)
		{
			// Setup the controls for this specific device.
			if (this._device == null)
			{
				MessageBox.Show("The device object has not been set.");
				return;
			}

			if (this._device.State != TwainState.SourceOpen)
			{
				MessageBox.Show("This dialog can only be used when the device state is SourceOpen.");
				return;
			}

			if (this._device.QueryCapability(DeviceCapability.ICAP_PIXELTYPE, true))
			{
				ImagePixelType[] pt = this._device.GetSupportedPixelTypes();
				foreach (ImagePixelType p in pt)
					this.cboPixelType.Items.Add(p.ToString());

				this.cboPixelType.SelectedItem = this._device.PixelType.ToString();
			}
			else
				this.cboPixelType.Enabled = false;

			if (this._device.QueryCapability(DeviceCapability.ICAP_XRESOLUTION, true))
			{
				TwainResolution[] res = this._device.GetSupportedResolutions();
				foreach (TwainResolution r in res)
				{
					this.cboResolution.Items.Add(r.X.ToString());
				}
				this.cboResolution.SelectedItem = this._device.Resolution.X.ToString();
			}
			else
				this.cboResolution.Enabled = false;

			// Every Twain driver must support this property.
			this.numPages.Value = this._device.TransferCount;

			if (this._device.QueryCapability(DeviceCapability.ICAP_BRIGHTNESS, true))
			{
				float[] vals = this._device.GetSupportedBrightnessValues();
				foreach (float v in vals)
					this.cboBrightness.Items.Add(v.ToString());

				this.cboBrightness.SelectedItem = this._device.Brightness.ToString();
			}
			else
				this.cboBrightness.Enabled = false;


			if (this._device.QueryCapability(DeviceCapability.ICAP_CONTRAST, true))
			{
				float[] vals = this._device.GetSupportedContrastValues();
				foreach (float v in vals)
					this.cboContrast.Items.Add(v.ToString());

				this.cboContrast.SelectedItem = this._device.Contrast.ToString();
			}
			else
				this.cboContrast.Enabled = false;

			this.chkAutoBorder.Enabled = this._device.QueryCapability(DeviceCapability.ICAP_AUTOMATICBORDERDETECTION, true);
			this.chkAutoDeskew.Enabled = this._device.QueryCapability(DeviceCapability.ICAP_AUTOMATICDESKEW, true);
			this.chkAutoRotate.Enabled = this._device.QueryCapability(DeviceCapability.ICAP_AUTOMATICROTATE, true);

			// If the device does not support ICAP_BARCODEDETECTIONENABLED, then it's not barcode enabled.
			if (this._device.QueryCapability(DeviceCapability.ICAP_BARCODEDETECTIONENABLED, true))
			{
				// Barcode has to be enabled to access the properties.
				this._device.BarCode.DetectionEnabled = true;
				if (this._device.BarCode.DetectionEnabled == false) return;

				this.numBarcodeRetries.Enabled = this._device.QueryCapability(DeviceCapability.ICAP_BARCODEMAXRETRIES, true);
				this.numBarcodeSearch.Enabled = this._device.QueryCapability(DeviceCapability.ICAP_BARCODEMAXSEARCHPRIORITIES, true);

				if (this._device.QueryCapability(DeviceCapability.ICAP_BARCODESEARCHMODE, true))
				{
					BarCodeSearchMode[] modes = this._device.BarCode.GetSearchModes();
					foreach (BarCodeSearchMode m in modes)
						this.cboBarcodeSearchMode.Items.Add(m.ToString());

					this.cboBarcodeSearchMode.SelectedItem = this._device.BarCode.SearchMode.ToString();
				}
				else
					this.cboBarcodeSearchMode.Enabled = false;

				if (this._device.QueryCapability(DeviceCapability.ICAP_BARCODESEARCHPRIORITIES, true))
				{
					BarCodeType[] pris = this._device.BarCode.GetSearchPriorities();
					foreach (BarCodeType bt in pris)
						this.listBarcodeSearch.Items.Add(bt.ToString());
				}
				else
					this.listBarcodeSearch.Enabled = false;
			}
			else
			{
				this.groupBarcode.Enabled = false;
			}
		}

		private void cboPixelType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this._device.PixelType = (ImagePixelType)Enum.Parse(typeof(ImagePixelType), this.cboPixelType.Text);
		}

		private void cboResolution_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this._device.Resolution = new TwainResolution(float.Parse(this.cboResolution.Text), float.Parse(this.cboResolution.Text), UnitType.Inches);
		}

		private void numPages_ValueChanged(object sender, System.EventArgs e)
		{
			// A value of zero isn't truely supported.
			if (this.numPages.Value == 0)
				this._device.TransferCount = -1;
			else
				this._device.TransferCount = Convert.ToInt32(this.numPages.Value);
		}

		private void cboBrightness_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this._device.Brightness = float.Parse(this.cboBrightness.Text);
		}

		private void cboContrast_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this._device.Contrast = float.Parse(this.cboContrast.Text);
		}

		private void chkAutoBorder_CheckedChanged(object sender, System.EventArgs e)
		{
			this._device.AutomaticBorderDetection = this.chkAutoBorder.Checked;
		}

		private void chkAutoDeskew_CheckedChanged(object sender, System.EventArgs e)
		{
			this._device.AutomaticDeskew = this.chkAutoDeskew.Checked;
		}

		private void chkAutoRotate_CheckedChanged(object sender, System.EventArgs e)
		{
			this._device.AutomaticRotate = this.chkAutoRotate.Checked;
		}

		private void chkBarcodeEnabled_CheckedChanged(object sender, System.EventArgs e)
		{
			this._device.BarCode.DetectionEnabled = this.chkBarcodeEnabled.Checked;
		}

		private void numBarcodeRetries_ValueChanged(object sender, System.EventArgs e)
		{
			if (!this.chkBarcodeEnabled.Checked)
			{
				MessageBox.Show("Please enable barcode detection before setting any barcode properties.", "Information");
				return;
			}

			this._device.BarCode.MaximumRetries = Convert.ToInt32(this.numBarcodeRetries.Value);
		}

		private void numBarcodeSearch_ValueChanged(object sender, System.EventArgs e)
		{
			if (!this.chkBarcodeEnabled.Checked)
			{
				MessageBox.Show("Please enable barcode detection before setting any barcode properties.", "Information");
				return;
			}

			this._device.BarCode.MaximumSearchPriorities = Convert.ToInt32(this.numBarcodeSearch.Value);
		}

		private void cboBarcodeSearchMode_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (!this.chkBarcodeEnabled.Checked)
			{
				MessageBox.Show("Please enable barcode detection before setting any barcode properties.", "Information");
				return;
			}

			this._device.BarCode.SearchMode = (BarCodeSearchMode)Enum.Parse(typeof(BarCodeSearchMode), this.cboBarcodeSearchMode.Text);
		}

		private void numTimeout_ValueChanged(object sender, System.EventArgs e)
		{
			if (!this.chkBarcodeEnabled.Checked)
			{
				MessageBox.Show("Please enable barcode detection before setting any barcode properties.", "Information");
				return;
			}

			this._device.BarCode.Timeout = Convert.ToInt32(this.numTimeout.Value);
		}

		private void btnScan_Click(object sender, System.EventArgs e)
		{
		}

	}
}
