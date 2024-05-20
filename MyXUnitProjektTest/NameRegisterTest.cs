
using MyXUnitProjekt;

namespace MyXUnitProjektTest
{
    [Collection("NameRegister")]
    [TestCaseOrderer("MyXUnitProjektTest", "MyXUnitProjektTest")]
    public class NameRegisterTest
    {

        private NameRegisterFixture _fixture;

        public NameRegisterTest(NameRegisterFixture fixture)
        {
            _fixture = fixture;
            _fixture.NameRegister.nickname = null; //CLeanup
        }

        [Theory]
        [InlineData("Marcus", "Henriksson", "Marcus Henriksson")]
        [InlineData("Niklas", "Cullberg", "Niklas Cullberg")]
        public void CreateFullNameOf_Marcus_Henriksson(string firstName, string lastName, string expected)
        {
            //Skapa ett objekt av NameRegister
            //NameRegister nameRegister = new NameRegister();
            NameRegister nameRegister = _fixture.NameRegister;
            //string firstName = "Marcus", lastName = "Henriksson";

            Assert.Equal(expected, nameRegister.FullName(firstName, lastName));
        }

        [Fact]
        public void CreateStandardizedNameOf_Marcus_Henriksson()
        {
            //Skapa ett objekt av NameRegister
            NameRegister nameRegister = _fixture.NameRegister;
            string firstName = "Marcus", lastName = "Henriksson";

            Assert.Equal("marcus henriksson", nameRegister.StandardizedName(firstName, lastName));
            Assert.Contains("henrik", nameRegister.StandardizedName(firstName, lastName));
        }

        [Fact]
        [Trait("Category", "Nickname")]
        public void CreateNameRegWithEmptyNickname()
        {
            NameRegister nameRegister = _fixture.NameRegister;
            Assert.Null(nameRegister.nickname);
        }

        [Fact]
        [Trait("Category", "Nickname")]
        public void CreateNameRegAndChangeNickname()
        {
            NameRegister nameRegister = _fixture.NameRegister;
            nameRegister.nickname = "Mackan";

            Assert.Equal("Mackan", nameRegister.nickname);

            //Cleanup for future tests
            nameRegister.nickname = null;
        }


    }
}
