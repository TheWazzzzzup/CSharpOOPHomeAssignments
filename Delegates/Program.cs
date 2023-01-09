﻿/// Generics WIC

interface IGenericList<T>
{
    void Store(T value);

    T Retrive(T value);

    bool Unique(T value);
}

class GenericList<T> : IGenericList<T>
{
    T[] array = new T[10];
    int indexer = 0;

    public T Retrive(T value)
    {
        throw new NotImplementedException();
    }

    public void Store(T value)
    {
        if (indexer < array.Length)
        {
            array[indexer] = value;
            indexer++;
        }
        else return;
    }

    public bool Unique(T value)
    {
        bool isUnique = true;
        foreach (T item in array)
        {
            if (item == value)
            {
                isUnique = false;
                return isUnique;
            }
        }
        return isUnique;
    }
}