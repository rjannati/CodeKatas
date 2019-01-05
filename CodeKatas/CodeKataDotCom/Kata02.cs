using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            if (elementArray.Length == 0) { return -1; }

            if(elementArray.Length == 1) 
            {
                var valueToCompare = elementArray[0];
                return (valueToCompare == value) ? 0 : -1;
            }
            else
            {
                var midIndex = elementArray.Length / 2;
                var valueToCompare = elementArray[midIndex];

                if(valueToCompare == value)
                {
                    return midIndex;
                }
                else if (valueToCompare > value)
                {
                    var startIndex = 0;

                    var slicedArray = elementArray
                        .Where((w, i) => i >= startIndex && i < midIndex)
                        .ToArray();

                    return Chop(value, slicedArray);
                }
                else // valueToCompare < value
                {
                    var endIndex = elementArray.Length - 1;

                    var slicedArray = elementArray
                        .Where((w, i) => i > midIndex && i <= (elementArray.Length - 1)).ToArray();

                    var middleResult = Chop(value, slicedArray);

                    if(middleResult == -1) { return -1; }
                    else { return middleResult + (midIndex + 1); }
                }

            }

        }
	}
}
