using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineKey.Structures
{
    /// <summary>
    /// 
    /// </summary>
    internal class NGramInLayout
    {
        private NineKeyLayout _layout;
        private NGram _nGram;
        private Dictionary<char, int> _charIndexes = new Dictionary<char, int>();
        private int _score = 0;

        public NGramInLayout(NGram nGram, NineKeyLayout layout)
        {
            _nGram = nGram;
            _layout = layout;
        }

        /// <summary>
        /// the chars in this ngram are all on 1 layer, spread over 2 layers, 
        /// or spread over 3 layers in the layout
        /// </summary>
        private int _numOfDiffLayers;

        /// <summary>
        /// true if all chars in the ngram are on the same row, else false  
        /// </summary>
        private bool _allOnSameRow;

        /// <summary>
        /// true if all chars in the ngram are on the adjacent rows
        /// ex: one char is on the top row and all other chars are on the middle row
        /// </summary>
        private bool _allOnAdjacentRows;

        /// <summary>
        /// true if all chars in the ngram are on the adjacent columns
        /// ex: in a bigram, one char is on the firs col, the second char is on the second col
        /// </summary>
        private bool _allOnAdjacentCols;

        /// <summary>
        /// true if all chars in the ngram are lined up on a diagonal in the layout
        /// </summary>
        private bool _allOnSameDiagonal;

        /// <summary>
        /// true if all chars in the ngram are on the same column, else false  
        /// </summary>
        private bool _allOnSameColumn;

        /// <summary>
        /// true if all chars in the ngram use the same exact key but on different layers,
        /// ex: 't' is on the top left corner on layer 0, 'h'  is on the top left corner on layer 1
        ///     and 'e' is on the top left corner on layer 2
        /// </summary>
        private bool _allOnSameKey;

        /// <summary>
        /// for bigrams, this will always be true
        /// for trigrams, this is true when the chars are in the same order
        /// or reverse order in the layout,
        ///     ex: ngram = the; same or reversed order are: the and eht, but not het or teh
        /// </summary>
        private bool _inCorrectOrder = true;

        public int NumOfDiffLayers { get => _numOfDiffLayers; set => _numOfDiffLayers = value; }
        public bool AllOnSameRow { get => _allOnSameRow; set => _allOnSameRow = value; }
        public bool AllOnAdjacentRows { get => _allOnAdjacentRows; set => _allOnAdjacentRows = value; }
        public bool AllOnAdjacentCols { get => _allOnAdjacentCols; set => _allOnAdjacentCols = value; }
        public bool AllOnSameDiagonal { get => _allOnSameDiagonal; set => _allOnSameDiagonal = value; }
        public bool AllOnSameColumn { get => _allOnSameColumn; set => _allOnSameColumn = value; }
        public bool AllOnSameKey { get => _allOnSameKey; set => _allOnSameKey = value; }
        public bool InCorrectOrder { get => _inCorrectOrder; set => _inCorrectOrder = value; }

        public NineKeyLayout Layout { get => _layout; }
        public NGram NGram { get => _nGram; }
        public int Score { get => _score; set => _score = value; }

        public void SetCharIndex(char c, int index)
        {
            _charIndexes.Add(c, index);
        }
    } // end of class NGramInLayout
} // end of namespace NineKey.Structures
