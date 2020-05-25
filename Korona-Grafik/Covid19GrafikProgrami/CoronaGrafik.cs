using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19GrafikProgrami
{
    class CoronaGrafik
    {
        private int bugunTest = 0;
        private int toplamTest = 0;

        private int bugunVaka = 0;
        private int toplamVaka = 0;

        private int bugunOlu = 0;
        private int toplamOlu = 0;

        private int bugunYogunBakim = 0;
        private int toplamYogunBakim = 0;

        private int bugunEntube = 0;
        private int toplamEntube = 0;

        private int bugunIyilesen = 0;
        private int toplamIyilesen = 0;

        private String tarih;

        private static CoronaGrafik _instance;

        private CoronaGrafik() { }

        public static CoronaGrafik GetInstance()
        {
            if (_instance == null) _instance = new CoronaGrafik();
            return _instance;
        }

        public int BugunTest { get { return bugunTest; } set { bugunTest = value; toplamTest += bugunTest; } }

        public int ToplamTest { get { return toplamTest; } }

        public int BugunVaka { get { return bugunVaka; } set { bugunVaka = value; toplamVaka += bugunVaka; } }

        public int ToplamVaka { get { return toplamVaka; } }

        public int BugunOlu { get { return bugunOlu; } set { bugunOlu = value; toplamOlu += bugunOlu; } }

        public int ToplamOlu { get { return toplamOlu; } }

        public int BugunIyilesen { get { return bugunIyilesen; } set { bugunIyilesen = value; toplamIyilesen += bugunIyilesen; } }

        public int ToplamIyilesen { get { return toplamIyilesen; } }

        public int BugunEntube { get { return bugunEntube; } set { bugunEntube = value; toplamEntube += bugunEntube; } }

        public int ToplamEntube { get { return toplamEntube; } }

        public int BugunYogunBakim { get { return bugunYogunBakim; } set { bugunYogunBakim = value; toplamYogunBakim += bugunYogunBakim; } }

        public int ToplamYogunBakim { get { return toplamYogunBakim; } }

        public string Tarih { get { return tarih; } set { tarih = value; } }
    }
}
