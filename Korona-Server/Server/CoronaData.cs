using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Globalization;

namespace Server
{
    class CoronaData : Subject
    {
        private List<Observer> observers;

        public CoronaData() {
             observers = new List<Observer>();    
        }

        public void AddObserver(Observer o)
        {
            observers.Add(o);
        }

        public void DeleteObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void NotifyObserver()
        {
            int bugunTest = GetBugunTest();
            int bugunVaka = GetBugunVaka();
            int bugunOlu = GetBugunOlu();
            int bugunYogunBakim = GetBugunYogunBakim();
            int bugunEntube = GetBugunEntube();
            int bugunIyilesen = GetBugunIyilesen();
            String tarih = GetTarih();
            foreach (Observer o in observers)
            {
                o.update(bugunTest, bugunVaka, bugunOlu, bugunYogunBakim, bugunEntube, bugunIyilesen, tarih);
            }
        }

        public int GetBugunTest()
        {
            TextBox txt_bugunTest = Application.OpenForms["FrmVerilerinGirildigiProgram"].Controls["txt_bugunTest"] as TextBox;
            return Convert.ToInt32(txt_bugunTest.Text);
        }
        public int GetBugunVaka()
        {
            TextBox txt_bugunVaka = Application.OpenForms["FrmVerilerinGirildigiProgram"].Controls["txt_bugunVaka"] as TextBox;
            return Convert.ToInt32(txt_bugunVaka.Text);
        }
        public int GetBugunOlu()
        {
            TextBox txt_bugunVefat = Application.OpenForms["FrmVerilerinGirildigiProgram"].Controls["txt_bugunVefat"] as TextBox;
            return Convert.ToInt32(txt_bugunVefat.Text);
        }
        public int GetBugunYogunBakim()
        {
            TextBox txt_bugunYogun = Application.OpenForms["FrmVerilerinGirildigiProgram"].Controls["txt_bugunYogun"] as TextBox;
            return Convert.ToInt32(txt_bugunYogun.Text);
        }
       
        public int GetBugunEntube()
        {
            TextBox txt_bugunEntube = Application.OpenForms["FrmVerilerinGirildigiProgram"].Controls["txt_bugunEntube"] as TextBox;
            return Convert.ToInt32(txt_bugunEntube.Text);
        }

        public int GetBugunIyilesen()
        {
            TextBox txt_bugunIyilesen = Application.OpenForms["FrmVerilerinGirildigiProgram"].Controls["txt_bugunIyilesen"] as TextBox;
            return Convert.ToInt32(txt_bugunIyilesen.Text);
        }

        public String GetTarih()
        {
            DateTimePicker tarih = Application.OpenForms["FrmVerilerinGirildigiProgram"].Controls["dateTimePicker1"] as DateTimePicker;
            return tarih.Value.Day.ToString() + " " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(tarih.Value.Month).ToUpper().ToString() + " " + tarih.Value.Year.ToString();
        }
    }
}
