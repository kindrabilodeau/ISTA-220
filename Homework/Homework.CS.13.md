## Kindra Bilodeau
#### C# Homework 13

1. **What is an interface as the term is used on object-oriented programming?**
  - It does not contain any code it just specifies the methods and properties
    that a class that inherits from the interface must provide.
2. **How do you define an interface?**
  - Just as you would a class but instead you use the interface keyword
3. **Can an interface have variables, fields, or properties?**
  - No, an interface can not contain any data
4. **How do you define a method in an interface?**
  - Just as you would in a class but with out using an access modifier
5. **Can you instantiate an object through an interface? Why or why not?**
  - Yes. an interface is still a type. even though it contains no data
6. **Using the new keyword, can you declare a reference to an interface?**
  - yes IFirearm f = new Pistol();
7. **Can an object inherit from multiple interfaces? Can a class implement multiple interfaces? If so, how
can it do so?**
  - Yes they objects and classes both can. It must use all the methods declared by these interfaces,
  if there are more than one, they would be separated by commas in a list.
8. **What does it mean to explicitly implement an interface?**
  - You specify which interface a method belongs to like interface.method
  - type name . method name
9. **What are the restrictions on interfaces?**
  - Not allowed to define any fields in an interface.
  - not allowed to define any constructors in an interface
  - not allowed to define a destructor in an interface (used to destroy an object instance)
  - cannot specify an access modifier for any method (all methods are public)
  - cannot nest any types - enums, structs, classes or interfaces
  - not allowed to inherit form a struct or a class
10. **What is the difference between an abstract class and an interface?**
  - abstract classes can have data and implementation
11. **What is an abstract method?**
  - It does not contain a method body and the derived class must override the method.
12. **What is an sealed class?**
  - Is a class that can not be used as a base class
13. **What is an sealed method?**
  - Any derived classes can not override that method
