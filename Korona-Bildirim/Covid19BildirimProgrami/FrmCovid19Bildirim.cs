using Microsoft.Office.Interop.Excel;
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

using Excel = Microsoft.Office.Interop.Excel;

namespace Covid19BildirimProgrami
{
    public partial class FrmCovid19Bildirim : Form
    {
        TcpClient client;
        NetworkStream ns;
        StreamReader sr;
        Thread th;

        private int sayac = 0;
        private int counter;

        public delegate void ricdegis(string text);

        public FrmCovid19Bildirim()
        {
            InitializeComponent();
        }

        private void FrmCovid19Bildirim_Load(object sender, EventArgs e)
        {
            client = new TcpClient("127.0.0.1", 500); // Başlatılan servere bağlanma
            th = new Thread(new ThreadStart(listenServer));
            th.Start(); ;
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
                {                                                             // 7 ye bölümünden kalan 0 ise gir ( 7 ve 6 yapmamızın sebebi ilk
                                                                              // veriyi aldıgımızda counter 6 oluyor daha sonra hep 7.
                    counter = 0;

                    // Tarihi yazdır.
                    CoronaData.GetInstance().Tarih = listBox1.Items[sayac - 1].ToString();
                    labelTarih.Text = CoronaData.GetInstance().Tarih;

                    // Günlük verileri alakalı değişkenlerin değerlerine ata.
                    CoronaData.GetInstance().BugunTest = Convert.ToInt32(listBox1.Items[sayac - 7]);
                    CoronaData.GetInstance().BugunVaka = Convert.ToInt32(listBox1.Items[sayac - 6]);
                    CoronaData.GetInstance().BugunOlu = Convert.ToInt32(listBox1.Items[sayac - 5]);
                    CoronaData.GetInstance().BugunYogunBakim = Convert.ToInt32(listBox1.Items[sayac - 4]);
                    CoronaData.GetInstance().BugunEntube = Convert.ToInt32(listBox1.Items[sayac - 3]);
                    CoronaData.GetInstance().BugunIyilesen = Convert.ToInt32(listBox1.Items[sayac - 2]);

                    // Günlük veriyi textboxlara yazdır.

                    txt_bugunTest.Text = CoronaData.GetInstance().BugunTest.ToString();
                    txt_bugunVaka.Text = CoronaData.GetInstance().BugunVaka.ToString();
                    txt_bugunVefat.Text = CoronaData.GetInstance().BugunOlu.ToString();
                    txt_bugunIyilesen.Text = CoronaData.GetInstance().BugunIyilesen.ToString();

                    // Toplam veriyi textboxlara yazdır
                    txt_toplamTest.Text = CoronaData.GetInstance().ToplamTest.ToString();
                    txt_toplamVaka.Text = CoronaData.GetInstance().ToplamVaka.ToString();
                    txt_toplamOlu.Text = CoronaData.GetInstance().ToplamOlu.ToString();
                    txt_toplamIyilesen.Text = CoronaData.GetInstance().ToplamIyilesen.ToString();
                    txt_toplamEntube.Text = CoronaData.GetInstance().ToplamEntube.ToString();
                    txt_toplamYogun.Text = CoronaData.GetInstance().ToplamYogunBakim.ToString();
                }
            }
        }

        private void btn_dosyayayaz_Click(object sender, EventArgs e)
        {
            string metin = CoronaData.GetInstance().Tarih + " Tarihindeki Güncel Koronavirüs Bilgileri\n   ---  ---  ---  ---  ---  ---  ---  ---  ---\n"
                + "Bugünkü Test Sayısı : " + CoronaData.GetInstance().BugunTest.ToString()
                + "\nBugünkü Vaka Sayısı : " + CoronaData.GetInstance().BugunVaka.ToString()
                + "\nBugünkü Vefat Sayısı : " + CoronaData.GetInstance().BugunOlu.ToString()
                + "\nBugünkü İyileşen Sayısı : " + CoronaData.GetInstance().BugunIyilesen.ToString()
                + "\n   ---  ---  ---  ---  ---  ---  ---  ---  ---"
                + "\nToplam Test Sayısı : " + CoronaData.GetInstance().ToplamTest.ToString()
                + "\nToplam Vaka Sayısı : " + CoronaData.GetInstance().ToplamVaka.ToString()
                + "\nToplam Vefat Sayısı : " + CoronaData.GetInstance().ToplamOlu.ToString()
                + "\nToplam Yoğun Bakım Sayısı : " + CoronaData.GetInstance().ToplamYogunBakim.ToString()
                + "\nToplam Entube Sayısı : " + CoronaData.GetInstance().ToplamEntube.ToString()
                + "\nToplam İyileşen Sayısı : " + CoronaData.GetInstance().ToplamIyilesen.ToString();

            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.FileName = "Koronavirüs Genel Bilgiler";
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
