// ----------------- 1 задание ----------------------

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeWork1
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите символы: ");
//            char input;
//            int spaceCount = 0;
//            do
//            {
//                input = Console.ReadKey().KeyChar;
//                if (input == ' ')
//                    spaceCount++;
//            }
//            while (input != '.');

//            Console.WriteLine("Количество введеных пробелов: " + spaceCount);

//        }
//    }
//}

// ----------------- 2 задание ----------------------

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeWork2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите 6 значный билет");
//            try
//            {
//                string sticket = Console.ReadLine();
//                if (sticket.Length < 0 && sticket.Length > 6)
//                {
//                    throw new IndexOutOfRangeException();
//                }
//                int Iticket = Convert.ToInt32(sticket);
//                Console.WriteLine((Convert.ToInt32(Convert.ToString(sticket)[0].ToString()) +
//                                   Convert.ToInt32(Convert.ToString(sticket)[1].ToString()) +
//                                   Convert.ToInt32(Convert.ToString(sticket)[2].ToString())) ==
//                                  (Convert.ToInt32(Convert.ToString(sticket)[3].ToString()) +
//                                   Convert.ToInt32(Convert.ToString(sticket)[4].ToString()) +
//                                   Convert.ToInt32(Convert.ToString(sticket)[5].ToString()))
//                    ? "Билет счастливый"
//                    : "Билет не является счастливым");
//            }
//            catch (Exception)
//            {
//                Console.WriteLine("Завершение программы");
//                Environment.Exit(0);
//            }
//        }
//    }
//}

// ----------------- 3 задание ----------------------

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeWork3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int spaceValue = 0;
//            ConsoleKeyInfo symbol;
//            do
//            {
//                Console.WriteLine("Введите символ для конвертации регистра");
//                Console.WriteLine("Для окончания ввода нажмите ESC ");
//                symbol = Console.ReadKey();
//                Console.WriteLine();
//                Console.Clear();
//                Console.WriteLine("Введенный символ " + symbol.KeyChar);
//                if (char.IsLetter(Convert.ToChar(symbol.KeyChar)))
//                {
//                    if (char.IsUpper(Convert.ToChar(symbol.KeyChar)))
//                    {
//                        Console.WriteLine("Конвертируемый символ " + char.ToLower(Convert.ToChar(symbol.KeyChar)));
//                    }
//                    else
//                    {
//                        Console.WriteLine("Конвертируемый символ " + char.ToUpper(Convert.ToChar(symbol.KeyChar)));
//                    }
//                }





//                //Console.WriteLine("Введенный символ " + Convert.ToInt32(Symbol.KeyChar));

//                //if (Convert.ToInt32(Symbol.KeyChar)>=65&& Convert.ToInt32(Symbol.KeyChar)<=90)
//                //{
//                //    Console.WriteLine("Конвертируемый символ " + Convert.ToChar(Convert.ToInt32(Symbol.KeyChar)+32));
//                //}
//                //if (Convert.ToInt32(Symbol.KeyChar) >= 97 && Convert.ToInt32(Symbol.KeyChar) <= 122)
//                //{
//                //    Console.WriteLine("Конвертируемый символ " + Convert.ToChar(Convert.ToInt32(Symbol.KeyChar) - 32));
//                //}


//                if (Convert.ToInt32(symbol.KeyChar) == 27)
//                {
//                    break;
//                }
//            } while (true);
//        }
//    }
//}


// ----------------- 4 задание ----------------------

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeWork4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Необходимо ввести А и В, причем А<B");
//            try
//            {
//                Console.WriteLine("Введите А");
//                int A = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Введите B");
//                int B = Convert.ToInt32(Console.ReadLine());
//                if (A >= B || A <= 0 || B <= 0)
//                {
//                    Console.WriteLine("Не соблюдено условие А<B либо числа A и B не положительные ");
//                    return;
//                }
//                Console.Clear();
//                for (int i = A; i <= B; i++)
//                {
//                    for (int j = 1; j <= i; j++)
//                    {
//                        Console.Write(i);
//                    }
//                    Console.WriteLine();
//                }
//            }
//            catch (Exception)
//            {
//                Console.WriteLine("Завершение программы");
//                Environment.Exit(0);
//            }
//        }
//    }
//}

// ----------------- 5 задание ----------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Необходимо ввести числом N, причем N>0");
            try
            {
                Console.WriteLine("Введите N");
                string N = Console.ReadLine();
                if (Convert.ToInt32(N) < 0)
                {
                    Console.WriteLine("Не соблюдено условие N>0");
                    return;
                }
                Console.Clear();
                Console.WriteLine("Полученное число");
                for (int i = N.Length - 1; i >= 0; i--)
                {
                    Console.Write(N[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Завершение программы");
                Environment.Exit(0);
            }
            Console.WriteLine();

        }
    }
}