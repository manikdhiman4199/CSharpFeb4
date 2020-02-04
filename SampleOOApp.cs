using System;

namespace ConsoleApp2
{
    class JUNGLE
    {
        static void Main(string[] args)
        {
            DoCompetition();
        }

        public static void DoCompetition()
        {
            Lion L1 = new Lion();
            Tiger T1 = new Tiger();
            L1.setName("Leo");
            T1.setName("Tiggy");
            Console.WriteLine("Lion's name is {0}", L1.getName());
            Console.WriteLine("Lion's strength is {0}", L1.getStrength());
            Console.WriteLine("Tiger's name is {0}", T1.getName());
            Console.WriteLine("Tiger's strength is {0}", T1.getStrength());
        }

    }
    class Feline
    {
        Random r1 = new Random();
        int Strength;
        String Name;
        public Feline()
            {
                Console.WriteLine("Yeah! we are in the constructor!");
                this.Strength = this.setStrength();
            }
 
            public int setStrength() {
            Strength = (int)r1.Next(1,100);
                        return Strength;
            }
            public String getName()
            {
                return this.Name;
            }

            public int getStrength()
            {
                return this.Strength;
            }
            public void setName(String aName)
                {   //variable scoping:
                    this.Name = aName;
                }
    }
    class Lion:Feline
    {
        
    }

    class Tiger:Feline
    {
        
    }
}
