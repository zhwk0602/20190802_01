using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Bird:Animal
    {
        public override void Wigth()
        {
            Console.WriteLine("Bird wigth =10");

            
        }
        public void Fly()
        {
            Console.WriteLine("會飛");
            
        }
        public Bird()//建構子
        {
            base.Name = "鳥";
            Console.WriteLine(Name);
        }
    }

}
