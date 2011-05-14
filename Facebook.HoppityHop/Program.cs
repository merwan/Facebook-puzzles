/*
 * Created by SharpDevelop.
 * User: Mérouane Atig
 * Date: 15/05/2011
 * Time: 01:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Facebook.HoppityHop
{
	class Program
	{
		public static void Main(string[] args)
		{
			if (args.Length == 0) {
				Console.WriteLine("You must provide a file name");
			}
			var filename = args[0];
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}