using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineKey
{
    /// <summary>
    /// Class <c>Config</c> holds the parameters used when running the genetic algorithm.
    /// </summary>
    internal class Config
    {
        public const int DEFAULT_NUM_OF_GENERATIONS = 100;
        public const int DEFAULT_POPULATION_SIZE = 50;
        public const int DEFAULT_NUM_OF_MUTATIONS = 5;
        public const decimal DEFAULT_PERCENT_TO_REPLACE = 33;
        private const bool DEFAULT_LETTERS_LAYERS_BY_FREQ = true;

        /// <summary>
        /// add this number of points when all letters in an ngram
        /// are on the same row and on the same layer
        /// </summary>
        public const int DEFAULT_POINTS_ROW_1_LAYER = 100;

        /// <summary>
        /// add this number of points when all letters in an ngram
        /// are on the same row and on 2 different layers
        /// </summary>
        public const int DEFAULT_POINTS_ROW_2_LAYERS = 50;

        /// <summary>
        /// add this number of points when all letters in an ngram
        /// are on the same row and on 3 different layers
        /// </summary>
        public const int DEFAULT_POINTS_ROW_3_LAYERS = 10;

        /// <summary>
        /// add this number of points when all letters in an ngram
        /// are on the same column and on the same layer
        /// </summary>
        public const int DEFAULT_POINTS_COL_1_LAYER = 10;

        /// <summary>
        /// add this number of points when all letters in an ngram
        /// are on the same column and on 2 different layers
        /// </summary>
        public const int DEFAULT_POINTS_COL_2_LAYERS = 10;

        /// <summary>
        /// add this number of points when all letters in an ngram
        /// are on the same column and on 3 different layers
        /// </summary>
        public const int DEFAULT_POINTS_COL_3_LAYERS = 10;

        /// <summary>
        /// // A - Z plus . [dot]
        /// </summary>
        public const int NUMBER_OF_KEYS = 27;

        private int _populationSize = DEFAULT_POPULATION_SIZE;
        private int _numOfGenerations = DEFAULT_NUM_OF_GENERATIONS;
        private int _numOfMutations = DEFAULT_NUM_OF_MUTATIONS;
        private decimal _percentToReplace = DEFAULT_PERCENT_TO_REPLACE / 100;
        private bool _lettersOnLayersByFreq = DEFAULT_LETTERS_LAYERS_BY_FREQ; // when true, the most frequently used letters are always on the top layer, mid-freq on middle layer, low freq   on lowest layer
        private bool _sameRowSameLayerAdd = true; // add points rather than subtract points
        private bool _sameRow2LayersAdd = true; // add points rather than subtract points
        private bool _sameRow3LayersAdd = true; // add points rather than subtract points
        private bool _sameColSameLayerAdd = false; // subtract points rather than add points
        private bool _sameCol2LayersAdd = false; // subtract points rather than add points
        private bool _sameCol3LayersAdd = false; // subtract points rather than add points
        private int _sameRowSameLayerPoints = 100;
        private int _sameRow2LayersPoints = 50;
        private int _sameRow3LayersPoints = 10;
        private int _sameColSameLayerPoints = 100;
        private int _sameCol2LayersPoints = 50;
        private int _sameCol3LayersPoints = 10;


        /// <summary>
        /// the number of individual layouts to generate in each Population
        /// </summary>
        public int PopulationSize { get => _populationSize; set => _populationSize = value; }
        
        /// <summary>
        /// the number of times populations will be created and tested
        /// </summary>
        public int NumOfGenerations { get => _numOfGenerations; set => _numOfGenerations = value; }

        /// <summary>
        /// the number of times letters will be have their position
        /// in the layout swapped  
        /// </summary>
        public int NumOfMutations { get => _numOfMutations; set => _numOfMutations = value; }

        /// <summary>
        /// the percentage of layouts to be replaced in the next generation
        /// that many low scoring layouts will be discarded and replaced
        /// with that many mutated top scoring layouts from the parent generation
        /// </summary>
        public decimal PercentToReplace { get => _percentToReplace; set => _percentToReplace = value; }
        
        /// <summary>
        /// when all the letters in an ngram are in the same row on the same layer,
        /// should points be added to or subtracted from that NGramInLayout's score?  
        /// </summary>
        public bool SameRowSameLayerAdd { get => _sameRowSameLayerAdd; set => _sameRowSameLayerAdd = value; }

        /// <summary>
        /// when all the letters in an ngram are in the same row but on 2 different layers,
        /// should points be added to or subtracted from that NGramInLayout's score?  
        /// </summary>
        public bool SameRow2LayersAdd { get => _sameRow2LayersAdd; set => _sameRow2LayersAdd = value; }

        /// <summary>
        /// when all the letters in an ngram are in the same row but on 3 different layers,
        /// should points be added to or subtracted from that NGramInLayout's score?  
        /// </summary>
        public bool SameRow3LayersAdd { get => _sameRow3LayersAdd; set => _sameRow3LayersAdd = value; }

        /// <summary>
        /// when all the letters in an ngram are in the same columnn on the same layer,
        /// should points be added to or subtracted from that NGramInLayout's score?  
        /// </summary>
        public bool SameColSameLayerAdd { get => _sameColSameLayerAdd; set => _sameColSameLayerAdd = value; }

        /// <summary>
        /// when all the letters in an ngram are in the same column but on 2 different layers,
        /// should points be added to or subtracted from that NGramInLayout's score?  
        /// </summary>
        public bool SameCol2LayersAdd { get => _sameCol2LayersAdd; set => _sameCol2LayersAdd = value; }

        /// <summary>
        /// when all the letters in an ngram are in the same column but on 3 different layers,
        /// should points be added to or subtracted from that NGramInLayout's score?  
        /// </summary>
        public bool SameCol3LayersAdd { get => _sameCol3LayersAdd; set => _sameCol3LayersAdd = value; }
        public int SameRowSameLayerPoints { get => _sameRowSameLayerPoints; set => _sameRowSameLayerPoints = value; }
        public int SameRow2LayersPoints { get => _sameRow2LayersPoints; set => _sameRow2LayersPoints = value; }
        public int SameRow3LayersPoints { get => _sameRow3LayersPoints; set => _sameRow3LayersPoints = value; }
        public int SameColSameLayerPoints { get => _sameColSameLayerPoints; set => _sameColSameLayerPoints = value; }
        public int SameCol2LayersPoints { get => _sameCol2LayersPoints; set => _sameCol2LayersPoints = value; }
        public int SameCol3LayersPoints { get => _sameCol3LayersPoints; set => _sameCol3LayersPoints = value; }
        public bool LettersOnLayersByFreq { get => _lettersOnLayersByFreq; set => _lettersOnLayersByFreq = value; }

    }

}
