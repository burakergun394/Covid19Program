namespace Covid19GrafikProgrami
{
    partial class FrmCoronaGrafik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_dosyayayaz = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(48, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 19);
            this.label10.TabIndex = 86;
            this.label10.Text = "HASTA SAYISI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(42, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 19);
            this.label9.TabIndex = 85;
            this.label9.Text = "HASTA SAYISI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(42, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 19);
            this.label8.TabIndex = 84;
            this.label8.Text = "HASTA SAYISI";
            // 
            // txt_toplamIyilesen
            // 
            this.txt_toplamIyilesen.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_toplamIyilesen.Location = new System.Drawing.Point(212, 380);
            this.txt_toplamIyilesen.Name = "txt_toplamIyilesen";
            this.txt_toplamIyilesen.ReadOnly = true;
            this.txt_toplamIyilesen.Size = new System.Drawing.Size(128, 36);
            this.txt_toplamIyilesen.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(31, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 19);
            this.label7.TabIndex = 82;
            this.label7.Text = "TOPLAM İYİLEŞEN";
            // 
            // txt_toplamEntube
            // 
            this.txt_toplamEntube.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_toplamEntube.Location = new System.Drawing.Point(212, 311);
            this.txt_toplamEntube.Name = "txt_toplamEntube";
            this.txt_toplamEntube.ReadOnly = true;
            this.txt_toplamEntube.Size = new System.Drawing.Size(128, 36);
            this.txt_toplamEntube.TabIndex = 81;
            // 
            // txt_toplamYogun
            // 
            this.txt_toplamYogun.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_toplamYogun.Location = new System.Drawing.Point(212, 255);
            this.txt_toplamYogun.Name = "txt_toplamYogun";
            this.txt_toplamYogun.ReadOnly = true;
            this.txt_toplamYogun.Size = new System.Drawing.Size(128, 36);
            this.txt_toplamYogun.TabIndex = 80;
            // 
            // txt_toplamOlu
            // 
            this.txt_toplamOlu.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_toplamOlu.Location = new System.Drawing.Point(212, 202);
            this.txt_toplamOlu.Name = "txt_toplamOlu";
            this.txt_toplamOlu.ReadOnly = true;
            this.txt_toplamOlu.Size = new System.Drawing.Size(128, 36);
            this.txt_toplamOlu.TabIndex = 79;
            // 
            // txt_toplamVaka
            // 
            this.txt_toplamVaka.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_toplamVaka.Location = new System.Drawing.Point(212, 150);
            this.txt_toplamVaka.Name = "txt_toplamVaka";
            this.txt_toplamVaka.ReadOnly = true;
            this.txt_toplamVaka.Size = new System.Drawing.Size(128, 36);
            this.txt_toplamVaka.TabIndex = 78;
            // 
            // txt_toplamTest
            // 
            this.txt_toplamTest.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_toplamTest.Location = new System.Drawing.Point(212, 100);
            this.txt_toplamTest.Name = "txt_toplamTest";
            this.txt_toplamTest.ReadOnly = true;
            this.txt_toplamTest.Size = new System.Drawing.Size(128, 36);
            this.txt_toplamTest.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(31, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 19);
            this.label6.TabIndex = 76;
            this.label6.Text = "TOPLAM  ENTUBE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 19);
            this.label5.TabIndex = 75;
            this.label5.Text = "TOPLAM  YOĞUN  BAKIM ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 19);
            this.label4.TabIndex = 74;
            this.label4.Text = "TOPLAM VEFAT SAYISI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 19);
            this.label3.TabIndex = 73;
            this.label3.Text = "TOPLAM VAKA SAYISI ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 19);
            this.label2.TabIndex = 72;
            this.label2.Text = "TOPLAM TEST SAYISI ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 37);
            this.label1.TabIndex = 71;
            this.label1.Text = "TÜRKİYE GÜNLÜK KORONAVİRÜS TABLOSU";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-2, 323);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 88;
            this.listBox1.Visible = false;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Aqua;
            this.chart1.BorderlineColor = System.Drawing.Color.Aqua;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(346, 67);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.EmptyPointStyle.Color = System.Drawing.Color.Blue;
            series1.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series1.Legend = "Legend1";
            series1.Name = "Vaka Sayısı";
            series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValuesPerPoint = 2;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series2.Legend = "Legend1";
            series2.Name = "Vefat Sayısı";
            series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(770, 437);
            this.chart1.TabIndex = 89;
            this.chart1.Text = "chart1";
            // 
            // btn_dosyayayaz
            // 
            this.btn_dosyayayaz.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dosyayayaz.Location = new System.Drawing.Point(980, 12);
            this.btn_dosyayayaz.Name = "btn_dosyayayaz";
            this.btn_dosyayayaz.Size = new System.Drawing.Size(128, 55);
            this.btn_dosyayayaz.TabIndex = 90;
            this.btn_dosyayayaz.Text = "TXT OLARAK KAYDET";
            this.btn_dosyayayaz.UseVisualStyleBackColor = true;
            this.btn_dosyayayaz.Click += new System.EventHandler(this.btn_dosyayayaz_Click_1);
            // 
            // FrmCoronaGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1120, 506);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_dosyayayaz);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_toplamIyilesen);
            this.Controls.Add(this.txt_toplamEntube);
            this.Controls.Add(this.txt_toplamYogun);
            this.Controls.Add(this.txt_toplamOlu);
            this.Controls.Add(this.txt_toplamVaka);
            this.Controls.Add(this.txt_toplamTest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCoronaGrafik";
            this.Text = "Corona Grafik";
            this.Load += new System.EventHandler(this.FrmCoronaGrafik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_dosyayayaz;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

