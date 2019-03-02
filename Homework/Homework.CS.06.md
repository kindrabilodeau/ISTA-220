#### Kindra Bilodeau

##### C Sharp Homework #6:


1. What is an exception
a type of error

2. What happens in a try block if the program executes without errors?
The program runs as normal. each statement runs one after another

3. How does the catch mechanism work for unhandled exceptions?
the runtime tries to find a catch handler that matches the if it cannot it will close the program
control is transferred to the catch statement

4. What happens in a program if an exception block fails to handle an particular error?
tries to find the exception block in the next higher level
the program will terminate with an unhandled exception

5. What is the parent class for all exceptions? How does this work?
exception. It is a generic exception handler and catches all types of exceptions

6. How do you determine the type of an error?
the exception object has a property that indicates the type of error 

7. What is the purpose of integer checking?
To prevent going over the and value limit and making sure you get the correct answer or get an overflowexception

8. What does the finally block do?
it runs the block of code even if an exception occurs.
