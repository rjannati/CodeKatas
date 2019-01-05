using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodeKatas.Tests.CodeKataDotCom
{
	public class Kata02Test_V1
	{
		protected Func<int, int[], int> Chop;

		public Kata02Test_V1()
		{
			Chop = CodeKatas.CodeKataDotCom.KarateChop_V1.Chop;
		}

		[Theory]
		[InlineData(3,new int[] { }, -1)]
		[InlineData(3,new int[] {1}, -1)]
		[InlineData(1, new int[] { 1 }, 0)]
		[InlineData(1, new int[] { 1, 3, 5 }, 0)]
		[InlineData(3, new int[] { 1, 3, 5 }, 1)]
		[InlineData(5, new int[] { 1, 3, 5 }, 2)]
		[InlineData(0, new int[] { 1, 3, 5 }, -1)]
		[InlineData(2, new int[] { 1, 3, 5 }, -1)]
		[InlineData(4, new int[] { 1, 3, 5 }, -1)]
		[InlineData(6, new int[] { 1, 3, 5 }, -1)]
		[InlineData(1, new int[] { 1, 3, 5, 7 }, 0)]
		[InlineData(3, new int[] { 1, 3, 5, 7 }, 1)]
		[InlineData(5, new int[] { 1, 3, 5, 7 }, 2)]
		[InlineData(7, new int[] { 1, 3, 5, 7 }, 3)]
		[InlineData(0, new int[] { 1, 3, 5, 7 }, -1)]
		[InlineData(2, new int[] { 1, 3, 5, 7 }, -1)]
		[InlineData(4, new int[] { 1, 3, 5, 7 }, -1)]
		[InlineData(6, new int[] { 1, 3, 5, 7 }, -1)]
		[InlineData(8, new int[] { 1, 3, 5, 7 }, -1)]
		public void Test_Chop(int valueParam, int[] arrayParam, int expectedResult)
		{
			var result = Chop(valueParam, arrayParam);
			Assert.Equal(expectedResult, result);
		}
	}

	public class Kata02Test_V2: Kata02Test_V1
	{
		public Kata02Test_V2()
		{
			Chop = CodeKatas.CodeKataDotCom.KarateChop_V2.Chop;
		}
	}
}
