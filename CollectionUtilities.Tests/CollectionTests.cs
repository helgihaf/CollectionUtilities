using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Marsonsoft.CollectionUtilities.Tests
{
	[TestClass]
	public class CollectionTests
	{
		private readonly int[] setArray = new[] { 5, 6, 7 };

		[TestMethod]
		public void ShouldSetCollection()
		{
			var list = new List<int> { 1, 2 };
			list.SetAs(setArray);

			Assert.AreEqual(setArray.Length, list.Count);
			for (int i = 0; i < setArray.Length; i++)
			{
				Assert.AreEqual(setArray[i], list[i]);
			}
		}

		[TestMethod]
		[ExpectedException(typeof(NullReferenceException))]
		public void ShouldThrowNullReferenceException()
		{
			List<int> list = null;
			list.SetAs(setArray);
		}

		[TestMethod]
		public void ShouldClearCollectionOnNullEnumeration()
		{
			var list = new List<int> { 1, 2 };
			list.SetAs(null);
			Assert.AreEqual(0, list.Count);
		}
	}
}
