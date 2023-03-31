//using ConsoleApp12.Collections;

//List<int> list = new List<int>();
//list.Add(155);
//list.Add(23);
//list.Add(123);
//int[] arr = new int[6];
//arr[0] = 500;
//arr[1] = 600;
//arr[2] = 700;
//arr[3] = 800;
//arr[4] = 900;
//arr[5] = 1000;
//list.AddRange(arr);
//list.Sort();
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine(list.Count);
//Console.WriteLine(list.Capacity);


using ConsoleApp12.Collections;
using System.Collections.Generic;

Console.WriteLine("---------------------");
MyList<int> myList = new MyList<int>();
myList.Add(1);
myList.Add(2);
myList.Add(3);
myList.Add(4);
 int[] arr = new int[6];
arr[0] = 500;
arr[1] = 600;
arr[2] = 700;
arr[3] = 800;
arr[4] = 900;
arr[5] = 1000;
myList.AddRange(arr);
foreach (var item in myList)
{
    Console.WriteLine(item);
}



Console.WriteLine(myList.Capacity);