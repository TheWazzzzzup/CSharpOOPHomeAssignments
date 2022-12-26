class Delegates
{
    Predicate<string> LimitedPrerequisite;

    List<string> ObserList;

    void AddToList(Predicate<string> Predicate)
    {
        LimitedPrerequisite = Predicate;
    }

    void UserAdd(string s)
    {
        
    }
    
}