using System;

namespace Day2.Core
{
    /// <summary>
    /// Represents a human
    /// </summary>
    public class Human
    {
        // human parameters
        protected string _name;
        protected uint _age;

        public string Name { get => _name; }

        /// <summary>
        /// Base constructor for Human initialization
        /// </summary>
        public Human(string name, uint age)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));
            if (age == 0)
                throw new ArgumentOutOfRangeException(nameof(age));

            _name = name;
            _age = age;
        }
    }
}
