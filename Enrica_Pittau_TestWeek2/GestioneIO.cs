using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Enrica_Pittau_TestWeek2.Entities;

namespace Enrica_Pittau_TestWeek2
{
    internal class GestioneIO
    {
        public static void StampaTasksSuFile(ArrayList elencoTasks)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "tasks.txt");
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (TasksUtente tasksDaStampareSuFile in elencoTasks)
                {
                    
                    sw.WriteLine(tasksDaStampareSuFile);
                }
            }

        }
    }
}
