using System;

class Print_useer
{
    public string username { set; get; }
    public string passwoord { set; get; }
    public string email;
    public Print_useer(string u,string p)
    {
        username = u;
        passwoord = p;
    }
    
        public void Profail()
        {
            Console.WriteLine($"username is : {username}");
            Console.WriteLine($"password is : {passwoord}********");
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
   

