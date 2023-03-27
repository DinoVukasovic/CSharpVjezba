using System;
using System.Collections;
using System.IO;
using System.Linq;

namespace Vjezba_Dino_Vukasovic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Unesite opciju od 0 do 7 ili 10 za izaci");
            int opcija = Int32.Parse(Console.ReadLine());

            while (opcija != 10)
            {
                switch (opcija)
                {
                    case 0:
                        Console.WriteLine("Odabrali ste parnost, unesite broj");
                        int broj = Int32.Parse(Console.ReadLine());
                        if (broj % 2 == 0)
                        {
                            Console.WriteLine("Broj " + broj + " je paran");
                        }
                        else
                        {
                            Console.WriteLine("Broj " + broj + " neparan");
                        }
                        break;

                    case 1:
                        Console.WriteLine("Odabrali ste opciju Kvadratna");
                        Console.WriteLine("Odaberite zelite li da kvadratna jednazba bude + ili -");
                        char plusMinus = Char.Parse(Console.ReadLine());

                        Console.WriteLine("Unesite prvi broj");
                        double a = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Unesite drugi broj");
                        double b = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Unesite treci broj");
                        double c = Double.Parse(Console.ReadLine());

                        double sqrt = b * b - 4 * a * c;
                        double sqrtResult = Math.Sqrt(sqrt);
                        double cPow = Math.Pow(a, 2);
                        if (plusMinus == '+')
                        {
                            double result1 = (-b + sqrtResult) / cPow;
                            Console.WriteLine("Rezultat sa + je " + result1);
                        }
                        else if (plusMinus == '-')
                        {
                            double result2 = (-b - sqrtResult) / cPow;
                            Console.WriteLine("Rezultat sa + je " + result2);
                        }
                        else
                        {
                            Console.WriteLine("Unjeli ste krivi znak");
                        }
                        break;

                    case 2:
                        int ocjena;
                        int brojOcjena = 0;
                        int sum = 0;
                        ArrayList ocijene = new ArrayList();

                        do
                        {
                            Console.WriteLine("Unesite ocjenu");
                            ocjena = Int32.Parse(Console.ReadLine());
                            if (ocjena > 5 || ocjena == 0)
                            {
                                Console.WriteLine("Ocjena mora biti izmedju 1 i 5");
                            }
                            else
                            {
                                ocijene.Add(ocjena);
                                brojOcjena++;
                            }
                        } while (brojOcjena < 10);

                        foreach (int i in ocijene)
                        {
                            sum = sum + i;
                        }

                        Console.WriteLine("Prosjek ocjena je " + sum / brojOcjena);

                        break;

                        case 3:
                        int number;
                        int summ = 0;
                        ArrayList numbers = new ArrayList();

                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine("Enter a number ");
                            number = Int32.Parse(Console.ReadLine());
                            numbers.Add(number % 10);
                        }

                        Console.WriteLine("Rezultat zadnji brojeva je : ");
                        foreach (int i in numbers)
                        {
                            summ += i;
                           
                        }
                        Console.WriteLine(summ);
                        break;

                    case 4:
                        int temp;
                        int[] lotto = new int[7];

                        Random rand = new Random();

                        for (int i = 0; i < 7; i++)
                        {
                            do
                            {
                                temp = rand.Next(1, 45);
                            }
                            while (lotto.Contains(temp));
                            lotto[i] = temp;
                        }

                        Console.Write($"the new lotto winning numbers are: ");
                        for (int i = 0; i < 7; i++)
                        {
                            Console.Write(lotto[i] + " ");
                        }
                        break;

                        case 5:
                        string dirLocation = @"C:\Users\Zera\Desktop\FileExercise";

                        if (!Directory.Exists(dirLocation))
                        {
                            Directory.CreateDirectory(dirLocation);
                        }
                        else
                        {
                            Console.WriteLine("Directory exists :)");
                        }

                        //Storing file name and file location into strings
                        string fileName = "matrix.txt";
                        string fileLocation = $"{dirLocation}\\{fileName}";

                        //Creting a file if it doesn't exist
                        if (!File.Exists(fileLocation))
                        {
                            FileStream stream = File.Create(fileLocation);
                            stream.Flush();
                            stream.Close();
                        }

                        int[,] matrix = new int[7, 7];
                        for (int i = 0; i < 7; i++)
                        {
                            for (int j = 0; j < 7; j++)
                            {
                                matrix[i, j] = i * 7 + j + 1;
                            }
                        }

                        using (StreamWriter writer = new StreamWriter(fileLocation))
                        {

                            for (int i = 0; i < 7; i++)
                            {
                                for (int j = 0; j < 7; j++)
                                {
                                    writer.Write(matrix[i, j] + " "); 
                                }
                                writer.WriteLine(); 
                            }
                        }

                        //Reading the text from a txt file
                        using (StreamReader reader = new StreamReader(fileLocation))
                        {
                            while (!reader.EndOfStream)
                            {
                                string line = reader.ReadLine();
                                Console.WriteLine(line);
                            }

                        }
                                break;
                }


                Console.WriteLine("\n");
                Console.WriteLine("Unesite opciju od 0 do 7 ili 10 za izaci");
                opcija = Int32.Parse(Console.ReadLine());
            }

        }

    }
}