using System;
using System.Collections.Generic;

namespace Zadania
{
    class Program
    {
       

        static void Main(string[] args)
        {
            //rozgrzewka
            // zadanie 2 

            //Console.WriteLine("Podaj swoje imię:");
            //var name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);

            //zadanie 3 
            int result = 5 + 9;

            //Operatory
            //zadanie 1
            int number = 1;
            float money = 12.99F;
            String text = "HELLO";
            bool isLogged = true;
            char myChar = 'x';
            decimal price = 0.12345678901234567890M;

            Console.WriteLine(number);
            Console.WriteLine(money);
            Console.WriteLine(text);
            Console.WriteLine(isLogged);
            Console.WriteLine(myChar);
            Console.WriteLine(price);

            //zadanie 2
            String myAge = "Age: ";
            int wifeAge = 18;
            var result1 = myAge + wifeAge;

            Console.WriteLine(result1);

            //int zostaje przekonwertowany w String

            //zadanie 3 
            bool isTrue = true;
            bool isFalse = false;
            bool isReallyTrue = true;

            bool and = isTrue && isFalse;
            bool or = isTrue || isReallyTrue;
            bool negative = !isFalse;

            Console.WriteLine(and);
            Console.WriteLine(or);
            Console.WriteLine(negative);

            //zadanie 4
            var a = 5;
            var b = 12;
            var add = a + b;
            var sub = a - b;
            var div = a / b;
            var mul = a * b;
            var mod = a % b;

            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(div);
            Console.WriteLine(mul);
            Console.WriteLine(mod);

            //zadanie 5
            String a1, b1, c1;
            a1 = "Ala ";
            b1 = "ma ";
            c1 = "kota.";
            var result2 = a1 + b1 + c1;

            Console.WriteLine(result2);
            // result2 zostaje Stingiem który łączy pozostałe zmienne String

            //Instrukcje sterujące i pętle
            //zadanie 1

            int n1 = 10, n2 = 20;
            if (n1 > n2)
            {
                Console.WriteLine("n1 jest większe od n2");
            }
            else if (n2 > n1)
            {
                Console.WriteLine("n2 jest większe od n1");
            }
            else
            {
                Console.WriteLine("n1 jest równe n2");
            }

            //zadanie 2
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("C#");
            }

            int j = 0;
            while (j < 10)
            {
                Console.WriteLine("C#");
                j++;
            }

            //zadanie 3
            var n = 10;

            for (var i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " - Parzysta");
                }
                else
                {
                    Console.WriteLine(i + " - Nieparzysta");
                }
            }

            //zadanie 4*
            var n4 = 5;
            String stars = "";
            for (var i = 0; i < n4; i++)
            {
                stars += "*";
                Console.WriteLine(stars);
            }

            //zadanie 5*
            var exam = 57;
            String point;

            if (exam >= 0 && exam <= 39)
            {
                point = "Ocena Niedostateczna";
            }
            else if (exam >= 40 && exam <= 54)
            {
                point = "Ocena Dopuszczająca";
            }
            else if (exam >= 55 && exam <= 69)
            {
                point = "Ocena Dostateczna";
            }
            else if (exam >= 70 && exam <= 84)
            {
                point = "Ocena Dobra";
            }
            else if (exam >= 85 && exam <= 98)
            {
                point = "Ocena Bardzo Dobra";
            }
            else if (exam >= 99 && exam <= 100)
            {
                point = "Ocena Celująca";
            }
            else
            {
                point = "Wartość poza zakresem";
            }
            Console.WriteLine(point);


            //Kolekcje
            // zadanie 1

            String[] colors = new String[4];
            colors[0] = "czerwony";
            colors[1] = "czarny";
            colors[2] = "różowy";
            colors[3] = "fioletowy";

            Console.WriteLine("Mój pierwszy kolor to: " + colors[0]);
            Console.WriteLine("Mój ostatno kolor to: " + colors[3]);

            // zadanie 2
            int[] liczby = new int[10];
            for (int i = 0; i < 10; i++)
            {
                liczby[i] = i;
            }

            for (int i=0; i < 10; i++)
            {
                Console.WriteLine("Liczba: " + i);
            }

            int k = 0;
            while (k != liczby.Length)
            {
                Console.WriteLine("Liczba: " + k);
                k++;
            }

            foreach (int liczba in liczby)
            {
                Console.WriteLine("Liczba: " + liczba);
            }

            var fruits = new List<string> { "Pomidor", "Jabłko", "Marchewka"};
            foreach (String owoc in fruits)
            {
                Console.Write(owoc + ", ");
            }
            fruits.Remove("Pomidor");
            fruits.RemoveAt(1);

            foreach (String owoc in fruits)
            {
                Console.WriteLine(owoc);
            }

        }
    }
}
