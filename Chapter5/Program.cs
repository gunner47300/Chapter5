using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            Excercise1();
            Excercise2();
            Excercise3();
            Excercise4();
            Excercise5();
            Excercise6();
            Excercise7();
            Excercise8();
            Excercise9();
            Excercise10();
            Excercise11();
        }


        static void Excercise1()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine("{0}\t{1}", a, b);
            }
        }

        static void Excercise2()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0) Console.WriteLine("0");
            else
            {
                if (a < 0) a = 1;
                else a = 0;

                if (b < 0) a += 1;                
                if (c < 0) a += 1;

                Console.WriteLine(a % 2 == 0 ? "+" : "-");
            }

            

        }

        static void Excercise3()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a < b)
            {
                if (b<c)
                {
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }
            else
            {
                if (a < c)
                {
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(a);
                }
            }
        }

        static void Excercise4()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double buffor;

            if(a>b)
            {
                if (a > c) { }
                else
                {
                    buffor = a;
                    a = c;
                    c = buffor;
                }
                if (b > c) { }
                else
                {
                    buffor = b;
                    b = c;
                    c = buffor;
                }           
            }
            else
            {
                if (b > c)
                {
                    buffor = a;
                    a = b;
                    b = buffor;
                }
                else
                {
                    buffor = a;
                    a = c;
                    c = buffor;
                }
                if (b > c) { }
                else
                {
                    buffor = b;
                    b = c;
                    c = buffor;
                }
            }
            Console.WriteLine("\t{0}\t{1}\t{2}", a, b, c);
        }

        static void Excercise5()
        {
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;

            }


        }

        static void Excercise6()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double delta = (b * b) - (4 * a * c);
            Console.WriteLine(delta);

            if(delta>0)
            {
                Console.WriteLine("x1 = {0}\tx2 = {1}",(-b - Math.Sqrt(delta)) / (2 * a), (-b + Math.Sqrt(delta)) / (2 * a));
            }
            else if(delta==0)
            {
                Console.WriteLine("x1= {0}", -b / 2 * a);
            }
            else
            {
                Console.WriteLine("Real roots doesnt exist.");
            }
        }

        static void Excercise7()
        {
            int[] numbers = new int[5];

            for(int i = 0; i < 5; i++)
            {
                numbers[i]= int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < 5; i++)
            {
                if (numbers[i] < numbers[i - 1]) numbers[i] = numbers[i - 1];
            }

            Console.WriteLine(numbers[4]);


        }

        static void Excercise8()
        {
            string a = Console.ReadLine();
            double b;
            bool isItNumberorString = double.TryParse(a, out b);

            switch (isItNumberorString)
            {
                case true:
                    Console.WriteLine(b + 1);
                    break;
                case false:
                    Console.WriteLine(a + "*");
                    break;
                default:
                    Console.WriteLine("Always use default statement!");
                    break;
            }
        }

        static void Excercise9()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int howMany = 0;

            if (a == 0) howMany++;
            if (b == 0) howMany++;
            if (c == 0) howMany++;
            if (d == 0) howMany++;
            if (e == 0) howMany++;

            if (a + b == 0) howMany++;
            if (a + c == 0) howMany++;
            if (a + d == 0) howMany++;
            if (a + e == 0) howMany++;
            if (b + c == 0) howMany++;
            if (b + d == 0) howMany++;
            if (b + e == 0) howMany++;
            if (c + d == 0) howMany++;
            if (c + e == 0) howMany++;
            if (d + e == 0) howMany++;

            if (a + b + c == 0) howMany++;
            if (a + c + d == 0) howMany++;
            if (a + b + e == 0) howMany++;
            if (a + c + d == 0) howMany++;
            if (a + c + e == 0) howMany++;
            if (a + d + e == 0) howMany++;
            if (b + c + d == 0) howMany++;
            if (b + c + e == 0) howMany++;
            if (c + d + e == 0) howMany++;
            if (b + d + e == 0) howMany++;

            if (a + b + c + d == 0) howMany++;
            if (a + b + c + e == 0) howMany++;
            if (a + b + d + e == 0) howMany++;
            if (a + c + d + e == 0) howMany++;
            if (b + c + d + e == 0) howMany++;

            if (a + b + c + d + e == 0) howMany++;

            Console.WriteLine("There is {0} subsets whose sum is 0.",howMany);
        }

        static void Excercise10()
        {
            int score = int.Parse(Console.ReadLine());

            if (1 <= score && score <= 3) Console.WriteLine("Score is: {0}", score * 10);
            else if (4 <= score && score <= 6) Console.WriteLine("Score is: {0}", score * 100);
            else if (7 <= score && score <= 9) Console.WriteLine("Score is: {0}", score * 1000);
            else Console.WriteLine("Error");
        }

        static void Excercise11()
        {
            int a = int.Parse(Console.ReadLine());
            int b = a % 10;
            int c = (a / 10) % 10;
            int d = (a / 100) % 10;
            string  answer="";

            if (d != 0) answer = string.Format("{0} hundert ",NameNumber(d));
            if (10 * c + b > 19) answer += NameNumberDecimal(c) + " ";
            else if (10 * c + b < 20 && 10 * c + b > 9) answer += NameNumberTeen(b);
            if(!(10 * c + b < 20 && 10 * c + b > 9)) answer += NameNumber(b);
            if (a + b + c == 0) answer = "zero";
            answer = answer.First().ToString().ToUpper() + answer.Substring(1);
            Console.WriteLine(answer);


        }

        static string NameNumberDecimal(int a)
        {
            string answer="";
            switch (a)
            {
                case 2:
                    answer = "twenty";
                    break;
                case 3:
                    answer = "thirty";
                    break;
                case 4:
                    answer = "fourty";
                    break;
                case 5:
                    answer = "fifty";
                    break;
                case 6:
                    answer = "sixty";
                    break;
                case 7:
                    answer = "seventy";
                    break;
                case 8:
                    answer = "eighty";
                    break;
                case 9:
                    answer = "ninety";
                    break;
                default:
                    answer = "";
                    break;
            }
            return answer;
        }
        static string NameNumber(int a)
        {
            string answer = "";
            switch (a)
            {
                case 1:
                    answer = "one";
                    break;
                case 2:
                    answer = "two";
                    break;
                case 3:
                    answer = "three";
                    break;
                case 4:
                    answer = "four";
                    break;
                case 5:
                    answer = "five";
                    break;
                case 6:
                    answer = "six";
                    break;
                case 7:
                    answer = "seven";
                    break;
                case 8:
                    answer = "eight";
                    break;
                case 9:
                    answer = "nine";
                    break;
                default:
                    answer = "";
                    break;
            }
            return answer;
        }
        static string NameNumberTeen(int a)
        {
            string answer = "";
            switch (a)
            {
                case 0:
                    answer = "ten";
                    break;
                case 1:
                    answer = "eleven";
                    break;
                case 2:
                    answer = "twelve";
                    break;
                case 3:
                    answer = "thirteen";
                    break;
                case 4:
                    answer = "fourteen";
                    break;
                case 5:
                    answer = "fiveteen";
                    break;
                case 6:
                    answer = "sixteen";
                    break;
                case 7:
                    answer = "seventeen";
                    break;
                case 8:
                    answer = "eighteen";
                    break;
                case 9:
                    answer = "nineteen";
                    break;
                default:
                    answer = "";
                    break;
            }
            return answer;
        }
    

    }
}
