using ConsoleApp12.Collections;
using ConsoleApp12.Collections;
using System.Collections.Generic;



//List<int> list = new List<int>();
//list.Add(155);
//list.Add(23);
//list.Add(123);
//list.Add(500);
//Console.WriteLine(list.Exists(n=>n.));
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}


var words = new List<string> { "falcon", "water", "war", "pen", "ocean" };

bool res = words.Exists(e => e.StartsWith("w"));

Console.WriteLine(res);
Console.WriteLine("---------------------");

MyList<string> myList = new MyList<string>();
myList.Add("salam");
myList.Add("necesen");
myList.Add("nevar");            //yarimciq
myList.Add("neyox");

bool exit = myList.Exists(n => n.StartsWith("w"));
Console.WriteLine(exit);
//foreach (var item in myList)
//{
//    Console.WriteLine(item);
//}









//List<int> numberList = new List<int> { 1, 11, 3, 4, 5 };

//int index = numberList.FindIndex(n => n % 2 == 0);

//Console.WriteLine(index);

