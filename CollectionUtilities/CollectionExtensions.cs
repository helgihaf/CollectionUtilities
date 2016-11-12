using System.Collections.Generic;

namespace Marsonsoft.CollectionUtilities
{
	public static class CollectionExtensions
	{
		/// <summary>
		/// Makes the collection contain only the elements of <paramref name="enumerable"/>.
		/// </summary>
		/// <param name="enumerable">The enumerable whose item are set to the <see cref="ICollection{T}"/> or null
		/// to clear the collection.</param>
		/// <exception cref="InvalidOperationException">An element in the enumerable has been modified.</exception>
		public static void SetAs<T>(this ICollection<T> collection, IEnumerable<T> enumerable)
		{
			collection.Clear();
			if (enumerable != null)
			{
				foreach (var item in enumerable)
				{
					collection.Add(item);
				}
			}
		}
	}
}
