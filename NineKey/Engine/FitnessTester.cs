using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NineKey.Structures;

namespace NineKey.Engine
{
    public enum LayerPosition
    {
        TOP, BOTTOM, MIDDLE
    }
    public enum RowPosition
    {
        TOP, BOTTOM, MIDDLE
    }
    public enum ColPosition
    {
        FIRST, SECOND, THIRD
    }

    /// <summary>
    /// Class <c>FitnessTester</c> judges how efficient each NineKeyLayout is.
    /// </summary>
    internal class FitnessTester
    {
        /// <summary>
        /// Applies tests to judge how fit the layout is.
        /// </summary>
        /// <param name="layout">the NineKeyLayout to test</param>
        /// <returns>an int representing the layout's fitness</returns>
        public int Test(NineKeyLayout layout)
        {
            int score = 0;
            try
            {
                score += SetTopLayerScore(layout);
                NGramInLayout[] ngil = new NGramInLayout[NGram.AllNGrams.Length];
                for (int n = 0; n < NGram.AllNGrams.Length; n++)
                {
                    NGram ng = NGram.AllNGrams[n];
                    ngil[n] = new NGramInLayout(ng, layout);

                    SetNGramInLayoutData(ngil[n]);
                    SetNGramInLayoutScore(ngil[n]);
                    score += ngil[n].Score;

                } // end of looping over AllNGrams 

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString()); // better logging needed here
            }
            return score;
        } // end of Test

        /// <summary>
        /// The layout is rewarded for having the most frequently used 
        /// keys on the topmost layer.
        /// </summary>
        private int SetTopLayerScore(NineKeyLayout layout)
        {
            int score = 500; // keep the weight somewhat proportional to the ngram scores

            // the first 9 letters are on the topmost layer
            for (int i = 0; i < 8; i++)
            {
                score += Letter.GetLetterByName(layout.KeyLetters[i]).Frequency * 100;
            }
            return score;
        } // end of SetTopLayerScore

        /// <summary>
        /// NGramInLayout objects hold a NineKeyLayout plus a single NGram, such as 'er'.
        /// This method updates data about that Ngram in that layout, such as whether
        /// or not the NGram chars are all on the same layer or all on adjacent rows.
        /// </summary>
        /// <param name="ngil">the NGramInLayout</param>
        private void SetNGramInLayoutData(NGramInLayout ngil)
        {
            NineKeyLayout layout = ngil.Layout;
            NGram ng = ngil.NGram;

            int indexOfCharInLayout = -1;
            HashSet<LayerPosition> layerPositions = new HashSet<LayerPosition>();
            HashSet<RowPosition> rowPositions = new HashSet<RowPosition>();
            HashSet<ColPosition> colPositions = new HashSet<ColPosition>();

            for (int c = 0; c < ng.Chars.Length; c++)
            {
                indexOfCharInLayout = Array.IndexOf(layout.KeyLetters, ng.Chars[c]);
                ngil.SetCharIndex(ng.Chars[c], indexOfCharInLayout);

                // how many layers are used by the ngram? 
                LayerPosition lp = GetLayerPosition(indexOfCharInLayout);
                layerPositions.Add(lp);

                // which rows are the ngram chars on?  
                RowPosition rp = GetRowPosition(indexOfCharInLayout);
                rowPositions.Add(rp);

                // which cols are the ngram chars on?  
                ColPosition cp = GetColPosition(indexOfCharInLayout);
                colPositions.Add(cp);
            }
            // how many layers are used by the ngram?
            ngil.NumOfDiffLayers = layerPositions.Count;

            // are the rows adjacent?
            ngil.AllOnAdjacentRows = AreRowsAdjacent(rowPositions);

            // are the columns adjacent? 
            ngil.AllOnAdjacentCols = AreColsAdjacent(colPositions);

            // are all ngram chars on the same row?  
            ngil.AllOnSameRow = rowPositions.Count == 1;

            // are all ngram chars on the same column?  
            ngil.AllOnSameColumn = colPositions.Count == 1;

            // are all ngram chars on the same diagonal?
            ngil.AllOnSameDiagonal =
                colPositions.Count == ng.Chars.Length &&
                rowPositions.Count == ng.Chars.Length &&
                ngil.AllOnAdjacentRows == true &&
                ngil.AllOnAdjacentCols == true;

            // are all the ngram chars using the same key on different layers? 
            ngil.AllOnSameKey =
                rowPositions.Count == 1 &&
                colPositions.Count == 1 &&
                layerPositions.Count == ng.Chars.Length;

            // for trigrams, the order counts,
            //     ex: 'the' or 'eht' are easy to type
            //         but 'teh' or 'het' are more difficult 
            // bigrams are always in the correct order
            //     ex: 'er' and 're' are easy to type in either order
            ngil.InCorrectOrder =
                ng.Chars.Length == 2 ||
                ng.Chars.Length == 3 && IndexIsInCenterSquare(ng.Chars[1]);

        } // end of SetNGramInLayoutData

