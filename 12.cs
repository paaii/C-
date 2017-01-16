using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] nums = new int[5];
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine ("enter number ");
				nums [i] = int.Parse (Console.ReadLine ());

			
			}
			for (int it = nums.Length - 1;it  >= 0; it--)
			{
				Console.WriteLine(nums[it]);
			}

			Console.ReadLine ();
		}
	}
}
