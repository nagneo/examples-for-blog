using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCounter
{
    public interface ICountSaver
    {
        void Save(int count);
    }
}
