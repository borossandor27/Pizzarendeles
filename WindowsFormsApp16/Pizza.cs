using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp16
{
    class Pizza
    {
        int pazon;
        string pnev;
        int par;

        public int Pazon { get => pazon; set => pazon = value; }
        public string Pnev { get => pnev; set => pnev = value; }
        public int Par { get => par; set => par = value; }

        public Pizza(int pazon, string pnev, int par)
        {
            Pazon = pazon;
            Pnev = pnev;
            Par = par;
        }

        public override string ToString()
        {
            return this.pnev;
        }
    }
}
