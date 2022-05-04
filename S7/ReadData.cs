using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7
{
    public class Data
    {
        //Pomiary analogowe
        public float varMeasurement1 { get; set; }
        public float varMeasurement2 { get; set; }
        public float varMeasurement3 { get; set; }
        public float varMeasurement4 { get; set; }

        //Pomiary analogowe sterowane
        public float varAnalog1 { get; set; }
        public float varAnalog2 { get; set; }
        public float varAnalog3 { get; set; }
        public float varAnalog4 { get; set; }

        //Stan silników
        public bool motorLeft { get; set; }
        public bool motorRight { get; set; }

        //Stan diód LED
        public bool led1 { get; set; }
        public bool led2 { get; set; }
        public bool led3 { get; set; }
        public bool led4 { get; set; }

        //Stan czujników
        public bool barrier { get; set; }
        public bool sensor1 { get; set; }
        public bool sensor2 { get; set; }

    }
}
