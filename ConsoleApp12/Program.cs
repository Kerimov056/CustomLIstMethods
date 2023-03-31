using ConsoleApp12.Collections;

List<int> list = new List<int>();
list.Add(155);
//list.Add(23);
//list.Add(123);
list.Sort();
foreach (var item in list)
{
    Console.WriteLine(item);
}
Console.WriteLine("---------------------");
MyList<int> myList = new MyList<int>();
//myList.Add(34);
//myList.Add(2);
myList.Add(3);
//myList.Add(4);
myList.Sort();
foreach (var item in myList)
{
    Console.WriteLine(item);
}



//for (int i = 0; i < Count; i++)
//{
//    for (int j = i + 1; j < Count; j++)
//    {
//        if (Equals(array[i] > array[j]))
//        {
//            T temp = array[i];
//            array[i] = array[j];
//            array[j] = temp;
//        }
//    }
//}