<Query Kind="Program" />

void Main()
{
	Timer timer = new Timer((obj) => Console.WriteLine(DateTime.Now.ToString()), null, 0, 100);
	Console.WriteLine("Hello");
	GC.Collect();
	Console.ReadLine();
}
