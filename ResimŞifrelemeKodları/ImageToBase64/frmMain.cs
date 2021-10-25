using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageToBase64
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void btnSelectFile_Click(object sender, EventArgs e)
		{
			// OpenFileDialog için seçenekler belirleniyor.
			// Parameter Settings for File Dialog
			ofdSelectImage.Filter = "Tüm Dosyalar |*.*| Jpeg Görseller|*.JPEG,*.JPG,*.jpg,*.jpeg| PNG Görseller|*.png";
			ofdSelectImage.FilterIndex = 1;
			ofdSelectImage.SupportMultiDottedExtensions = true;
			ofdSelectImage.Multiselect = false;

			if (ofdSelectImage.ShowDialog() == DialogResult.OK)
			{
				string secilenDosya = ofdSelectImage.FileName;

				// PictureBox' ta görsel yükleniyor.
				// ımage loading to Picturebox
				pbxLoadedımage.Image = Image.FromFile(secilenDosya);
				pbxLoadedımage.SizeMode = PictureBoxSizeMode.Zoom;

				// Görsel' in Base64 çevrimi yapılıyor.
				// Image converting to base64

				byte[] imageBytes = System.IO.File.ReadAllBytes(secilenDosya);
				string base64Formatted = Convert.ToBase64String(imageBytes);
				txbBase64Code.Text = base64Formatted;

				// Base64 kod' dan görsele dönüştürme yapılıyor
				// Base64 code is converting to image

				byte[] base64Bytes = Convert.FromBase64String(base64Formatted);
				MemoryStream memoryStream = new MemoryStream(base64Bytes);
				pbxConvertedImage.Image = Image.FromStream(memoryStream);
				pbxConvertedImage.SizeMode = PictureBoxSizeMode.Zoom;
			}
		}
	}
}