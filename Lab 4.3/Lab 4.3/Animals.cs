using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._3
{
    //6) implement interface IEnumerable
    class Animals : IEnumerable<Animal>
    {
        // 7) declare private array of Animal

        public Animal[] AnimalsList;

        // 8) declare parameter constructor to initialize array   

        public Animals(params Animal[] animals)
        {
            AnimalsList = animals;
        }

        // 9) implement method GetEnumerator(), which returns IEnumerator
        // use foreach on array of Animal
        // and yield return for every animal
        public IEnumerator<Animal> GetEnumerator()
        {
            foreach(var animal in AnimalsList)
            {
                yield return animal; 
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return AnimalsList.GetEnumerator();
        }
    }
}
