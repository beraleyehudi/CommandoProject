using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoProject
{
    internal class Weapon
    {
        public string Name;
        public string Manufacturer;
        public int Bullets;

        public Weapon(string name, string manufacturer)
        {
            Name = name;
            Manufacturer = manufacturer;
        }

        public void Shoot()
        {
            Console.WriteLine("bummmm!!");
            this.Bullets--;
        }

    }
}
