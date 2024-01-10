using System;

class Person{
    private string _firstName;
    private string _lastName;
    public string firstName{
        get {return _firstName; }
        set {
            if (!string.IsNullOrWhiteSpace(value)){
                _firstName = value;
            }
            else{
                System.Console.WriteLine("The name cannot be blank");
            }
            }
    }
     public string lastName{
        get {return _lastName; }
        set {
            if (!string.IsNullOrWhiteSpace(value)){
                _lastName = value;
            }
            else{
                System.Console.WriteLine("The name cannot be blank");
            }
            }
    }
        public void doTheBondThing(){
            System.Console.WriteLine();
            Console.WriteLine($"Your name is {_lastName}, {_lastName} {_firstName}");
        }
    }

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();

        System.Console.WriteLine("What is your first name?");
        person.firstName = Console.ReadLine();
        System.Console.WriteLine("What is your last name?");
        person.lastName = Console.ReadLine();

        person.doTheBondThing();

    }
}