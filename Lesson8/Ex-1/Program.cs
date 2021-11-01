using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    //Бессмертнова
    //Задание1. С помощью рефлексии выведите все свойства структуры DateTime.
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(DateTime);
            PropertyInfo[] propertiesDateTime = type.GetProperties();
            Console.WriteLine("Свойства структуры DateTime:");
            foreach (var property in propertiesDateTime)
            {
                Console.WriteLine($"{property.Name}");
            }
            Console.ReadKey();
        }
    }
}
