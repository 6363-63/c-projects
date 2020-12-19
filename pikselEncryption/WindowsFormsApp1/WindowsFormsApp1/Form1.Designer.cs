
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.orjinal_goruntu = new System.Windows.Forms.PictureBox();
            this.hedef_goruntu = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.decryptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orjinal_goruntu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hedef_goruntu)).BeginInit();
            this.SuspendLayout();
            // 
            // orjinal_goruntu
            // 
            this.orjinal_goruntu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orjinal_goruntu.Location = new System.Drawing.Point(12, 76);
            this.orjinal_goruntu.Name = "orjinal_goruntu";
            this.orjinal_goruntu.Size = new System.Drawing.Size(363, 334);
            this.orjinal_goruntu.TabIndex = 0;
            this.orjinal_goruntu.TabStop = false;
            this.orjinal_goruntu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // hedef_goruntu
            // 
            this.hedef_goruntu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hedef_goruntu.Location = new System.Drawing.Point(573, 76);
            this.hedef_goruntu.Name = "hedef_goruntu";
            this.hedef_goruntu.Size = new System.Drawing.Size(363, 334);
            this.hedef_goruntu.TabIndex = 1;
            this.hedef_goruntu.TabStop = false;
            this.hedef_goruntu.Click += new System.EventHandler(this.hedef_goruntu_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(269, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sifrele >>>>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(573, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "<<<ÇÖZ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // decryptionTextBox
            // 
            this.decryptionTextBox.Location = new System.Drawing.Point(776, 436);
            this.decryptionTextBox.Multiline = true;
            this.decryptionTextBox.Name = "decryptionTextBox";
            this.decryptionTextBox.Size = new System.Drawing.Size(160, 36);
            this.decryptionTextBox.TabIndex = 4;
            this.decryptionTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(828, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Şifreyi giriniz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifrelenecek kelime";
            // 
            // encryptionTextBox
            // 
            this.encryptionTextBox.Location = new System.Drawing.Point(39, 447);
            this.encryptionTextBox.Multiline = true;
            this.encryptionTextBox.Name = "encryptionTextBox";
            this.encryptionTextBox.Size = new System.Drawing.Size(153, 37);
            this.encryptionTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(519, 47);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(417, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fotoğrafı şifrelemek için bir string kelime Girmelisiniz ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(295, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "fotograf seçmek için üzerine tıklayınız";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Location = new System.Drawing.Point(381, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 37);
            this.button3.TabIndex = 10;
            this.button3.Text = "Fotografı Kaydet";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 522);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encryptionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decryptionTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hedef_goruntu);
            this.Controls.Add(this.orjinal_goruntu);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.orjinal_goruntu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hedef_goruntu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox orjinal_goruntu;
        private System.Windows.Forms.PictureBox hedef_goruntu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox decryptionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox encryptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}

