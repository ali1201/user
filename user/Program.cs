using System;

namespace user
{
  class Program
  {
    static void Main(string[] args)
    {

      User test = new User("", "");
      Console.WriteLine("enter username :  ");
      string a = Console.ReadLine();
      Console.WriteLine($"username is :  {test.username}");

      Console.WriteLine("enter password :  ");
      string b = Console.ReadLine();
      Console.WriteLine($"password is :  {test.passwoord}");

      test.Profail();
      test.Start();

      //Console.WriteLine(" enter uesr :");
      //string u = Console.ReadLine();

      //Console.WriteLine(" uesrname  is : ");
      //Console.WriteLine(" password  is : ");

      /*Print_useer a = new Print_useer();


      Console.Write(a.username);
      Console.Write(a.passwoord);*/

      /* Console.ReadLine();
       string f = a.username;
       Console.WriteLine(f);
      */
      //Print_useer a = Console.ReadLine(Print_useer a.username)); ; ;
      //Print_useer k = new Print_useer("n", "j", "h");

      //Console.ReadLine();
    }
  }
}