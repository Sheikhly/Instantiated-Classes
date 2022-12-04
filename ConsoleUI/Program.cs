using ConsoleUI;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    /*
     * In this App We Want to Take a quick look of How Instantiation Works
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            UserMassages.SayHello();

            PersonModel person = new PersonModel();

            person.firstName = "Sina";

            PersonModel secondperson = new PersonModel();

            secondperson.firstName = "Elahe";

            Console.WriteLine(person.firstName);

            Console.WriteLine(secondperson.firstName);


            Console.ReadLine();
        }
    }
}