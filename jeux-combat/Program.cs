using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeux_combat
{
  
    class Program
    {
        static void Main(string[] args)
        {
           Guerrier guerrier1 = new Guerrier("soldat", 10, 40, 30, 100);
           Guerrier guerrier2 = new Guerrier("personne", 50, 50, 10, 100);
            guerrier1.LancerAttaqueAvecDefense(guerrier2);
            guerrier1.Affichage();
            guerrier2.Affichage();
            guerrier1.ActiveSoin();
            guerrier1.Affichage();
            Console.WriteLine(guerrier1.Mana);
            Console.ReadKey();
        }
        
    }
}
