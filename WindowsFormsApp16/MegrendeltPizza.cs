using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp16
{
    class MegrendeltPizza
    {
        int vazon;
        int pazon;
        string pnev;
        decimal db;

        public int Vazon { get => vazon; set => vazon = value; }
        public int Pazon { get => pazon; set => pazon = value; }
        public string Pnev { get => pnev; set => pnev = value; }
        public decimal Db { get => db; set => db = value; }

        public MegrendeltPizza(int vazon, int pazon, string pnev, decimal db)
        {
            Vazon = vazon;
            Pazon = pazon;
            Pnev = pnev;
            Db = db;
        }

        public override string ToString()
        {
            return this.Pnev + " (" + this.db + " db)";
        }
    }
}
