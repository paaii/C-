using System;

namespace teht10
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			int[] numbers = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
			Console.WriteLine (numbers.ToString (numbers));
			foreach (var item in numbers) {
				if (item % 2 == 0)
					Console.WriteLine (item.ToString ("HEP"));
			}

		}
	}
}
