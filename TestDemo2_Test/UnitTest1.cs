using System;
using Xunit;
using TestDemo2;

namespace TestDemo2_Test
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			string actual = StringHelpers.Reverse("hello");
			Assert.Equal("olleh", actual);
		}

		[Fact]
		public void TestEmpty()
		{
			string actual = StringHelpers.Reverse("");
			Assert.Equal("", actual);
		}

		[Fact]
		public void TestNull()
		{
			Assert.Throws<NullReferenceException>(
				() => StringHelpers.Reverse(null)
			);
		}
	}
}
