using System;
using System.Threading;
using System.Threading.Tasks;
using Vibrant.InfluxDB;
using Vibrant.InfluxDB.Client;
using S7.Net;

namespace DataCollector
{
    public class Program
    {
        public static bool dataSend = true;
        public struct ReadStructure
        {
            //Pomiary analogowe
            public float varMeasurement1;
            public float varMeasurement2;
            public float varMeasurement3;
            public float varMeasurement4;

            //Pomiary analogowe sterowane
            public float varAnalog1;
            public float varAnalog2;
            public float varAnalog3;
            public float varAnalog4;

            //Reserved
            public bool v1;
            public bool v2;
            public bool v3;
            public bool v4;
            public bool v5;
            public bool v6;
            public bool v7;
            public bool v8;
            public bool v9;
            public bool v10;
            public bool v11;
            public bool v12;
            public bool v13;
            public bool v14;
            public bool v15;
            public bool v16;


        }
        public static ReadStructure readStructure;

        public static Plc plc = new Plc(CpuType.S71200, "192.168.3.1", 0, 1);

        static void Main(string[] args) => MainAsync(args).GetAwaiter().GetResult();

        static async Task MainAsync(string[] args)
        {
            const string influxHost = "http://127.0.0.1:8086";
            const string databaseName = "S7Database";

            var client = new InfluxClient(new Uri(influxHost));

            while(true)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Pobieranie danych...");
                GetDataFromPlc();
                Thread.Sleep(200);

                if (!dataSend)
                {
                    try
                    {
                        Console.WriteLine("Wysyłanie danych...");
                        await SendToInfluxDB(databaseName, client);
                        Thread.Sleep(1800);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }

        public static async Task SendToInfluxDB(string db, InfluxClient client)
        {
            try
            {
                string mesurementName = "s7measurement";
                DateTime timestamp = DateTime.Now;
                var data = CreateDataStructure(timestamp);
                Console.WriteLine("Stworzono zestaw danych");
                await client.WriteAsync(db, mesurementName, data);
                dataSend = true;
                Console.WriteLine("Dane zostały przesłane do InfluxDB");
                Console.WriteLine(" ");
            }
            catch (Exception e)
            {
                Console.WriteLine("Nie udalo sie przeslac danych do InfluxDB, powod:");
                Console.WriteLine(e.Message);
                Console.WriteLine(" ");
            }
        }

        private static DataStructure[] CreateDataStructure(DateTime start)
        {
            var dataStructure = new DataStructure[1];

            var data = new DataStructure {
                Timestamp = start,
                Plc = "1",

                VarMeasurement1 = readStructure.varMeasurement1,
                VarMeasurement2 = readStructure.varMeasurement2,
                VarMeasurement3 = readStructure.varMeasurement3,
                VarMeasurement4 = readStructure.varMeasurement4,

                VarAnalog1 = readStructure.varAnalog1,
                VarAnalog2 = readStructure.varAnalog2,
                VarAnalog3 = readStructure.varAnalog3,
                VarAnalog4 = readStructure.varAnalog4,
            };
            dataStructure[0] = data;
            return dataStructure;
        }
        private static void GetDataFromPlc()
        {
            try
            {
                plc.Open();
                Thread.Sleep(1);
                if (plc.IsConnected)
                {
                    readStructure = 
                        (ReadStructure)plc.ReadStruct(typeof(ReadStructure), 1, 0);
                    dataSend = false;
                    Console.WriteLine("Dane zostały pobrane ze sterownika");
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("Nie udało sie pobrać danych ze sterownika, powód:");
                    Console.WriteLine("Brak połączenia ze sterownikiem");
                    Console.WriteLine(" ");
                }
                Thread.Sleep(1);
                plc.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Nie udało sie pobrać danych ze sterownika, powód:");
                Console.WriteLine(e.Message);
                Console.WriteLine(" ");
            }
        }

    }
}
