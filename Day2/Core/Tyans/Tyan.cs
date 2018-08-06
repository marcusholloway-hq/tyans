using System;

namespace Day2.Core
{
    /// <summary>
    /// Represents a tyan. Inherited from Human
    /// </summary>
    public sealed class Tyan : Human
    {
        public const ushort MIN_BREAST_SIZE = 2;
        public const ushort MAX_BREAST_SIZE = 5;
        public const ushort MIN_AGE = 18;
        public const ushort MAX_AGE = 25;

        // number of variants in enum Attractive_Kawaii
        public static readonly int KawaiinessVariants
            = Enum.GetNames(typeof(Kawaiiness)).Length;

        public enum Kawaiiness { Ultra, Super, Middle, Low }

        private ushort _breastSize = 2;
        private Kawaiiness _kawaiiness = Kawaiiness.Middle;

        /// <summary>
        /// Basic constructor to set only name and age. 
        /// Sets other parameters to default.
        /// Inherited from Human.
        /// </summary>
        public Tyan(string name, uint age) : base (name, age)
        {
        }

        /// <summary>
        /// Extended constructor to set all parameters. Inherited from Human.
        /// </summary>
        public Tyan(string name, uint age, ushort breastSize, Kawaiiness kawaiiness) : base (name, age)
        {
            if (breastSize > MAX_BREAST_SIZE)
                throw new ArgumentException
                    ($"Input parameter is bigger than max value ({MAX_BREAST_SIZE})",
                    nameof(breastSize));

            if (breastSize < MIN_BREAST_SIZE)
                throw new ArgumentException
                    ($"Input parameter is bigger than max value ({MAX_BREAST_SIZE})",
                    nameof(breastSize));

            _breastSize = breastSize;
            _kawaiiness = kawaiiness;
        }

        // TODO: Remove temp override
        public override string ToString()
        { 
            return $"Name: {_name} Age: {_age} Breast size: {_breastSize} Kawaiiness: {_kawaiiness}";
        }

        /// <summary>
        /// Overloaded Equals() to compare all parameters except _name
        /// </summary>
        /// <returns>true is all parameters (except name) are equal</returns>
        public bool Equals(Tyan tyan)
        {
            if (_age == tyan._age 
                && _breastSize == tyan._breastSize 
                && _kawaiiness == tyan._kawaiiness)
                return true;

            return false;
        }
    }
}