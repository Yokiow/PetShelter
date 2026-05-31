using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public interface ICountable
    {
        int Count(); // число животных
        int Count(Type type); // число животных конкретного типа
        int Percentage(Type type); // % от общего числа 
    }
}
