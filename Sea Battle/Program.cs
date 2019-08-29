using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[]
            {
                                 @" 
                    _           _   _   _           _     _       
                   | |         | | | | | |         | |   (_)      
                   | |__   __ _| |_| |_| | ___  ___| |__  _ _ __  
                   | '_ \ / _` | __| __| |/ _ \/ __| '_ \| | '_ \ 
                   | |_) | (_| | |_| |_| |  __/\__ \ | | | | |_) |
                   |_.__/ \__,_|\__|\__|_|\___||___/_| |_|_| .__/ 
                                                           | |    
                                                           |_|    

                                       |__
                                       |\/
                                       ---
                                       / | [
                                !      | |||
                              _/|     _/|-++'
                          +  +--|    |--|--|_ |-
                       { /|__|  |/\__|  |--- |||__/
                      +---------------___[}-_===_.'____                 /\
                  ____`-' ||___-{]_| _[}-  |     |_[___\==--            \/   _
   __..._____--==/___]_|__|_____________________________[___\==--____,------' .7
  |                                                                     BB-61/
   \_________________________________________________________________________|

                ------------------------------------------------
                   Для продолжения нажмите на любую клавишу...

"
                };

            Console.WindowWidth = 84;
            Console.WriteLine("\n\n");
            foreach (string line in arr)
            Console.WriteLine(line);
            Console.ReadKey();
            Console.Clear();
            Console.Title = "Sea Battle";
            Console.WriteLine();
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Добрый день!");
            Console.WriteLine(" Как чувствуете себя? Не хотите ли сыграть?\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Конечно! {Y}");
            Console.WriteLine(" Нет, в следующий раз. {N} \n");
            Selection();
            Console.ReadLine();
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

        static void Matrix()
        {
            Console.WriteLine("\n Введите размер поля через запятую <,> \n");
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

            for (int j = 1; j < y-1; j++)
            {
                    myMatrix[0, j] = alpha[j].ToString();
            }

            for (int i = 1; i < x - 1; i++)
            {
                myMatrix[i, 0] = alpha[i].ToString();
            }

            for (int i = 1; i < x-1; i++)
            {
                for (int j = 1; j < y-1; j++)
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
    }
}
