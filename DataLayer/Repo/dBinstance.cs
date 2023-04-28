using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repo
{
    internal class dBinstance
    {
        internal dBCC db;

        internal dBinstance()
        {
            db = new dBCC();
        }
    }
}
