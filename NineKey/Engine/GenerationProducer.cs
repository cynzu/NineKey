using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NineKey.Facade;
using NineKey.Structures;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace NineKey.Engine
{
    /// <summary>
    /// Class <c>GenerationProducer</c> runs the genetic algorithm
    /// by creating NineKeyLayout with a Generation,
    /// running those through the FitnessTester, removing low-scoring
    /// layouts and replacing those with slightly modified
    /// versions of the top-scoring layout. That process is repeated
    /// until the NUMBER_OF_GENERATIONS defined in Config has been reached.
    /// </summary>
    internal class GenerationProducer : IGenerationObservable
    {
        private int _generationOrdinal = 0;
        private Random _random = new Random();
        private Generation[] _generations = new Generation[Config.NUMBER_OF_GENERATIONS];
        private List<IGenerationObserver> _observers = new List<IGenerationObserver>();

        public GenerationProducer() { }

        public void AddGenerationObserver(IGenerationObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveGenerationObserver(IGenerationObserver observer)
        {
            _observers.Remove(observer);
        }

        public IGeneration[] FindTheBestLayout()
        {
            CreateInitialGeneration();

            try
            {
                // the loop logic below subtracts 1 from Config.NUMBER_OF_GENERATIONS
                // because the first item is created by the CreateInitialGeneration step above
                // for (int n = 0; n < Config.NUMBER_OF_GENERATIONS - 1; n++)
                for (int n = 0; n < Config.NUMBER_OF_GENERATIONS; n++)
                {
                    TestLayouts(_generations[n]);
                    _generations[n].TallyScores();
                    NotifyObservers(_generations[n]);
                    if (n < _generations.Length - 1)
                    {
                        _generations[n + 1] = CreateNextGeneration(_generations[n]);
                    }
                } // end of loop which creates and tests each generation
                NotifyObservers(_generations[_generations.Length - 1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return _generations;
        }

        /// <summary>
        /// creates a group of NineKeyLayout instances with the letters and dot
        /// chars randomly arranged
        /// </summary>
        private void CreateInitialGeneration()
        {
            char[] keyLetters = new char[Config.NUMBER_OF_KEYS];

            // this loop stuffs letters a-z into the keyLetters
            int index = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                keyLetters[index++] = i;
            }

            // the last item is the dot char
            keyLetters[Config.NUMBER_OF_KEYS - 1] = '.';

            NineKeyLayout[] layouts = new NineKeyLayout[Config.POPULATION_SIZE];
            for (int n = 0; n < Config.POPULATION_SIZE; n++)
            {
                // intentionally apply a lot of mutations to the initial population
                keyLetters = Mutate(keyLetters, Config.NUMBER_OF_MUTATIONS * 5);
                layouts[n] = new NineKeyLayout(keyLetters);
            } // end of loop to create NineKeyLayout instances

            _generations[0] = new Generation(layouts, _generationOrdinal++);
        } // end of CreateInitialGeneration

        private Generation CreateNextGeneration(Generation parent)
        {
            // the NineKeyLayout objs in the parent Generation were sorted
            //  descending by fitness _score when TallyScores() was called above;
            Generation child = new Generation(parent);

            // in the child, replace the lowest scoring 
            // the layouts with mutated versions of the parent
            // generation's highest scoring layouts
            int numToRemove = (int)(Config.POPULATION_SIZE * Config.PERCENT_TO_REPLACE);
            NineKeyLayout mutatedFromParent;
            char[] newLayoutChars = new char[Config.NUMBER_OF_KEYS];

            for (int i = 0; i < numToRemove; i++)
            {
                newLayoutChars = Mutate(parent.Layouts[i].KeyLetters, Config.NUMBER_OF_MUTATIONS);
                mutatedFromParent = new NineKeyLayout(newLayoutChars);
                child.ReplaceLayout(Config.POPULATION_SIZE - 1 - i, mutatedFromParent);
            }

            // mutate all of the middle-scoring ones too
            NineKeyLayout mutatedLayout;
            char[] mutatedChars;
            int startIndexOfMidScores = numToRemove;
            int endIndexOfMidScores = (child.Layouts.Length) - numToRemove;
            for(int i= startIndexOfMidScores; i< endIndexOfMidScores; i++)
            {
                mutatedChars = Mutate(child.Layouts[i].KeyLetters, Config.NUMBER_OF_MUTATIONS);
                mutatedLayout = new NineKeyLayout(mutatedChars);
                child.ReplaceLayout(i, mutatedLayout);
            }

            return child;
        }

        /// <summary>
        /// TestLayouts sets the fitness _score on each NineKeyLayout 
        /// in the Generation passed in as a parameter.
        /// </summary>
        /// <param name="g"></param>
        private void TestLayouts(Generation g)
        {
            FitnessTester tester = new FitnessTester();
            foreach (NineKeyLayout nkl in g.Layouts)
            {
                nkl.FitnessScore = tester.Test(nkl);
            }
        } // end of TestLayouts

        private char[] Mutate(char[] keyLetters, int numOfMutations)
        {
            char[] mutated = new char[keyLetters.Length];
            keyLetters.CopyTo(mutated, 0);

            for (int n = 0; n < numOfMutations; n++)
            {
                // swap chars from 2 random indexes
                int random1 = (int)_random.NextInt64(keyLetters.Length);
                int random2 = (int)_random.NextInt64(keyLetters.Length);
                (mutated[random2], mutated[random1]) = (mutated[random1], mutated[random2]);
            }

            return mutated;
        } // end of Mutate

        private void NotifyObservers(Generation g)
        {
            foreach (IGenerationObserver observer in _observers)
            {
                observer.Observe(g);
            }
        }


    } // end of class GenerationProducer
}  // end of namespace NineKey.Engine
