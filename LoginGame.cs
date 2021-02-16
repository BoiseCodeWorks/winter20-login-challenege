using System;
using System.Collections.Generic;
using loginapp.Models;

namespace loginapp
{
  public class LoginGame
  {


    public Dictionary<string, User> Users { get; set; } = new Dictionary<string, User>();
    public void Login()
    {
      System.Console.WriteLine("Please log in to continue. \nUsername:");
      string username = Console.ReadLine();
      System.Console.WriteLine("Password:");
      string password = Console.ReadLine();
      if (Users.ContainsKey(username.ToLower()) && Users[username.ToLower()].ValidatePassword(password))
      {
        System.Console.WriteLine("Welcome to the mainframe");
      }
      else
      {
        System.Console.WriteLine("Authorities have been notified and are enroute.");
      }

    }

    public void Register(User newUser)
    {
      Users.Add(newUser.Name.ToLower(), newUser);
    }

    public LoginGame()
    {
      User tim = new User("Tim", "<3tacos<3");
      User trevor = new User("Trevor", "password123");
      User nathan = new User("Nathan", "CapitalPPasswordwith0foro");

      Users.Add(tim.Name.ToLower(), tim);
      //   Users.Add(trevor.Name.ToLower(), trevor);
      //   Users.Add(nathan.Name.ToLower(), nathan);


      Register(tim);
      Register(trevor);
      Register(nathan);
    }
  }
}