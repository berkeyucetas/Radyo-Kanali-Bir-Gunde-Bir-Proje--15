namespace Radyo_Kanalı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.btntrtfm = new System.Windows.Forms.Button();
            this.btnfenomenfm = new System.Windows.Forms.Button();
            this.btnsuperfm = new System.Windows.Forms.Button();
            this.btnpowerfm = new System.Windows.Forms.Button();
            this.btnmetrofm = new System.Windows.Forms.Button();
            this.btnistanbulfm = new System.Windows.Forms.Button();
            this.btnbestfm = new System.Windows.Forms.Button();
            this.btnalemfm = new System.Windows.Forms.Button();
            this.btnslowfm = new System.Windows.Forms.Button();
            this.btnkralfm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 291);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(522, 224);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Radyo_Kanalı.Properties.Resources.exit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(672, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 128);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btntrtfm
            // 
            this.btntrtfm.BackgroundImage = global::Radyo_Kanalı.Properties.Resources.trtfm;
            this.btntrtfm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntrtfm.Location = new System.Drawing.Point(540, 146);
            this.btntrtfm.Name = "btntrtfm";
            this.btntrtfm.Size = new System.Drawing.Size(126, 128);
            this.btntrtfm.TabIndex = 10;
            this.btntrtfm.UseVisualStyleBackColor = true;
            this.btntrtfm.Click += new System.EventHandler(this.btntrtfm_Click);
            // 
            // btnfenomenfm
            // 
            this.btnfenomenfm.BackgroundImage = global::Radyo_Kanalı.Properties.Resources.fenomenfm;
            this.btnfenomenfm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfenomenfm.Location = new System.Drawing.Point(540, 12);
            this.btnfenomenfm.Name = "btnfenomenfm";
            this.btnfenomenfm.Size = new System.Drawing.Size(126, 128);
            this.btnfenomenfm.TabIndex = 9;
            this.btnfenomenfm.UseVisualStyleBackColor = true;
            this.btnfenomenfm.Click += new System.EventHandler(this.btnfenomenfm_Click);
            // 
            // btnsuperfm
            // 
            this.btnsuperfm.BackgroundImage = global::Radyo_Kanalı.Properties.Resources.süperfm;
            this.btnsuperfm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsuperfm.Location = new System.Drawing.Point(408, 146);
            this.btnsuperfm.Name = "btnsuperfm";
            this.btnsuperfm.Size = new System.Drawing.Size(126, 128);
            this.btnsuperfm.TabIndex = 7;
            this.btnsuperfm.UseVisualStyleBackColor = true;
            this.btnsuperfm.Click += new System.EventHandler(this.btnsuperfm_Click);
            // 
            // btnpowerfm
            // 
            this.btnpowerfm.BackgroundImage = global::Radyo_Kanalı.Properties.Resources.powerfm;
            this.btnpowerfm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpowerfm.Location = new System.Drawing.Point(276, 146);
            this.btnpowerfm.Name = "btnpowerfm";
            this.btnpowerfm.Size = new System.Drawing.Size(126, 128);
            this.btnpowerfm.TabIndex = 6;
            this.btnpowerfm.UseVisualStyleBackColor = true;
            this.btnpowerfm.Click += new System.EventHandler(this.btnpowerfm_Click);
            // 
            // btnmetrofm
            // 
            this.btnmetrofm.BackgroundImage = global::Radyo_Kanalı.Properties.Resources.metrofm;
            this.btnmetrofm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmetrofm.Location = new System.Drawing.Point(144, 146);
            this.btnmetrofm.Name = "btnmetrofm";
            this.btnmetrofm.Size = new System.Drawing.Size(126, 128);
            this.btnmetrofm.TabIndex = 5;
            this.btnmetrofm.UseVisualStyleBackColor = true;
            this.btnmetrofm.Click += new System.EventHandler(this.btnmetrofm_Click);
            // 
            // btnistanbulfm
            // 
            this.btnistanbulfm.BackgroundImage = global::Radyo_Kanalı.Properties.Resources.istanbulfm;
            this.btnistanbulfm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnistanbulfm.Location = new System.Drawing.Point(12, 146);
            this.btnistanbulfm.Name = "btnistanbulfm";
            this.btnistanbulfm.Size = new System.Drawing.Size(126, 128);
            this.btnistanbulfm.TabIndex = 4;
            this.btnistanbulfm.UseVisualStyleBackColor = true;
            this.btnistanbulfm.Click += new System.EventHandler(this.btnistanbulfm_Click);
            // 
            // btnbestfm
            // 
            this.btnbestfm.BackgroundImage = global::Radyo_Kanalı.Properties.Resources.bestfm;
            this.btnbestfm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbestfm.Location = new System.Drawing.Point(408, 12);
            this.btnbestfm.Name = "btnbestfm";
            this.btnbestfm.Size = new System.Drawing.Size(126, 128);
            this.btnbestfm.TabIndex = 3;
            this.btnbestfm.UseVisualStyleBackColor = true;
            this.btnbestfm.Click += new System.EventHandler(this.btnbestfm_Click);
            // 
            // btnalemfm
            // 
            this.btnalemfm.BackgroundImage = global::Radyo_Kanalı.Properties.Resources.alemfm;
            this.btnalemfm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnalemfm.Location = new System.Drawing.Point(276, 12);
            this.btnalemfm.Name = "btnalemfm";
            this.btnalemfm.Size = new System.Drawing.Size(126, 128);
            this.btnalemfm.TabIndex = 2;
            this.btnalemfm.UseVisualStyleBackColor = true;
            this.btnalemfm.Click += new System.EventHandler(this.btnalemfm_Click);
            // 
            // btnslowfm
            // 
            this.btnslowfm.BackgroundImage = global::Radyo_Kanalı.Properties.Resources.slowtürkfm;
            this.btnslowfm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnslowfm.Location = new System.Drawing.Point(144, 12);
            this.btnslowfm.Name = "btnslowfm";
            this.btnslowfm.Size = new System.Drawing.Size(126, 128);
            this.btnslowfm.TabIndex = 1;
            this.btnslowfm.UseVisualStyleBackColor = true;
            this.btnslowfm.Click += new System.EventHandler(this.btnslowfm_Click);
            // 
            // btnkralfm
            // 
            this.btnkralfm.BackgroundImage = global::Radyo_Kanalı.Properties.Resources.kralfm;
            this.btnkralfm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkralfm.Location = new System.Drawing.Point(12, 12);
            this.btnkralfm.Name = "btnkralfm";
            this.btnkralfm.Size = new System.Drawing.Size(126, 128);
            this.btnkralfm.TabIndex = 0;
            this.btnkralfm.UseVisualStyleBackColor = true;
            this.btnkralfm.Click += new System.EventHandler(this.btnkralfm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btntrtfm);
            this.Controls.Add(this.btnfenomenfm);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnsuperfm);
            this.Controls.Add(this.btnpowerfm);
            this.Controls.Add(this.btnmetrofm);
            this.Controls.Add(this.btnistanbulfm);
            this.Controls.Add(this.btnbestfm);
            this.Controls.Add(this.btnalemfm);
            this.Controls.Add(this.btnslowfm);
            this.Controls.Add(this.btnkralfm);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkralfm;
        private System.Windows.Forms.Button btnslowfm;
        private System.Windows.Forms.Button btnalemfm;
        private System.Windows.Forms.Button btnbestfm;
        private System.Windows.Forms.Button btnistanbulfm;
        private System.Windows.Forms.Button btnmetrofm;
        private System.Windows.Forms.Button btnpowerfm;
        private System.Windows.Forms.Button btnsuperfm;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btntrtfm;
        private System.Windows.Forms.Button btnfenomenfm;
        private System.Windows.Forms.Button button1;
    }
}

