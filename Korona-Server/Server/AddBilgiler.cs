using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Server
{
    class AddBilgiler : Observer, Display
    {
        private int bugunTest;
        private int bugunVaka;
        private int bugunOlu;
        private int bugunYogunBakim;
        private int bugunEntube;
        private int bugunIyilesen;
        private String tarih = null;
             
        TcpListener server;
        Socket socket;
        Thread th;
        Thread th2;
        NetworkStream ns;
        StreamWriter sw;
        StreamWriter sw2;
        public void Display()
        {
            try
            { 
                sw.WriteLine(bugunTest);
                sw.WriteLine(bugunVaka);
                sw.WriteLine(bugunOlu);
                sw.WriteLine(bugunYogunBakim);
                sw.WriteLine(bugunEntube);
                sw.WriteLine(bugunIyilesen);
                sw.WriteLine(tarih);
                sw.Flush();
                sw2.WriteLine(bugunTest);
                sw2.WriteLine(bugunVaka);
                sw2.WriteLine(bugunOlu);
                sw2.WriteLine(bugunYogunBakim);
                sw2.WriteLine(bugunEntube);
                sw2.WriteLine(bugunIyilesen);
                sw2.WriteLine(tarih);
                sw2.Flush();
            }
            catch
            {
                return;
            }
        }

        public void update(int bugunTest, int bugunVaka, int bugunOlu, int bugunYogunBakim, int bugunEntube, int bugunIyilesen, string tarih)
        {
            this.bugunTest = bugunTest;
            this.bugunVaka = bugunVaka;
            this.bugunOlu = bugunOlu;
            this.bugunYogunBakim = bugunYogunBakim;
            this.bugunEntube = bugunEntube;
            this.bugunIyilesen = bugunIyilesen;
            this.tarih = tarih;
            Display();
        }

        public void serveriBaslat()
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), 500); // localhost baslatma
            server.Start();
            int i = 0;
            if (i == 0) // iki tane client başlatabilmek için kontrol işlemi yaptım
            {
                th = new Thread(new ThreadStart(listenClient));
                th.Start();
                i++;
            }
            if (i == 1)
            {
                th2 = new Thread(new ThreadStart(listenClient2));
                th2.Start();
            }
        }

        private void listenClient2() 
        {
            socket = server.AcceptSocket();
            ns = new NetworkStream(socket);
            sw2 = new StreamWriter(ns); // onceki streamwriter nesnesi meşgul oldugundan yeni olusturdum
            MessageBox.Show(DateTime.Now.ToString() + " istemci bağlandı."); 
        }

        private void listenClient()
        {
            socket = server.AcceptSocket();
            ns = new NetworkStream(socket);
            sw = new StreamWriter(ns); 
            MessageBox.Show(DateTime.Now.ToString() + " istemci bağlandı.");
        }
    }
}
