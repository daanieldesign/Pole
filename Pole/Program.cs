using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pole je datová struktura, která obsahuje hodnoty stejného datového typu
            //Na pole můžeme nahlížet jako seznam buněk, které mají svoji pozici a hodnoty
            //Velikost pole za běhu programu je neměnná
            //Praktické použití – uložení čísel do řady, práce s textem, vyhledávání dat

            /*
            int[] pole = new int[5]; //datový typ [] název = new int [velikost]
            int[] cisla = { 10, 0, -2, 36 }; //Vložení hodnot při incializaci pole

            Console.WriteLine("Stav pole před změnou");
            Console.WriteLine(cisla[0]);
            Console.WriteLine(cisla[2]);

            cisla[2] = 100; //Přepsání hodnoty na indexu dva
            cisla[0] = -100;

            //Indexování pole začíná od nuly, index představuje uloženou pozici prvku
            Console.WriteLine("Stav pole po změně");
            Console.WriteLine(cisla [0]);
            Console.WriteLine(cisla [2]);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(pole[1]); //Každý průchod zobrazí obsah indexu pole
            }

            int pocet_nul = 0;
            for (int i = 0; i < cisla.Length; i++) //Příkaz Length zjistí počet elementů pole
            {
                Console.WriteLine(cisla [i]);
                if (cisla[i] == 0)
                {
                    pocet_nul++;
                    //pocet_nul = pocet_nul + 1;
                    //pocet_nul +=1
                }
            }
            Console.WriteLine("Počet nul: " + pocet_nul);
            */
            
            int[] cisla = new int[10];
            for (int i = 0; i < 10; i++)
            {
                cisla[i] = i * 10;
            }

            for (int i = cisla.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(cisla[i]);
            }

            Console.ReadKey();
        }
    }
}
