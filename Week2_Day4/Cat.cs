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
        private int age;
        private string furColor;
        private bool isHungry = true; //we can set the values of variables in fields


        //Properties (c# specific)
        public string Name
        {
            get { return this.name; } //this going to the program showing us what we want to see
            set { this.name = value; } //this is us changing the value from the program
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
