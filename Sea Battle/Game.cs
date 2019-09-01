using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_Battle
{
    partial class Game
    {
        protected string InputStr;

        public Game()
        {

        }

        static void Selection()
        {
            string selection = Console.ReadLine();
            switch (selection.ToUpper())
            {
                case "Y":
                    Console.WriteLine("\n Удачной игры :3\n");
                    Matrix();
                    break;
                case "N":
                    Console.WriteLine("\n Ууу, ну хорошо, буду ждать вас ^_^");
                    break;
                default:
                    Console.WriteLine("\n Не расстраивай Харуку-тян, нажимай правильные клавиши.");
                    Selection();
                    break;
            }
        }

        public string Input
        {
            get { return InputStr; }
            set
            {
                // Здесь value на самом деле имеет тип string.
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                    InputStr = value;
            }
        }
        /// <summary>
        /// Объявление матрицы (поля для игры)
        /// </summary>
        static void Matrix()
        {
            Console.WriteLine("\n Введите размер поля через запятую или пробел\n");
            int x = int.Parse(Console.ReadLine()) + 2;
            int y = int.Parse(Console.ReadLine()) + 2;
            Console.Clear();
            char[] alpha = " АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();

            Console.WriteLine("\n");
            // A rectangular MD array.
            string[,] myMatrix;
            myMatrix = new string[x, y];

            // Populate (3 * 4) array.
            /*   for (int i = 1; i < x; i++)
               {
                   for (int j = 1; j < y; j++)
                   {
                       myMatrix[i, j] = ((i+1) + j).ToString();
                   }
               }*/

            for (int j = 1; j < y - 1; j++)
            {
                myMatrix[0, j] = alpha[j].ToString();
            }

            for (int i = 1; i < x - 1; i++)
            {
                myMatrix[i, 0] = alpha[i].ToString();
            }

            for (int i = 1; i < x - 1; i++)
            {
                for (int j = 1; j < y - 1; j++)
                {
                    myMatrix[i, j] = "_";
                }
            }


            // Print (3 * 4) array.
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine("\n");
            }
            Console.WriteLine();
        }

        static void Print(string[] arr)
        {
            Console.Title = "Sea Battle";
            Console.WindowWidth = 84;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.White;
            foreach (string line in arr)
            {
                Console.WriteLine(line);
            }
            Selection();
            Console.ReadLine();
        }

        public virtual void PassAndReceive()
        {
            string[] arr = new[]
            {
                   " Добрый день!",
                   " Как чувствуете себя? Не хотите ли сыграть?\n",
                   " Конечно! {Y}",
                   " Нет, в следующий раз. {N}"
            };
            Print(arr);
        }
    }
}
