namespace Brezerkers_Assignemnt
{
    internal abstract class Unit
    {
        public virtual int CarryCap { get; protected set; } = 10;
        public virtual Dice HitChance { get; protected set; }
        public virtual Dice Protection { get; protected set; }
        public virtual Dice Damage { get; protected set; } = new Dice(2, 8, -5);
        public virtual int Hp { get; protected set; } = 20;
        public virtual void Attack(Unit Defender)
        {
            Defender.Defend(this);
        }
        public abstract void Defend(Unit Attacker);
        public abstract void WeatherEffect(Weather weather);
        protected enum _race { Ebony, Ivory, Hermione };
        public virtual bool IsDead => Hp <= 0;
    }
}
