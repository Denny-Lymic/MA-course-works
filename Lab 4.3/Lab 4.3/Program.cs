using Lab_4._3;
// 10) Create an array of Animal objects and object of Animals    
// print animals with foreach operator for object of Animals 

Animals animals = new Animals(
    null,
    new Animal("parrot", 0.2f),
    new Animal("dog", 6.0f),
    new Animal("cat", 3.5f),
    new Animal("frog", 0.5f),
    new Animal("rat", 0.8f),
    null
    );

IEnumerator<Animal> animaIEnumerator = animals.GetEnumerator();
while (animaIEnumerator.MoveNext())
{
    if (animaIEnumerator.Current == null)
    {
        Console.WriteLine("Null");
        continue;
    }
    Console.WriteLine(animaIEnumerator.Current.Genus + " " + animaIEnumerator.Current.Weight + "kg(s)");
}
Console.WriteLine();

// 11) Invoke 3 types of sorting 
// and print results with foreach operator for array of Animal objects  

Console.WriteLine("Normal sorting");
animaIEnumerator = animals.GetEnumerator();
Array.Sort(animals.AnimalsList);
while (animaIEnumerator.MoveNext())
{
    if (animaIEnumerator.Current == null)
    {
        Console.WriteLine("Null");
        continue;
    }
    Console.WriteLine(animaIEnumerator.Current.Genus + " " + animaIEnumerator.Current.Weight + "kg(s)");
}
Console.WriteLine();

Console.WriteLine("Sorting by weight ascending");
animaIEnumerator = animals.GetEnumerator();
Array.Sort(animals.AnimalsList, Animal.SortWeightAscending);
while (animaIEnumerator.MoveNext())
{
    if (animaIEnumerator.Current == null)
    {
        Console.WriteLine("Null");
        continue;
    }
    Console.WriteLine(animaIEnumerator.Current.Genus + " " + animaIEnumerator.Current.Weight + "kg(s)");
}
Console.WriteLine();

Console.WriteLine("Sorting by genus descending");
animaIEnumerator = animals.GetEnumerator();
Array.Sort(animals.AnimalsList, Animal.SortGenusDescending);
while (animaIEnumerator.MoveNext())
{
    if (animaIEnumerator.Current == null)
    {
        Console.WriteLine("Null");
        continue;
    }
    Console.WriteLine(animaIEnumerator.Current.Genus + " " + animaIEnumerator.Current.Weight + "kg(s)");
}


Console.ReadLine();