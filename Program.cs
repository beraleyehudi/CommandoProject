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

            int currentNumber;
            int i = 0;
            while(i < str.Length)
            { 
            
                bool equl = true;

                currentNumber = int.Parse(str[i].ToString());

                if (currentNumber < str.Length - i)
                {
                    for (int j = 1; j < currentNumber; j++)
                    {
                        

                        if (!(str[i + j] == str[i]))
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
                i++;
            }
            return false;
        }

        public bool Selution1(string str)
        {
            int counter = 0;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] != str[i])
                {
                    if (counter == int.Parse(str[i - 1].ToString()))
                    {
                        Console.WriteLine(counter);
                        return true;
                    }
                    counter = 0;

                }
                counter++;
            }
            Console.WriteLine(counter);
            return false;
        }

        public bool Selution2(string str)
        {
            int timer = int.Parse(str[0].ToString());
            for (int i = 0; i < str.Length - 1; i++)
            {
                timer--;

                if (str[i] != str[i + 1])
                {

                    if (timer == 0)
                    {
                        Console.WriteLine(timer);
                        return true;
                    }
                    timer = int.Parse(str[i].ToString());

                }



            }
            Console.WriteLine(timer);
            return false;
        }

        public bool Selution3(string str)
        {
            string target = str[0].ToString();
            for (int i = 1; i < str.Length; i++)
            {
                Console.WriteLine(target);
                if (str[i] != target[target.Length - 1])
                {
                    if (target.Length == int.Parse(str[i - 1].ToString()))
                    {
                        Console.WriteLine(target);
                        return true;
                    }
                    target = str[i].ToString();
                    Console.WriteLine(target);




                }
                target += str[i];
                


            }
            if (target.Length == int.Parse(target[target.Length - 1].ToString()))
            {
                Console.WriteLine(target);
                return true;
            }
            Console.WriteLine(target);
            return false;

        }
        //Console.WriteLine(Selution("33454443322"));












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

            Console.WriteLine(new Program().Practice("2334"));
            Console.WriteLine();
            Console.WriteLine(new Program().Selution1("12334"));
            Console.WriteLine();
            Console.WriteLine(new Program().Selution2("2332"));
            Console.WriteLine();
            Console.WriteLine(new Program().Selution3("233"));
            Console.WriteLine("rerfewre");

            

            
            
        }

      





    }
}

