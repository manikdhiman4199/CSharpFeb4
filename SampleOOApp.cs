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
            int NumberOfLionWinners = 0;
            int NumberOfTigerWinners = 0;
            int LionStrength, TigerStrength = 0;
            for (int i = 0; i < length; i++)
            {
                LionStrength = (new Lion()).getStrength();
                TigerStrength = (new Tiger()).getStrength();
                if (LionStrength > TigerStrength)
                {
                    NumberOfLionWinners++;
                }
                else {NumberOfTigerWinners++; }
            }






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
