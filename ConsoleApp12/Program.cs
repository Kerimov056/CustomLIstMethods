using ConsoleApp12.Collections;
using ConsoleApp12.Collections;
using System.Collections.Generic;



//List<int> list = new List<int>();
//list.Add(155);
//list.Add(23);
//list.Add(123);
//list.Add(500);
//list.Remove(123);

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}


Console.WriteLine("---------------------");

MyList<int> myList = new MyList<int>();
myList.Add(1);
myList.Add(2);
myList.Add(3);
myList.Add(4);
Console.WriteLine(myList.Remove(1));
foreach (var item in myList)
{
    Console.WriteLine(item);
}


