# Object-Oriented Programming Summary

# Encapsulation
##Process of wrapping code and data together into a single unit
       class Person
       {
        private string firstName;
        private string lastName;
  
        public Person(string firstName, string lastName)
        {
          this.FirstName = firstName;
          this.LastName = lastName;
        }
  
        public string FirstName
        { 
          get { return this.firstName; } 
          set { this.firstName = value; } 
        }
  
        public string LastName
        { 
          get { return this.lastName; } 
          set { this.lastName = value; } 
        }
      }
_________________________________________________________________________________________________________________________________
# Inheritance
Superclass - Parent class, Base Class - The class giving its members to its child class
                   ^
Subclass - Child class, Derived Class - The class taking members from its base class

      class Animal{
         void Eat();
      }

      class Dog(){
        void Bark();
      }
      static void Main()
      {
        Animal animal = new Animal();
        animal.Eat();
         
        Dog dog = new Dog();
        dog.Bark();
        dog.Eat();
      }

##Virtual Methods – defines a method that can be overriden
public class Animal
{
  public virtual void Eat() { … }
}

public class Dog : Animal
{   
  public override void Eat() {}
}
_________________________________________________________________________________________________________________________________
# Polymorphism
##Ability of an object to take on many forms

public interface IAnimal {}
public abstract class Mammal {}
public class Person : Mammal, IAnimal {}
--> Animal person    = new Person();
    Mammal personOne = new Person();
    
#Types of Polymorphism
-> Runtime polymorphism                Method 
    public class Shape {}              overriding
    public class Circle : Shape {}
    public static void main() {
      Shape shape = new Circle()
    }
>Overriding can take place sub-class.
>Argument list must be the same as that of the parent method
>The overriding method must have same return type
>Access modifier cannot be more restrictive
>Private and static methods can NOT be overriden
>The overriding method must not throw new or broader checked exceptions.

-> Compile time polymorphism
public static void main() {
  int Sum(int a, int b, int c)         Method 
  double Sum(Double a, Double b)       overloading
}

>Overloading can take place in the same class or in its sub-class.
>Constructor can be overloaded
>Overloaded methods must have a different argument list.
>Overloaded method should always be the part of the same class (can also take place in sub class), with same name but different parameters.
>They may have the same or different return types.


#Abstract Classes

>Abstract class can NOT be instantiated
>An abstract class may or may not include abstract methods.
>If it has at least one abstract method, it must be declared abstract
>To use abstract class, you need to extend it

public abstract class Shape
{
    public abstract double CalculatePerimeter();
    public abstract double CalculateArea();
    public virtual string Draw() {...}    
}

public class Rectangle : Shape
{
  public override double CalculatePerimeter() {...}
  public override double CalculateArea() {...}
  public sealed override string Draw() {return base.Draw() + "Rectangle"; }
}
##Keyword - sealed - Modifier that  prevents other classes from inheriting from it
              public abstract class Shape {}
              public sealed class Rectangle : Shape {}
              public class Sqaure : Rectangle {}//Compile time error
              
              public class Rectangle : Shape
              {
                 public sealed override double GetArea() {}
              }
              public class Sqaure : Rectangle 
              {
                 public override double GetArea() {}   //Compile time error
              }
              
##Static classes cannot be instantiated
Math.Abs(-3.14);
Initialization of Static class is just before the first time usage.
Memory Clearance of Static class is On program exit.

Initialization of Non-Static class is when the constructor is called.
Memory Clearance of Non-Static class is By the garbage collector.









