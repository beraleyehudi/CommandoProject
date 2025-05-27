using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoProject
{
    internal class Commando
    {
        public string Name { get; set; }
        public string CodeName {  get; set; }
        public string[] Tools = { "Hammer", "Chisel", "Knife", "Rope", "Ladder" };
        public Enums.SoliderStatus Status;

        public Commando(string name, string codeName)
        {
            Name = name;
            CodeName = codeName;
        }

        public void Walk()
        {
            Console.WriteLine("The solider walking");
            this.Status = Enums.SoliderStatus.walk;
        }

        public void Hide()
        {
            Console.WriteLine("The solider hiding");
            this.Status = Enums.SoliderStatus.hide;
        }

        public void Attack()
        {
            Console.WriteLine("The solider is attacking");
        }
        public string SayName(string commandeRank)
        {
            switch(commandeRank)
            {
                case "general":
                    return this.Name;

                case "colonel":
                    return this.CodeName;

                default:
                    return "the information is classified";
            }
        }


        internal class AirCommando : Commando
        {
            public AirCommando(string name, string codeName) : base(name, codeName)
            {
            }

            public void Parachuting()
            {
                Console.WriteLine("The solider is parachuting");
            }

            public void Attack()
            {
                Console.WriteLine("The solider air commando is attacking");
            }
        }

        internal class SeaCommando : Commando
        {
            public SeaCommando(string name, string codeName) : base(name, codeName)
            {
            }


            public void Swimming()
            {
                Console.WriteLine("The solider is swimming");
            }

            public void Attack()
            {
                Console.WriteLine("The solider sea commando is attacking");
            }
        }





    }
}
