namespace Brezerkers_Assignemnt
{
    sealed class IvoryLight : LightUnit
    {
        private int _initCounter = 2;

        public override int Counters { get => _initCounter; protected set => this._initCounter = value; }
    }

    sealed class IvoryHeavy : HeavyUnit
    {
        private int _initMultiplier = 1;
        public override float Multiplier { get => _initMultiplier; protected set => this._initMultiplier = (int)(value * 1.2); }
    }

    sealed class TinyNote : HeavyUnit
    {
        private int _initMultiplier = 1;
        public override float Multiplier { get => _initMultiplier; protected set => this._initMultiplier = (int)(value * 0.2); }
    }
}
