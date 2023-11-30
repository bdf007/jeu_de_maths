// See https://aka.ms/new-console-template for more information
using System;
using System.Dynamic;

namespace jeu_de_maths
{
    class Program
    {
        enum e_Operateur
        {
            ADDITION = 1,
            MULTIPLICATION = 2,
            SOUSTRACTION = 3,
        }
        static bool PoserQuestion(int min, int max)
        {
            int reponseInt = 0;
            Random generateurNb = new Random();
            
            
            int nb1 = generateurNb.Next(min, max + 1);
            int nb2 = generateurNb.Next(min, max + 1);
            e_Operateur operateur = (e_Operateur)generateurNb.Next(1, 4);
            string question;
            int resultatAttendu;
           /* if(operateur == e_Operateur.ADDITION)
            {
                question =$"{nb1} + {nb2} = ";
                resultatAttendu = nb1 + nb2 ;
            }
            else if (operateur == e_Operateur.SOUSTRACTION)
            {
                question =$"{nb1} - {nb2} = ";
                resultatAttendu = nb1 - nb2 ;
            }
            else if (operateur == e_Operateur.MULTIPLICATION)
            {
               question =$"{nb1} * {nb2} = ";
                resultatAttendu = nb1 * nb2 ;
            }
            else
            {
                Console.WriteLine("Opérateur inconnu");
                return false;
            }*/

            switch (operateur)
            {
                case e_Operateur.ADDITION:
                    question = $"{nb1} + {nb2} = ";
                    resultatAttendu = nb1 + nb2;
                    break;
                case e_Operateur.SOUSTRACTION:
                    question = $"{nb1} - {nb2} = ";
                    resultatAttendu = nb1 - nb2;
                    break;
                case e_Operateur.MULTIPLICATION:
                    question = $"{nb1} * {nb2} = ";
                    resultatAttendu = nb1 * nb2;
                    break;
                default:
                    Console.WriteLine("Opérateur inconnu");
                    return false;
            }
            while(true)
            {
                Console.Write(question);
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
            if (reponseInt == resultatAttendu )
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
            const int NB_QUESTIONS = 5;
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

