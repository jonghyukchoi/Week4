using System;

namespace Calculator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Enter the first number: ");
			int firstNum = int.Parse (Console.ReadLine ());

			Console.Write ("Enter the second number: ");
			int secondNum = int.Parse (Console.ReadLine ());

			Console.Write ("Enter the operation(+, -, *, / and % are allowed) : ");
			string operation = Console.ReadLine ();

			if (operation == "+")
				Console.WriteLine ("계산 결과: {0}", firstNum + secondNum);
			else if (operation == "-")
				Console.WriteLine ("계산 결과: {0}", firstNum - secondNum);
			else if (operation == "*")
				Console.WriteLine ("계산 결과: {0}", firstNum * secondNum);
			else if (operation == "/")
				Console.WriteLine ("계산 결과: {0}", firstNum / secondNum);
			else if (operation == "%")
				Console.WriteLine ("계산 결과: {0}", firstNum % secondNum);
			else
				Console.WriteLine ("You entered {0}. Only +, -, *, /, and % are allowed.", operation);
		}
	}
}
