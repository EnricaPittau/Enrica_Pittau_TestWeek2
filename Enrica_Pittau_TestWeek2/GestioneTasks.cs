using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Enrica_Pittau_TestWeek2.Entities;

namespace Enrica_Pittau_TestWeek2
{
    internal class GestioneTasks
    {
        
        public static int VerificaInputIntero()
        {
            int valoreIntero;
            bool conversion = Int32.TryParse(Console.ReadLine(), out valoreIntero);
            while (!conversion || valoreIntero < 0)
            {
                Console.WriteLine("Inserisci un valore corretto");
                conversion = Int32.TryParse(Console.ReadLine(), out valoreIntero);
            }
            return valoreIntero;
        }
        public static TasksUtente InserimentoNuovoTasks()//Un nuovo task può essere aggiunto solo se la sua data di scadenza è posteriore alla data di inserimento del task
        {
            //while (true)
            //{
            //    if (DateTime.Now )
            //    {

            //    }
            //}
            TasksUtente task1 = new TasksUtente();

            Console.WriteLine("Inserisci descrizione");
            task1.Descrizione = Console.ReadLine();
            Console.WriteLine("Inserisci DataPrimoInserimento");
            DateTime.TryParse(Console.ReadLine(), out DateTime dataPrimoInserimento);
            Console.WriteLine("Inserisci scadenza");
            DateTime.TryParse(Console.ReadLine(), out DateTime scadenza);
            Console.WriteLine("Inserisci livello di priorità: basso, medio o alto");
            task1.LivelloPriorità = Console.ReadLine();
            
            return task1;
        }
        public static void StampaTasks(ArrayList elencoTasks)
        {
            foreach (TasksUtente task1 in elencoTasks)
            {
                StampaTasks(elencoTasks);
            }
        }
 
        public static void RimuoviTask(ArrayList elencoTasks)
        {          
            TasksUtente TaskDaCancellare = CercaTask(elencoTasks);
            if (TaskDaCancellare != null)
            {
                elencoTasks.Remove(TaskDaCancellare);
                Console.WriteLine("Cancellazione avvenuta con successo");
            }
            else
            {
                Console.WriteLine("Task non trovato");
            }
        }

        public static TasksUtente CercaTask(ArrayList elencoTasks)
        {
                Console.Write("Inserisci descrizione: ");
                string descrizione = Console.ReadLine();

                foreach (TasksUtente task1 in elencoTasks)
                {
                    
                    if (task1.Descrizione.Equals(descrizione))
                    {
                        return task1; 
                    }
                }
                return null;
        }
        public static TasksUtente FiltraTask(ArrayList elencoTasks)
        {
            Console.Write("Inserisci priorità: ");
            string livelloPriorità = Console.ReadLine();

            foreach (TasksUtente task1 in elencoTasks)
            {
                if (task1.LivelloPriorità == livelloPriorità)              
                {
                   
                    Console.WriteLine($"I task con priorità {livelloPriorità} sono queste: {task1.Descrizione}");
                }
            }
            return null;
        }



    }
}
