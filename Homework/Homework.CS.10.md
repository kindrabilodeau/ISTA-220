## Kindra Bilodeau
#### C # Homework 10

1. **What does an array look like in memory?**
  - Per book: "arrays live in a contiguous (together in a sequence) block of memory and are accessed by using an index.."
  -
2. **Where is memory allocated to hold an array, on the stack or on the heap?**
  - heap
3. **Where is memory allocated to hold an array reference, on the stack or on the heap?**
  - stack
4. **Can an array hold values of different types? This is a trick question, the answer is, “It depends.”**
  - "It depends." Per book: "All the items in an array have the same type.."
  - an array can hold references to differnt types 
5. **Describe the syntax of the condition or a foreach loop.**
  - int[] socks = {1, 2, 3, 4};
    foreach (sock in socks)
    cw"sock";
6. **How do you make a deep copy of a array?**
  - By using Clone, and all of the fields that reference types also provide a clone method.
7. **What is the difference between a multi-dimensional array and an array of arrays?**
  - A multi-dimensional array takes up a lot of memory and if you don't use it, it's a waste
  - Array of arrays each column has a differnt length and there is no memory wasted.
8. **How do you “flatten” a multidimensional array? In other words, take something that looks like a
matrix
1 2 3
4 5 6
7 8 9 and turn it into an array [1, 2, 3, 4, 5, 6, 7, 8, 9]?**
