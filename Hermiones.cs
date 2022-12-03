using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brezerkers_Assignemnt
{
    sealed class HermioneLight : LightUnit
    {
        private int _initCounter = 20;
        public override int Counters { get => _initCounter; protected set => _initCounter = value ; }
    }

    sealed class HermioneHeavy : HeavyUnit
    {
        private int _initMultiplier = 1;
        public override float Multiplier { get => _initMultiplier; protected set => _initMultiplier = (int)(value * 8.8); }
    }

    sealed class HermioneGranger : HeavyUnit
    {
        private int _initMultiplier = 1;
        public override float Multiplier { get => _initMultiplier + 888; protected set => _initMultiplier = (int)(value * 8.8); }
    }
}
