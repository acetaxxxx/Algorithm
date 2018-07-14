using System;
using System.Collections;
using System.Collections.Generic;
namespace SortLib.Interface
{
    public interface ISort<T>
    {
        void Sort(ref IEnumerable<T> array);
    }
}
