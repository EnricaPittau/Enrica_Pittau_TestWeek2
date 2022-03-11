using System;
using System.Collections.Generic;
using System.Text;

namespace Enrica_Pittau_TestWeek2.Entities
{
    internal class TasksUtente
    {
        public string Descrizione { get; set; }
        public DateTime DataPrimoInserimento { get; set; }
        public DateTime Scadenza { get; set; }
        public string LivelloPriorità { get; set; }
        //public string Filtro { get; set; }

        //public string Priorità()
        //{
        //    switch (LivelloPriorità)
        //    {
        //        case "Basso"

        //        default:
        //            break;
        //    }
        //}

    }
}
