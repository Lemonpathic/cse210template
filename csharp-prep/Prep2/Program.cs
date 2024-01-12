using System;

class Grade
{
    private int _grade;
    private string letterGrade;
    public int _Grade{
        get{ return _grade; }
        set{
            if(value <= 0){
                throw new ArgumentException("Invalid Grade");
            }
            _grade = value;
            getLetterGrade(_grade);
            System.Console.WriteLine($"The letter grade for {_grade} is {letterGrade}!");
        }

    }
 private void getLetterGrade(int value)
    {
        if (value >= 90)
        {
            letterGrade = "A";
        }
        else if (value >= 80)
        {
            letterGrade = "B";
        }
        else if (value >= 70)
        {
            letterGrade = "C";
        }
        else if (value >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string input = "0";

        while(input != "2"){

            System.Console.WriteLine("Choose an option:\n[1] Add a new grade\n[2] Quit");
            input = Console.ReadLine();
            
            if(input == "1"){
                
                System.Console.WriteLine("Enter a percentage");
                string percentage = Console.ReadLine();

                if(int.TryParse(percentage, out int parsedVal)){
                    Grade grade = new Grade();
                    grade._Grade = parsedVal;
                }
                else{
                    System.Console.WriteLine("Invalid Grade entered");
                }

            }
            else if(input == "2"){
                System.Console.WriteLine("Quitting...");
                break;
            }
            else{
                System.Console.WriteLine("This input is not recognized Bryan Wilson try again");
            }
            
        }
    }
}