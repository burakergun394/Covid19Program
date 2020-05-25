namespace Covid19BildirimProgrami
{
    partial class FrmCovid19Bildirim
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
            this.labelTarih = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_bugunIyilesen = new System.Windows.Forms.TextBox();
            this.txt_bugunVefat = new System.Windows.Forms.TextBox();
            this.txt_bugunVaka = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_bugunTest = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_toplamIyilesen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_toplamEntube = new System.Windows.Forms.TextBox();
            this.txt_toplamYogun = new System.Windows.Forms.TextBox();
            this.txt_toplamOlu = new System.Windows.Forms.TextBox();
            this.txt_toplamVaka = new System.Windows.Forms.TextBox();
            this.txt_toplamTest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dosyayayaz = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // labelTarih
            // 
            this.labelTarih.Font = new System.Drawing.Font("Helvetica", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTarih.Location = new System.Drawing.Point(373, 121);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(282, 296);
            this.labelTarih.TabIndex = 70;
            this.labelTarih.Text = "7 MAYIS 2020";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(452, 334);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 69;
            this.listBox1.Visible = false;
            // 
            // txt_bugunIyilesen
            // 
            this.txt_bugunIyilesen.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_bugunIyilesen.Location = new System.Drawing.Point(758, 363);
            this.txt_bugunIyilesen.Name = "txt_bugunIyilesen";
            this.txt_bugunIyilesen.ReadOnly = true;
            this.txt_bugunIyilesen.Size = new System.Drawing.Size(174, 39);
            this.txt_bugunIyilesen.TabIndex = 68;
            // 
            // txt_bugunVefat
            // 
            this.txt_bugunVefat.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_bugunVefat.Location = new System.Drawing.Point(758, 289);
            this.txt_bugunVefat.Name = "txt_bugunVefat";
            this.txt_bugunVefat.ReadOnly = true;
            this.txt_bugunVefat.Size = new System.Drawing.Size(174, 39);
            this.txt_bugunVefat.TabIndex = 67;
            // 
            // txt_bugunVaka
            // 
            this.txt_bugunVaka.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_bugunVaka.Location = new System.Drawing.Point(758, 213);
            this.txt_bugunVaka.Name = "txt_bugunVaka";
            this.txt_bugunVaka.ReadOnly = true;
            this.txt_bugunVaka.Size = new System.Drawing.Size(174, 39);
            this.txt_bugunVaka.TabIndex = 66;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(661, 393);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 19);
            this.label20.TabIndex = 65;
            this.label20.Text = "SAYİSİ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(661, 374);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 19);
            this.label21.TabIndex = 64;
            this.label21.Text = "İYİLEŞEN";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(661, 355);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(91, 19);
            this.label22.TabIndex = 63;
            this.label22.Text = "BUGÜNKÜ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(661, 314);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 19);
            this.label17.TabIndex = 62;
            this.label17.Text = "SAYİSİ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(661, 295);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 19);
            this.label18.TabIndex = 61;
            this.label18.Text = "VEFAT";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(661, 276);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 19);
            this.label19.TabIndex = 60;
            this.label19.Text = "BUGÜNKÜ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(661, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 19);
            this.label14.TabIndex = 59;
            this.label14.Text = "SAYİSİ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(661, 224);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 19);
            this.label15.TabIndex = 58;
            this.label15.Text = "VAKA";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(661, 205);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 19);
            this.label16.TabIndex = 57;
            this.label16.Text = "BUGÜNKÜ";
            // 
            // txt_bugunTest
            // 
            this.txt_bugunTest.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_bugunTest.Location = new System.Drawing.Point(758, 137);
            this.txt_bugunTest.Name = "txt_bugunTest";
            this.txt_bugunTest.ReadOnly = true;
            this.txt_bugunTest.Size = new System.Drawing.Size(174, 39);
            this.txt_bugunTest.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(661, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 19);
            this.label13.TabIndex = 55;
            this.label13.Text = "SAYİSİ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(661, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 19);
            this.label12.TabIndex = 54;
            this.label12.Text = "TEST";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(661, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 19);
            this.label11.TabIndex = 53;
            this.label11.Text = "BUGÜNKÜ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(61, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 19);
            this.label10.TabIndex = 52;
            this.label10.Text = "HASTA SAYISI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(55, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 19);
            this.label9.TabIndex = 51;
            this.label9.Text = "HASTA SAYISI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(55, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "HASTA SAYISI";
            // 
            // txt_toplamIyilesen
            // 
            this.txt_toplamIyilesen.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_toplamIyilesen.Location = new System.Drawing.Point(225, 391);
            this.txt_toplamIyilesen.Name = "txt_toplamIyilesen";
            this.txt_toplamIyilesen.ReadOnly = true;
            this.txt_toplamIyilesen.Size = new System.Drawing.Size(128, 36);
            this.txt_toplamIyilesen.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(44, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 19);
            this.label7.TabIndex = 48;
            this.label7.Text = "TOPLAM İYİLEŞEN";
            // 
            // txt_toplamEntube
            // 
            this.txt_toplamEntube.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_toplamEntube.Location = new System.Drawing.Point(225, 322);
            this.txt_toplamEntube.Name = "txt_toplamEntube";
            this.txt_toplamEntube.ReadOnly = true;
            this.txt_toplamEntube.Size = new System.Drawing.Size(128, 36);
            this.txt_toplamEntube.TabIndex = 47;
            // 
            // txt_toplamYogun
            // 
            this.txt_toplamYogun.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_toplamYogun.Location = new System.Drawing.Point(225, 266);
            this.txt_toplamYogun.Name = "txt_toplamYogun";
            this.txt_toplamYogun.ReadOnly = true;
            this.txt_toplamYogun.Size = new System.Drawing.Size(128, 36);
            this.txt_toplamYogun.TabIndex = 46;
            // 
            // txt_toplamOlu
            // 
            this.txt_toplamOlu.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_toplamOlu.Location = new System.Drawing.Point(225, 213);
            this.txt_toplamOlu.Name = "txt_toplamOlu";
            this.txt_toplamOlu.ReadOnly = true;
            this.txt_toplamOlu.Size = new System.Drawing.Size(128, 36);
            this.txt_toplamOlu.TabIndex = 45;
            // 
            // txt_toplamVaka
            // 
            this.txt_toplamVaka.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_toplamVaka.Location = new System.Drawing.Point(225, 161);
            this.txt_toplamVaka.Name = "txt_toplamVaka";
            this.txt_toplamVaka.ReadOnly = true;
            this.txt_toplamVaka.Size = new System.Drawing.Size(128, 36);
            this.txt_toplamVaka.TabIndex = 44;
            // 
            // txt_toplamTest
            // 
            this.txt_toplamTest.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_toplamTest.Location = new System.Drawing.Point(225, 111);
            this.txt_toplamTest.Name = "txt_toplamTest";
            this.txt_toplamTest.ReadOnly = true;
            this.txt_toplamTest.Size = new System.Drawing.Size(128, 36);
            this.txt_toplamTest.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(44, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 19);
            this.label6.TabIndex = 42;
            this.label6.Text = "TOPLAM  ENTUBE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "TOPLAM  YOĞUN  BAKIM ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "TOPLAM VEFAT SAYISI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "TOPLAM VAKA SAYISI ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "TOPLAM TEST SAYISI ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 37);
            this.label1.TabIndex = 37;
            this.label1.Text = "TÜRKİYE GÜNLÜK KORONAVİRÜS TABLOSU";
            // 
            // btn_dosyayayaz
            // 
            this.btn_dosyayayaz.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dosyayayaz.Location = new System.Drawing.Point(826, 12);
            this.btn_dosyayayaz.Name = "btn_dosyayayaz";
            this.btn_dosyayayaz.Size = new System.Drawing.Size(113, 70);
            this.btn_dosyayayaz.TabIndex = 71;
            this.btn_dosyayayaz.Text = "TXT OLARAK KAYDET";
            this.btn_dosyayayaz.UseVisualStyleBackColor = true;
            this.btn_dosyayayaz.Click += new System.EventHandler(this.btn_dosyayayaz_Click);
            // 
            // FrmCovid19Bildirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(951, 449);
            this.Controls.Add(this.btn_dosyayayaz);
            this.Controls.Add(this.labelTarih);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_bugunIyilesen);
            this.Controls.Add(this.txt_bugunVefat);
            this.Controls.Add(this.txt_bugunVaka);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_bugunTest);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_toplamIyilesen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_toplamEntube);
            this.Controls.Add(this.txt_toplamYogun);
            this.Controls.Add(this.txt_toplamOlu);
            this.Controls.Add(this.txt_toplamVaka);
            this.Controls.Add(this.txt_toplamTest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCovid19Bildirim";
            this.Text = "Covid 19 Bildirim";
            this.Load += new System.EventHandler(this.FrmCovid19Bildirim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_bugunIyilesen;
        private System.Windows.Forms.TextBox txt_bugunVefat;
        private System.Windows.Forms.TextBox txt_bugunVaka;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_bugunTest;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_toplamIyilesen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_toplamEntube;
        private System.Windows.Forms.TextBox txt_toplamYogun;
        private System.Windows.Forms.TextBox txt_toplamOlu;
        private System.Windows.Forms.TextBox txt_toplamVaka;
        private System.Windows.Forms.TextBox txt_toplamTest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dosyayayaz;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

