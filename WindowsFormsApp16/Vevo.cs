using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp16
{
    class Vevo
    {
        int vazon;
        string vnev;
        string vcim;

        public int Vazon { get => vazon; set => vazon = value; }
        public string Vnev { get => vnev; set => vnev = value; }
        public string Vcim { get => vcim; set => vcim = value; }

        public Vevo(int vazon, string vnev, string vcim)
        {
            Vazon = vazon;
            Vnev = vnev;
            Vcim = vcim;
        }

        public override string ToString()
        {
            return this.vnev;
        }
    }
}