        /// <summary>
        /// After SetNGramInLayoutData determines the characteristics of the
        /// NGramInLayout, this method uses that data to score the efficiency.
        /// </summary>
        /// <param name="ngil">the NGramInLayout instance which is getting its score set</param>
        private void SetNGramInLayoutScore(NGramInLayout ngil)
        {
            int score = 0;
            int weight = ngil.NGram.Frequency; // ngrams that are more common earn a higher _score

            if (ngil != null)
            {
                score += GetRowScore(ngil, weight);
                score += GetColScore(ngil, weight);
                score += GetDiagonalScore(ngil, weight);
                score += GetLayerScore(ngil, weight);

                if (ngil.NGram.Chars.Length > 2 && ngil.InCorrectOrder)
                {
                    score += weight + 100; // trigrams in correct order get bonus points
                }
                ngil.Score = score;
            }
        } // end of SetNGramInLayoutScore


        /// <summary>
        /// Given the index of a char in a 27 char array,
        /// return the layer that it occupies in a 3 layer keyboard layout
        /// of 3 cols and 3 rowPositions.
        /// </summary>
        /// <param name="index">the position of a char in the char[27] </param>
        /// <returns>LayerPosition enum value representing the index of the layer</returns>
        private LayerPosition GetLayerPosition(int index)
        {
            LayerPosition position = LayerPosition.TOP;
            if (index >= 0 && index <= 8)
            {
                position = LayerPosition.TOP;
            }
            else if (index >= 9 && index <= 17)
            {
                position = LayerPosition.MIDDLE;
            }
            else if (index >= 8 && index <= 26)
            {
                position = LayerPosition.BOTTOM;
            }
            else
            {
                throw new ArgumentException("index must be >= 0 and <= 27");
            }

            return position;
        } // end of GetLayerPosition

        /// <summary>
        /// Given the index of a char in a 27 char array,
        /// return the row that it occupies in a 3 layer keyboard layout
        /// of 3 cols and 3 rowPositions.
        /// </summary>
        /// <param name="index">the position of a char in the char[27] </param>
        /// <returns>RowPosition enum value representing the index of the row</returns>
        private RowPosition GetRowPosition(int index)
        {
            RowPosition position = RowPosition.TOP;
            if (index >= 0 && index <= 2 ||
                index >= 9 && index <= 11 ||
                index >= 18 && index <= 20)
            {
                position = RowPosition.TOP;
            }
            else if (index >= 3 && index <= 5 ||
                index >= 12 && index <= 14 ||
                index >= 21 && index <= 23)
            {
                position = RowPosition.MIDDLE;
            }
            else if (index >= 6 && index <= 8 ||
                index >= 15 && index <= 17 ||
                index >= 24 && index <= 26)
            {
                position = RowPosition.BOTTOM;
            }
            else
            {
                throw new ArgumentException("index must be >= 0 and <= 27");
            }

            return position;
        } // end of GetRowPosition


        /// <summary>
        /// Given the index of a char in a 27 char array,
        /// return the column that it occupies in a 3 layer keyboard layout
        /// of 3 cols and 3 rowPositions.
        /// </summary>
        /// <param name="index">the position of a char in the char[27] </param>
        /// <returns>ColPosition enum value representing the index of the column</returns>
        private ColPosition GetColPosition(int index)
        {
            ColPosition position = ColPosition.FIRST;

            if (index % 3 == 0)
            {
                position = ColPosition.FIRST;
            }
            else if (index % 3 == 1)
            {
                position = ColPosition.SECOND;
            }
            else if (index % 3 == 2)
            {
                position = ColPosition.THIRD;
            }
            else
            {
                throw new ArgumentException("index must be >= 0 and <= 27");
            }

            return position;
        } // end of GetColPosition

        /// <summary>
        /// Returns true if the row positions passed in as a parameter are adjacent,
        /// else returns false.
        /// </summary>
        /// <param name="rowPositions">the group of row positions to consider</param>
        /// <returns>true when the rows are adjacent, else returns false</returns>
        private bool AreRowsAdjacent(HashSet<RowPosition> rowPositions)
        {
            bool adj = false;

            if (rowPositions.Count == 1)
            {
                adj = true;
            }
            else if (rowPositions.Count >= 2 && rowPositions.Contains(RowPosition.MIDDLE))
            {
                adj = true;
            }

            return adj;
        } // end of AreRowsAdjacent

        /// <summary>
        /// Returns true if the column positions passed in as a parameter are adjacent,
        /// else returns false.
        /// </summary>
        /// <param name="colPositions">the group of column positions to consider</param>
        /// <returns>true when the columns are adjacent, else returns false</returns>
        private bool AreColsAdjacent(HashSet<ColPosition> colPositions)
        {
            bool adj = false;

            if (colPositions.Count == 1)
            {
                adj = true;
            }
            else if (colPositions.Count >= 2 && colPositions.Contains(ColPosition.SECOND))
            {
                adj = true;
            }

            return adj;
        } // end of AreColsAdjacent

