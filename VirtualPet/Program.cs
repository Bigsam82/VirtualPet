using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {

            VirtualPet PetFights = new VirtualPet();

            PetFights.Welcome();

            PetFights.Knowledge();

            PetFights.Gamerules();

            PetFights.LayofdaLand();

            PetFights.Stats();

            Console.ReadLine();
        }
        
    }
}
