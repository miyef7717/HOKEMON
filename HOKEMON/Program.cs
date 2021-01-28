using System;
using System.Collections.Generic;
using System.Text;


namespace Hokemon
{​​​​​​
    class BattleArena
    {​​​​​​​
        public void Talk(hokemon Talker)
        {​​​​​​​
            Console.WriteLine("Hello my name is {​​​​​​​0}​​​​​​​", Talker.Name);
        }​​​​​​​


        public void startABattle(hokemon object01, hokemon object02)
        {​​​​​​​
            Console.WriteLine("{​​​​​​​0}​​​​​​​: I want a battle", object01.Name);
            Console.WriteLine("{​​​​​​​0}​​​​​​​: I accept", object02.Name);
            Console.WriteLine("{​​​​​​​0}​​​​​​​: Says I have an attack of {​​​​​​​2}​​​​​​​\n I don't care I can defend with {​​​​​​​3}​​​​​​​!!", object01.Name, object02.Name, object01.attackCalculator(), object02.defenceCalculator()
                );
        }​​​​​​​
    }​​​​​​​
}​​​​​​​



namespace Hokemon
{​​​​​​​
    class hokemon
    {​​​​​​​
        // MEMBERS - All Attributes, Methods and Properties are MEMBERS of this CLASS


        // VARIABLES a.k.a ATTRIBUTES inside a class can also be refered to as FIELDS
        private string name;
        private int health;
        private int max_health;
        private int attack;
        private int speed;
        private int defense;


        // PROPERTIES
        // PROPERTIES are a combination of a field and method - this keeps variables / attributes PRIVATE
        // and allows us to perform checks on what is input
        public string Name         // Notice PROPERTY has no parenthesis its identifier unlike the METHODS below
        {​​​​​​​
            get {​​​​​​​ return name; }​​​​​​​
            set {​​​​​​​ name = value; }​​​​​​​
        }​​​​​​​
        public int Health         // Health PROPERTY this is public keeping the 'health' 
        {​​​​​​​
            get {​​​​​​​ return health; }​​​​​​​
            set {​​​​​​​ health = value; }​​​​​​​
        }​​​​​​​


        // METHODS
        public hokemon()  // CONSTRUCTOR method 
        {​​​​​​​
            provide_name();
            max_health = 100;
            health = random_int_generator(10, max_health);
            attack = random_int_generator(10, 100);
            speed = random_int_generator(10, 100);
            defense = random_int_generator(10, 100);


        }​​​​​​


        public void get_details()
        {​​​​​​​
            Console.WriteLine("\n\n************\nName: {​​​​​​​0}​​​​​​​\nHealth: {​​​​​​​1}​​​​​​​/{​​​​​​​2}​​​​​​​\nAttack: {​​​​​​​3}​​​​​​​\nSpeed: {​​​​​​​4}​​​​​​​\nDefense: {​​​​​​​5}​​​​​​​\n**********\n", name, health, max_health, attack, speed, defense);
        }​​​​​​​         // get_details METHOD 


        public void provide_name()
        {​​​​​​​
            Console.WriteLine("Enter a name for your Hokemon: ");
            name = Console.ReadLine();
        }​​​​​​​


        public int random_int_generator(int min_value, int max_value) // PARAMETERS int min_value, int max_value
        {​​​​​​​
            Random rnd = new Random(); // INSTANTIATING the rnd object from the RANDOM class 


            int randomValue;


            randomValue = rnd.Next(min_value, max_value);


            return randomValue;
        }​​​​​​​


        public int attackCalculator()
        {​​​​​​​
            int attackValue;
            Random rnd = new Random();
            attackValue = ((attack * speed) / 2) * rnd.Next(0, 2); //


            return attackValue;
        }​​​​​​​
        public int defenceCalculator()
        {​​​​​​​
            int defenceValue;
            Random rnd = new Random();


            defenceValue = (defense * speed) / 10 * rnd.Next(0, 2);


            return defenceValue;
        }​​​​​​​
    }​​​​​​​
}​​​​​​​
 






















