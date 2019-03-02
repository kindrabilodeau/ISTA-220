## Kindra Bilodeau
#### C# Homework 12

1. How does inheritance promote the principle of don’t repeat yourself (DRY)?
  - By only having to create common methods one time and reuse it multiple times
2. What is the syntax of a derived class that inherits from a base class?
  - class derivedclass : baseclass
3. Do all user defined types (classes and structs) inherit from some base class? If so, what is it?
  - all classes derive from System.Object
4. What happens if you do not have a default constructor in a base class when creating a derived class?
  - You have to call the correct base class constructor or you get a compile time error
5. Can you assign a variable of a derived class to another variable of its base class? Why or why not?
  - Yes you can assign a derived class to a base class, because it is a form of the base class ( a horse is a mammal )
6. Can you assign a variable of a derived class to another variable of a derived class of its base class?
Why or why not?
  - No, they are not the same types. Horses are not the same as whales
7. Can you assign a variable of a base class to another variable of a derived class? Why or why not?
  - No, not all mammals are horses
8. Under what circumstances would you want to use the new keyword when defining a method in a
derived class?
  - To hide a method in the base class method and turn the warning off
9. What is a virtual method? Why would you want to define a virtual method?
  -  A method that is intended to be overridden. It provides different implantations of the same method
10. What does override do? Why does it do it?
  - it declares another implementation of that method
11. How do you define an extension type?
  - in an extension method in a static class with a parameter of this keyword and the type
  - using the keyword this. 
12. Why do you define an extension type?
  - To be able to call a function and immediately use it with your existing code.
