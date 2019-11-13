using System;
using SortingStrategyPatternHW.Services.Interface;
using SortingStrategyPatternHW.Common.Helpers;
namespace SortingStrategyPatternHW.Services
{
    public class QuickSortService : ISortService
    {
        public string SortInput(string Value)
        {
            char[] chr = Value.ToCharArray();
            QuickSortHelper.quickSort(chr, 0, chr.Length - 1);
            return new string(chr);
        }
    }
}
