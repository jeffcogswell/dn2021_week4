using System;
using System.Collections.Generic;

namespace VirtualDemo
{

	abstract class Car
	{
		// The word "abstract" means they can't create an instance of this class,
		// only classes derived from it.

		public string Make;
		public string Model;
		public int GasAmount;

		public virtual void Drive()
		{
			Console.WriteLine("I'm driving!");
		}
	}

	class EconomyCar : Car
	{
		public override void Drive()
		{
			Console.WriteLine("I'm driving slowly!");
		}
	}

	class RaceCar : Car
	{
		int SuperchargerSize;
		public override void Drive()
		{
			Console.WriteLine("I'm driving really fast!");
		}
	}

	class Program
	{

		static void TestTrack(Car testcar)
		{
			// This is polymorphism in action.
			// The computer will call the correct verson of Drive
			// Downside: We only know this is car.
			// So if we pass in a RaceCar, we cannot check the value of SuperchargerSize.
			// Question: What if I really need to access SuperchargerSize??? We have to "cast". (Google it!)
			Console.WriteLine("\nWe're at the test track!!!");
			Console.WriteLine($"We're testing a {testcar.Model}!");
			testcar.Drive();
		}

		static void Main(string[] args)
		{
			EconomyCar pinto = new EconomyCar();
			pinto.Make = "Ford";
			pinto.Model = "Pinto";
			pinto.GasAmount = 10;
			Console.WriteLine("Let's drive the pinto!");
			pinto.Drive();

			RaceCar f1 = new RaceCar();
			f1.Make = "Formula";
			f1.Model = "One";
			f1.GasAmount = 30;
			Console.WriteLine("\nLet's drive the formula one!");
			f1.Drive();

			List<Car> cars = new List<Car>();
			cars.Add(pinto);
			cars.Add(f1);

			Car mycar;
			mycar = pinto;
			Console.WriteLine("\nmycar points to the Pinto:");
			Console.WriteLine(mycar.Model);
			mycar.Drive(); // The code called the right version of Drive. This is "polymorphism"

			mycar = f1;
			Console.WriteLine("\nmycar now points to the f1:");
			Console.WriteLine(mycar.Model);
			mycar.Drive();

			TestTrack(pinto);
			TestTrack(f1);

		}
	}
}
