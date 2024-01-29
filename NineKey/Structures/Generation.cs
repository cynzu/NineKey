using NineKey.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineKey.Structures
{
    /// <summary>
    /// Class <c>Generation</c> holds a collection of char arrays which
    /// represent possible keyboard layouts of 3 rows and 3 columns using
    /// 3 separate layers. That adds up to 27: one key for each letter plus a 
    /// key for the dot character.
    /// 
    /// The GenerationProducer class sends each Generation 
    /// to the FitnessTester class to determine how efficent 
    /// each char [] layout is, using criteria like:
    /// keys frequently grouped together are easily reached,
    /// letters used most frequently are on the top-most layer, etc.
    /// 
    /// The Generation keeps track of the highest _score and which char[] layouts achieved that _score.
    /// 
    /// </summary>
    internal class Generation : IGeneration
    {
        /// <summary>
        /// the _ordinal representing when this Generation was created relative 
        /// to other Generations, ex: the first generation is 0, next is 1, etc.
        /// </summary>
        private int _ordinal = 0;

        /// <summary>
        /// the highest _score achieved by any of the NineKeyLayout layouts in this generation
        /// </summary>
        private int _topScore = 0;

        /// <summary>
        /// the list of NineKeyLayouts in this Generation
        /// </summary>
        private NineKeyLayout[] _layouts = Array.Empty<NineKeyLayout>();

        /// <summary>
        /// a list of layouts which achieved the top _score in this generation
        /// </summary>
        private readonly List<NineKeyLayout> _topScoringLayouts = new List<NineKeyLayout>();

        private readonly Dictionary<int, HashSet<NineKeyLayout>> _layoutsByScore
            = new();

        /// <summary>
        /// the _ordinal representing when this Generation was created relative 
        /// to other Generations, ex: the first generation is 0, next is 1, etc.
        /// </summary>
        public int Ordinal { get => _ordinal; init => _ordinal = value; }

        /// <summary>
        /// the list of NineKeyLayouts in this Generation
        /// </summary>
        public NineKeyLayout[] Layouts { get => _layouts; init => _layouts = value; }

        /// <summary>
        /// the highest _score achieved by any of the NineKeyLayout layouts in this generation
        /// </summary>
        public int TopScore { get => _topScore; set => _topScore = value; }

        /// <summary>
        /// a list of layouts which achieved the top _score in this generation
        /// </summary>
        public List<NineKeyLayout> TopScoringLayouts { get => _topScoringLayouts; }
        
        public Dictionary<int, HashSet<NineKeyLayout>> LayoutsByScore { get => _layoutsByScore; }

    public Generation(NineKeyLayout[] layouts, int ordinal)
        {
            _layouts = layouts;
            Ordinal = ordinal;
        }

        public Generation(Generation cloneMe)
        {
            _layouts = cloneMe._layouts;
            _ordinal = cloneMe._ordinal + 1;
            foreach (var layout in _layouts)
            {
                layout.FitnessScore = 0; // reset this
            }
        }

        /// <summary>
        /// TallyScores keeps track of the topScore in this Generation
        /// and which NineKeyLayouts achieved that score.
        /// </summary>
        public void TallyScores()
        {
            int topScore = 0;
            foreach (var layout in _layouts)
            {
                if (layout.FitnessScore > topScore)
                {
                    topScore = layout.FitnessScore;
                }
            }
            _topScore = topScore;

            // keep track of what each layout scored
            foreach (NineKeyLayout layout in _layouts)
            {
                if (layout.FitnessScore == _topScore)
                {
                    _topScoringLayouts.Add(layout);
                }
                

                if (!_layoutsByScore.ContainsKey(layout.FitnessScore))
                {
                    HashSet<NineKeyLayout> values = new()
                    {
                        layout
                    };
                    _layoutsByScore[layout.FitnessScore] = values;
                } 
                else
                {
                    HashSet<NineKeyLayout> values = _layoutsByScore[layout.FitnessScore];
                    values.Add(layout);
                }
                
            }

            Array.Sort(_layouts);

        } // end of TallyScores

        /// <summary>
        /// Replace the NineKeyLayout instance at the index passed in
        /// with the NineKeyLayout nkl parameter.
        /// </summary>
        /// <param name="index">the index of the layout to replace</param>
        /// <param name="nkl">the NineKeyLayout to use as a replacement</param>
        public void ReplaceLayout(int index, NineKeyLayout nkl)
        {
            _layouts[index] = nkl;
        }

    } // end of class Generation
} // end of namespace NineKey.Structures
﻿