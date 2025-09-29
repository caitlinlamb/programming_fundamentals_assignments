using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_fundamentals_assignments
{
    internal class Pump
    {
        private string status = "avail"; // field
        public string Status   // property
        {
            get { return status; }
            set { status = value; }
        }
    

        public Pump()
        {

        }
            
        public void fuel(Object pump_timer)
        {
            status = "busy ";
            pump_timer.Start();
            if (pump_timer.Elapsed == )
            
            
        } 
    
        }
    }

