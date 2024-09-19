using System.ComponentModel.Design;

namespace IshaProperties
{
    class Password
    {
        private string pass;

        public void Receive()
        {
            Console.WriteLine("What's the password?");
            Pass = Console.ReadLine();
        }

        public Password(string _pass)
        {
            Pass = _pass;
        }
        
        public string Pass
        {
            get { return pass; }
            set 
            {
                if (value == "password123" || value == "notapassword" || value == "thisisapassword")
                {
                    pass = value;
                    Console.WriteLine("Welcome back to your page!");
                }
                else
                {
                    pass = "Invalid Password";
                }
            }
        }
    }
}