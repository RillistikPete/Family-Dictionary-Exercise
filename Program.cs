using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){ 
                {"name", "Garren"},
                {"age", "28"}
            });;

            myFamily.Add("Grandmother", new Dictionary<string, string>(){ 
                {"name", "Nanny"},
                {"age", "83"}
            });;

            myFamily.Add("Momma", new Dictionary<string, string>(){ 
                {"name", "Patty"},
                {"age", "61"}
            });;
        
        // Key / Values -- the Key of object is "sister", while the Values are "name" and "age"


            foreach (var item in myFamily){
                Console.WriteLine($"{item.Value["name"]} is my {item.Key} and is {item.Value["age"]} years old.");
            }
            
        }
    }
}
