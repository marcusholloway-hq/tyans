using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Day2.Core.Tyans
{
    /// <summary>
    /// Searcher to search Tyan instances
    /// </summary>
    public sealed class TyanSearcher : Searcher
    {
        /// <summary>
        /// Searcher parameters
        /// </summary>
        private ReadOnlyCollection<Tyan> _tyans;
        private uint _age;
        private ushort _breastSize;
        private Tyan.Kawaiiness _kawaiiness;

        /// <summary>
        /// Basic search by age
        /// </summary>
        public TyanSearcher(SearcherSettings<Tyan> settings, uint age)
        {
            if (age == 0)
                throw new ArgumentOutOfRangeException(nameof(age));

            _tyans = settings._objects;
            _age = age;
        }

        /// <summary>
        /// Search by age and breastSize
        /// </summary>
        public TyanSearcher(SearcherSettings<Tyan> settings, uint age, ushort breastSize)
               : this (settings, age)
        {
            if (breastSize == 0)
                throw new ArgumentOutOfRangeException(nameof(age));

            _breastSize = breastSize;
        }

        /// <summary>
        /// Search by age, breastSize and kawaiiness
        /// </summary>
        public TyanSearcher(SearcherSettings<Tyan> settings, uint age, ushort breastSize, Tyan.Kawaiiness kawaiiness)
               : this (settings, age, breastSize)
        {
            _kawaiiness = kawaiiness;
        }

        /// <summary>
        /// Searches tyans by parameters, specified in TyanSearcher
        /// Returns null if 0 tyans found
        /// </summary>
        /// <returns>Array with names of tyans with required parameters</returns>
        public override string[] Search()
        {
            var tyans = new List<string>();
            var sample = new Tyan("Sample", _age, _breastSize, _kawaiiness);

            foreach (var tyan in _tyans)
            {
                if (tyan.Equals(sample))
                    tyans.Add(tyan.Name);
            }

            if (tyans == null || tyans.Count == 0)
                return null;

            return tyans.ToArray();
        }
    }
}
