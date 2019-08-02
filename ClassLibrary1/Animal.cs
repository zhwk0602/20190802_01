using System;

namespace ClassLibrary1
{
    public abstract class Animal:IBiological
    {
        public string Name { get; set; }//屬性property
      
        public void Run()
        {
            Console.WriteLine("會跑");
        }
        public abstract void Wigth();
        
    }

}
    
      
