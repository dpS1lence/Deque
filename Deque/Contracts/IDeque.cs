using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDeque.Contracts
{
    public interface IDeque<T>
    {
        void InsertFront(T element);
        void InsertRear(T element);
        T DeleteFront();
        T DeleteRear();
        T[] ToArray();
    }
}
