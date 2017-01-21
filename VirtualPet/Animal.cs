using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {

        private string name;
        //  private int age;
        //  private int hunger;
        //  private string sayings;
        //  private int fight;
        private int sleep;
        private int poop;
        private int imhungry;
        private int thirst;
        private int hyperLevel;
        private int userInput;
        private int collardmac;
        private int slothdwn;
        private int numbertwo;
        private int gatorade;

        //   private int collardMac;
        //  private int turnUp;
        //  private int slothdwn;
        //  private int gatorade;
        //  private int numberTwo;

        public VirtualPet()//constructor
        {
            this.name = "Slater";//name
            this.imhungry = 10;//food
            this.hyperLevel = 10;//energy
            this.poop = 10;//poop
            this.thirst = 10;//thirst
            this.sleep = 10;//sleep
            this.userInput = 0;
            //  this.collardMac = 0;
            //  this.turnUp = 0;
            // this.slothdwn = 0;
            // this.numberTwo = 0;
        }

        public void Welcome()
        {
            Console.WriteLine("HEEEEEEEEEELLLLLLLLLLLLLLLLLLLLOOOOOOOOOOOOOO I'm Slater the Sloth I love the to eat, sleep and poop.\n I'm a Sloth what do you expect");
        }
        public void Hello()
        {
            this.Welcome();
        }


        public void Knowledge()
        {
            Console.WriteLine("Hunger Level" + " " + imhungry);
            Console.WriteLine("Energy Level" + " " + hyperLevel);
            Console.WriteLine("Poop Level" + " " + poop);
            Console.WriteLine("Thrist Level" + " " + thirst);
        }
        public void Gamerules()
        {
            Console.WriteLine("With Slater you can Feed him, Quench his Thirst, make him have to Poop or give him Energy!");
        }
        public void Rules()
        {
            this.Gamerules();
        }
        public void LayofdaLand()
        {
            Console.WriteLine("All of Slater's levels will start off at 10.\n From putting numbers into the game it will increase or decrease his levels");
        }
        public void Land()
        {
            this.LayofdaLand();
        }
        //  public VirtualPet()
        //  {
        //      this.userInput = userInput;
        //      this.CollardMac = CollardMac;
        //      this.TurnUp = Turnup;
        //      this.Slothdwn = Sloth;
        //      this.NumberTwo = NumberTwo;
        //  }


        public void Stats()
        {
            Console.WriteLine("Choose a number between 1 and 5 and see what your result will be");
            int userinput = int.Parse(Console.ReadLine());//userinput


            if (userinput == 1)
            {
                collardmac -= 5; slothdwn += 10; numbertwo += 2; gatorade += 2;
                Console.WriteLine("Slater's Food level decreased 5!\n Sleep level increased 10! Thirst level increased 2! \n Slater is happy because he likes to sleep!");

                return;
            }
            else if (userinput == 2)
            {
                int turnup = 0;
                turnup += 5; slothdwn -= 10; numbertwo += 2; gatorade += 2;
                Console.WriteLine(" Slater's Energy level increased 5! \n Sleep level will decrease by 10! \n Poop Level goes up by 2! \n His Thirst Level increased by 2! \n Slater is angry because he loves to sleep!");

                return;
            }
            if (userinput == 3)
            {
                slothdwn -= 5; numbertwo += 2; gatorade += 2;
                Console.WriteLine(" Slater's Sleep level decreased by 5! \n Slater's Poop level increased by 2! \n Slater's Thirst level increased by 2 \n Slater wants to Claw your eyes out because he needs more sleep!");
                return;
            }
            else if (userinput == 4)
            {
                gatorade += 10; slothdwn -= 10; numbertwo += 2;
                Console.WriteLine(" Slater's Sleep level decreased by 10! \n Slater's Poop level increased by 2! \n Slater's Thirst level increased by 10! \n Slater isn't happy but its cold beer in the fridge so he will be fine!");
                return;
            }
            if (userinput == 5)
            {
                numbertwo -= 5; slothdwn += 3; gatorade += 2;
                Console.WriteLine(" Slater's Sleep level decreased by 5!\n Slater's Sleep level increased be 3!\n Slater's Thirst level increased by 2! \n Slater is pretty much on the level because everything you gave him is just so so!");

                return;
            }
        }



        public int TurnUp
        {
            get { return hyperLevel; }//energy
            set { this.hyperLevel = value; }
        }
        public int CollardMac//feed
        {

            get { return imhungry; }
            set { this.imhungry = value; }
        }
        public int Slothdwn//sleep
        {

            get { return sleep; }
            set { this.sleep = value; }
        }
        public int NumberTwo//poop
        {

            get { return poop; }
            set { this.poop = value; }
        }
        public int Gatorade//thirst
        {

            get { return thirst; }
            set { this.thirst = value; }
        }


    }
}


      
    


