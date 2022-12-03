using System.Diagnostics.CodeAnalysis;

namespace Brezerkers_Assignemnt
{
    public struct Dice
    {
        uint _scalar;
        uint _baseDie;
        int _modifier;

        public Dice(uint scalar, uint baseDie, int modifier)
        {
            _scalar = scalar;
            _baseDie = baseDie;
            _modifier = modifier;
        }

        public int Roll()
        {
            int diceResualt = _modifier;
            for (int i = 0; i < _scalar; i++)
            {
                diceResualt += Random.Shared.Next(0, (int)_baseDie + 1);
            }
            return diceResualt;
        }

        public override string ToString()
        {
            return _scalar + "d, " + _baseDie + " " + (_modifier > -1 ? "+" : "-") + _modifier;
        }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Dice))
            {
                return false;
            }

            var b = (Dice)obj;
            if (b._baseDie == _baseDie && b._modifier == _modifier && b._scalar == _scalar)
            {
                return true;
            }

            else return false;
        }

        public override int GetHashCode()
        {
            return (byte)((_baseDie / 16) + (_modifier * 27) + MathF.Sqrt(_scalar));
        }


    }
}
