using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoProject
{
    internal class Commando
    {
        public string Name;
        public string CodeName;
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
        }

        public void Hide()
        {
            Console.WriteLine("The solider hiding");
        }



    }
}
