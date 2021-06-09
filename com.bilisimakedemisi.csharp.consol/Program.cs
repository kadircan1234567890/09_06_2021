using System;

namespace com.bilisimakedemisi.csharp.consol
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("naber kadircan!");
            #region 


            #endregion

            user _user = new user();


            _user.MyPropert = 1;
            _user.FullName = "kadircan.katirci";

            user _user2 = _user;

            _user2.FullName = "soner";



            Console.WriteLine(_user.MyPropert);


            Console.WriteLine(_user.FullName);

            logger _logger = logger.Database;
            if (_logger==logger.SMS)
            {
                //sms at
            }
               






            
        }
    }
}
