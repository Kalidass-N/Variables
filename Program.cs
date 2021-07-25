using System;
using System.Collections;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Hello World";
            //int num = 10;
            //char c = 'S';
            //long l = 123456789;
            //float pi = 3.14f;


            //Console.WriteLine("VALUES are "+name+" " + num +" " +c + " "+ l +" " +pi);
            //Console.ReadLine();

            ArrayList list = new ArrayList();
            list.Add(100);
            list.Add(230);
            list.Add(200);

            foreach (var item in list) {
                Console.WriteLine(item);
            }

        }
    }
}
