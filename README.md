# The-Three-Lenses
This is for the challenge The Three Lenses in C# Player's Guide Fifth Edition. 

You have a array with [1,9,2,8,3,7,4,6,5].
Create a collection where all the odd numbers are filterd out, and only the even should be considered
The numbers are in order
the numbers are doubled.

For example, the array above, the odd/even filther should result in 2,8,4,6. The ordering step should result in 2,4,6,8.
The doubling step should result in 4,8,12,16.

Objectives: 
Write a method that will take an int[] as input and produce an IEnumerable<int> (it could be a list or array if you want)
that meets all three of the conditions above using only procedural code if staments, switches and loops. Hint:
the static Array.Sort method might be a usefull tool here.

Write a method that takes an int[] as input and produces an IEnumerable<int> that meets the three abouve conditions using a keyword-based query expression
(from x, where x, select x).

Write a method that will take an int[] as input and produce an IEnumerable<int> that meets the three above conditions using a method call based query expression.
(x.Select(n => n + 1)), x.Where(n => n < 0).

Run all three methods and display the results to ensure they all produce good answers.

Awnser this question: Compare the size and understandability of these three approaches. 
Do any stand out as being particularly good or particularly bad?

Awnser this question: Of the three approaches, which is your personal favorite, and why?