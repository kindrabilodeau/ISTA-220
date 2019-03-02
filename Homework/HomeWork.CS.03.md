## Kindra Bilodeau
###C# Homework 03
1. What is a method?
a named sequence of statements
-a name block of statements that can accept input and can return output
2. What does a return statement do?
It's at the end of a method and it returns the specified value.
3. What is an expression bodied method?
It is a method that contains an expression and uses the => symbol to reference the expression
-makes the code simpler and easier to understand (supposedly)
ex: int addValues (int leftHandSide, int rightHandSide)=> leftHandSide + rightHandSide;
4. What is the scope of a variable?
The region of the program in which that variable is usable.
-is the block in which the variable is declared
5. What is an overloaded method?
two identifiers have the same name and are declared in the same scope  
multiple methods with the same name but different parameters
6. How do you call a method that requirements arguments?
you put your argument between parenthesis
result is contains value returned by method, methodName is the *exact* name, argumentList is the infor the method accepts.  
7. How do you write a method, that is, specify the method definition, that requires a parameter list?
putting values in the parenthesis that are separated by commas
You have to specify the variable type
8. How do you specify a parameter as optional when defining a method?
by providing a default value which is indicated by using the assignment operator.
void optMethod(int first, double second = 0.0, string third = "Hello"){}
9. How do you pass a argument to a method as a named parameter?
You specify the name of the parameter, followed by a colon and the value to use.
ex: optMethod(first:99, second:123.45, third:" World");
-you can vary the order
10. How do you return values from a method? Can you return multiple values from a method, and if so,
how?
By calling it. yes you can return multiple values. by returning a tuple. which is a small list collections of values. you have to specify the return type
(sum, product) = getBoth (16, 3); method returns two values
11. How does the compiler resolve an ambiguity between named arguments and optional parameters?
The complier won't let you
