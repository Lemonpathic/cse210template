namespace Learning04;

public class Person
{
    private string id;
    private string name;

    
    

    protected Person(string id, string name)
    {
        this.id = id;
        this.name = name;
        
    }

    protected string DisplayInfo()
    {
        return $"{name}: {id}";
    }
}

public class Student : Person
{
    private string major;

    public Student(string id, string name, string major) : base(id,name)
    {
        this.major = major;
    }

    public void Display()
    {
        Console.WriteLine($"{DisplayInfo()} - {major}");
    }
    
}

