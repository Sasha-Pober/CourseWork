using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace CourseWork
{
    class Cuisine 
    {
        public string type { get; set; } 

        public Cuisine(string type)
        {
            this.type = type;
        }
    }

    
}
