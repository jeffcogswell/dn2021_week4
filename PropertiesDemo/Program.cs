using System;

namespace PropertiesDemo
{
	// Let's modify this class to not allow Length and Width to be set
	// after the instance is created.

	class Rectangle
	{
		private double pLength;
		private double pWidth;

		public Rectangle(double Length, double Width)
		{
			pLength = Length;
			pWidth = Width;
		}

		public double GetLength()
		{
			return pLength;
		}

		public double GetWidth()
		{
			return pWidth;
		}

		public double GetArea()
		{
			return pLength * pWidth;
		}
	}

	// Annoying but for demonstration purposes only!
	// Let's allow the programmer to change Width. However, Width must
	// be at least 0. If they try to make it negative, we'll just make it 0.
	class RectWithProps
	{
		private double pLength; // Technically this is a member variable
		private double pWidth; // Technically this is a member variable

		public double Length
		{
			get
			{
				return pLength;
			}
		}

		public double Width
		{
			get
			{
				return pWidth;
			}
			set
			{
				if (value < 0)
				{
					pWidth = 0;
				}
				else
				{
					pWidth = value;
				}
			}
		}

		public RectWithProps(double Length, double Width)
		{
			pLength = Length;
			pWidth = Width;
		}

		public double GetArea()
		{
			return pLength * pWidth;
		}
	}

	class RectWithFullProps
	{
		public double Length { get; set; } // Technically this is a property
		public double Width { get; set; } // Technically this is a property

		//private double pLength;
		//private double pWidth;

		//public double Length
		//{
		//	get
		//	{
		//		return pLength;
		//	}
		//	set
		//	{
		//		pLength = value;
		//	}
		//}

		//public double Width
		//{
		//	get
		//	{
		//		return pWidth;
		//	}
		//	set
		//	{
		//		pWidth = value;
		//	}
		//}

		public RectWithFullProps(double Length, double Width)
		{
			this.Length = Length;
			this.Width = Width;
		}

		public double GetArea()
		{
			return Length * Width;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Rectangle r1 = new Rectangle(3.5, 2.6);
			Console.WriteLine($"Rectangle has Length {r1.GetLength()} and Width {r1.GetWidth()}");
			Console.WriteLine(r1.GetArea());

			Console.WriteLine();

			RectWithProps r2 = new RectWithProps(4.2, 5.5);
			Console.WriteLine(r2.Length);
			Console.WriteLine(r2.Width);
			r2.Width = 10.5;
			Console.WriteLine(r2.Width);
			r2.Width = -5.0;
			Console.WriteLine($"We tried to set Width to -5.0. But width is {r2.Width}");

			Console.WriteLine();

			RectWithFullProps r3 = new RectWithFullProps(5.6, 7.8);
			Console.WriteLine(r3.Length);
			Console.WriteLine(r3.Width);
			r3.Length = 11.2;
			r3.Width = 12.5;
			Console.WriteLine(r3.Length);
			Console.WriteLine(r3.Width);

		}
	}
}
