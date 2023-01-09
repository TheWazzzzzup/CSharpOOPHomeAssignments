using System.Collections;

class Simple<T> : IEnumerable<T>
{
    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

struct SimleStruct<T> : IEnumerator<T>
{
    List<T> _list;
    int _index = -1;

    public SimleStruct(List<T> list) => _list = list;

    public T Current => _list[_index];

    public bool MoveNext()
    {
        _index++;
        return _index < _list.Count;
    }

    object IEnumerator.Current => Current;
    public void Dispose() { }
    public void Reset() { }

}
static class ExtetionMethod
{
    static int BoolToInt(this bool b)
    {
        return b ? 1 : 0;
    }

    static int NLettersInString (this string s)
    {
        return s.Length;
    }

    static int FactorialMe(this ref int x)
    {
        int f = 0;

        if (x <= 0)
        {
            return 0;
        }
        else
        {
            for (int i = 1; i < x; i++)
            {
                f = f * i;
            }
        }

        
    }
}