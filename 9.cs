using System;

namespace teht9
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int summa = 0, luku = 0;
			while (true) 
			{
				Console.WriteLine ("Anna luku ");
				luku = int.Parse (Console.ReadLine ());

				if (luku == 0)
					break;
				else
					summa += luku;
			}
			Console.WriteLine ("lukujen summa " + summa);
			Console.ReadKey ();
	}
}
}
