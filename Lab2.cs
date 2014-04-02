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

			Console.Write ("Enter the operation(+, -, *, /, and % are allowed) : ");
			string operation = Console.ReadLine ();
			switch (operation)
			{
			case "+":
				Console.WriteLine ("Result: {0}", firstNum + secondNum);
				break;
			case "-":
				Console.WriteLine ("Result: {0}", firstNum - secondNum);
				break;
			case "*":
				Console.WriteLine ("Result: {0}", firstNum * secondNum);
				break;
			case "/":
				Console.WriteLine ("Result: {0}", firstNum / secondNum);
				break;
			case "%":
				Console.WriteLine ("Result: {0}", firstNum & secondNum);
				break;
			default:
				Console.WriteLine ("You entered {0}. Only +, -, *, /, % are allowed", operation);
				break;
			}
		}
	}
}
