using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day4
{
    class Cat
    {
        //STATES
        //fields
        private string name;

        //Properties (c# specific)
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
            // decides if you get access to fields, the private category 
           
        }
        
            
        //BEHAVIORS


        //CONSTRUCTORS

        public Cat()
        {
            //default construction because it takes no 
            //parameters in the parentheses
        }

    }
}
