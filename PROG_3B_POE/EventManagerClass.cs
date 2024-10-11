using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_3B_POE
{
    public class EventManagerClass
    {
        // Centralized list to manage events across the application
        public static List<EventsList> EventsList { get; set; } = new List<EventsList>();
    }
}
