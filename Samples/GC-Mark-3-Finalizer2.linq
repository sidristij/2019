<Query Kind="Program">
  <Namespace>System.Runtime.CompilerServices</Namespace>
</Query>

void Main()
{
	var sc = new SomeClass() { Field = new Random().Next() };
	sc.DoSomething();
	Console.ReadLine();
}

public class SomeClass
{
	public int Field;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void DoSomething()
	{
		Console.WriteLine(this.Field.ToString());
		Console.WriteLine("Am I dead?");
	}
	
	~SomeClass()
	{
		Console.WriteLine("In finalizer");
	}
}
