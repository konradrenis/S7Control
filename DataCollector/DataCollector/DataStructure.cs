using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vibrant.InfluxDB;
using Vibrant.InfluxDB.Client;

namespace DataCollector
{
    public class DataStructure
    {
        [InfluxTimestamp]
        public DateTime Timestamp { get; set; }

        [InfluxTag("plc")]
        public string Plc { get; set; }

        [InfluxField("varMeasurement1")]
        public double VarMeasurement1 { get; set; }

        [InfluxField("varMeasurement2")]
        public double VarMeasurement2 { get; set; }

        [InfluxField("varMeasurement3")]
        public double VarMeasurement3 { get; set; }

        [InfluxField("varMeasurement4")]
        public double VarMeasurement4 { get; set; }

        [InfluxField("varAnalog1")]
        public double VarAnalog1 { get; set; }

        [InfluxField("varAnalog2")]
        public double VarAnalog2 { get; set; }

        [InfluxField("varAnalog3")]
        public double VarAnalog3 { get; set; }

        [InfluxField("varAnalog4")]
        public double VarAnalog4 { get; set; }

    }
}