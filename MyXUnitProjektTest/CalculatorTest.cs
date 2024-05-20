using MyXUnitProjekt;
using Xunit.Abstractions;

namespace MyXUnitProjektTest
{
    public class CalculatorTest : IClassFixture<CalculatorFixture>
    {

        private CalculatorFixture _fixture;
        private ITestOutputHelper _testOutputHelper;

        public CalculatorTest ( CalculatorFixture calculatorFixture, ITestOutputHelper testOutputHelper)
        {
            //calc = new Calculator();
            _fixture = calculatorFixture;
            _testOutputHelper = testOutputHelper;
            _testOutputHelper.WriteLine("Constructor");
        }

        [Fact]
        [Trait("Category", "Adding")]
        public void Add5With7()
        {
            /* SETUP */
            double nr1 = 5, nr2 = 7, expected = 12, summa;
            Calculator calc = _fixture.Calc;
            _testOutputHelper.WriteLine("SETUP färdig");
            _testOutputHelper.WriteLine($"Exepcted value is {expected}");
            // Console.WriteLine("Console writeline");

            /* EXECUTE */
            summa = calc.Add(nr1, nr2);

            /* ASSERT */
            Assert.Equal(expected, summa);
            _testOutputHelper.WriteLine("Test färdigt");
        }

        [Fact]
        [Trait("Category", "Adding")]
        [Trait("Category", "Fibonassi")] //Same testcase in multiple groups
        public void Add10With12WithDecimals()
        {
            /* SETUP */
            double nr1 = 10.3, nr2 = 12.4, expected = 22.7, summa;
            //Calculator calc = new Calculator();
            Calculator calc = _fixture.Calc;

            /* EXECUTE */
            summa = calc.Add( nr1,  nr2);

            /* ASSERT */
            Assert.Equal(expected, summa, 2);
        }

        [Fact]
        [Trait("Category", "Fibonassi")]
        public void CheckFor0()
        {
            Calculator calc = new Calculator();

            Assert.All(calc.numbers, n => Assert.NotEqual(n, 0));
        }

        [Fact]
        [Trait("Category", "Fibonassi")]
        public void CheckFor13()
        {
            Calculator calc = new Calculator();

            Assert.Contains(13, calc.numbers);
        }

        [Fact]
        [Trait("Category", "Fibonassi")]
        public void CheckFor11NotIncluded()
        {
            Calculator calc = new Calculator();

            Assert.DoesNotContain(11, calc.numbers);
        }

        [Fact]
        [Trait("Category", "Fibonassi")]
        public void CheckNUmbersBetween0To100()
        {
            Calculator calc = new Calculator();
            Assert.All(calc.numbers, n => Assert.InRange(n, 0, 100));
        }
    }
}