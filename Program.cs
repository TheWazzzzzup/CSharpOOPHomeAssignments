// - - - - - C# II (Dor Ben Dor) - - - - - - -
//           Amit Yosef Mor Yosef
// - - - - - - - - - - - - - - - - - - - - - -

using Brezerkers_Assignemnt;


class Game
{
    static public void Main(String[] args)
    {
        List<Unit> Ebonies = new();
        List<Unit> Ivories = new();

        for (int i = 0; i < Random.Shared.Next(1, 20); i++)
        {
            int x = Random.Shared.Next(0, 3);
            {
                switch (x)
                {
                    case 0:
                        Ebonies.Add(new EbonyBoss());
                        break;
                    case 1:
                        Ebonies.Add(new EbonyHeavy());
                        break;
                    case 2:
                        Ebonies.Add(new EbonyLight());
                        break;

                }
            }
        }

        for (int i = 0; i < Random.Shared.Next(1, 20); i++)
        {
            int x = Random.Shared.Next(0, 3);
            {
                switch (x)
                {
                    case 0:
                        Ivories.Add(new IvoryHeavy());
                        break;
                    case 1:
                        Ivories.Add(new IvoryLight());
                        break;
                    case 2:
                        Ivories.Add(new TinyNote());
                        break;
                }
            }
        }
        Battle.UnitsBattle(Ebonies, Ivories);
    }


}