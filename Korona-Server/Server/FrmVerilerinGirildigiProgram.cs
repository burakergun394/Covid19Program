using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Globalization;

namespace Server
{
    public partial class FrmVerilerinGirildigiProgram : Form
    {
        AddBilgiler bilgi = new AddBilgiler();
        
        public FrmVerilerinGirildigiProgram()
        {
            InitializeComponent();    
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            CoronaData data = new CoronaData();
            data.AddObserver(bilgi);
            data.NotifyObserver();          
        }

        private void FrmVerilerinGirildigiProgram_Load(object sender, EventArgs e)
        {
            bilgi.serveriBaslat();

            MessageBox.Show(DateTime.Now.ToString() + " server başlatıldı.");
        }
    }
}
