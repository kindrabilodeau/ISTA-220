## Kindra Bilodeau
#### C# Homework 17

1. **What is a type parameter?**  
  - It specifies the types of objects on which they use.
  - it uses angle brackets<type>
2. **What does a type parameter do?**
  - It specifies the type of objects
  - you create generic types that can take on any kind of type
3. **How many type parameters can a generic class have?**
  - Unlimited  
4. **What is the difference between a generic class and a generalized class?**
  - A generic class uses type Parameters
  - A generalized class takes parameters that can cast to different types
5. **What is a constraint? How do you specify a constraint?**
  - A constraint limits the type parameters of a generic class to specific interfaces and ensures that you get certain methods.
  - class<t> where t : interface
6. **What is a generic method? How do you define a generic method?**
  - A generalized method that are type safe and prevent casting.
  - Defined MethodName<t>
7. **What do we mean when we cay that a generic type interface is invariant?**
  - You can only use the type originally specified.
8. **What do we mean when we cay that a generic type interface is covariant?**
  - Enables you to use a more specfic type than originally specified.
9. **Does covariance work with value types? Does it work with reference types?**
  -
10. **What do we mean when we say that a generic type interface is contravariant?**
  - Allows you to use a less specific type an originally specified.
