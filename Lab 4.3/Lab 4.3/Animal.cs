using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._3
{
    // 12) change methods of sorting to properties

    // 1) implement interface IComparable
    public class Animal : IComparable
    {
        // 2) declare properties and parameter constructor
        public string Genus { get; set; }
        public float Weight { get; set; }

        public Animal(string genus, float weight)
        {
            Genus = genus;
            Weight = weight;
        }

        public static IComparer<Animal> SortWeightAscending { get { return new SortWeightAscendingHelper(); } }
        public static IComparer<Animal> SortGenusDescending { get { return new SortGenusDescendingHelper(); } }

        // 3) implement method ComareTo()
        // it comares Genus of type string - return result of method String.Compare 
        // for this.genus and argument object
        // don't forget to cast object to Animal

        public int CompareTo(object? obj)
        {
            Animal? animal = obj as Animal;
            return String.Compare(this.Genus, animal?.Genus);
        }

        // 4) declare methods SortWeightAscending(), SortGenusDescending()
        // they are static and return IComparer
        // return type is custed from constructor of classes SortWeightAscendingHelper, 
        // SortGenusDescendingHelper calling 

        // 5) declare 2 nested private classes SortWeightAscendingHelper, SortGenusDescendingHelper 
        // they implement interface IComparer
        // every nested class has implemented method Comare with 2 parameters of object and return int
        // class SortWeightAscendingHelper sort weight by ascending
        // class SortGenusDescendingHelper sort genus by descending

        class SortWeightAscendingHelper : IComparer<Animal>
        {
            public int Compare(Animal? x, Animal? y)
            {
                if (x == null) return -1;
                if (y == null) return 1;
                if (x == null || y == null) return 0;
                if (x.Weight > y.Weight) return 1;
                if (x.Weight < y.Weight) return -1;
                return 0; // Equals
            }
        }
        class SortGenusDescendingHelper : IComparer<Animal>
        {
            public int Compare(Animal? x, Animal? y)
            {
                if (x == null) return 1;
                if (y == null) return -1;
                if (x == null || y == null) return 0;
                //return String.Compare(x.Genus, y.Genus);
                if (String.Compare(x.Genus, y.Genus) < 0) return 1;
                if (String.Compare(x.Genus, y.Genus) > 0) return -1;
                return 0; // Equals
            }
        }
    }
}
