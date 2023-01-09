/// Generics WIC

interface IGenericList<T>
{
    void Store(T value);

    T Retrive (T value);

    bool Unique(T value);
}