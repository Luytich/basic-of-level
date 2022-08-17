using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace udemyy
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine($"Should print out 4:{stack.Peek()}");

            stack.Pop();

            Console.WriteLine($"Should print out 3:{stack.Peek()}");
            foreach (var cur in stack) 
            {
                Console.WriteLine(cur);


            }
            var queue = new Queue<int>();
            
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine($"Should print out 1:{queue.Peek()}");

            queue.Dequeue();

            Console.WriteLine($"Should print out 2:{queue.Peek()}");
            Console.WriteLine("iterate over the queue");


            foreach (var cur in queue)
            {
                Console.WriteLine(cur);


            }
        }
        static void dictionary()
        {
            var people = new Dictionary<int, string>();
            people.Add(1, "John");
            people.Add(2, "Bob");
            people.Add(3, "Alice");

            people = new Dictionary<int, string>()
            {
                { 1, "John" },
                { 2, "Bob" },
                { 3, "Alice" },
            };

            string name = people[1];
            Console.WriteLine(name);

            Console.WriteLine("iterating over keys");
            Dictionary<int, string>.KeyCollection keys = people.Keys;

            foreach (var item in keys)
            {
                Console.WriteLine(item);


            }

            Console.WriteLine("iterating over values");
            Dictionary<int, string>.ValueCollection values = people.Values;
            foreach (var item in values)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("iterating over key-value pairs");

            foreach (var pair in people)
            {
                Console.WriteLine($"Key:{pair.Key}. value:{pair.Value}");

            }
            Console.WriteLine();

            Console.WriteLine($"Count={people.Count}");

            bool containskey = people.ContainsKey(2);
            bool containsvalue = people.ContainsValue("John");

            Console.WriteLine($"contains key:{containskey}.contain value:{containsvalue}");

            people.Remove(1);

            if (people.TryAdd(2, "Ellias"))
            {
                Console.WriteLine("added successfully");


            }

            else
            {
                Console.WriteLine("failed to add using key 2");
            }

            if (people.TryGetValue(2, out string val))
            {
                Console.WriteLine($"key 2, val={val}");


            }

            else
            {
                Console.WriteLine("failed to get");
            }


            people.Clear();

        }
        static void list()
        {

            var intlist = new List<int>() { 1, 2, 4, 7, 5, 9, 12 };
            intlist.Add(7);

            int[] intarray = { 1, 2, 3 };
            intlist.AddRange(intarray);

            if (intlist.Remove(1)) //first occurence
            {
                //do
            }
            else { }

            intlist.RemoveAt(0);

            intlist.Reverse();

            bool contains = intlist.Contains(3);

            int min = intlist.Min();
            int max = intlist.Max();

            Console.WriteLine($"Min={min}. max={max}");

            int index0f = intlist.IndexOf(2);
            int lastindexof = intlist.LastIndexOf(2);

            Console.WriteLine($"index0f2={index0f}.lastIndex0f2={lastindexof}");

            for (int i = 0; i < intlist.Count; i++)
            {
                Console.WriteLine($"{intlist[i]}");

            }
            Console.WriteLine();

            foreach (int item in intlist)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
        }
        static void array()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = Array.BinarySearch(numbers, 7);

            int[] copy = new int[10];
            Array.Copy(numbers, copy, numbers.Length);

            int[] anothercopy = new int[10];
            copy.CopyTo(anothercopy, 0);

            Array.Reverse(copy);
            foreach (var c in copy)
            {
                Console.WriteLine(c);

            }
            Console.WriteLine();
            Array.Sort(copy);
            foreach (var c in copy)
            {
                Console.WriteLine(c);

            }
            Array.Clear(copy, 0, copy.Length);

            int[] a1;

            a1 = new int[10];

            int[] a2 = new int[5];
            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

            int[] a4 = { 1, 3, 2, 4, 5 };

            Array myarray = new int[5];

            Array myarray2 = Array.CreateInstance(typeof(int), 5);
            myarray2.SetValue(12, 0);

            Console.WriteLine(myarray.GetValue(0));
        }
        static void homeworkautefincation()
        {
            string password = "qwerty";
            string login = "johnsilver";

            int tries = 1;
            while (tries <= 3)
            {
                Console.WriteLine("enter login?");
                string userlogin = Console.ReadLine();

                Console.WriteLine("enter login?");
                string userPass = Console.ReadLine();

                if (userlogin == login && userPass == password) ;
                {
                    Console.WriteLine("Enter the syste");

                }
                tries++;

                if (tries == 4) ;
                {
                    Console.WriteLine("You exceeded the number of availble tries");
                    break;
                }
            }


        }
        static void Homeworkfactorial ()
        {
            Console.WriteLine("Enter n>=0");
            int n = int.Parse(Console.ReadLine());

            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;

            }

            Console.WriteLine(factorial);
        }
        static void Homeworkfibonacci()
        {
            Console.WriteLine(" What fibonacci numbers do you want Enter? ");
            int n = int.Parse(Console.ReadLine());
            int[] fibonacci = new int[n];
            int a0 = 0;
            int a1 = 1;

            fibonacci[0] = a0;
            fibonacci[1] = a1;

            for (int i = 2; i < n; i++)
            {
                int a = a0 + a1;
                fibonacci[i] = a;

                a0 = a1;
                a1 = a;

            }

            foreach (int cur in fibonacci)
            {
                Console.WriteLine(cur);

            }
            Console.ReadLine();
        }
        static void homeworkmidle()
            {
            Console.WriteLine(" Enter up to 10 positive integers. You can stop accepting numbers by entering 0 ");
            int[] numbers = new int[10];
            int inputCount = 0;

            while (inputCount < 10)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[inputCount] = number;

                inputCount++;

                if (number == 0)
                    break;


            }

            int sum = 0;
            int count = 0;

            foreach (int n in numbers)
            {
                if (n > 0 && n % 3 == 0)
                {
                    sum += n;
                    count++;
                }
            }

            double average = (double)sum / count;
            Console.WriteLine(average);
        }
        static void Debugging()
        {
            Console.WriteLine("Let's calculate the square of a trinagle?");
            Console.WriteLine("Enter the lenght of side AB?");

            double ab = GetDoble();

            Console.WriteLine("Enter the lenght of side BC?");

            double bc = GetDoble();

            Console.WriteLine("Enter the lenght of side AC?");

            double ac = GetDoble();

            int divisor = int.Parse(Console.ReadLine());
            int result = 5 / divisor;


            double p = (ab + bc + ac) / 2;

            double square = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));

            Console.WriteLine($"Square of the triangle equals{square}");

            Console.ReadLine();
        }
        static double GetDoble()
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
