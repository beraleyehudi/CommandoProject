using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoProject
{
    public static class AccessPermissoins
    {
        public static class CommandoAccess
        {
            public static string NameAccess(string commandeRank, Commando commando)
            {
                switch (commandeRank)
                {
                    case "general":
                        return commando.Name;

                    case "colonel":
                        return commando.CodeName;

                    default:
                        return "the information is classified";
                }
            }
        }
    }
}
