using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public interface IChangeable
    {
        bool AddPet(Pet pet);// Метод добавления питомца
        void RemovePet(Pet pet); // Метод удаления питомца
    }
}
