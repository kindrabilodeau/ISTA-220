## Kindra Bilodeau
#### C# Homework 16

1. **Give five examples (using valid C# code) of the five bitwise operators listed in the text.**
  - ~ The not operator. Displays the opposite. zero's and ones are reversed
  - << Left Shift operator. far two left numbers are dropped and two zeros are add to the end
  - | OR operator .returns value if either or contain a 1. (1 is just an example)
  - & AND operator. returns if both contain a 1.
  - ^ XOR operator. returns value is one or the other has it but not both
2. **Does C# implement the right-shift (>>) operator? If so, give an example of its operation using valie
C# code.**
  - Yes there is. It would be just like left shift but opposite. drop the two on the right and add two zeros to the left side
3. **Explain in detail this code: bits & (1 << index);.**
  - bits is compared using &, 1 is left shifted number of index
4. **Explain in detail this code: bits |= (1 << index);.**
  - bits is compared the compound operator |= 1 is left shifted number indicated by index
5. **Explain in detail this code: bits &= (1 << index);.**
  - bits is compared using compound operator &= left shifted number indicated by index
6. **How does C# interpret this? bool peek = bits[n];**
  - retrieve a bool at whatever index n is set to.
7. **How does C# interpret this? bits[n] = true;**
  - set the bit at index n to true
8. **How does C# interpret this? bits[n] ^= true;**
  - it compares bits index n to itself and if that's true it will return true,
9. **Assume that users were assigned read, write, and execute permissions according to this scheme: read
= 1, write = 2, execute = 4. How would you interpret the following user permissions:**
- (a) permission = 0 = 000
- (b) permission = 1 = 001
- (c) permission = 2 = 010
- (d) permission = 3 = 011
- (e) permission = 4 = 100
- (f) permission = 5 = 101
- (g) permission = 6 = 110
- (h) permission = 7 = 111
    - you convert the permission number to binary
    - (h) 7 = 111
    - (f) 5 = 101 etc..
10. **Answer the previous question by converting the decimal per**
  -
