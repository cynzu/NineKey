using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineKey
{
    /// <summary>
    /// Class <c>Config</c> holds the constants used when running the genetic algorithm.
    /// </summary>
    internal abstract class Config
    {
        /// <summary>
        /// // A - Z plus . [dot]
        /// </summary>
        public const int NUMBER_OF_KEYS = 27;

        /// <summary>
        /// the number of individual layouts to generate in each Population
        /// </summary>
        public const int POPULATION_SIZE = 50;

        /// <summary>
        /// the number of times populations will be created and tested
        /// </summary>
        public const int NUMBER_OF_GENERATIONS = 100;

        /// <summary>
        /// the number of times letters will be have their position
        /// in the layout swapped  
        /// </summary>
        public const int NUMBER_OF_MUTATIONS = 5;

        /// <summary>
        /// the percentage of layouts to be replaced in the next generation
        /// that many low scoring layouts will be discarded and replaced
        /// with that many mutated top scoring layouts from the parent generation
        /// </summary>
        public const double PERCENT_TO_REPLACE = .3;
    }

}
