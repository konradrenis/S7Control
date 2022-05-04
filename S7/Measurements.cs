using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S7
{
    public partial class Measurements : UserControl
    {
        int numberOfAdresses = 4;
        Adress[] adresses = new Adress[4];
        string adressTime = "&from=now-1h&to=now";

        public Measurements()
        {
            InitializeComponent();
        }

        private void Measurements_Load(object sender, EventArgs e)
        {
            //Initialize charts
            for (int i = 0; i < numberOfAdresses; i++)
            {
                adresses[i] = new Adress();
            }
            //http://192.168.3.3:3000/d/feddXckgk/tasmociag?orgId=1&from=1638674034655&to=1638701668678&viewPanel=2&refresh=5s&kiosk=tv

            adresses[0].SetAdress("http://192.168.3.3:3000/d/feddXckgk/tasmociag?orgId=1", "&from=now-1h&to=now", "&refresh=10s", "&viewPanel=2");
            wv1.Source = adresses[0].ConnectAdress();

            adresses[1].SetAdress("http://192.168.3.3:3000/d/feddXckgk/tasmociag?orgId=1", "&from=now-1h&to=now", "&refresh=10s", "&viewPanel=4");
            wv2.Source = adresses[1].ConnectAdress();

            adresses[2].SetAdress("http://192.168.3.3:3000/d/feddXckgk/tasmociag?orgId=1", "&from=now-1h&to=now", "&refresh=10s", "&viewPanel=11");
            wv3.Source = adresses[2].ConnectAdress();

            adresses[3].SetAdress("http://192.168.3.3:3000/d/feddXckgk/tasmociag?orgId=1", "&from=now-1h&to=now", "&refresh=10s", "&viewPanel=12");
            wv4.Source = adresses[3].ConnectAdress();

            //comboBox Initialize
            comboBox.Items.Add("Miesiąc");
            comboBox.Items.Add("Tydzień");
            comboBox.Items.Add("Dzień");
            comboBox.SelectedIndex = 0;

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (comboBox.SelectedIndex){
                case 0:
                    adressTime = "&from=now-1M&to=now";
                    break;
                case 1:
                    adressTime = "&from=now-1w&to=now";
                    break;
                case 2:
                    adressTime = "&from=now-24h&to=now";
                    break;
                case 3:
                    adressTime = "&from=now-1h&to=now";
                    break;
            
            }

            for (int i = 0; i < numberOfAdresses; i++)
            {
                adresses[i].UpdateAdressTime(adressTime);
            }
            wv1.Source = adresses[0].ConnectAdress();
            wv2.Source = adresses[1].ConnectAdress();
            wv3.Source = adresses[2].ConnectAdress();
            wv4.Source = adresses[3].ConnectAdress();
            
        }

       
    }
}
