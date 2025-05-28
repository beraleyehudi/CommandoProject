using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoProject
{
    internal class Program
    {

        public bool Practice(string str)
        {

            int currentNumber = 0;

            for (int i = 0; i < str.Length; i++)
            {
                bool equl = true;
                
                currentNumber = int.Parse(str[i].ToString());

                if (currentNumber < str.Length)
                {
                    for (int j = 0; j < currentNumber; j++)
                    {
                        if (!(str[i] == str[i + 1+ j]))
                        {
                            equl = false;
                            break;
                        }
                    }
                    if (equl)
                    {
                        return true;
                    }
                }


            }
            return false;
        }




           


        


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

            Console.WriteLine(new Program().Practice("2345"));
        }

      





    }
}

