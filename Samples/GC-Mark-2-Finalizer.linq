<Query Kind="Program" />

void Main()
{
	var sc = new SomeClass();
	sc.DoSomething("Hello from SomeClass");
	Console.ReadLine();
}

public class SomeClass
{
	public void DoSomething(string msg)
	{
		GC.Collect();
		Console.WriteLine(msg);
	}
	~SomeClass()
	{
		Console.WriteLine("In finalizer");
	}
}
