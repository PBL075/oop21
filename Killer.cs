using System;

namespace project
{
    class Killer
    {
        public string name;
        public int health;
        public Type type; 

        public Killer(string name, int health, Type type)
        {
            this.name = name;
            this.health = health;
            this.type = type;
        }

        public void PrintValues()
        {
            Console.WriteLine("Robotul " + name + " are " + health + " HP si rolul de " + type);
        }
    }
}