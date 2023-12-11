using NineKey.Facade;

namespace NineKey.Structures
{
    /// <summary>
    /// Each <c>NineKeyLayout</c> in the represents a keyboard layout
    /// with 3 rows and 3 columns on 3 different layers
    /// consisting of the 26 letters in the alphabet plus a dot.
    /// When translated to an actual keyboard layout, the item at [0] will be 
    /// on the top left key, [1] will be on the top center, [2] on the top right key, 
    /// [3] is the leftmost key on the second row, etc. The second keyboard layer
    /// begins with the char at [9] on the top left corner...
    /// </summary>
    internal class NineKeyLayout : IComparable, INineKeyLayout
    {
        private char[] _keyLetters = new char[Config.NUMBER_OF_KEYS];
        private int _fitnessScore = 0;

        public char[] KeyLetters { get => _keyLetters; }

        public int FitnessScore { get => _fitnessScore; set => _fitnessScore = value; }


        public NineKeyLayout(char[] keyLetters)
        {
            _keyLetters = keyLetters;
        }

        int IComparable.CompareTo(object? obj)
        {
            int comparison = 0;

            if (obj != null && obj is NineKeyLayout)
            {
                // sort with the highest score first, lowest score last
                comparison = ((NineKeyLayout)obj)._fitnessScore.CompareTo(_fitnessScore);
            }

            return comparison;
        } // end of CompareTo

        public override string ToString()
        {
            string s = string.Empty;
            for (int i = 0; i < _keyLetters.Length; i++)
            {
                char c = _keyLetters[i];
                s += c;
            }
            return s;
        }

        public string Layout => this.ToString();
    } // end of class NineKeyLayout
} // end of namespace
