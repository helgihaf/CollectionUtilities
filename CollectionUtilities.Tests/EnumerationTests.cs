using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Marsonsoft.CollectionUtilities.Tests
{
	[TestClass]
	public class EnumerationTests
	{
		[TestMethod]
		public void ShouldForEach()
		{
			var enumerable = CreateEnumerable();
			int sum = 0;
			enumerable.ForEach(i => sum += i);
			Assert.AreEqual(enumerable.Sum(), sum);
		}

		[TestMethod]
		[ExpectedException(typeof(NullReferenceException))]
		public void ShouldHandleNullEnumeration()
		{
			IEnumerable<int> enumerable = null;
			int sum = 0;
			enumerable.ForEach(i => sum += i);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ShouldThrowArgumentNullException()
		{
			var enumerable = CreateEnumerable();
			enumerable.ForEach(null);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void ShouldThrowInvalidOperationExceptionOnChangedEnumerable()
		{
			var list = new List<int>();
			list.Add(1);
			IEnumerable<int> enumerable = list;
			enumerable.ForEach(i => list.Add(i));

		}
		private IEnumerable<int> CreateEnumerable()
		{
			return Enumerable.Range(0, 10);
		}
	}
}
