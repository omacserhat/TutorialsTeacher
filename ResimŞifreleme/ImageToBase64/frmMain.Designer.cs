namespace ImageToBase64
{
	partial class frmMain
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
			this.pbxLoadedımage = new System.Windows.Forms.PictureBox();
			this.ofdSelectImage = new System.Windows.Forms.OpenFileDialog();
			this.btnSelectFile = new System.Windows.Forms.Button();
			this.txbBase64Code = new System.Windows.Forms.TextBox();
			this.pbxConvertedImage = new System.Windows.Forms.PictureBox();
			this.lblGorsel = new System.Windows.Forms.Label();
			this.lblBase64 = new System.Windows.Forms.Label();
			this.lblConvertedImage = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbxLoadedımage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxConvertedImage)).BeginInit();
			this.SuspendLayout();
			// 
			// pbxLoadedımage
			// 
			this.pbxLoadedımage.Location = new System.Drawing.Point(13, 151);
			this.pbxLoadedımage.Name = "pbxLoadedımage";
			this.pbxLoadedımage.Size = new System.Drawing.Size(502, 351);
			this.pbxLoadedımage.TabIndex = 1;
			this.pbxLoadedımage.TabStop = false;
			// 
			// ofdSelectImage
			// 
			this.ofdSelectImage.FileName = "openFile_Image";
			// 
			// btnSelectFile
			// 
			this.btnSelectFile.Location = new System.Drawing.Point(12, 17);
			this.btnSelectFile.Name = "btnSelectFile";
			this.btnSelectFile.Size = new System.Drawing.Size(187, 56);
			this.btnSelectFile.TabIndex = 2;
			this.btnSelectFile.Text = "Görsel Seç / Select Image";
			this.btnSelectFile.UseVisualStyleBackColor = true;
			this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
			// 
			// txbBase64Code
			// 
			this.txbBase64Code.Location = new System.Drawing.Point(521, 151);
			this.txbBase64Code.Multiline = true;
			this.txbBase64Code.Name = "txbBase64Code";
			this.txbBase64Code.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txbBase64Code.Size = new System.Drawing.Size(502, 352);
			this.txbBase64Code.TabIndex = 3;
			// 
			// pbxConvertedImage
			// 
			this.pbxConvertedImage.Location = new System.Drawing.Point(1029, 151);
			this.pbxConvertedImage.Name = "pbxConvertedImage";
			this.pbxConvertedImage.Size = new System.Drawing.Size(502, 351);
			this.pbxConvertedImage.TabIndex = 4;
			this.pbxConvertedImage.TabStop = false;
			// 
			// lblGorsel
			// 
			this.lblGorsel.AutoSize = true;
			this.lblGorsel.Location = new System.Drawing.Point(12, 121);
			this.lblGorsel.Name = "lblGorsel";
			this.lblGorsel.Size = new System.Drawing.Size(201, 17);
			this.lblGorsel.TabIndex = 5;
			this.lblGorsel.Text = "Orijinal Görsel / Original Image";
			// 
			// lblBase64
			// 
			this.lblBase64.AutoSize = true;
			this.lblBase64.Location = new System.Drawing.Point(518, 121);
			this.lblBase64.Name = "lblBase64";
			this.lblBase64.Size = new System.Drawing.Size(93, 17);
			this.lblBase64.TabIndex = 6;
			this.lblBase64.Text = "Base64 Code";
			// 
			// lblConvertedImage
			// 
			this.lblConvertedImage.AutoSize = true;
			this.lblConvertedImage.Location = new System.Drawing.Point(1026, 121);
			this.lblConvertedImage.Name = "lblConvertedImage";
			this.lblConvertedImage.Size = new System.Drawing.Size(268, 17);
			this.lblConvertedImage.TabIndex = 7;
			this.lblConvertedImage.Text = "Dönüştürülmüş Görsel / Converted Image";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1545, 515);
			this.Controls.Add(this.lblConvertedImage);
			this.Controls.Add(this.lblBase64);
			this.Controls.Add(this.lblGorsel);
			this.Controls.Add(this.pbxConvertedImage);
			this.Controls.Add(this.txbBase64Code);
			this.Controls.Add(this.btnSelectFile);
			this.Controls.Add(this.pbxLoadedımage);
			this.Name = "frmMain";
			this.Text = "Image Converting";
			((System.ComponentModel.ISupportInitialize)(this.pbxLoadedımage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxConvertedImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox pbxLoadedımage;
		private System.Windows.Forms.OpenFileDialog ofdSelectImage;
		private System.Windows.Forms.Button btnSelectFile;
		private System.Windows.Forms.TextBox txbBase64Code;
		private System.Windows.Forms.PictureBox pbxConvertedImage;
		private System.Windows.Forms.Label lblGorsel;
		private System.Windows.Forms.Label lblBase64;
		private System.Windows.Forms.Label lblConvertedImage;
	}
}

