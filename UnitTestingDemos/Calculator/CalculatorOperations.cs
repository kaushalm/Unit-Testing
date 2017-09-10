using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;
using System.IO;

namespace Calculator
{
    public class CalculatorOperations

    {
        Stopwatch sw = new Stopwatch();
        List<data> _data = new List<data>();
        public int Add( int num1, int num2)
        {
            sw.Start();
            sw.Stop();
            var time = sw.ElapsedMilliseconds;
            //write to json

            _data.Add(new data()
            {
                name = "Sum",
                timeTaken = 2
            });
            string json = JsonConvert.SerializeObject(_data.ToArray());
            System.IO.File.WriteAllText(@"D:\path.txt", json);
            return num1 + num2;           
        }


        public int Multiply(int num1, int num2)
        {
            sw.Start();
            sw.Stop();
            var time = sw.ElapsedMilliseconds;
            _data.Add(new data()
            {
                name = "Multiply",
                timeTaken = 4
            });
            string json = JsonConvert.SerializeObject(_data.ToArray());
            System.IO.File.WriteAllText(@"D:\path.txt", json);
            return num1 * num2;           
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Running");
            CalculatorOperations cop = new CalculatorOperations();
            cop.Add(4,5);
            cop.Multiply(5, 4);
            cop.LoadJson();
        }


        public void LoadJson()
        {
            using (StreamReader r = new StreamReader("D://path.txt"))
            {
                string json = r.ReadToEnd();
                List<data> items = JsonConvert.DeserializeObject<List<data>>(json);
            }
        }

    }

    public class data
    {
        public string name { get; set; }
        public long timeTaken { get; set; }
    }
   

}
