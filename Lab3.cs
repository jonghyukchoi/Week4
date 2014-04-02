using System;

namespace Lab3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Enter your number: ");
			int number = int.Parse (Console.ReadLine());

			const int SUNDAY = 0;
			const int MONDAY = 1;
			const int TUESDAY = 2;
			const int WEDNESDAY = 3;
			const int THURSDAY = 4;
			const int FRIDAY = 5;
			const int SATURDAY = 6;

			switch (number) {
			case (int)SUNDAY:
				Console.WriteLine ("Sun");
				break;
			case (int)MONDAY:
				Console.WriteLine ("Moon");
				break;
			case (int)TUESDAY:
				Console.WriteLine ("Mars");
				break;
			case (int)WEDNESDAY:
				Console.WriteLine ("Mercury");
				break;
			case (int)THURSDAY:
				Console.WriteLine ("Jupitor");
				break;
			case (int)FRIDAY:
				Console.WriteLine ("Venus");
				break;
			case (int)SATURDAY:
				Console.WriteLine ("Saturn");
				break;
			}
		}
	}
}
