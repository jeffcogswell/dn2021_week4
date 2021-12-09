using System;
using System.Collections.Generic;

namespace PolymorphismDemo
{
	class Book
	{
		/*
		 * Book has three functions:
		 *   GetTitle()
		 *   GetAuthor()
		 *   PrintInfo()
		 * These three public functions make up Book's interface.
		 */

		protected string Title;
		protected string Author;

		public Book(string Title, string Author)
		{
			this.Title = Title;
			this.Author = Author;
		}

		public string GetTitle()
		{
			return Title;
		}

		public string GetAuthor()
		{
			return Author;
		}

		public virtual void PrintInfo()
		{
			Console.WriteLine($"Book {Title} by {Author}");
		}
	}

	class EBook : Book
	{
		/*
		 * EBook has three functions:
		 *   GetTitle()
		 *   GetAuthor()
		 *   GetFormat()
		 *   PrintInfo()
		 * These four public functions make up the objct's interface.
		 */
		private string Format; // Kindle or Nook

		public EBook(string Title, string Author, string Format) : base(Title, Author)
		{
			this.Format = Format;
		}

		public string GetFormat()
		{
			return Format;
		}

		public override void PrintInfo()
		{
			//base.PrintInfo();
			Console.WriteLine($"EBook {Title} by {Author} available for {Format}");
		}
	}


	class Program
	{
		// This function demonstrates polymorphism. It doesn't care what the actual types are in the list,
		// as long as they're derived from Book or an instance of Book itself.
		private static void PrintLibrary(string LibraryName, List<Book> library)
		{
			Console.WriteLine(LibraryName);
			foreach (Book next in library)
			{
				next.PrintInfo(); // Polymorphism means it will call the correct "version" of PrintInfo for the current object
			}
		}

		static void Main(string[] args)
		{
			List<Book> library = new List<Book>();
			Book mybook;

			mybook = new Book("Christmas Carol", "Charles Dickens");
			Console.WriteLine($"Adding a book by {mybook.GetAuthor()}");
			library.Add(mybook);

			mybook = new EBook("Great Expectations", "Charles Dickens", "Kindle");
			Console.WriteLine($"Adding a book by {mybook.GetAuthor()}");
			library.Add(mybook);

			mybook = new EBook("The Martian Chronicles", "Ray Bradbury", "Nook");
			Console.WriteLine($"Adding a book by {mybook.GetAuthor()}");
			library.Add(mybook);

			PrintLibrary("Cool Library", library);


			//EBook another;
			//another = new EBook("a", "b", "c");
			// Cannot do the following! We can only put objects of the class or classes derived from it in the variable.
			// Book is not derived from EBook.
			//another = new Book("a", "b");

		}


	}
}
