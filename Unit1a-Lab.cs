using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string name = "Josh Rockwood";
      Console.WriteLine(name);  // It is expected for the code to read my name back
      
      int myNumber = 21;
      myNumber = 207;
      Console.WriteLine(myNumber); // It is expected that the inital number of 21 with be overwritten by the next inputed number of 207
      
      double twoNumber = 12.95;
      Console.WriteLine(twoNumber); // It is expected that the number 12.95 should be shown by use of the variable 'double'
      
      char favoriteLetter = 'R';
      Console.WriteLine(favoriteLetter); // It is expected that only the letter R should be shown through use of the char variable
      
      string phrase = "Coding can be fun once you get the hang of it";
      Console.WriteLine(phrase); // Should show the phrase above
      
      string trueFalseStatement = "Chocolate is the best icecream flavor.";
      bool question = true;
      Console.WriteLine(trueFalseStatement + question); // The inital question should be shown, followed by the answer to the question, which is true
      
     }
  }
}
