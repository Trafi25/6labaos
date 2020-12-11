using System;
using System.Threading;
namespace Lab6 {
	class Program {


		static void FirstFuction()
		{
			for (int i = 0; i < 1000; i++)
			{
				//process 
				//Thread.Sleep(100);
			
			}

			return;
		}

		static void SecondFunction()
		{
			for (int i = 0; i < 1000; i++)
			{
				//process 
				//Thread.Sleep(100);
				
			}
			return;
		}

		static void Main(string[] args)
		{
			Console.Write("\n Inside main()\n");
			string numoffunc = "first";			

			int i = 0;

			for (; i < 0xffffff; i++) ;
			switch (numoffunc)
			{
				case "first":
					FirstFuction();
					break;
				case "second":
					SecondFunction();
					break;
			}
		

		}
	}
}