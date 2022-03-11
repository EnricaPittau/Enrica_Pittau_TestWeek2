using System;
using System.Collections;
using Enrica_Pittau_TestWeek2.Entities;

namespace Enrica_Pittau_TestWeek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Agenda ---");
            ArrayList elencoTasks = new ArrayList();
            bool continua = true;
            //TasksMenu();
            //int scelta = GestioneTasks.VerificaInputIntero();
            while (continua)
            {
                int scelta = TasksMenu();

                switch (scelta)
                {
                 case 1:
                    //Inserimento di un nuovo task
                    elencoTasks.Add(GestioneTasks.InserimentoNuovoTasks());
                    break;
                  case 2:
                    //Stampa tasks
                    GestioneTasks.StampaTasks(elencoTasks);
                    break;
                  case 3:
                    //Rimuovi task
                    GestioneTasks.RimuoviTask(elencoTasks);
                    break;
                    case 4:
                        //Filtra tasks per priorità
                        GestioneTasks.FiltraTask(elencoTasks);
                        break;
                    case 0:
                    continua = false;
                    break;
                        //return continua;
                    default:
                    continua = false;
                    break;
                }
            }
        }
        public static int TasksMenu()
        {
            Console.WriteLine("1. Inserisci tasks");
            Console.WriteLine("2. Stampa tasks utente");
            Console.WriteLine("3. Rimuovi tasks utente");
            Console.WriteLine("4. Filtra per priorità");
            Console.WriteLine("0. Esci");
            Int32.TryParse(Console.ReadLine(), out int scelta);
            return scelta;

        }
    }
}
