## Kindra Bilodeau
#### C # Homework 9

1. **Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols,
like Private, PFD, Corporal, or 1stLt, 2ndLt, Capt?**
  - enum Ranks { Private, PFC, lance Corporal, Corporal}
2. **Using the Ranks enum, assign a rank to yourself or a friend.**
  - Rank Me = Rank.Sergeant;
3. **Determine the numeric index of particular ranks, using the Ranks enum.**
  - 0, 1, 2, 3
4. **How do you select the type of an enum?**
  - when you create the enum you use after the name use a colon and then the type you want to use.
  - enum Ranks : short {Private, PFC, Corporal, Sergeant}
5. **Are structs stored on the stack or on the heap? What about enums?**
  - structs are stored on the stack.
  - enums are on the stack
6. **Declare a struct named DOD with four branches.**
  - public struct DOD
      {
        public string Army, Marines, Navy, Airforce;
      }
7. **Why can’t you create a default constructor for a struct?**
  - Because the complier will always create one for structs.
8. **What is CIL? What does the CLR do to the CIL?**
  - Common Intermediate Language
  - The CLR converts the CIR into something that the computer can understand.
