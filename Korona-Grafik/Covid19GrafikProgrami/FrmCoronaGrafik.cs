using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Covid19GrafikProgrami
{
    public partial class FrmCoronaGrafik : Form
    {
        TcpClient client;
        NetworkStream ns;
        StreamReader sr;
        Thread th;

        private int sayac = 0;
        private int counter;
        private int grafikSayac = 1;

        public delegate void ricdegis(string text);
        public FrmCoronaGrafik()
        {
            InitializeComponent();
            
        }

        private void FrmCoronaGrafik_Load(object sender, EventArgs e)
        {
            client = new TcpClient("127.0.0.1", 500); // Başlatılan servere bağlanma
            th = new Thread(new ThreadStart(listenServer));
            th.Start(); ;
            chart1.Series["Vaka Sayısı"].Points.AddXY("4 MAYIS", CoronaGrafik.GetInstance().ToplamVaka);
            chart1.Series["Vefat Sayısı"].Points.AddXY("4 MAYIS", CoronaGrafik.GetInstance().ToplamOlu);

        }

        private void listenServer()
        {
            ns = client.GetStream();
            sr = new StreamReader(ns);

            while (true)
            {
                try
                {
                    string yazi = sr.ReadLine();
                    ekranabas(yazi);

                }
                catch
                {
                    return;
                }
            }
        }

        private void ekranabas(string yazi)
        {
            if (this.InvokeRequired)
            {
                ricdegis degis = new ricdegis(ekranabas);
                this.Invoke(degis, yazi);
                counter++;
            }
            else
            {
                listBox1.Items.Add(yazi);
                sayac++;
                if (sayac % 7 == 0 && (counter % 6 == 0 || counter % 7 == 0)) // eğer ınvokerequired girerse counter ile saysın ve 6 ya 
                {                                                             // 7 ye bölümünden kalan 0 ise gir ( 7 ve 6 yapmamızın sebebi ilk                                                                      // veriyi aldıgımızda counter 6 oluyor daha sonra hep 7 ).
                    counter = 0;

                    // Tarihi yazdır.
                    CoronaGrafik.GetInstance().Tarih = listBox1.Items[sayac - 1].ToString().Substring(0, listBox1.Items[sayac - 1].ToString().Length - 4);

                    // Günlük verileri alakalı değişkenlerin değerlerine ata.
                    CoronaGrafik.GetInstance().BugunTest = Convert.ToInt32(listBox1.Items[sayac - 7]);
                    CoronaGrafik.GetInstance().BugunVaka = Convert.ToInt32(listBox1.Items[sayac - 6]);
                    CoronaGrafik.GetInstance().BugunOlu = Convert.ToInt32(listBox1.Items[sayac - 5]);
                    CoronaGrafik.GetInstance().BugunYogunBakim = Convert.ToInt32(listBox1.Items[sayac - 4]);
                    CoronaGrafik.GetInstance().BugunEntube = Convert.ToInt32(listBox1.Items[sayac - 3]);
                    CoronaGrafik.GetInstance().BugunIyilesen = Convert.ToInt32(listBox1.Items[sayac - 2]);


                    // Günlük veriyi grafige yazdır.              

                    chart1.Series["Vaka Sayısı"].Points.AddXY(CoronaGrafik.GetInstance().Tarih, CoronaGrafik.GetInstance().ToplamVaka);
                    chart1.Series["Vefat Sayısı"].Points.AddXY(CoronaGrafik.GetInstance().Tarih, CoronaGrafik.GetInstance().ToplamOlu);

                    chart1.Series["Vaka Sayısı"].IsValueShownAsLabel = true;
                    chart1.Series["Vefat Sayısı"].IsValueShownAsLabel = true;


                    chart1.ChartAreas[0].AxisX.Maximum = grafikSayac;
                   

                    // Toplam veriyi textboxlara yazdır
                    txt_toplamTest.Text = CoronaGrafik.GetInstance().ToplamTest.ToString();
                    txt_toplamVaka.Text = CoronaGrafik.GetInstance().ToplamVaka.ToString();
                    txt_toplamOlu.Text = CoronaGrafik.GetInstance().ToplamOlu.ToString();
                    txt_toplamIyilesen.Text = CoronaGrafik.GetInstance().ToplamIyilesen.ToString();
                    txt_toplamEntube.Text = CoronaGrafik.GetInstance().ToplamEntube.ToString();
                    txt_toplamYogun.Text = CoronaGrafik.GetInstance().ToplamYogunBakim.ToString();

                    grafikSayac++;
                }
            }
        }

        private void btn_dosyayayaz_Click_1(object sender, EventArgs e)
        {
            string metin = CoronaGrafik.GetInstance().Tarih + " Tarihindeki Güncel Koronavirüs Bilgileri\n   ---  ---  ---  ---  ---  ---  ---  ---  ---\n"
                + "\nToplam Test Sayısı : " + CoronaGrafik.GetInstance().ToplamTest
                + "\nToplam Vaka Sayısı : " + CoronaGrafik.GetInstance().ToplamVaka
                + "\nToplam Vefat Sayısı : " + CoronaGrafik.GetInstance().ToplamOlu
                + "\nToplam Yoğun Bakım Sayısı : " + CoronaGrafik.GetInstance().ToplamYogunBakim
                + "\nToplam Entube Sayısı : " + CoronaGrafik.GetInstance().ToplamEntube
                + "\nToplam İyileşen Sayısı : " + CoronaGrafik.GetInstance().ToplamIyilesen;

            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.FileName = "Koronavirüs Grafik Bilgileri";
            saveFileDialog1.Filter = "txt Dosyaları (*.txt)|*.txt|Tüm Dosyalar(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Kayit = new StreamWriter(saveFileDialog1.FileName);
                Kayit.WriteLine(metin);
                Kayit.Close();
            }
        }
    }
}
