using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NineKey.Structures;

namespace NineKey.Facade
{
    internal interface IGenerationObservable
    {
        void AddGenerationObserver(IGenerationObserver observer);
        void RemoveGenerationObserver(IGenerationObserver observer);
        IGeneration[] FindTheBestLayout();
        void AcceptConfig(Config c);
    } // end of interface IGenerationObservable
} // end of namespace NineKey.Facade
