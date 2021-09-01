using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Task;

namespace Demo
{
	class Program
	{
		static void Main(String[] args)
		{
			Console.WriteLine("enter the number");
			int number = Convert.ToInt32(Console.ReadLine());
			int fact=1;
			for(int i=1;i<=number;i++)
			{
				fact *= i;
			}
			Console.WriteLine("Factorisl of" +number+ "is:" +fact);
			Console.Read();
		}
	)
)