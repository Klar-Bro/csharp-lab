// See https://aka.ms/new-console-template for more information

//zadanie 1: Odlicz od 10 do 0 wypisując na ekran kolejne liczby. Użyj pętli do.
using System;
using System.Collections.Generic;

int x = 10;
do
{
    Console.Write(x);
    x--;
} while (x >= 0);

//zadanie 2: Pytaj użytkownika o hasło do momentu aż nie wpisze "koniec".
string haslo;
do
{
    Console.WriteLine("Podaj hasło!");
    haslo = Console.ReadLine();
} while (haslo != "koniec");

//zadanie 3:
int y = 0;

while (y <= 100)
{
    if (y % 2 == 0)
        Console.WriteLine(y);
    y++;
}

//zadanie 4:
for (int c = 0; c <= 15; c++)
    Console.WriteLine($"kwatrat {c} wynosi {c * c}");

//zad 5
List<int> numbers = new() { 4, 25, 35, 42, 55, 78, 99, 101 };
foreach (int element in numbers)
{
    if (element % 7 ==0)
        Console.Write($"{element} ");
   
}

//zadanie 6
    // wystarczy dopisac break na koncu programu

//zadanie 7;

double[] tablica = new double[20];
for (int i = 0; i < tablica.Length; i++)
{
    tablica[i] = Math.Sqrt(i+1);
}
Console.WriteLine("pierwiastki z kolejnych liczb calkowitych:");
for (int i= 0; i< tablica.Length; i++)
{
        Console.WriteLine($"Pierwiastek z { i+1} = {tablica[i]}");
}

//zadanie 8

int[,] macierz = new int[3, 4];
int licznik = 1;
for (int q = 0; q<3; q++)
{
    for (int w = 0; w<4; w++)
    {
        macierz[q, w] = licznik;
        licznik++;
    }
}
Console.WriteLine("macierz po transpozycji (4x3):");
for (int w=0; w<4; w++)
{
    for (int q = 0; q < 3; q++)
    {
        Console.Write(macierz[q, w] + "\t");
    }
    Console.WriteLine();
}

//zadanie 10;
void PrintUpperCase(string txt)
{
    Console.WriteLine(txt.ToUpper());
}
PrintUpperCase("tekst do druku");

//zadanie 13

void PrintConsoleSquare(int k, int l)
{
    //rysuj gorna
    for(int i=0; i<k; i++)
        Console.Write("$");

    // zejdz do nowej lini
        Console.WriteLine();
    //rysuj srodek/boki
    for (int i = 0; i < k - 2; i++)
    {
        Console.Write("$");
        //teraz puste
        for (int j = 0; j < k; j++)
        {
            Console.Write(" ");
        }
        Console.Write("$");
        Console.WriteLine() ;
    }

        //rysuj dolna
        for (int i=0; i<k; i++)
       Console.Write("$");
}
    PrintConsoleSquare(5, 5);


// zadanie 12
string EvenOrOdd1 (int toCheck)
{
    string retStr = "";
    if(toCheck%2 == 0)
    {
        retStr = "even";
    }
    else
    {
        retStr = "odd";
    }
    return retStr;
}

//string EvenOrOdd2(int toCheck)
//{
  //  if (toCheck % 2 == 0)
    //    return "Even";
    //else
      //  return "Odd";
//}

//zadanie 11

void CreateAndPrintMatrix(int x, int y)
{
    char[,] matrix = new char[x,y];
    for (int i = 0; i<x; i++)
    {
        for (int j = 0; j<y; j++)
        {
            matrix[x, y] = '#';
        }
    }
    for(int i=0;i<x; i++)
    {
        for (int j = 0; j<y; j++)
        {
            Console.Write(matrix[x, y]);
        }
        Console.WriteLine();
    }
}
CreateAndPrintMatrix(10, 10);

