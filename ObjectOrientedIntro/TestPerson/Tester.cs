using ObjectOrientedIntro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPerson {
    class Tester {
        /*
        * A class can have a main method. This means that when the program is run,
        * the main method will be the first thing to start. Here I use it to call
        * Person.
        */
        static void Main(string[] args) {
            
            /*
             * Here I am simply declaring the object person1. I have not instanted
             * this object yet but what I have done is reserve a place in memmory
             * of the person1 object. Currently its value is null
             */
            Person person1;
            /*
             * Remember where I wrote public Person()? This is where I call that
             * constructor so that I can set that null value to an instance of 
             * Person.
             */
            person1 = new Person();
            /*
             * Now I am setting the values to the the person1 object and calling
             * their appropriate getters and outputting them on the console
             */
            person1.setName("Preston Johnston");
            Console.WriteLine("Name: {0}", person1.getName());
            Console.WriteLine("Continue?");
            Console.ReadLine();

            person1.setAge(24);
            Console.WriteLine("Age: {0}", person1.getAge());
            Console.WriteLine("Continue?");
            Console.ReadLine();

            person1.setGender(Gender.Male);
            //Console.WriteLine("Gender: {0}", person1.getGender());
            Console.WriteLine("Continue?");
            Console.ReadLine();

            /*
             * That was fun and all but calling all those set methods was so
             * exhausting. Lets try this again but with the other constructor.
             * This way, all the values are set so we can call them.
             */
            Person person2 = new Person("Robert Watson", 24, Gender.Male);
            Console.WriteLine("Name: {0}", person2.getName());
            Console.WriteLine("Continue?");
            Console.ReadLine();

            Console.WriteLine("Age: {0}", person2.getAge());
            Console.WriteLine("Continue?");
            Console.ReadLine();

            //Console.WriteLine("Gender: {0}", person2.getGender());
            Console.WriteLine("Continue?");
            Console.ReadLine();

            /*
             * Now go back to the Person class and see if you can add a color 
             * attribute with its appropriate setters and getters. Also,
             * create a new constructor that supports name, age, 
             * gender and the color property you created. Then output them in
             * the console.
             */

        }
    }
}
