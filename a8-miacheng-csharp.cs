using System;

class Program {
  

  static void Print_assignment(int number, string desc)
  {
    Console.WriteLine("A" + number + ": " + desc);
  }
  
  public static void Main (string[] args) {
    string my_name = "Thomas Zeng";
    int my_year = 2025;
    Console.WriteLine (my_name + "(" + my_year + ")");
    Console.WriteLine ("CS150 FA2022");

  string[]  assignments = {"Three IDES", "Student Data", "Dogs of NYC", "Tracery", "Bayesian Movies", "Matchmaking", "Webscraping", "Cats and Colors", "Three Languages"};
    
    for (int i = 0; i <9 ; i++) 
    {
      string desc = assignments[i];
      Print_assignment(i,desc);
    }
  }
}