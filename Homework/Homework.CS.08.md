## Kindra Bilodeau
#### C Sharp Homework 08


1. ** What is the difference between deep copy and shallow copy?**
    - Deep copy returns what's in the reference name. (the object)
    - shallow copy only copies the reference name
2. ** What is the value of a reference after you declare and initialize it?**
    - It's a memory type
3. ** How do you declare a value type?**
    - by declare a variable and assigning it a value.
    - int i = 42;
4. ** How do you declare a reference type?**
    - by creating a new object instance of an object or a string.
    - Circle c = new Circle(42); Circle refc = c;
5. ** Does C# allow you to assign NULL to a value type?**
    - No, you cant it to a value type  
6. ** Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?**
    - no. not sure why..
7. ** What is the difference between the stack and the heap?**
    -  all value types are created on the stack. all reference types are created on the heap.
    - stack - short term, heap - long term
8. ** What does it mean when we say that all classes are specialized types?**
    - that each class are form of the system.object
9. ** What does ref do?**
    - allows you to change something on the copy and original argument.
10. ** What does out do?**
    - allows the method to initialize the parameter, it also changes the original argument.
11. ** Describe boxing and unboxing in your own words.**
    - boxing is the runtime stores a copy variable in the heap
    - unboxing is checking the object type using casting then storing it on the stack
12. ** What does cast do?**
    - you can specify the data being referenced has a specific type
