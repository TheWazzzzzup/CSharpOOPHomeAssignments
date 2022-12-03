namespace Brezerkers_Assignemnt
{
    internal abstract class HeavyUnit : Unit
    {
        private int _intialCarryCap;

        public HeavyUnit()
        {
            _intialCarryCap = this.CarryCap;
        }

        public abstract float Multiplier { get; protected set; }
        public override int Hp { protected set => base.Hp = (int)(value * Multiplier); }

        public override int CarryCap { protected set => base.CarryCap = value + 5; }

        public override void WeatherEffect(Weather weather)
        {
            switch (weather)
            {
                case Weather.Scorching:
                    this.CarryCap = base.CarryCap - 5;
                    break;
                case Weather.Freezing:
                    this.Multiplier = 0.8f;
                    break;
                case Weather.Divine:
                    this.Multiplier = 1.2f;
                    break;
                case Weather.Sunny:
                    this.Multiplier = 1;
                    break;
                default:
                    break;
            }
        }

        public override void Defend(Unit Attacker)
        {
            Hp -= Attacker.Damage.Roll();
            Console.WriteLine("\n- - - - - - - - - - - - - -");
            Console.WriteLine(Attacker.ToString().Substring(22) + " Attacked " + this.ToString().Substring(22));
            Console.WriteLine(this.ToString().Substring(22) + (this.IsDead ? " Survived The Attack" : " Joined the graveyard"));
            Console.WriteLine("- - - - - - - - - - - - - -\n");
        }
    }
}
