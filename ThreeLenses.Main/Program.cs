int[] arrayGiven = {1,9,2,8,3,7,4,6,5};

string? Question1 = @"
The Procedural one has lots of more space it also might to someone who learned a few basic things then it makes the most sense.
The KeyWord one has just one line and it felt really simple to just put the keywords in also it just one line of code very small
The Method call one was a little confusing at first but then it became just like the keywords one where it just one line of code the space then . 
is a little confusing to look at.
None of them seem perticulary bad they all work just the keywords one and the method call are better.";

string? Question2 = @"
Of the three approaches, the keyword one is my favorite very simple to understand the word describes what is going on and it is very small amount of code.";
Console.WriteLine("Procedural method.");
foreach(int num in Procedural(arrayGiven))
{
    Console.Write($"{num} ");
}
Console.WriteLine();
Console.WriteLine("Keyword method.");
foreach(int num in KeyWord(arrayGiven))
{
    Console.Write($"{num} ");
}
Console.WriteLine();
Console.WriteLine("Method call method");
foreach(int num in MethodCall(arrayGiven))
{
    Console.Write($"{num} ");
}
Console.WriteLine();
Console.WriteLine(Question1);
Console.WriteLine(Question2);

IEnumerable<int> Procedural(IEnumerable<int> ints)
{
    List<int> result = new List<int>();
    foreach (var i in ints)
    {
        if(i % 2 == 0)
        {
            result.Add(i);
        }
    }
    result.Sort();
    for(int i = 0; i<result.Count(); i++)
    {
        result[i] = result[i] * 2;
    }
    return result;
}

IEnumerable<int> KeyWord(IEnumerable<int> ints)
{
    IEnumerable<int> result = from o in ints where o % 2 == 0 orderby o select o * 2;

    return result;
}

IEnumerable<int> MethodCall(IEnumerable<int> ints)
{
    IEnumerable<int> result = ints.Where(o => o % 2 == 0) .OrderBy(o => o) .Select(o => o * 2);

    return result;
}