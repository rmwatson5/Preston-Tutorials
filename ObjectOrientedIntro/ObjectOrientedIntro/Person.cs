using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedIntro {
    /*
     * Below this comment line is a class. The strict definition of a class is
     * that it is an "object" that has attributes, and carries out functions
     * geared for one specific purpose. That is atleast what a class SHOULD be.
     * It is best design principles to keep it that way. Lets look at the
     * properties of a class. I have named this class Person. Now in creating 
     * this class you should think, what is a person? Well, a Person has a name,
     * maybe a phone number, a gender (sometimes), and many other attributes.
     */
    public class Person {
        /*
         * This is a variable (in this case, the variable is a  field). Think of 
         * this as an attribute to a class. When creating fields and such it is
         * best practice to keep in mind the "is a" and "has a" relationship. In 
         * this case, a person "has a" name. The name is a string variable meaning
         * it typically contains a series of characters.
         * 
         * You may have notices the "public" and "private" before the field and the
         * class declaration. These are access modifiers. When I create an instance
         * of this class from another assembly or class, these modifiers tell me what
         * access they have to those variables. For example, another class can 
         * create an instance of Person because it is set to public. However, they
         * cannot see or interact with the variable "_name" because it is set to
         * private. Only the class Person can see or alter "_name". There are four
         * main Access Modifiers: public, private, protected, and internal. Play
         * around with the access modifiers and see what happens when you try to call
         * the variables outside the class
         */
        private string _name;
        private string _phoneNumber;
        private int _age;
        /*
         * Now heres a special field. If you look below the class you will see that I 
         * created an enum called Gender. Enums are great for when you can assign a 
         * specific value to something and nothing else. For example, when I set the
         * _gender variable to this person, they can only be Male or Female but not 
         * both.
         */
        private Gender _gender;

        /*
         * This here is called a constructor. This is used to make instantiate the
         * Person class. When you create an instance of the person class you are only
         * assigning a place in memmory (the runtime stack) but not setting that
         * spot to anything. So the value is null. Without instantiating Person, 
         * you will get a runtime error (exception) when invoking a method (or
         * function) because you are telling that place in memmory null.method().
         * Look in my tester class to see how I instantiate Person.
         */
        public Person() {
        }

        /*
         * Now this may seem confusing. I created another constructor. But look
         * at the parameters. When I want to instantiate Person, I could either
         * use the previous constructor or use this one. This is called overloading.
         */
        public Person(string name, int age, Gender gender) {
            _name = name;
            _age = age;
            _gender = gender;
        }

        public void setName(string name) {
            _name = name;
        }

        public string getName() {
            return _name;
        }

        public void setAge(int age) {
            _age = age;
        }

        public int getAge() {
            return _age;
        }


    }

    public enum Gender {
        Male = 0,
        Female
    }
}
