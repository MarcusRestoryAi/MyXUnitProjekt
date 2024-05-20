using MyXUnitProjekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyXUnitProjektTest
{
    [Collection("NameRegister")]
    public class NameRegisterTest2
    {

        private NameRegisterFixture _fixture;

        public NameRegisterTest2(NameRegisterFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void CreatePersonOrRegister()
        {
            NameRegister nameRegister = _fixture.NameRegister;

            //Skapa ett objekt av klassen Person
            NameRegister p1 = nameRegister.createNew(true);
            //Skapa ett objekt av klassen NameRegister
            NameRegister p2 = nameRegister.createNew(false);

            Assert.IsType(typeof(Person), p1);

            Assert.IsNotType(typeof(Person), p2);
        }
    }
}
