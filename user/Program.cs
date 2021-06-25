using System;

namespace user
{
  class Program
  {
    static void Main(string[] args)
    {

      // Get the username.
      Console.Write("Username: ");
      string username = Console.ReadLine();

      // Get the password.
      Console.Write("Password: ");
      string password = Console.ReadLine();

      // Create the new user instance.
      User user = new User(username, password);
      user.email = "test@example.com";
      user.Profail();
    }
  }
}