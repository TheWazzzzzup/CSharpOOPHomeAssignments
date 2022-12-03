namespace Brezerkers_Assignemnt
{
    internal static class Battle
    {
        private static int weatherIndex = 2;
        private static int forceWeather = 6;
        private static int weatherStreak = 0;
        private static bool initialEffect = false;


        public static void UnitsBattle(List<Unit> attackers, List<Unit> defenders)
        {
            List<Unit> winners = new();
            List<Unit> losers = new();

            ArmiesPrint(attackers, defenders);

            RoundManager(attackers, defenders);

            if (IsArmyAlive(attackers))
            {
                Console.WriteLine("The Winners are the attackers");
                winners = attackers;
                losers = defenders;
            }
            else
            {
                Console.WriteLine("The Winners are the Defenders");
                winners = defenders;
                losers = attackers;
            }
            Console.WriteLine("\n The winner have " + ResourceCalculator(winners, losers) + " resources");
        }

        private static void RoundManager(List<Unit> attackers, List<Unit> defenders)
        {
            do
            {
                if (weatherStreak == 0)
                {
                    if (Random.Shared.Next(0, forceWeather) == 0 && weatherStreak == 0)
                    {
                        initialEffect = true;
                        weatherStreak = Random.Shared.Next(1, 4);
                        weatherIndex = Random.Shared.Next(0, 4);
                    }
                }
                if (initialEffect == true)
                {
                    ApplyWeather(attackers, defenders, (Weather)weatherIndex);
                    initialEffect = false;
                }
                if (weatherStreak == 0 && weatherIndex != 2)
                {
                    weatherIndex = 2;
                    ApplyWeather(attackers, defenders, (Weather)weatherIndex);
                }

                RandomUnit(attackers).Attack(RandomUnit(defenders));
                if (IsArmyAlive(attackers) && IsArmyAlive(defenders))
                {
                    RandomUnit(defenders).Attack(RandomUnit(attackers));
                }

                else { break; }
            } while (IsArmyAlive(attackers) && IsArmyAlive(defenders));
        }

        private static void ApplyWeather(List<Unit> attackers, List<Unit> defenders, Weather weather)
        {
            foreach (Unit attacker in attackers)
            {
                attacker.WeatherEffect(weather);
            }
            foreach (Unit defender in defenders)
            {
                defender.WeatherEffect(weather);
            }
        }

        private static int ResourceCalculator(List<Unit> winner, List<Unit> loser)
        {
            int resourcesAvailable = AvailableResource(loser);
            int resourcesCollected = 0;

            foreach (Unit unit in winner)
            {
                if (unit.IsDead == false && resourcesAvailable > 0)
                {
                    if (resourcesAvailable - unit.CarryCap >= 0)
                    {
                        resourcesCollected += unit.CarryCap;
                        resourcesAvailable -= unit.CarryCap;
                    }
                    else
                    {
                        resourcesCollected += resourcesAvailable;
                        resourcesAvailable = 0;
                    }
                }
            }
            return resourcesCollected;
        }

        private static int AvailableResource(List<Unit> defetedArmy)
        {
            int availableResources = 0;

            foreach (Unit unit in defetedArmy)
            {
                availableResources += unit.CarryCap;

            }
            return availableResources;
        }

        private static Unit RandomUnit(List<Unit> listOfUnits)
        {
            var x = Random.Shared.Next(0, listOfUnits.Count);
            Unit unit = listOfUnits[x];
            if (unit.IsDead == false)
            {
                return unit;
            }
            else { return RandomUnit(listOfUnits); }
        }

        private static bool IsArmyAlive(List<Unit> army)
        {
            var deadUnits = 0;
            foreach (var unit in army)
            {
                if (unit.IsDead == true)
                {
                    deadUnits++;
                }
            }
            if (deadUnits == army.Count) { return false; }
            else { return true; }
        }

        private static void ArmiesPrint(List<Unit> attackers, List<Unit> defenders)
        {
            int attackersCarry = 0;
            int defendersCarry = 0;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The Attackers");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var attacker in attackers)
            {
                Console.WriteLine(attacker.ToString().Substring(22));
                attackersCarry += attacker.CarryCap;
            }
            Console.WriteLine("With a total of " + attackersCarry + " resources");
            

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nThe Defenders");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var defender in defenders)
            {
                Console.WriteLine(defender.ToString().Substring(22));
                defendersCarry += defender.CarryCap;
            }
            Console.WriteLine("With a total of " + defendersCarry + " resources\n");
        }
    }
}
