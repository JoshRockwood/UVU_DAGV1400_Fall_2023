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

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 100 + 50;
      Console.WriteLine(x); // writes variable x as 150 due to equation
      
      int y = x * 2;
      Console.WriteLine(y); // writes variable y as 200 due to being multiplied by 2
      
      int z = y / x;
      Console.WriteLine(z); // writes variable z as 2 due to 300 being divided by 150
      
      int xy = y % x;
      Console.WriteLine(xy); // writes 0 as the division remainder of 300 and 150 is 0
      
      int t = 206;
      t++;
      Console.WriteLine(t); // writes 207 as ++ gives an increment of 1 to 206
      
      int xz = 5679;
      xz--;
      Console.WriteLine(xz); // writes 5678 as -- gives a decrement of 1 to 5679
      
      x += 50;
      Console.WriteLine(x); // writes 200 as 50 is added to the inital x variable of 150
      
      x /= 50;
      Console.WriteLine(x); // writes 4 as current x variable of 200 is divided by 50
      
      int b = 5;
      int a = 7; 
      Console.WriteLine(x != y); // returns True because 5 is not equal to 7
      
      int ab = 2;
      int bc = 2;
      int cd = 1;
      Console.WriteLine(ab >= bc); // returns True because 2 is equal to 2
      Console.WriteLine(bc >= cd); // returns True because 2 is greater than 1
      }
  }
}
