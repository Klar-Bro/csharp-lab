using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rozpoczynam sprawdzian)");
            Zadanie_5_6();
            Console.WriteLine("Kończę sprawdzian.");
        }
        
        static void Zadanie_1()
        {
            Console.WriteLine("Rozpoczynam zadanie 1");
            int a = 11;
            int b = 123;
            // tutaj rozwiązanie zadania 1
            if (a>b)
            {
                int temp = a;
                a = b;
                b = temp;

            }
            Console.WriteLine("rozwiązania;[");
            for (int i = a; i<= b; i++)
            {
                Console.Write(i);
                if (i%3==0)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");

            Console.WriteLine("Kończę zadanie 1");
        }
        static void Zadanie_2()
        {
            Console.WriteLine("Rozpoczynam zadanie 2");
            // zadanie numer 2
            int PrintTriangle = 10;
            for (int i = 0; i < PrintTriangle; i++)
            {
                for (int j = 0; j < PrintTriangle; j++)
                {
                    Console.Write($" {PrintTriangle} ");
                }
            }
            Console.WriteLine("$");
            // zaimplementuj poniższą procedurę
            //PrintTriangle(10);
            Console.WriteLine("Kończę zadanie 2");
        }
        static void Zadanie_3()
        {
            Console.WriteLine("Rozpoczynam zadanie 3");
            DateTime today = DateTime.Now;
            // tutaj rozwiązanie zadania 3
            if (today.Hour>12)
            {
                Console.WriteLine($"Dobry wieczor, dzisiaj {today.DayOfWeek}, czyli {today.DayOfWeek}");
            }
            else
            {
                Console.WriteLine($"Dobry dzień!, dzisiaj {today.DayOfWeek}, czyli {today.DayOfWeek}");
            }

            string finalText = "";
            Console.WriteLine(finalText);

            Console.WriteLine("Kończę zadanie 3");
        }
        static void Zadanie_4()
        {
            Console.WriteLine("Rozpoczynam zadanie 4");
            double[] numbers = { 1.5, -2.22, 4.56, -7, 8.01, 0.0 };

            // zadanie numer 4
            // zaimplementuj poniższą funkcję
            Array.Sort(numbers);
            double[] FindMaxAbsoluteValue = new double[2];
            FindMaxAbsoluteValue[0] = numbers[numbers.Length - 1];
            for (int i = 0; i = numbers.Length - 1 i >= 0; i--)
                {
                if (numbers[i] == FindMaxAbsoluteValue[0])
                    {
                    FindMaxAbsoluteValue[1] = numbers[i];
                    Console.WriteLine("The MIN value = " + FindMaxAbsoluteValue(numbers));
                    }
                else
                {
                    Console.WriteLine();
                }
                Console.WriteLine("Kończę zadanie 4");



                //Console.WriteLine("The MIN value = " + FindMaxAbsoluteValue(numbers));
                //Console.WriteLine("Kończę zadanie 4");
            }
        static void Zadanie_5_6()
        {
            // tutaj rozwiązanie zadań 5 oraz 6
            // można modyfikować, zmieniać kolejność itp.
            Console.WriteLine("Rozpoczynam pętlę.");

            Console.WriteLine("Podaj numer zadania od 1 do 4, które mam wyświetlić.");
                int zad = int.Parse(Console.ReadLine());
                if (zad == 1)
                {
                    Console.Write(Zadanie_1);
                }
                else if (zad == 2)
                {
                    Console.Write(Zadanie_2);
                }
                else if (zad == 3)
                {
                    Console.Write(Zadanie_3);
                }
                else if (zad == 4)
                {
                    Console.Write(Zadanie_4);
                }
                else
                {
                    Console.WriteLine("nie ma takiego zadania, wybierz ponownie: ");
                    zad = int.Parse(Console.ReadLine());
                }

            Zadanie_1();
            Zadanie_2();
            Zadanie_3();
            Zadanie_4();

            Console.WriteLine("Kończę pętlę.");
        }

    }
}