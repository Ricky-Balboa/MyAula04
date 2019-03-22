using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            string num;
            int n;
            Perks[] Caracteristicas ;
            bool op;
            
            Console.WriteLine("Insira o numero de NPC's");
            num = Console.ReadLine();
            n = Convert.ToInt32(num);
            Caracteristicas = new Perks[n] ;
            for (int i=0; i < n; i++)
            {
                Console.WriteLine("NPC numero -> " + (i+1));
                Console.WriteLine("Tem Stealth ?");
                string a = Console.ReadLine();
                if(a == "sim")
                {
                    Caracteristicas[i] |= Perks.Stealth;
                }
               
                Console.WriteLine("Tem Combat ?");
                string b = Console.ReadLine();
                if (b == "sim")
                {
                    Caracteristicas[i] |= Perks.Combat;
                }
                
                
                Console.WriteLine("Tem LockPick ?");
                string c = Console.ReadLine();
                if (c == "sim")
                {
                    Caracteristicas[i] |= Perks.Lockpick;
                }
               
                Console.WriteLine("Tem Luck ?");
                string d = Console.ReadLine();
                if (d == "sim")
                {
                    Caracteristicas[i] |= Perks.Luck;
                }
               


            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("NPC numero -> " + (i + 1));
                Console.WriteLine(Caracteristicas[i]);
                
                
            }

        }
   
}
}
