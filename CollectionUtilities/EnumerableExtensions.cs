using System;
using System.Collections.Generic;

namespace Marsonsoft.CollectionUtilities
{
	public static class EnumerableExtensions
	{
		/// <summary>
		/// Performs the specified action on each element of the <see cref="IEnumerable{T}"/> 
		/// </summary>
		/// <param name="action">The <see cref="Action{T}"/> delegate to perform on each element of the <see cref="IEnumerable{T}</param>
		/// <exception cref="ArgumentNullException"><paramref name="action"/> is null.</exception>
		/// <exception cref="InvalidOperationException">An element in the collection has been modified.</exception>
		public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
		{
			if (action == null)
			{
				throw new ArgumentNullException(nameof(action));
			}

			foreach (var item in enumerable)
			{
				action(item);
			}
		}
	}
}
