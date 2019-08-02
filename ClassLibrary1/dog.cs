using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Dog:Animal
    {
        public override void Wigth()
        {
            Console.WriteLine("Dog wigth =40");

            
        }
        public Dog()//建構子
        {
            Name = "狗";
            Console.WriteLine(Name);
        }
    }
}
