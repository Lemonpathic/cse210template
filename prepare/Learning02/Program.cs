// C# program to illustrate how  
// to write a file in C# 
using System; 
using System.IO; 
  

class Program { 
    static void Main(string[] args) 
    { 
        // Store the path of the textfile in your system 
        string file = @"C:\Users\goofy\Schooling\Semester 1 (2 Year)\cse210template\prepare\Learning02\Learning02.csproj\Textfile.txt"; 
  
        // To write all of the text to the file 
        string text = "This is some text."; 
        File.WriteAllText(file, text); 
  
        // To display current contents of the file 
        Console.WriteLine(File.ReadAllText(file)); 
        Console.WriteLine(); 
  
        // To write text to file line by line 
        string[] textLines1 = { "This is the first line",  
            "This is the second line", 
            "This is the third line" }; 
  
        File.WriteAllLines(file, textLines1); 
  
        // To display current contents of the file 
        Console.WriteLine(File.ReadAllText(file)); 
  
        // To write to a file using StreamWriter 
        // Writes line by line 
        string[] textLines2 = { "This is the new first line", 
            "This is the new second line" }; 
  
        using(StreamWriter writer = new StreamWriter(file)) 
        { 
            foreach(string ln in textLines2) 
            { 
                writer.WriteLine(ln); 
            } 
        } 
        // To display current contents of the file 
        Console.WriteLine(File.ReadAllText(file)); 
  
        Console.ReadKey(); 
    } 
}