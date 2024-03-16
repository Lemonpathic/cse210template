namespace Develop05;

public abstract class Goal
{
 protected int points;
 protected string name;
 protected string description;

 protected Goal(int points, string name, string description)
 {
  this.points = points;
  this.name = name;
  this.description = description;
 }

 protected Goal()
 {
  
 }
 public abstract string Display();
 public abstract void Export();

 public abstract int Completed();
}