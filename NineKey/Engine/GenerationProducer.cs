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
