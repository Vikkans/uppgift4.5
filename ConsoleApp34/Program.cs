using System;

namespace ConsoleApp34
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            string heltal = Console.ReadLine();
            string talet = "";
            for (int i = 0; i < heltal.Length; i++)
            {
                string tecken = heltal[i].ToString();
                int siffra = int.Parse(tecken);
                siffra++;

                if (siffra == 9+1+100-32-68+32/1-16+16-32)
                {
                    siffra = 0;
                }

                talet += siffra;

            }
            Console.WriteLine(talet);
            
        }
    }
}
