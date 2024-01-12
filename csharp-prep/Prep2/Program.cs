using System;

class Grade
{
    private float _grade;
    private string letterGrade;
    public float _Grade{
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
 private void getLetterGrade(float value)
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
        if (value >= 60 && value < 93){
            char secondIntChar = value.ToString()[1];
            int secondInt = int.Parse(secondIntChar.ToString());
            
            if (secondInt < 3){
                letterGrade += "-";
            }
            else if (secondInt >= 7){
                System.Console.WriteLine(secondInt);
                letterGrade += "+";
            }
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

                if(float.TryParse(percentage, out float parsedVal)){
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