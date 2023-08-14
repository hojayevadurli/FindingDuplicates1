using System;
using System.Collections.Generic;

public class DuplicateFinder
{
    private List<string> inputList;

   

    public DuplicateFinder(List<string> inputList)
    {
        this.inputList = inputList;
    }



    public List<string> FindDuplicates()
    {
        Dictionary<string, int> seen = new Dictionary<string, int>();
        List<string> duplicates = new List<string>();

        foreach (string item in inputList)
        {
            if (seen.ContainsKey(item))
            {
                if (seen[item] == 1)
                {
                    duplicates.Add(item);
                }
                seen[item]++;
            }
            else
            {
                seen[item] = 1;
            }
        }

        return duplicates;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<string> inputItems = new List<string> { "apple", "dog", "balloon", "banana", "cat", "dog", "dog", "celery", "elephant", "elephant", "balloon" };
        DuplicateFinder duplicateFinder = new DuplicateFinder(inputItems);
        List<string> duplicates = duplicateFinder.FindDuplicates();

        foreach (string duplicate in duplicates)
        {
            Console.WriteLine(duplicate);
        }
    }
}
