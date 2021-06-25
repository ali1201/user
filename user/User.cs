using System;

class User
{
    public string username;
    public string passwoord;
    public string email;

    public User(string u,string p)
    {
        username = u;
        passwoord = p;
    }
    
    public void Profail()
    {
        Console.WriteLine($"username is : {username}");
        Console.WriteLine($"password is : {passwoord.Substring(0, 3)}********");

        if (email == null)
        {
            Console.WriteLine(" email not found ");
        }
        else
        {
            Console.WriteLine($"emai is : {email}");
        }
    }

    public void Start()
    {
        Console.WriteLine("starting....");
    }  
}
   

