using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FileDialog goruntuCek = new OpenFileDialog();
			goruntuCek.Filter = "Jpeg Dosyası | *.jpg";

            DialogResult cevap = goruntuCek.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                orjinal_goruntu.ImageLocation = goruntuCek.FileName;
            }
        }
    


        private void button1_Click(object sender, EventArgs e)
        {
            if (orjinal_goruntu.Image == null)
            {
                return;
            }
            if (encryptionTextBox.Text == null)
            {
                return;
            }
			Bitmap orjinalGoruntu = new Bitmap(orjinal_goruntu.Image);
			int genislik = orjinalGoruntu.Width;
			int yukseklik = orjinalGoruntu.Height;
			BitmapData orjinalGoruntuVerisi = orjinalGoruntu.LockBits(
				new Rectangle(0, 0, genislik, yukseklik),
				ImageLockMode.ReadOnly,
				PixelFormat.Format24bppRgb
			);
			IntPtr orjinalGoruntuAdresi = orjinalGoruntuVerisi.Scan0;
			byte[] byte_orjinalGoruntu = new byte[orjinalGoruntuVerisi.Stride * yukseklik];
			Marshal.Copy(
				orjinalGoruntuAdresi,
				byte_orjinalGoruntu,
				0,
				orjinalGoruntuVerisi.Stride * yukseklik
			);
			Bitmap hedefGoruntu = new Bitmap(genislik, yukseklik);
			BitmapData hedefGoruntuVerisi = hedefGoruntu.LockBits(
				new Rectangle(0, 0, genislik, yukseklik),
				ImageLockMode.WriteOnly,
				PixelFormat.Format24bppRgb
			);
			IntPtr hedefGoruntuAdresi = hedefGoruntuVerisi.Scan0;
		    byte[] byte_hedefGoruntu = new byte[hedefGoruntuVerisi.Stride * yukseklik];
            string sifre=encryptionTextBox.Text;
			byte[] byte_encryption = Encoding.ASCII.GetBytes(sifre);
			for (int i = 0; i < hedefGoruntuVerisi.Stride * yukseklik; i++)
			{
                    byte_hedefGoruntu[i]=(byte)((byte_orjinalGoruntu[i] + (byte_encryption[i % sifre.Length])) + (hedefGoruntuVerisi.Stride * yukseklik-i));
			}
			Marshal.Copy(
				byte_hedefGoruntu,
			0,
				hedefGoruntuAdresi,
				hedefGoruntuVerisi.Stride * yukseklik
			);
			orjinalGoruntu.UnlockBits(orjinalGoruntuVerisi);
			hedefGoruntu.UnlockBits(hedefGoruntuVerisi);
			orjinal_goruntu.Image = null;
			hedef_goruntu.Image = hedefGoruntu;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
			if (hedef_goruntu.Image == null)
				return;
			Bitmap encryptedGoruntu = new Bitmap(hedef_goruntu.Image);
			int genislik = encryptedGoruntu.Width;
			int yukseklik = encryptedGoruntu.Height;
			BitmapData encryptedGoruntuVerisi = encryptedGoruntu.LockBits(
				new Rectangle(0, 0, genislik, yukseklik),
				ImageLockMode.ReadOnly,
				PixelFormat.Format24bppRgb
			);
			
			IntPtr encryptedGoruntuAdresi = encryptedGoruntuVerisi.Scan0;
			byte[] byte_encryptedGoruntu = new byte[encryptedGoruntuVerisi.Stride * yukseklik];
			Marshal.Copy(
				encryptedGoruntuAdresi,
				byte_encryptedGoruntu,
				0,
				encryptedGoruntuVerisi.Stride * yukseklik
			);
			Bitmap decryptedGoruntu = new Bitmap(genislik, yukseklik);
			BitmapData decryptedGoruntuVerisi = decryptedGoruntu.LockBits(
				new Rectangle(0, 0, genislik, yukseklik),
				ImageLockMode.WriteOnly,
				PixelFormat.Format24bppRgb
			);
			byte[] byte_decryptedGoruntu = new byte[decryptedGoruntuVerisi.Stride * yukseklik];
			IntPtr decryptedGoruntuAdresi = decryptedGoruntuVerisi.Scan0;
			string decryptionPass = decryptionTextBox.Text;
			byte[] byte_encryption = Encoding.ASCII.GetBytes(decryptionPass);
			if (encryptionTextBox.Text != decryptionTextBox.Text && encryptionTextBox.Text!="") // program kapatıp tekrar açtığımızda şifrelenmiş fotoğrafı çözerken 2 adımlı şifre çözme yonteminin programa gömülü olanı iptal ediyorum
			{
				for (int i = 0; i < decryptedGoruntuVerisi.Stride * yukseklik; i++)
				{
					byte_decryptedGoruntu[i] = (byte)((byte_encryptedGoruntu[i] - byte_encryption[i % byte_encryption.Length]) + (decryptedGoruntuVerisi.Stride * yukseklik - i));
				}
			}
			else
			for (int i = 0; i < decryptedGoruntuVerisi.Stride * yukseklik; i++)
			{				
				byte_decryptedGoruntu[i] = (byte)((byte_encryptedGoruntu[i] - byte_encryption[i % byte_encryption.Length]) - (decryptedGoruntuVerisi.Stride * yukseklik - i));
			}
			Marshal.Copy(
				byte_decryptedGoruntu,
			0,
				decryptedGoruntuAdresi,
				decryptedGoruntuVerisi.Stride * yukseklik
			);
			encryptedGoruntu.UnlockBits(encryptedGoruntuVerisi);
			decryptedGoruntu.UnlockBits(decryptedGoruntuVerisi);
			orjinal_goruntu.Image = decryptedGoruntu;
			
			hedef_goruntu.Image = null;
			
		}


        private void hedef_goruntu_Click(object sender, EventArgs e)
        {
			FileDialog goruntuCek = new OpenFileDialog();
			goruntuCek.Filter = "Jpeg Dosyası | *.jpg";

			DialogResult cevap = goruntuCek.ShowDialog();

			if (cevap == DialogResult.OK)
			{
				hedef_goruntu.ImageLocation = goruntuCek.FileName;
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

        private void button3_Click(object sender, EventArgs e) 
        {
			SaveFileDialog sfd = new SaveFileDialog();//yeni bir kaydetme diyaloğu oluşturuyoruz.
			sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";//.bmp veya .jpg olarak kayıt imkanı sağlıyoruz.
			sfd.Title = "Kayıt";//diğaloğumuzun başlığını belirliyoruz.
			sfd.FileName = "resim";//kaydedilen resmimizin adını 'resim' olarak belirliyoruz.
			DialogResult sonuç = sfd.ShowDialog();
			if (sonuç == DialogResult.OK)
			{
				hedef_goruntu.Image.Save(sfd.FileName);//Böylelikle resmi istediğimiz yere kaydediyoruz. istedigimiz zaman şifrelediğimiz kelime ile çözebiliriz
			}
		}
    }
    }