        /// <summary>
        /// Returns true if the index passed in as a parameter holds the center
        /// position of any row or column in the 9 x 9 x 3-layer grid.
        /// </summary>
        /// <param name="index">the index of a position in a 9 x 9 grid on 3 layers
        ///     which has been 'flattened' into a char[27] </param>
        /// <returns>true if the index passed in as a parameter holds the center
        ///     position of any row or column in the 9 x 9 x 3-layer grid.</returns>
        private bool IndexIsInCenterSquare(int index)
        {
            bool isCenter = false;

            if (Array.IndexOf(new int[] { 1, 3, 4, 5, 7, 10, 12, 13, 14, 16, 19, 21, 22, 23, 25 }, index) > -1)
            {
                isCenter = true;
            }

            return isCenter;
        } // end of IndexIsInCenterSquare

        /// <summary>
        /// Provides an int representing the fitness of the NGramInLayout
        /// focusing on how well the rows are laid out.
        /// </summary>
        /// <param name="ngil">the NGramInLayout instance to test</param>
        /// <param name="weight">an int representing how often the ngram appears
        ///     in the English language</param>
        /// <returns>an int representing the fitness of the NGramInLayout
        /// focusing on how well the rows are laid out</returns>
        private int GetRowScore(NGramInLayout ngil, int weight)
        {
            int score = 0;
            if (ngil.AllOnSameRow && ngil.NumOfDiffLayers == 1)
            {
                score += weight + 100;
            }
            else if (ngil.AllOnSameRow && ngil.NumOfDiffLayers == 2)
            {
                score += weight + 45;
            }
            else if (ngil.AllOnSameRow && ngil.NumOfDiffLayers == 3)
            {
                score += weight + 10;
            }
            if (ngil.AllOnAdjacentRows)
            {
                score += weight + 30;
            }
            return score;
        } // end of GetRowScore


        /// <summary>
        /// Provides an int representing the fitness of the NGramInLayout
        /// focusing on how well the columns are laid out.
        /// </summary>
        /// <param name="ngil">the NGramInLayout instance to test</param>
        /// <param name="weight">an int representing how often the ngram appears
        ///     in the English language</param>
        /// <returns>an int representing the fitness of the NGramInLayout
        /// focusing on how well the columns are laid out</returns>
        private int GetColScore(NGramInLayout ngil, int weight)
        {
            int score = 0;
            if (ngil.AllOnSameColumn && !ngil.AllOnSameKey) // same col can be an impediment so subtract  
            {
                score -= 50;
            }
            else if (ngil.AllOnSameKey)
            {
                score += 20;
            }
            if (ngil.AllOnAdjacentCols)
            {
                score += weight + 10;
            }

            return score;
        } // end of GetColScore


        /// <summary>
        /// Provides an int representing the fitness of the NGramInLayout
        /// focusing on how well the diagonal grid-cells are laid out.
        /// </summary>
        /// <param name="ngil">the NGramInLayout instance to test</param>
        /// <param name="weight">an int representing how often the ngram appears
        ///     in the English language</param>
        /// <returns>an int representing the fitness of the NGramInLayout
        /// focusing on how well the diagonal grid-cells  are laid out</returns>
        private int GetDiagonalScore(NGramInLayout ngil, int weight)
        {
            int score = 0;
            if (ngil.AllOnSameDiagonal && ngil.NumOfDiffLayers == 1)
            {
                score += weight + 250;
            }
            else if (ngil.AllOnSameDiagonal && ngil.NumOfDiffLayers == 2)
            {
                score += weight + 30;
            }
            else if (ngil.AllOnSameDiagonal && ngil.NumOfDiffLayers == 3)
            {
                score += weight + 5;
            }

            return score;
        } // end of GetDiagonalScore


        /// <summary>
        /// Provides an int representing the fitness of the NGramInLayout
        /// focusing on how well the layers are laid out.
        /// </summary>
        /// <param name="ngil">the NGramInLayout instance to test</param>
        /// <param name="weight">an int representing how often the ngram appears
        ///     in the English language</param>
        /// <returns>an int representing the fitness of the NGramInLayout
        /// focusing on how well the layers are laid out</returns>
        private int GetLayerScore(NGramInLayout ngil, int weight)
        {
            int score = 0;
            if (ngil.NumOfDiffLayers == 1)
            {
                score += weight + 100;
            }
            else if (ngil.NumOfDiffLayers == 2 && ngil.NGram.Chars.Length > 2)
            {
                score += weight + 10;
            }
            else if (ngil.NumOfDiffLayers == 3 && !ngil.AllOnSameKey)
            {
                score -= weight + 5; // subtract points if all are on different layers
            }

            return score;
        } // end of GetDiagonalScore
    } // end of abstract class FitnessTester
}  // end of namespace NineKey
