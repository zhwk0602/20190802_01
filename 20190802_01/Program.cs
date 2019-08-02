using System;
using ClassLibrary1;

namespace _20190802_01
{
    internal class Program
    {
        private static string Property { get; set; }//Property

        private static void Main(string[] args)
        {




            var a = MachineState.Poweroff;
            Dog d = new Dog();
            d.Run();
            d.Wigth();
            Cat c = new Cat();
            c.Run();
            c.Wigth();
            Bird b = new Bird();
           
            b.Run();
            b.Wigth();
            b.Fly();
            //Console.WriteLine("Hello World!");

            // var aa = new Class1();
            //Console.WriteLine(aa.AA());

            // Property = "aaa";
            //Console.WriteLine("This is Property" + Property);

            //靜態使用方法
            StaticClass.AA();
            var x = "hello".Append();
            Console.WriteLine(x);
            //轉型
            object s1 = "1234";
            string s2 = s1 as string;
            //轉型2
            string s3 = "2019-08-02";
            DateTime s4 = DateTime.Parse(s3);

            string s5 = "2019-08-02";
            DateTime s6;
            var isParse = DateTime.TryParse(s5.ToString(), out s6);

           // int n = 0;
           //do
           // {
           //    Console.WriteLine(n);
           //     n++;
          //  } while (n < 5);

            int n = 0;
            while (n < 5)
            {
                Console.WriteLine(n);
                n++;
            }
            var numbers = new int[] { 3, 14, 15, 92, 6 };
            foreach (int number in numbers)
            {
                //if (number == 92)
                //continue;
                //if (number == 6)
                //break;   
                Console.Write($"{number} ");
            }
            try
            {
                var s = int.Parse("aaaa");
            }
            catch (Exception)
            {

                throw;
            }





            }
        }
}