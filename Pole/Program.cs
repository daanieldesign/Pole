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

            /*int[] cisla = new int[10];
             for (int i = 0; i < 10; i++)
             {
                 cisla[i] = i * 10;
             }

             for (int i = cisla.Length - 1; i >= 0; i--)
             {
                 Console.WriteLine(cisla[i]);
             }
             */

            //Program dostane na vstup posloupnost celých čísel. Spočítejte a vypište, kolik bylo mezi zadanými čísly kladných, záporných a nulových hodnot. Tuto informaci vypište.

            /*    
            int n, kladne = 0, zaporne = 0, nula = 0;

                Console.Write("Zadejte počet čísel: ");
                n = int.Parse(Console.ReadLine());

                int[] cisla = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Zadejte cislo: ");
                    cisla[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < n; i++)
                {
                    if (cisla[i] > 0)
                    {
                        kladne++;
                    }
                    else if (cisla[i] < 0)
                    {
                        zaporne++;
                    }
                    else
                    {
                        nula++;
                    }
                }

                Console.WriteLine("Počet čísel: {0} kladných, {1} záporných a {2} nuly.", kladne, zaporne, nula);*/

            //Sestavte program, který bude od uživatele načítat čísla. Načítejte do té doby, dokud je posloupnost čísel rostoucí. Spočítejte průměrnou hodnotu zadaných čísel. Tuto informaci vypište.

            int cislo, soucet = 0, pocet = 0, predchozi = int.MinValue;

            do
            {
                Console.Write("Zadejte číslo: ");
                cislo = int.Parse(Console.ReadLine());

                if (cislo <= predchozi)
                {
                    Console.WriteLine("Posloupnost není rostoucí.");
                    break;
                }

                soucet += cislo;
                pocet++;
                predchozi = cislo;

            } while (true);

            double prumer = soucet / pocet;
            Console.WriteLine("Průměrná hodnota čísel: {0}", prumer);

            Console.ReadKey();
        }
    }
}
