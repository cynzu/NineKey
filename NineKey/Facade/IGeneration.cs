using NineKey.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineKey.Facade
{
    internal interface IGeneration
    {
        List<NineKeyLayout> TopScoringLayouts { get; }
        public int Ordinal { get; }
        public int TopScore { get; }
    }
} // end of namespace NineKey.Facade
