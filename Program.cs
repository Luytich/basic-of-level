using System;

namespace B_ControlFlow
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Let's calculate the square of a trinagle?");
            Console.WriteLine("Enter the lenght of side AB?");

            double ab = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the lenght of side BC?");

            double bc = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the lenght of side AC?");

            double ac = double.Parse(Console.ReadLine());

            double p = (ab + bc + ac) / 2;

            double square = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));

            Console.WriteLine($"Square of the triangle equals{square}");

        }
        
        static double GetDoble ()
        {
            return double.Parse(Console.ReadLine());
        }

        static void SwitchCase()

        {
            int month = int.Parse(Console.ReadLine());
            string season = string.Empty;
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumm";
                    break;
                default:
                    throw new ArgumentException("Unexpected number of month");
            }
            Console.WriteLine(season);
            Console.ReadLine();

            /*int weddingYears = int.Parse(Console.ReadLine());

            string name = string.Empty;

            switch (weddingYears)
            {
                case 5:
                    name = "Weed свадьба";
                    break;
                case 10:
                    name = "Оловянная свадьба";
                    break;
                case 15:
                    name = "Хрустальная свадьба";
                    break;
                case 20:
                    name = "Фарфоровая свадьба";
                    break;
                case 25:
                    name = "Серебрянная свадьба";
                    break;
                case 30:
                    name = "Жемчужная свадьба";
                    break;
                default:
                    name = "Не знаем такого юбилея";
                    break;

            }*/
        }

        static void BreakContinue()
        {
            int[] numbers = { 0, 3, 2, 1, 5, 4, 6, 7, 8, 9 };

            foreach (int n in numbers)
            {    //if(n% 2==0)
                //{
                //    Console.WriteLine(n);

                //}
                if (n % 2 != 0)
                    continue;
                Console.WriteLine(n);
            }


            Console.ReadLine();

            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Number={numbers[i]}");

                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbers[i] == j)
                        break;
                    Console.Write($"{ letters[j]}");

                }
                Console.WriteLine();
            }


            Console.ReadLine();

            int[] numbers2 = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            int counter = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (counter == 3)
                    break;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair({atI};{atJ}).Indexes({i};{j})");
                        counter++;
                    }
                    if (counter == 3)
                        break;
                }

            }
        }
        static void WhileDoWhile()
        {
            //int age = 30;

            //    while(age<18)
            //    {
            //        Console.WriteLine("First while loop");
            //        Console.WriteLine("What is your age?");
            //        age = int.Parse(Console.ReadLine());

            //    }

            //    do
            //    {
            //        Console.WriteLine("Do\\While");
            //        Console.WriteLine("What is your age?");
            //        age = int.Parse(Console.ReadLine());


            //    }

            //    while (age < 18);

            int[] numbers = { 1, 2, 3, 4, 5 };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i] + " ");
            }

            Console.WriteLine("Good");

        }
        static void NestedFor()
        {
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair({atI};{atJ}).Indexes({i};{j})");

                    }

                }
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        int atI = numbers[i];
                        int atJ = numbers[j];
                        int atK = numbers[k];

                        if (atI + atJ + atK == 0)

                        {
                            Console.WriteLine($"Triplets({atI};{atJ};{atK}).Indexes({i};{j};{k})");

                        }
                    }
                }
            }


        }

        static void ForForeach()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + "  ");
            }
            Console.WriteLine();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i] + "  ");
            }

            Console.WriteLine();

            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] % 2 == 0)
                {
                    Console.WriteLine(numbers[j] + "  ");
                }

            }
            foreach (int val in numbers)
            {
                Console.WriteLine(val + "  ");

            }

        }
        static void HomeworkGetMax()
        {
            Console.WriteLine(" Сan You enter  a?");
            int a = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());
            //1st
            // int max = a;
            //if (b > a)
            //   max = b;
            //2nd
            //int max = a;
            //if (a > b)
            //    max = a;
            //else
            //    max = b;

            //3rd
            int max = a > b ? a : b;
            Console.WriteLine($"Max={max}");

        }
        static void ifelse()
        {
            Console.WriteLine("What's your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What's your weight in kg?");
            double weight = int.Parse(Console.ReadLine());

            Console.WriteLine("What's your height in cm?");
            double height = int.Parse(Console.ReadLine());

            double bodyMassIndex = weight / (height / 100 * height / 100);

            bool isTooLow = bodyMassIndex <= 18.5;
            bool isNormal = bodyMassIndex > 18.5 && bodyMassIndex < 25;
            bool isAboveNormal = bodyMassIndex >= 25 && bodyMassIndex <= 30;
            bool isTooFat = bodyMassIndex > 30;

            bool isFat = isAboveNormal || isTooFat;

            if (isFat)
            {
                Console.WriteLine("You'd better lose some weight");

            }

            else
            {
                Console.WriteLine("Oh, you're in a good shape.");
            }
            //if(isFat==false)
            if (!isFat)
            {
                Console.WriteLine("You're definitely not fat");

            }

            if (isTooLow)
            {
                Console.WriteLine("Not enough weight");
            }
            else if (isNormal)
            {
                Console.WriteLine("You're OK");

            }

            else if (isAboveNormal)
            {
                Console.WriteLine("Be careful");
            }

            else
            {
                Console.WriteLine("You need to lose some weight.");

            }
            //

            if (isFat || isTooFat)
            {

                Console.WriteLine("Anyway it's time to get on diet.");

            }
            //ternary operation
            string description = age > 18 ? "You can drink alcohol" : "You should a bit older";
            //the same in if-else construction
            //if(age>18)
            //{
            //     description = "You can drink alcohol";

            //}

            // else
            // {
            //  description = "You should a bit older";

            // }
            Console.WriteLine(description);
        }

    }

}
