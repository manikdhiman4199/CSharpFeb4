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
            Console.WriteLine("Tiger's name is {0}", T1.getName());
        }

    }
    class Feline
    {
            String Name;
            int Strength() {
                        return 0;
            }
            public String getName()
            {
                return this.Name;
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
