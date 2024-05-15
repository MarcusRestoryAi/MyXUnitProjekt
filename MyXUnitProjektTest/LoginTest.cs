using MyXUnitProjekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyXUnitProjektTest
{
    public class LoginTest
    {
        [Fact]
        public void LoginSucceeded()
        {
            //Skapa objektet
            Login login = new Login();

            string username = "Marcus", password = "12345";

            //Exekvera test
            Assert.Equal(login.returnSuccess, login.AttemptLogin(username, password));
        }
        [Fact]
        public void LoginFailed()
        {
            //Skapa objektet
            Login login = new Login();

            string username = "Niklas", password = "98765";

            //Exekvera test
            //Assert.Equal(login.returnWrongPassword, login.AttemptLogin(username, password));

            //Exekvera Test med Throw
            ArgumentException e = Assert.Throws<ArgumentException>(() => login.AttemptLogin(username, password));
            Assert.Equal(e.Message, login.returnWrongPassword);
        }

        [Fact]
        public void MissingUsername()
        {
            //Skapa objektet
            Login login = new Login();

            string username = null, password = "98765";

            //Exekvera test
            Assert.Equal(login.returnMissingUsername, login.AttemptLogin(username, password));
        }

        [Fact]
        public void MissingPassword()
        {
            //Skapa objektet
            Login login = new Login();

            string username = "Niklas", password = null;

            //Exekvera test
            Assert.Equal(login.returnMissingPassword, login.AttemptLogin(username, password));
        }

        [Fact]
        public void OtherTests()
        {
            bool testing = true, falseValue = false;

            Assert.Null(null);
            Assert.NotNull(testing);
            
            Assert.True(testing);
            Assert.True(!falseValue);
        }
    }
}
