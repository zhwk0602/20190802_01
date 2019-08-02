using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Cat : Animal
    {
        public override void Wigth()
        {
            Console.WriteLine("Cat wigth =30");
           
           
        }
        public void climb()
        {
            Console.WriteLine("會爬牆");
        }
        public Cat()//建構子
        {
            Name = "貓";
            Console.WriteLine(Name);
        }






    }
}
