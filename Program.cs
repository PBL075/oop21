using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            Killer killer = new Killer("Killer", 1000, Type.Enemy);
            
            killer.PrintValues();
        }
    }
}

