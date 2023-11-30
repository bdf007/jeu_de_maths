// See https://aka.ms/new-console-template for more information
using System;
using System.Dynamic;

namespace jeu_de_maths
{
    class Program
    {

        static bool PoserQuestion(int min, int max)
        {
            int reponseInt = 0;
            Random generateurNb = new Random();
            
            
                int nb1 = generateurNb.Next(min, max + 1);
                int nb2 = generateurNb.Next(min, max + 1);
            while(true)
            {
                Console.Write($"{nb1} + {nb2} = ");
            string reponse = Console.ReadLine();
                try
                {
                    reponseInt = int.Parse(reponse);
                    break;
                }
                catch
                {
                    Console.WriteLine("Erreur: Vous devez rentrer un nombre");
                }
            }
            if (reponseInt == nb1 + nb2)
            {
                return true;
            }
            else
            {
                 return false;
            }
            
            
        }
        static void Main(string[] args)
        {

            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            const int NB_QUESTIONS = 10;
            int score=0;
            for (int i = 0; i < NB_QUESTIONS; i++)
            {
                Console.WriteLine($"Question {i + 1}/{NB_QUESTIONS}");
                if (PoserQuestion(NOMBRE_MIN, NOMBRE_MAX))
                {
                    Console.WriteLine("Bravo");
                    score++;
                }
                else
                {
                    Console.WriteLine("Mauvaise Réponse");
                }
                Console.WriteLine();

            }
            Console.WriteLine($"Votre score est de {score}/{NB_QUESTIONS}");
            int moyenne = NB_QUESTIONS/2;
            if(score == NB_QUESTIONS)
            { 
                Console.WriteLine("Excellent");
            }
            else if (score == 0)
            {
                Console.WriteLine("Révisz vos maths");
            } 
            else if(score > moyenne)
            {
                Console.WriteLine("Pas Mal");
            }
            else
            {
                Console.WriteLine("Peut mieux faire");
            }

        }
    }
}

