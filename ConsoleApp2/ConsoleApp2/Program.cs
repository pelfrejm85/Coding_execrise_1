using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	private static readonly string star = "*";
	public static void Main()
	{
		int[] list1 = { 3, 4, 2, 1, 6, 6, 4, 4 };
		int[] list2 = { 8, 8, 8, 8, 6, 1, 1, 8, 1, 4 };
		Console.WriteLine("list1");
		CreateHorizontalHistogram(list1);
		Console.WriteLine();
		CreateVerticalHistogram(list1);
		Console.WriteLine();
		Console.WriteLine("list2");
		CreateHorizontalHistogram(list2);
		Console.WriteLine();
		CreateVerticalHistogram(list2);
		Console.WriteLine();
		Console.Read();
	}
	public static void CreateVerticalHistogram(int[] arr)
	{
		int[] count = new int[arr.Max()+1];
		

		for (int i = 1; i <=count.Length; i++)
        {
			for(int k = 0; k< arr.Length; k++)
            {
                if (i == arr[k])
                {
					count[i]++;
                }
            }
        }

		var max = count.Max();
		string nums = "";
		for(int j = max; j>0;  j--)
        {
			for(int p = 0; p <count.Length; p++)
            {
				if(count[p] >= j)
                {
                    if (!nums.Contains(p.ToString()))
                    {
						nums = nums + p.ToString();
                    }
					Console.Write("*");
                }
				else
                {
					Console.Write("");
                }
            }
			Console.WriteLine();
			
        }
		Console.WriteLine(nums);
	}
	public static void CreateHorizontalHistogram(int[] arr)
	{
		string[] count = new String[arr.Max()+1];
		int[] distArr = arr.Distinct().ToArray();
		for (int k = 0; k < arr.Length; k++)
		{
			for (int j = 1; j <=count.Length; j++)
			{
			
				if (j== arr[k])
				{
					count[j] += star;
				}
			}
		}
		foreach (int x in distArr)
		{
			Console.WriteLine(x + ":" + count[x]);
		}
	}
}