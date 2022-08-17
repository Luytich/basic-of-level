using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace UdemyCourse
{
    class Program
    {
        private static int n;

        static void Main(string[] args)
        {
            

        }

        static void Homework03()
        {

            Console.WriteLine("What's your last name?");
            string lastname = Console.ReadLine();

            Console.WriteLine("What's your first name?");
            string firstname = Console.ReadLine();

            Console.WriteLine("What's your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What's your weight in kg?");
            double weight = int.Parse(Console.ReadLine());

            Console.WriteLine("What's your height in cm?");
            double height = int.Parse(Console.ReadLine());

            double bodyMassIndex = weight / (height / 100 * height / 100);

            string profile =
            $"Your profile:{Environment.NewLine}"

            + $"Full Name: {lastname}{firstname}{Environment.NewLine}"
            + $"Age: {age}{Environment.NewLine}"
            + $"Weight: {weight}{Environment.NewLine}"
            + $"Height: {weight}{Environment.NewLine}"
            + $"Body Mass Index: {bodyMassIndex}{Environment.NewLine}";

            Console.WriteLine(profile);

        }

        static void Homework02()
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

        static void Homework01 ()
        {
            //Home task 1-3

            //3

            Console.WriteLine("Enter an intergener?");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"The number of didgits: { number.ToString().Length}");

            //1

            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}");

            //2

            Console.WriteLine("Enter an intergener?");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter an intergener?");

            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"a={a}, c={c}");

            int z = a;
            a = c;
            c = z;

            Console.WriteLine($"a={a}, c={c}");


        }
        static void Date()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine(now.ToString());

            Console.WriteLine($"It's {now.Date},{now.Hour},:{now.Minute}");

            DateTime dt = new DateTime(2016, 2, 28);
            DateTime newDT = dt.AddDays(1);


            Console.WriteLine(newDT);
            TimeSpan ts = now - dt;
            //ts=now.Subctact(dt);
            Console.WriteLine(ts.Days);

        }
        static void IntroToArrays()
        {
            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

            int[] a4 = { 1, 2, 3, 4, 5 };

            Console.WriteLine(a4[0]);
            int number = a4[4];

            Console.WriteLine(number);

            a4[4] = 6;
            Console.WriteLine(a4[4]);
            Console.WriteLine(a4.Length);

            Console.WriteLine(a4[a4.Length - 1]);

            string s1 = "abcdefgh";
            char first = s1[0];
            char last = (s1[s1.Length - 1]);

            Console.WriteLine($"First:{first}.Last:{last}");
            //impossible
            // s1[0] = 'z';
        }
        static void MathDemo()
        {
            //Math.BigMul

            Console.WriteLine(Math.Pow(2, 3));

            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Sqrt(8));

            Console.WriteLine(Math.Round(1.7));
            Console.WriteLine(Math.Round(1.4));


            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));


        }
        static void Comments()
        {
            // single-line comment
            /*
             * multi-line comment
             * we can write here many words
             * 
             * 
             */

            //describe hows and whys! not whats!

            int a = 1;

            //why?   its right

            a++;

        }

        static void CastingAndParsing()
        {
            byte b = 3;// 0000 0011
            int i = b;// 0000 0000 0000 0000 0000 0000 0000  0011
            long l = i;// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 00011

            float f = i;//3.0


            Console.WriteLine(f);

            b = (byte)i;
            //Console.WriteLine(b);

            i = (int)f;
            //Console.WriteLine(i);


            f = 3.1f;
            i = (int)f;
            Console.WriteLine(i);

            string str = "1";
            //i=(int)str;
            i = int.Parse(str);
            Console.WriteLine($"Parsed i={i}");

            int x = 5;
            int result = x / 2;
            Console.WriteLine(result);

            double result2 = (double)x / 2;
            Console.WriteLine(result2);
        }

        static void Consoleo()
        {
            //Console.WriteLine("Hi,please tell me your name");

            //string name=Console.ReadLine();
            //string sentence=$"Your name is {name}";
            //Console.WriteLine(sentence);
            Console.WriteLine("Hi,please tell me your age");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            string sentence = $"Your age is {age}";
            Console.WriteLine(sentence);


            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("New Style");
        }
        static void CmparingStrings()
        {
            // string str1 = "abcde";
            //string str2 = "abcde";

            //bool areEqual = str1 == str2;
            //Console.WriteLine(areEqual);

            //string.Equals(str1, str2, StringComparison.Ordinal) ;
            //Console.WriteLine(areEqual);

            string str1 = "Strasse";
            string str2 = "Straße";



            bool areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            Console.WriteLine(areEqual);

            areEqual = string.Equals(str1, str2, StringComparison.InvariantCulture);
            Console.WriteLine(areEqual);

            areEqual = string.Equals(str1, str2, StringComparison.CurrentCulture);
            Console.WriteLine(areEqual);
        }
        static void StringFormat()
        {
            string name = "John";
            int age = 30;

            string str1 = string.Format("My name is {0} and I'm {1}", name, age);
            string str2 = $"My name is {name} and I'm {age}";
            //string str2 = "My name is " + name + "I'm" + age;
            Console.WriteLine(str1);
            Console.WriteLine(str2);


            string str3 = "My name is \nJohn";

            Console.WriteLine(str3);

            string str4 = "I'm \t30";
            Console.WriteLine(str4);

            //differentr operation system
            str3 = $"My name is {Environment.NewLine} John";
            Console.WriteLine(str3);

            string str5 = "I'm John and I'm a \"good\" programmer";
            Console.WriteLine(str5);

            //string str6 = "C:\\tmp\\test_file.txt";
            //Console.WriteLine(str6);

            string str6 = @"C:\tmp\test_file.txt";
            Console.WriteLine(str6);

            int answer = 42;
            string result1 = string.Format("{0:d}", answer);
            string result2 = string.Format("{0:d4}", answer);

            Console.WriteLine(result1);
            Console.WriteLine(result2);

            result1 = string.Format("{0:f}", answer);
            result2 = string.Format("{0:f4}", answer);

            Console.WriteLine(result1);
            Console.WriteLine(result2);


            double answer1 = 42.3;
            string result3 = string.Format("{0:f}", answer1);
            string result4 = string.Format("{0:f4}", answer1);
            Console.WriteLine(result3);
            Console.WriteLine(result4);

            double answer2 = 42.08;
            string result5 = string.Format("{0:f}", answer2);
            string result6 = string.Format("{0:f1}", answer2);
            Console.WriteLine(result5);
            Console.WriteLine(result6);

            Console.OutputEncoding = Encoding.UTF8;

            double money = 12.8;
            result1 = string.Format("{0;C}", money);
            result2 = string.Format("{0;C2}", money);

            result2 = $"{ money:C2}";

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            //Console.WriteLine(money.ToString("C"));
            ///Console.WriteLine(result);


        }
        static void StringBuilderDemo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John ");
            sb.AppendLine("!");
            sb.AppendLine("Hello!");


            string str = sb.ToString();
            Console.WriteLine(str);

        }
        static void StringModification()
        {
            string nameConcat = string.Concat("My", "name", "is", "John");
            Console.WriteLine(nameConcat);

            nameConcat = "My" + "name" + "is" + "Joihn";
            Console.WriteLine(nameConcat);

            nameConcat = string.Join(" ", "My", "name", "is", "John");
            Console.WriteLine(nameConcat);

            //string newName =
            nameConcat = nameConcat.Insert(0, "By the way, ");
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Remove(0, 1);
            Console.WriteLine(nameConcat);

            string replaced = nameConcat.Replace('n', 'z');
            Console.WriteLine(replaced);

            string data = "12;28;34;64";
            string[] spliData = data.Split(';');
            string first = spliData[0];
            Console.WriteLine(first);

            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]);
            Console.WriteLine(nameConcat[0]);

            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);

            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);

            string john = "My name is John";
            Console.WriteLine(john.Trim());


        }
        static void StringEmptyliness()
        {

            string str = string.Empty; //same as ""

            string empty = "";
            string whiteSpaced = " ";
            string noeEmpty = "b";
            string nullString = null;

            Console.WriteLine("IsNull0rEmpty");
            bool IsNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(IsNullOrEmpty);

            IsNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(IsNullOrEmpty);

            IsNullOrEmpty = string.IsNullOrEmpty(noeEmpty);
            Console.WriteLine(IsNullOrEmpty);

            IsNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(IsNullOrEmpty);

            Console.WriteLine();
            Console.WriteLine("IsNullOrWhiteSpace");

            bool IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(IsNullOrWhiteSpace);

            IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpaced);
            Console.WriteLine(IsNullOrWhiteSpace);

            IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(noeEmpty);
            Console.WriteLine(IsNullOrWhiteSpace);

            IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(IsNullOrWhiteSpace);


        }
        static void QueryingStrings()
        {
            string name = new string("abracadabra");
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('E');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            bool endsWithAbra = name.EndsWith("abra");
            Console.WriteLine(endsWithAbra);

            bool startsWithAbra = name.StartsWith("abra");
            Console.WriteLine(startsWithAbra);

            int index0fA = name.IndexOf('a', 1);
            Console.WriteLine(index0fA);

            int lastIndexOfR = name.LastIndexOf('r');
            Console.WriteLine(lastIndexOfR);

            Console.WriteLine(name.Length);

            string subtsr = name.Substring(5);
            string subtsrFromTo = name.Substring(0, 3);

            Console.WriteLine(subtsr);
            Console.WriteLine(subtsrFromTo);

        }
        static void StaticAndInstanceMembers()
        {
            string name = new string("abaracadabra");
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('E');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            string abc = string.Concat("a", "b", "c");
            Console.WriteLine(abc);

            Console.WriteLine(int.MinValue);

            int x = 1;
            string xstr = x.ToString();
            Console.WriteLine(xstr);
            Console.WriteLine(x);

        }
        static void ComparisonOperators()
        {
            int x = 1;
            int y = 2;

            bool areEqual = x == y;
            Console.WriteLine(areEqual);

            bool result = x > y;
            Console.WriteLine(result);

            result = x >= y;
            Console.WriteLine(result);

            result = x <= y;
            Console.WriteLine(result);

            result = x < y;
            Console.WriteLine(result);

            result = x != y;
            Console.WriteLine(result);
        }
        static void MathOperations()
        {
            int x = 1;
            int y = 2;
            int z = x + y;
            int k = x - y;
            int a = z + k - y;

            Console.WriteLine(z);
            Console.WriteLine(k);
            Console.WriteLine(a);

            int b = z * 2;
            int c = k / 2;

            Console.WriteLine(b);
            Console.WriteLine(c);

            a = 4 % 2;
            b = 5 % 2;

            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 3;
            a = a * a;
            //=a*a*a;
            Console.WriteLine(a);

            a = 2 + 2 * 2;
            Console.WriteLine(a);
            a *= 2;
            //a = a * 2;

            Console.WriteLine(a);
            a /= 2;
            //a = a / 2;
            Console.WriteLine(a);
        }
        static void IncrementDecrement()

        {
            int x = 1;
            x = x + 1;

            Console.WriteLine(x);

            x++;
            Console.WriteLine(x);


            ++x;
            Console.WriteLine(x);


            x = x - 1;
            x--;
            --x;
            Console.WriteLine(x);

            Console.WriteLine("Learn about increments");
            Console.WriteLine($"Last x state is {x}");

            int j = x++;
            Console.WriteLine(j);
            Console.WriteLine(x);

            j = ++x;
            Console.WriteLine(j);
            Console.WriteLine(x);

            x += 2;
            //x=x+2;

            Console.WriteLine(x);
            j -= 2;
            //j=j-2;
            Console.WriteLine(j);
        }
        static void Overflow()
        {
            //checked 
            //{ 
            uint x = uint.MaxValue;

            Console.WriteLine(x);

            x = x + 1;

            Console.WriteLine(x);

            x = x - 1;

            Console.WriteLine(x);
            //}

        }

        static void Varilablesscope()

        {
            var a = 1;

            {
                var b = 2;

                {
                    var c = 3;


                    Console.WriteLine(b);
                    Console.WriteLine(c);

                }
            }
        }

        static void Literals()
        {
            int x = 0b11;
            int y = 0b1001;
            int k = 0b10001001;
            int m = 0b1000_1001;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);

            x = 0x1F;
            y = 0xFF0D;
            k = 0x1FAB30EF;
            m = 0x1FAB_30EF;

            Console.WriteLine();

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);

            Console.WriteLine();


            Console.WriteLine(4.5e2);
            Console.WriteLine(3.1E-1);

            Console.WriteLine();

            Console.WriteLine('\x78');
            Console.WriteLine('\x5A');

            Console.WriteLine('\u0420');
            Console.WriteLine('\u0421');
        }

        static void Variables()

        {
            int x = -1;

            int y;
            y = 2;

            //Int32 x1 = -1;

            //uint z = -1;

            float f = 1.1f;

            double d = 2.3;

            int x2 = 0;
            int x3 = new int();

            var a = 1;
            var b = 1.2;

            //Dictionary<int, string> = new Dictionary<int,
            var dict = new Dictionary<int, string>();

            //var v;

            decimal money = 3.0m;

            char character = 'A';

            string name = "Jomh";

            bool canDrive = true;
            bool canDraw = false;

            object obj1 = 1;
            object obj2 = "obj2";

            Console.WriteLine(a);
            Console.WriteLine(name);




        }
    }
}