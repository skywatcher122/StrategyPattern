using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingStrategyPatternHW.Services;
using SortingStrategyPatternHW.Services.Interface;
namespace SortingStrategyPatternHW.Controllers
{
    public class SortingStrategyController
    {
        public SortingStrategyController()
        {

        }

        public string Sorting(string Value, int Index)
        {
            if (Value != "")
            {
                ISortService SortSvc;
                switch (Index)
                {
                    case 0:
                        SortSvc = new QuickSortService();
                        break;

                    case 1:
                        SortSvc = new BubbleSortService();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                return SortSvc.SortInput(Value);
            }
            else
                throw new Exception("Value Input is Empty!");
        }
    }
}
