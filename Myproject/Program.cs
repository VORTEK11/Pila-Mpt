using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace pila
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1)  Таблица умножения ");
            Console.WriteLine("2)  Угадай число");
            Console.WriteLine("3) Вывод делителей числа ");

            while (true)
            {
                Console.WriteLine("Выберите действие: ");
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Таблица умножения, если вдруг забыли :3 ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\ny/x |   1\t2\t3\t4\t5\t6\t7\t8\t9\t10 ");
                            Console.Write("----------------------------------------------------------------------------------------------");
                            Console.WriteLine();
                            for (int i = 1; i < 11; i++)
                            {
                                Console.Write(i + "   |  ");
                                for (int j = 1; j < 11; j++)
                                {
                                    Console.Write("\t" + i * j);
                                }
                                Console.WriteLine("");
                                Console.WriteLine("");
                                
                            }
                            break;

                        }
                    case 2:
                        {
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Я хочу сыграть в игру. Игра будет в комнате которая не намного больше чем комната где ты провел большую часть своей жизни в аудитории РЭУ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Введите 1ое число: ");
                                int x = int.Parse(Console.ReadLine());
                                Console.Write("Введите 2ое число: ");
                                int y = int.Parse(Console.ReadLine());

                                Random random = new Random();
                                int k = random.Next(x, y);
                                int count = 0;
                                string str;

                                Console.WriteLine("Угадайте число в интервале от {0} до {1}\n", x, y);

                                do
                                {
                                    Console.Write("Ваш вариант: ");
                                    str = Console.ReadLine();

                                    if (int.Parse(str) < k)
                                        Console.WriteLine("Укажите число больше");
                                    if (int.Parse(str) > k)
                                        Console.WriteLine("Укажите число меньше");

                                    count++;
                                }
                                while (int.Parse(str) != k);

                                Console.WriteLine("Вы угадали с {0} попытки", count);
                                Console.ReadLine();
                                break;
                            }
                        }
                    case 3:
                        //тут пусто
                        Console.WriteLine("Продлите подписку оценкой, чтобы в будущем она заработала))");
                        break;
                }
                Console.WriteLine("Повторить? (Y/N)");
                ConsoleKeyInfo e = Console.ReadKey();
                if (e.KeyChar == 'n') break;
                Console.WriteLine();

            }

        }
    }
}