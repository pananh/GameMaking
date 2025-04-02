using System;
using System.ComponentModel;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Example
{

	public class Test
	{
		private static void ThreadOne()
		{
			Thread.Sleep(5000);
			Console.WriteLine("ThreadOne");
		}

		private static void ThreadTwo()
		{
			Thread.Sleep(2000);
			Console.WriteLine("ThreadTwo");
		}
		static void Main()
		{

			Console.WriteLine("Thead Vs Async/Await");

			var watch = new System.Diagnostics.Stopwatch();
			watch.Start();

			// Chay khong dong bo
			//ThreadOne();	
			//ThreadTwo();

			// Dong do nhu sau  bang Thread
			//Thread thread1 = new Thread(ThreadOne);
			//Thread thread2 = new Thread(ThreadTwo);
			//thread1.Start();
			//thread2.Start();

			// Chan luong tiep tuc cho toi khi cac tien trinh thread1, 2 hoan thanh
			//thread1.Join();
			//thread2.Join();


			// Chay dong bo bang Task can tim hieu them
			//var task1 = ThreadOne;
			//var task2 = ThreadTwo;




			watch.Stop();
			Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

			Console.ReadKey();

		}
	}
}

