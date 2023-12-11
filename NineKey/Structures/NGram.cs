using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NineKey.Structures
{
    /// <summary>
    /// Class <c>NGram</c> represents letters which are commonly 
    /// adjacent, ex: "st" and "er" are commonly adjacent. The info about which
    /// groups a letter belongs to is used by the FitnessTester. If a Layout places
    /// many commonly adjacent letters in a way that is easy to type, then that 
    /// increases the fitness _score of a layout.
    /// </summary>
    internal class NGram
    {
        private readonly char[] _chars;
        private readonly int _frequency;
        private static int s_numOfAllNGrams = 45;
        private static NGram[] s_allNGrams = new NGram[s_numOfAllNGrams];
        private static Dictionary<char, List<NGram>> s_NGramsByChar =
            new Dictionary<char, List<NGram>>();

        public char[] Chars => _chars;
        public int Frequency => _frequency;

        public NGram(char[] chars, int frequency)
        {
            _chars = chars;
            _frequency = frequency;
        }

        public static NGram[] AllNGrams
        {
            get
            {
                NGram[] copy = new NGram[s_allNGrams.Length];
                s_allNGrams.CopyTo(copy, 0); // return a copy to preserve immutability 
                return copy;
            }
        }

        public static List<NGram> GetNGramsForChar(char c)
        {
            List<NGram> g = new List<NGram>();
            if (s_NGramsByChar.ContainsKey(c))
            {
                g = s_NGramsByChar[c];
            }
            return g;
        }

        private static void AddNGram(int index, char[] chars)
        {
            if (index > s_numOfAllNGrams)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            NGram ngram = new NGram(chars, s_allNGrams.Length - index);
            s_allNGrams[index] = ngram;
            List<NGram> ngramList = new List<NGram>();
            foreach (char c in chars)
            {
                if (!s_NGramsByChar.ContainsKey(c))
                {
                    ngramList = new List<NGram>();
                }
                else
                {
                    ngramList = s_NGramsByChar[c];
                }
                ngramList.Add(ngram);
                s_NGramsByChar[c] = ngramList;
            }
        } // end of AddNGram(int index, char[]_keyLetters)

        static NGram()
        {
            // _frequency info (1st param passed to AddNGram)
            // is derived from: https://www3.nd.edu/~busiforc/handouts/cryptography/letterfrequencies.html
            // but modified to use relative _frequency

            // it is important to add the most frequent ngrams first
            // because "s_allNGrams.Length - n" is used as the relative _frequency
            int n = 0;
            AddNGram(n++, new char[] { 't', 'h', 'e' });
            AddNGram(n++, new char[] { 'a', 'n', 'd' });
            AddNGram(n++, new char[] { 't', 'h', 'a' });
            AddNGram(n++, new char[] { 'e', 'n', 't' });
            AddNGram(n++, new char[] { 'i', 'n', 'g' });
            AddNGram(n++, new char[] { 'i', 'o', 'n' });
            AddNGram(n++, new char[] { 't', 'i', 'o' });
            AddNGram(n++, new char[] { 'f', 'o', 'r' });
            AddNGram(n++, new char[] { 'n', 'd', 'e' });
            AddNGram(n++, new char[] { 'h', 'a', 's' });
            AddNGram(n++, new char[] { 'n', 'c', 'e' });
            AddNGram(n++, new char[] { 'e', 'd', 't' });
            AddNGram(n++, new char[] { 't', 'i', 's' });
            AddNGram(n++, new char[] { 'o', 'f', 't' });
            AddNGram(n++, new char[] { 's', 't', 'h' });
            AddNGram(n++, new char[] { 'm', 'e', 'n' });

            AddNGram(n++, new char[] { 't', 'e' });
            AddNGram(n++, new char[] { 't', 'h' });
            AddNGram(n++, new char[] { 'h', 'e' });
            AddNGram(n++, new char[] { 'i', 'n' });
            AddNGram(n++, new char[] { 'e', 'n' });
            AddNGram(n++, new char[] { 'n', 't' });
            AddNGram(n++, new char[] { 'r', 'e' });
            AddNGram(n++, new char[] { 'e', 'r' });
            AddNGram(n++, new char[] { 'a', 'n' });
            AddNGram(n++, new char[] { 't', 'i' });
            AddNGram(n++, new char[] { 'e', 's' });
            AddNGram(n++, new char[] { 'o', 'n' });
            AddNGram(n++, new char[] { 'a', 't' });
            AddNGram(n++, new char[] { 's', 'e' });
            AddNGram(n++, new char[] { 'n', 'd' });
            AddNGram(n++, new char[] { 'o', 'r' });
            AddNGram(n++, new char[] { 'a', 'r' });
            AddNGram(n++, new char[] { 'a', 'l' });
            AddNGram(n++, new char[] { 't', 'e' });
            AddNGram(n++, new char[] { 'c', 'o' });
            AddNGram(n++, new char[] { 'd', 'e' });
            AddNGram(n++, new char[] { 't', 'o' });
            AddNGram(n++, new char[] { 'r', 'a' });
            AddNGram(n++, new char[] { 'e', 't' });
            AddNGram(n++, new char[] { 'e', 'd' });
            AddNGram(n++, new char[] { 'i', 't' });
            AddNGram(n++, new char[] { 's', 'a' });
            AddNGram(n++, new char[] { 'e', 'm' });
            AddNGram(n++, new char[] { 'r', 'o' });

        } // end of static NGram()

    } // end of class NGram
} // end of namespace NineKey.Structures
