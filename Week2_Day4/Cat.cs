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
            //default constructor because it takes no 
            //parameters in the parentheses
        }

        public Cat(string name, int age, string furColor) //overloading a constructor. assigning values right away.
        {
            this.name = name;
            this.age = age;                 //Constructor is a type of method!
            this.furColor = furColor;
            //field         parameter
        }

        //Methods

        public void Eat()
        {
            if(isHungry) // same as if(isHungry == true)
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry? " + isHungry);

        }

        public void WorkOut()
        {
            if (isHungry == false)
            {
                isHungry = true;
            }
            Console.WriteLine("The cat worked out. Hungry now? " + isHungry);
        }

    }
}
