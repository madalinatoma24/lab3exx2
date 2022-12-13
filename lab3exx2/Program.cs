using System;

namespace lab3exx2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ex 2  Scrieti o functie care va determina daca un numar este sau nu numar prim. Apelati-o si afisati-i rezultatul.
            */
            Console.WriteLine("Introduceti numarul: ");
            int numar = int.Parse(Console.ReadLine());

            if (NumberPrimeOrNot(numar) == true)
            {
                Console.WriteLine($"Numarul: {numar} este prim.");
            }
            else
            {
                Console.WriteLine($"Numarul: {numar} nu este prim");
            }

            static bool NumberPrimeOrNot(int n)
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }


            /* o alta incercare mai ciudata
                        if (NumberIsPrime(numar) == true)
                        {
                            Console.WriteLine($"Numarul: {numar} este prim.");
                        }
                        else
                        {
                            Console.WriteLine($"Numarul: {numar} nu este prim");
                        }
                        static bool NumberIsPrime(int n)
                        {
                            int[] arr;
                            //int size=n;
                            arr = new int[n];
                            if (n > 2)
                            {
                                for (int i = 0; i < arr.Length; i++)
                                {
                                    if (i > 0)
                                    {
                                        if (n % i == 0)
                                        {
                                            arr[i] = i;
                                        }
                                    }
                                }
                                //Array.Resize(ref arr, arr.Length);

                                if (arr[2] != 0 || arr[3] != 0)
                                {
                                    return false;
                                }
                                else
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                return true;
                            }
                        }*/
        }
    }
}
