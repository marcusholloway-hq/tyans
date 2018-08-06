using System;

namespace Day2.Core.Tyans.Settings
{
    /// <summary>
    /// Settings for factory
    /// </summary>
    public class FactorySettings
    {
        // array of names to generate instances, inherited from Human     
        public string[] Names { get; }
        // count of instances to generate
        public ulong Count { get; }

        /// <summary>
        /// Basic constructor to set only array of names.
        /// Count will be set to the default value.
        /// </summary>
        /// <param name="names">Array of names for objects</param>
        public FactorySettings(string[] names)
        {
            if (names == null)
                throw new ArgumentNullException(nameof(names));
            if (names.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(names));

            Names = names;           
        }

        /// <summary>
        /// Settings for factory
        /// </summary>
        /// <param name="names">Array of names for instances</param>
        /// <param name="count">Count of instances to generate</param>
        public FactorySettings(string[] names, ulong count = 10) : this (names)
        {
            if (count == 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            Count = count;
        }
    }
}
