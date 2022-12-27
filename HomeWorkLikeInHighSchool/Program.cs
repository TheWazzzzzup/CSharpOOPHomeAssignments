LimitedList withoutS = new((s) => s.StartsWith("s"));
withoutS.AddWithPrerequeset("sharon");
withoutS.AddWithPrerequeset("shay");
withoutS.AddWithPrerequeset("shnitzel");
withoutS.AddWithPrerequeset("rotem");
withoutS.AddWithPrerequeset("rotem7");
withoutS.AddWithPrerequeset("rotem5");
withoutS.AddWithPrerequeset("rotem3");
withoutS.AddWithPrerequeset("rotem9");
withoutS.AddWithPrerequeset("rotem6");
withoutS.AddWithPrerequeset("rotem2");

withoutS.PrintAll();

public class LimitedList
{
    public Action itemAdded;

    List<string> limitedList = new();
    Func<string, bool> prerequeset;

    public LimitedList(Func<string, bool> listPrerequeset)
    {
        prerequeset = listPrerequeset;
    }

    public bool AddWithPrerequeset(string input)
    {
        if (prerequeset.Invoke(input))
        {
            limitedList.Add(input);
            itemAdded?.Invoke();
            return true;
        }
        else return false;
    }

    public void PrintAll()
    {
        foreach (string input in limitedList)
        {
            Console.WriteLine(input);
        }
    }
}