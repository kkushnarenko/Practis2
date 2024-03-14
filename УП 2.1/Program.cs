/*

// Задание 1

using System;

public class program
{
    public static void Main(string[] args)
    {
        string j = "драгоценности";
        string s = "камни";

        char[] J = j.ToCharArray();
        char[] S = s.ToCharArray();

        int same = 0;

        for (int i = 0; i < J.Length; i++)
        {
            for(int n = 0; n < S.Length; n++)
            {
                if (J[i] == S[n])
                {
                    same++;
                }
            }
            
        }
        Console.WriteLine(same);

    }
}

*/

//Задание 2


using System;

public class program
{
    static void combinations(int[] candidates, List<int> result, int index, int target)
    {
        if (target == 0)
        {
            foreach (int number in result)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

        }
 
        for (int i = index; i < candidates.Length; i++)
        {
            if (candidates[i] > target)
            {
                break;
            }

            else if (i > index && candidates[i] == candidates[i - 1])
            {
                continue;
            }
            result.Add(candidates[i]);
            combinations(candidates, result, i + 1, target - candidates[i]);
            result.RemoveAt(result.Count - 1);
        }
    }

    public static void Main(string[] args)
    {
        int[] candidates = new int[] { 10, 1, 2, 7, 6, 1, 5 };
        int target = 8;
        int index = 0;

        Array.Sort(candidates);

        List<int> result = new List<int>();

        combinations(candidates, result, index, target);
    }
}


//Задание 3

/*
using System;

public class program
{
    public static void Main(string[] args)
    {
        int[] nums = new int[10] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

        bool same = false;

        for(int i = 0;  i < nums.Length - 1; i++)
        {
            for(int j = i + 1;  j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    same = true;

                }   
            }
        }
        Console.WriteLine(same);
    }
}

*/


