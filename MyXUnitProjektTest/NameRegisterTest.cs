
using MyXUnitProjekt;

namespace MyXUnitProjektTest
{
    public class NameRegisterTest
    {
        [Fact]
        public void CreateFullNameOf_Marcus_Henriksson()
        {
            //Skapa ett objekt av NameRegister
            NameRegister nameRegister = new NameRegister();
            string firstName = "Marcus", lastName = "Henriksson";

            Assert.Equal("Marcus Henriksson", nameRegister.FullName(firstName, lastName));
        }

        [Fact]
        public void CreateStandardizedNameOf_Marcus_Henriksson()
        {
            //Skapa ett objekt av NameRegister
            NameRegister nameRegister = new NameRegister();
            string firstName = "Marcus", lastName = "Henriksson";

            Assert.Equal("marcus henriksson", nameRegister.StandardizedName(firstName, lastName));
            Assert.Contains("henrik", nameRegister.StandardizedName(firstName, lastName));
        }

        [Fact]
        public void CreatePersonOrRegister()
        {
            NameRegister nameRegister = new NameRegister();

            //Skapa ett objekt av klassen Person
            NameRegister p1 = nameRegister.createNew(true);
            //Skapa ett objekt av klassen NameRegister
            NameRegister p2 = nameRegister.createNew(false);

            Assert.IsType(typeof(Person), p1);

            Assert.IsNotType(typeof(Person), p2);
        }
    }
}
