using System;
using System.Collections.Generic;
using Login_Challenge.Models;

namespace Login_Challenge
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Dictionary<string, User> users = new Dictionary<string, User>();

      User jake = new User("Jake", "IHeartCod3");

      users.Add(jake.Name, jake);

      System.Console.Write("User Name");
      string username = Console.ReadLine();
      Console.Write("Password");
      string password = Console.ReadLine();

      if (users.ContainsKey(username) && users[username].ValidatePassword(password))
      {
        System.Console.WriteLine("You are logged in");
      }
      else
      {
        System.Console.WriteLine("Invalid CredentialsU");
      }




    }
  }
}
