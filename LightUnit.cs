namespace Brezerkers_Assignemnt
{
    internal abstract class LightUnit : Unit
    {
        private int _intialCarryCap;
        private IRandomProvider rng = new Bag();

        public LightUnit()
        {
            _intialCarryCap = this.CarryCap;
        }

        public override IRandomProvider Damage { get => rng; protected set => base.Damage = value; }

        public abstract int Counters { get; protected set; }

        public override void WeatherEffect(Weather weather)
        {
            switch (weather)
            {
                case Weather.Scorching:
                    this.CarryCap = this.CarryCap - 2;
                    break;
                case Weather.Freezing:
                    if (this.Counters > 0)
                    {
                        this.Counters--;
                    }
                    break;
                case Weather.Divine:
                    if (this.Counters < 20)
                    {
                        this.Counters++;
                    }
                    break;
                case Weather.Sunny:
                    this.CarryCap = _intialCarryCap;
                    break;
                default:
                    break;
            }
        }

        public override void Defend(Unit Attacker)
        {
            Random rnd = new();
            if (Counters > 0 && rnd.Next(0, 2) == 1)
            {
                Console.WriteLine("\n- - - - - - - - - - - - - -");
                Console.WriteLine(Attacker.ToString().Substring(22) + " Attacked " + this.ToString().Substring(22));
                Console.WriteLine(this.ToString().Substring(22) + " Succseffuly Counter Attacked");
                Console.WriteLine("↓ ↓ ↓ ↓ ↓ ↓ ↓ ↓ ↓ ↓ ↓ ↓ ↓ ↓ ↓ ↓");
                Attacker.Defend(this);
            }
            else
            {
                Hp -= Attacker.Damage.RandomNumber();
                Console.WriteLine("- - - - - - - - - - - - - -");
                Console.WriteLine(Attacker.ToString().Substring(22) + " Attacked " + this.ToString().Substring(22));
                Console.WriteLine(this.ToString().Substring(22) + (this.IsDead ? " Survived The Attack" : " Joined the graveyard"));
                Console.WriteLine("- - - - - - - - - - - - - -\n\n");
            }
        }
    }
}
