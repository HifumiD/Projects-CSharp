using System;
using System.Security.Cryptography.X509Certificates;

internal class Animal
{

	public string Name { get; set; }
	public int Age { get; set; }
	public bool IsHungry { get; set; }

	public Animal(string name, int age) 
	{
		Name = name;
		Age = age;
		IsHungry = true;

	}

	

	public virtual void MakeSound()
	{
		
	}

	public virtual void Eat()
	{
		if (IsHungry)
		{
			Console.WriteLine($"{Name} is eating");

		}
		else
		{
			Console.WriteLine($"{Name} is not hungry");
		}
	}

	public virtual void Play()
	{
		Console.WriteLine($"{Name} is eating");
	}
}
