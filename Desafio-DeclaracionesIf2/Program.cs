using System;

namespace Desafio_DeclaracionesIf2
{
    internal class Program
    {
        static string CurrentPlayer;
        static int CurrentScore;
        static string OldBest;

        static void Main(string[] args)
        {
            Current();
            Console.Clear();
            Validacion();
        }
        public static void Validacion()
        {
            string BestPlayer = "Nandito";
            int BestScore = 100;

            if (CurrentScore > BestScore)
            {
                OldBest = BestPlayer;
                BestPlayer = CurrentPlayer;
                BestScore = CurrentScore;
                Console.WriteLine("Felicidades {0}, Venciste a {1}. El nuevo Score mas alto es: {2}!", BestPlayer, OldBest, BestScore);
                Console.WriteLine(" ");
                Console.WriteLine("New Best Score.................... {0} | New NickName.................... {1} ", BestScore, BestPlayer);
            }
            else
            {
                Console.WriteLine("Excelente Puntuacion pero no fue suficiente para vencer a {0}", BestPlayer);
                Console.WriteLine(" ");
                Console.WriteLine("Best Score.................... {0} | NickName.................... {1} ", BestScore, BestPlayer);
            }
        }
        public static void Current()
        {
            Console.WriteLine("Ingrese NickName: ");
            CurrentPlayer = Console.ReadLine();
            Console.WriteLine("Ingrese su puntuacion alcanzada: ");
            int.TryParse(Console.ReadLine(), out CurrentScore);
            if (CurrentScore > 0)
            {
                Console.WriteLine("Datos ingresados Correctamente!");
            }
            else
            {
                Console.WriteLine("El Score ingresado no es valido. Favor ingresar un dato numerico unicamente.");

            }
            Console.ReadLine();

        }
    }
}
