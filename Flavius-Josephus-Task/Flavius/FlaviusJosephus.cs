using System;
using System.Collections.Generic;

namespace Flavius
{
    /// <summary>
    /// The class provides methods for crossing out each k person's qualifier in sequence.
    /// </summary>
    public class FlaviusJosephus
    {
        private List<int> people;

        /// <summary>
        /// Initializes a new instance of the <see cref="FlaviusJosephus"/> class.
        /// </summary>
        /// <param name="count">People count.</param>
        public FlaviusJosephus(int count)
        {
            if (count < 1)
            {
                throw new ArgumentException($"{nameof(count)} less than one");
            }

            this.people = new List<int>(count);
            for (int i = 0; i < count; i++)
            {
                this.people.Add(i + 1);
            }
        }

        /// <summary>
        /// Crossing out each k person's qualifier in sequence.
        /// </summary>
        /// <param name="k">Position.</param>
        /// <returns>People.</returns>
        public IEnumerable<int> Effacement(int k)
        {
            int current = 0;
            int counter = 0;
            while (this.people.Count != 0)
            {
                if (current >= this.people.Count)
                {
                    current = 0;
                }

                if (counter == k - 1)
                {
                    yield return this.people[current];
                    this.people.RemoveAt(current);
                    counter = 0;
                }

                counter++;
                current++;
            }
        }
    }
}
