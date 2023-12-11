using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NineKey.Structures;

namespace NineKey.Facade
{
    internal interface IGenerationObserver
    {
        void Observe(IGeneration g);


    } // end of interface GenerationObserver
} // end of namespace NineKey.Facade
