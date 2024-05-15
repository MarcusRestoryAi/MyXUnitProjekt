using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyXUnitProjekt
{
    public class Login
    {
        public string returnMissingUsername = "Du saknar Username";
        public string returnMissingPassword = "Du saknar Password";
        public string returnWrongPassword = "Du har skrivit in fel lösenord";
        public string returnSuccess = "Du har loggat in";

        public string AttemptLogin(string username, string password)
        {
            string correctUserName = "Marcus", correctPassword = "12345";

            //Kontroll av inkommande värden
            if (username == null) {
                return returnMissingUsername;
            }
            if (password == null)
            {
                return returnMissingPassword;
            }

            //Kontroll mot korrekta värden
            if (username == correctUserName && password == correctPassword)
            {
                return returnSuccess;
            } else
            {
                //return returnWrongPassword;
                throw new ArgumentException(returnWrongPassword);
            }
        }
    }
}
