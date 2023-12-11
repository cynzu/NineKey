using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineKey.Structures
{
    /// <summary>
    /// Class <c>Letter</c> represents a letter in the alphabet or the dot character. 
    /// A Letter may belong to zero or more ngrams, letters which are commonly 
    /// adjacent, ex: "st" and "er" are commonly adjacent. The info about which
    /// ngrams a letter belongs to is used by the FitnessTester. If a Layout places
    /// many commonly adjacent letters in a way that is easy to type, then that 
    /// increases the fitness _score of a layout.
    /// </summary>
    internal class Letter
    {
        // this is relative _frequency, with a higher number
        // meaning it is used more often in the English language
        // than a letter with a lower _frequency
        private readonly int _frequency;
        private readonly char _name;
        private readonly int _ordinal;
        private readonly NGram[] _ngrams;

        private static Letter[] _allLetters = new Letter[Config.NUMBER_OF_KEYS]; // A - Z plus . [dot]
        private static Dictionary<char, Letter> _lettersByName =
            new Dictionary<char, Letter>();

        public int Frequency => _frequency;
        public char Name => _name;
        public int Ordinal => _ordinal;

        public NGram[] NGrams
        {
            get
            {
                NGram[] copy = new NGram[_ngrams.Length];
                _ngrams.CopyTo(copy, 0); // return a copy to preserve immutability 
                return copy;
            }
        }

        public static Letter[] AllLetters
        {
            get
            {
                Letter[] copy = new Letter[_allLetters.Length];
                _allLetters.CopyTo(copy, 0); // return a copy to preserve immutability 
                return copy;
            }
        }

        public static Letter GetLetterByName(char name)
        {
            return _lettersByName[name];
        }

        private Letter(int frequency, char name, int ordinal = 0)
        {
            _frequency = frequency;
            _name = name;
            _ordinal = ordinal; // not sure if this will ever be used cz 12/07/2023
            _ngrams = NGram.GetNGramsForChar(name).ToArray();
            _lettersByName[name] = this;
        }

        static Letter()
        {
            int n = 0;

            // _frequency info (1st param passed to Letter constructor)
            // is derived from: https://www3.nd.edu/~busiforc/handouts/cryptography/letterfrequencies.html
            // but modified to use relative _frequency
            _allLetters[n++] = new Letter(24, 'a', n);
            _allLetters[n++] = new Letter(7, 'b', n);
            _allLetters[n++] = new Letter(14, 'c', n);
            _allLetters[n++] = new Letter(17, 'd', n);
            _allLetters[n++] = new Letter(26, 'e', n);
            _allLetters[n++] = new Letter(12, 'f', n);
            _allLetters[n++] = new Letter(9, 'g', n);
            _allLetters[n++] = new Letter(18, 'h', n);
            _allLetters[n++] = new Letter(22, 'i', n);

            _allLetters[n++] = new Letter(2, 'j', n);
            _allLetters[n++] = new Letter(5, 'k', n);
            _allLetters[n++] = new Letter(15, 'l', n);
            _allLetters[n++] = new Letter(13, 'm', n);
            _allLetters[n++] = new Letter(21, 'n', n);
            _allLetters[n++] = new Letter(23, 'o', n);
            _allLetters[n++] = new Letter(8, 'p', n);
            _allLetters[n++] = new Letter(3, 'q', n);
            _allLetters[n++] = new Letter(19, 'r', n);

            _allLetters[n++] = new Letter(20, 's', n);
            _allLetters[n++] = new Letter(25, 't', n);
            _allLetters[n++] = new Letter(15, 'u', n);
            _allLetters[n++] = new Letter(6, 'v', n);
            _allLetters[n++] = new Letter(10, 'w', n);
            _allLetters[n++] = new Letter(4, 'x', n);
            _allLetters[n++] = new Letter(11, 'y', n);
            _allLetters[n++] = new Letter(1, 'z', n);
            _allLetters[n++] = new Letter(27, '.', n);
        }

        public override string ToString()
        {
            return _name.ToString();
        }

        public override bool Equals(object? obj)
        {
            return obj is Letter letter &&
                   _frequency == letter._frequency &&
                   _name == letter._name &&
                   _ordinal == letter._ordinal &&
                   EqualityComparer<NGram[]>.Default.Equals(_ngrams, letter._ngrams);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    } // end of class Letter
} // end of namespace NineKey.Structures
