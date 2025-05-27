using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon gan = new Weapon("Uzi", "israel");
            //Commando commando = new Commando("shaldag", "012");

            //Console.WriteLine(gan.Name + "\n" + gan.Manufacturer + "\n" + gan.Bullets);
            //Console.WriteLine(commando.Name + "\n" + commando.CodeName + "\n" + commando.Status);
            //commando.Walk();
            //Console.WriteLine(commando.Name + "\n" + commando.CodeName + "\n" + commando.Status);
            //gan.Shoot();
            //Console.WriteLine(gan.Name + "\n" + gan.Manufacturer + "\n" + gan.Bullets);

            AirCommando airCommando = new AirCommando("shaldag", "1234");
            SeaCommando seaCommando = new SeaCommando("shaytet 13", "321");

            Commando[] commandos = { airCommando, seaCommando };
            foreach (Commando commando in commandos)
            {
                commando.Attack();

            }

            

        }
    }
}
