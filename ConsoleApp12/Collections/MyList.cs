using System;
using System.Collections;

namespace ConsoleApp12.Collections;

public class MyList<T>:IEnumerable<T>
{
    public int Count { get; private set; }
    private int _capacity;
    public int Capacity
    {
        get => _capacity;
        set
        {
            if (value<Count)
            {
                throw new ArgumentException();
            }
            _capacity = value;
            Array.Resize(ref array,_capacity);
        }
        
    }
    private T[] array;

    public MyList()
    {
        _capacity = 0;
        Count = 0;
        array = new T[_capacity];
    }

    public T this[int index]{ 
        get 
        {
            if (Count <= index)
            {
                throw new IndexOutOfRangeException();
            }
            return array[index];
        }
        set
        {
            if (Count <= index)
            {
                throw new IndexOutOfRangeException();
            }
            array[index] = value;
        } 
    }
    public void Add(T obj)
    {
        if (_capacity==0)
        {
            _capacity = 4;
            Array.Resize(ref array,_capacity);
        }
        if (_capacity==Count)
        {
            _capacity *= 2;
            Array.Resize(ref array, _capacity);
        }
        array[Count] = obj;
        Count++;
    }

    public bool Contient(T obj)
    {
        for (int i = 0; i < Count; i++)
        {
            if (obj.Equals(Count))
            {
                return true;
            }
        }
        return false;
    }

    public T? Find(Predicate<T> predicate)
    {
        for (int i = 0; i < Count; i++)
        {
            if (predicate(array[i]))
            {
                return array[i];
            }
        }
        return default;
    }


    public void Clear()
    {
        _capacity = 0;
        Count = 0;
        array = default;
        //Array.Clear(array, 0, Count);
    }

    public void Reverrse()
    {
       
        for (int i = 0; i < Count/2; i++)
        {
            if (Count==0)
            {
                throw new Exception();
            }                            //1,2,3,4
            if (Count>1)
            {
                T temp = array[i];
                array[i] = array[Count - i - 1];
                array[Count - i - 1] = temp;
            }
            if(Count==1)
            {
                Console.WriteLine(array[0]);
            }
        }
    }

    public void Sort()    //IComparer<T> comparer
    {
        if (Count == 0)
        {
            throw new Exception();
        }                            //1,2,3,4
        if (Count > 1)
        {
            for (int i = 0; i < Count; i++)
            {
                for (int j = i + 1; j < Count; j++)
                {
                    if (Comparer<T>.Default.Compare(array[i], array[j]) > 0)
                    {
                        T temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        if (Count == 1)
        {
            Console.WriteLine(array[0]);
        }
    }

    public void AddRange(IEnumerable<T> values)
    {
        foreach (T item in values)
        {
            Add(item);
        }
    }


    public int IndexOf(T obj, int index,int count)  //3ci ovolad'i
    {
        if (count<Count)
        {
           for (int i = 0; i < count; i++)
           {
             if (obj.Equals(array[i]) && i == index)
             {
                return 1;
             }
           }
        }
        else
        {
            throw new ArgumentNullException();
        }
        return -1;
    }
    public int IndexOf(T obj, int index)  //2ci ovolad'i
    {
        for (int i = 0; i < Count; i++)
        {
            if (obj.Equals(array[i]) && i == index)
            {
                return 1;
            }
        }
        return -1;
    }
    public int IndexOf(T obj)  //1ci ovolad'i
    {
        for (int i = 0; i < Count; i++)
        {
            if (obj.Equals(array[i]))
            {
                return 1;
            }
        }
        return -1;
    }

    public bool Remove(T obj) 
    {
        for (int i = 0; i < Count; i++)             
        {
            if (obj.Equals(array[i]))
            {
                array[i] = default;
                if (i == array.Length - 1)
                {
                    Count--;
                    Array.Resize(ref array,Count);
                    return true;
                }
                var temp = array;
                T[] newArray= new T[Count-1];
                int c = 0;
                for (int j = 0; j < Count; j++)
                {
                    if (i==j)
                    {
                        continue;
                    }
                    newArray[c] =array[j];
                    c++;
                }
                array = newArray;
                Count--;
                return true;
            }
        }
        Console.WriteLine("Not Value!");
        return false;
    }

    public bool Exists(Predicate<T> predicate)
    {

        foreach (var item in array)   
        {
            if (predicate(item))
            {
                return true;
            }
        }
        return false;
    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
        {
            yield return array[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
