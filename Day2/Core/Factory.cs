using System;
using System.Collections.ObjectModel;
using System.Security.Cryptography;

namespace Day2.Core
{
    /// <summary>
    /// Factory to generate instances
    /// </summary>
    public class Factory<T> where T : class
    {
        /// <summary>
        /// Generates instances with random parameters
        /// </summary>
        /// <returns>ReadOnlyCollection with generated instances</returns>
        public virtual ReadOnlyCollection<T> Generate()
        {
            return null;
        }

        /// <summary>
        /// Generates secure seed for Random instances
        /// </summary>
        /// <returns>Secure seed</returns>
        protected static int GetSeed()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var intBytes = new byte[4];
                rng.GetBytes(intBytes);
                return BitConverter.ToInt32(intBytes, 0);
            }
        }
    }
}
