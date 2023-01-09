/// Generics WIC

class GameObject
{
    List<Component> objectCompenets = new();

    T GetComponent<T>() where T: Component
    {
        foreach(Component comp in objectCompenets)
        {
            if (comp == T)
        }
    }
}





class Component
{

}

#region 1st WIC
//interface IGenericList<T>
//{
//    void Store(T value);

//    T Retrive(int value);

//    bool Unique(T value);
//}

//class GenericList<T> : IGenericList<T> where T : class
//{
//    T[] array = new T[10];
//    int indexer = 0;

//    public T Retrive(int index)
//    {
//        return array[index];
//    }

//    public void Store(T value)
//    {
//        if (indexer < array.Length)
//        {
//            array[indexer] = value;
//            indexer++;
//        }
//        else return;
//    }

//    public bool Unique(T value)
//    {
//        bool isUnique = true;
//        foreach (T item in array)
//        {
//            if (item == value)
//            {
//                isUnique = false;
//                return isUnique;
//            }
//        }
//        return isUnique;
//    }
//}

#endregion
