using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7
{
    public class Adress
    {
        public Adress()
        {
            adressBase=" ";
            adressTime=" ";
            adressRefresh=" ";
            adressPanel = " ";
        
        }


        public string adressBase;
        public string adressTime;
        public string adressRefresh;
        private string adressEnd = "&kiosk";
        private string adressPanel;

        public string adress;
        
        public Uri ConnectAdress()
        {
            adress = String.Concat(adressBase, adressRefresh, adressPanel, adressTime, adressEnd);
            Uri uri = new Uri(adress);
            return uri;
        }

        public void SetAdress(string Base, string Time, string Refresh, string Panel)
        {
            adressBase = Base;
            adressTime = Time;
            adressRefresh = Refresh;
            adressPanel = Panel;
        }

        public void UpdateAdressTime(string Time)
        {
            adressTime = Time;
        }
    }
}
