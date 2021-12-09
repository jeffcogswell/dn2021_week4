using System;
using System.Collections.Generic;

namespace InterfaceDemo
{

	interface IRentable
	{
		DateTime? GetDueDate();
		void Rent();
		void Return(DateTime ReturnedOn);
	}

	class LibraryBook : IRentable
	{

		public string Title;
		public string Author;
		public DateTime? DueDate;
		public DateTime LastReturn;

		public DateTime? GetDueDate()
		{
			return DueDate;
		}

		public void Rent()
		{
			DueDate = DateTime.Today.AddMonths(1);
		}

		public void Return(DateTime ReturnedOn)
		{
			LastReturn = ReturnedOn;
			DueDate = null;
		}

		public override string ToString()
		{
			return $"Library Book: Title {Title} by {Author} due on {DueDate}.";
		}
	}

	class DVD : IRentable
	{
		public string Title;
		public string Director;
		public int Minutes;
		public bool isCheckedOut;
		public DateTime? DueBackOn;

		public DateTime? GetDueDate()
		{
			return DueBackOn;
		}

		public void Rent()
		{
			DueBackOn = DateTime.Today.AddDays(21);
			isCheckedOut = true;
		}

		public void Return(DateTime ReturnedOn)
		{
			isCheckedOut = false;
		}

		public override string ToString()
		{
			return $"DVD: Title {Title} Directed By {Director} due on {DueBackOn}";
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<IRentable> MyRentedItems = new List<IRentable>();

			LibraryBook book1 = new LibraryBook();
			book1.Title = "Great Expectations";
			book1.Author = "Charles Dickens";
			book1.Rent();
			MyRentedItems.Add(book1);

			DVD mydvd = new DVD();
			mydvd.Title = "Star Wars: A New Hope";
			mydvd.Director = "George Lucas";
			mydvd.Minutes = 100;
			mydvd.Rent();
			MyRentedItems.Add(mydvd);

			foreach (IRentable rented in MyRentedItems)
			{
				Console.WriteLine(rented);
			}

		}
	}
}
