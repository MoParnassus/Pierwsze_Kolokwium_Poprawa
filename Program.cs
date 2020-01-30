using System;


namespace PIII_LAB_Kolokwium_Parnas_Wojciech_Pierwsze
{

    class Gracz
    {
        private Gracz()
        {
            int hp;
            int mp;
        }
        public void eq()
        {


        }
    }
        class Program
    {

        static void Drugie()
            {

                int[][] ary = new int[][]
                {
                    new int[1],
                    new int[3],
                    new int[5],
                    new int[7]
                };

            for (int i = 0; i < ary.Length; i++)
            {
                for (int j = 0; j < ary.Length; j++)
                {

                }
            }

            }
            static void Pierwsze()
        {
            int x, y, wynik;
            Console.Write("Podaj X = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj Y = ");
            y = Convert.ToInt32(Console.ReadLine());

            y = x ^ 3 - 3 * x;

            Console.WriteLine(y);
        }
        static void Main(string[] args)
        {
            Pierwsze();
            Drugie();
        }
        
    }

}
