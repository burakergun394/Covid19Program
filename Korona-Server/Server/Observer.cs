using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    interface Observer
    {
        void update(int bugunTest, int bugunVaka, int bugunOlu, int bugunYogunBakim, int bugunEntube, int bugunIyilesen, String tarih);
    }
}
