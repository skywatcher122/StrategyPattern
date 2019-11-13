using System;
using SortingStrategyPatternHW.Services.Interface;

namespace SortingStrategyPatternHW.Services
{
    public class BubbleSortService : ISortService
    {
        public string SortInput(string Value)
        {
            var array = Value.ToCharArray();
            foreach (var t in Value)
            {
                for (var j = 0; j < Value.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return new string(array);
        }
    }
}
