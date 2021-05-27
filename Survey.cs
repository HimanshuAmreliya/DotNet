using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey1
{
    class Data {
        public String name;
        public int age;
        public String month;

        public void Info() {
            Console.WriteLine("your name is - {0}", name);
            Console.WriteLine("your age is - {0}", age);
            Console.WriteLine("your birth month is - {0}", month);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();

            Console.WriteLine("what is your name ?");
            data.name = Console.ReadLine();
            Console.WriteLine("what is your age ?");
            data.age = int.Parse(Console.ReadLine());
            Console.WriteLine("what is your birth month ?");
            data.month = Console.ReadLine();

            data.Info();
        }
    }
}
