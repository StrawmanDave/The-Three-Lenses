IEnumerable<int> arrayGiven = new List<int>(){1,9,2,8,3,7,4,6,5};

foreach(int num in Procedural(arrayGiven))
{
    Console.WriteLine(num);
}

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

IEnumerable<int> 