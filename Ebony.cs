namespace Brezerkers_Assignemnt
{
    sealed class EbonyHeavy : HeavyUnit
    {
        private int _initMultiplier = 1;

        public override float Multiplier { get => _initMultiplier; protected set => this._initMultiplier = (int)(value * 1.5); }

    }
    sealed class EbonyLight : LightUnit
    {
        private int _initCounter = 5;

        public override int CarryCap { get => base.CarryCap; protected set => base.CarryCap = value;}

        public override int Counters { get => _initCounter; protected set => _initCounter = value; }
    }

    sealed class EbonyBoss : HeavyUnit
    {
        private int _initMultiplier = 1;

        public override float Multiplier { get => _initMultiplier; protected set => this._initMultiplier = (int)(value * 4.5); }
    }
}
