using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NineKey.Engine;


namespace NineKey.Facade
{
    internal abstract class Factory
    {
        public static IGenerationObservable Producer => new GenerationProducer();

    } // end of class Factory
} // end of namespace NineKey
