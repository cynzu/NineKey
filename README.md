# NineKey
NineKey is a C# Windows app which uses a genetic algorithm to produce efficient keyboard layouts using a 3 x 3 grid on 3 layers to arrange letters A - Z and the dot character. It is intended for use by people programming customizable keyboards or macropads.  

A finished layout will look something like this:


      

      Layer:        1       2       3 
      
      row 1:      o a r   z y q   g f d
      
      row 2:      t e s   k c .   x n p 
      
      row 3:      h i m   b v j   l w u 

NineKey's task is to place the letters A - Z and the dot "." character onto a 3 x 3 grid of keyboard keys using 3 layers. A layer is a way to give a single physical key a way to produce more than one character. On a normal keyboard, the shift key allows the "1" key to output an exclamation mark. On programmable keyboards or macropads, users can create custom mappings with many layers.   

A genetic algorithm mimics the process of biological evolution in order to find a solution to a problem. In nature, the "problem" is survival, and the "solution" is to create individuals with traits which enable them to survive and reproduce, thereby passing on the genes which make them fit. In a computer program the "problem" can be anything, and the program designer can choose what it means for a solution to be "good" or "fit".

NineKey tries to produce the most efficient layout possible, with commonly used characters and combinations of characters easy to reach. It starts by creating a group of charcter arrays containing A - Z plus dot. It then scrambles the characters and tests them to see which char[27], when placed on the keyboard, are efficient. Then the algorithm throws out the lowest scoring character arrays, replacing them with copies of the highest scoring arrays which have been modified slightly. That new child population is then tested, and the process repeats itself.  

Currently (Dec 11, 2023), the variables used by the algorithm (how many char[27]'s to create in each generation, how many generations to create, etc.) are hardcoded in a config file. I plan to add a user interface which allows users to modify those parameters themselves. 

Inspiration to use a genetic algorithm to get an efficient keyboard layout came from here: https://www.youtube.com/watch?v=xDQXokCON-w&list=WL&index=2&t=25s.
