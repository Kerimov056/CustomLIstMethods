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
        Array.Clear(array, 0, Count);
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
            //Array.Sort(array, 0, Count);
        }
        if (Count == 1)
        {
            Console.WriteLine(array[0]);
        }
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
