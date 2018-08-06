using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Day2.Core.Tyans.Settings;

namespace Day2.Core.Tyans
{
    /// <summary>
    /// Creates a factory to generate tyans
    /// </summary>
    public sealed class TyanFactory : Factory<Tyan>
    {
        // array of names to generate instances   
        private string[] _names;
        // count of instances to generate
        private ulong _count;      

        /// <summary>
        /// Constructor to set factory parameters
        /// </summary>
        /// <param name="settings">FactorySettings instance with specified parameters</param>
        public TyanFactory(FactorySettings settings)
        {
            _names = settings.Names;
            _count = settings.Count;
        }

        /// <summary>
        /// Generates instances with parameters, specified in FactorySettings instance
        /// </summary>
        /// <returns>ReadOnlyCollection of tyans</returns>
        public override ReadOnlyCollection<Tyan> Generate()
        {
            var tyans = new List<Tyan>();
            var rnd = new Random(GetSeed());

            for (ulong i = 0; i < _count; i++)
            {
                tyans.Add(new Tyan(_names[rnd.Next(_names.Length)], 
                                   (uint)rnd.Next(Tyan.MIN_AGE, Tyan.MAX_AGE + 1),
                                   (ushort)rnd.Next(Tyan.MIN_BREAST_SIZE, Tyan.MAX_BREAST_SIZE),
                                   (Tyan.Kawaiiness)rnd.Next(Tyan.KawaiinessVariants)                         
                         ));
            }
            return new ReadOnlyCollection<Tyan>(tyans);
        }
    }
}
