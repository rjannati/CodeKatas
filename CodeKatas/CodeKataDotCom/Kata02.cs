using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Refer to http://codekata.com/kata/kata02-karate-chop/
/// </summary>
namespace CodeKatas.CodeKataDotCom
{
	public static class KarateChop_V1
	{
		public static int Chop(int value, int[] elementArray)
		{
			var result = -1;
			var continueToSearch = true;
			var startIndex = 0;
			var length = elementArray.Length;
			var endIndex = length - 1;
			while(startIndex <= endIndex && continueToSearch)
			{
				var midpointIndex = (length / 2) + startIndex;
				var valueToCompare = elementArray[midpointIndex];

				if (valueToCompare == value)
				{
					result = midpointIndex;
					continueToSearch = false;
				}
				else if (valueToCompare > value)
				{
					endIndex = midpointIndex - 1;
					length = (endIndex - startIndex) + 1;
					continueToSearch = true;
				}
				else //valueToCompare < value
				{
					startIndex = midpointIndex + 1;
					length = (endIndex - startIndex) + 1; 
					continueToSearch = true;
				}
			}
			
			return result;
		}
	}

	public static class KarateChop_V2
	{
		public static int Chop(int value, int[] elementArray)
		{
			throw new NotImplementedException();
		}
	}
}
