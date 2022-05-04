using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7
{
    public class OnOff
    {
        public OnOff(ref bool _varBool, string _adressOn, string _adressOff)
        {
            adressOn = _adressOn;
            adressOff = _adressOff;
            varBool = _varBool;
        }

        public string adressOn;
        public string adressOff;
        public bool varBool;
    }
}
