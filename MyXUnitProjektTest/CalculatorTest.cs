using MyXUnitProjekt;

namespace MyXUnitProjektTest
{
    public class CalculatorTest
    {
        [Fact]
        public void Add5With7()
        {
            /* SETUP */
            double nr1 = 5, nr2 = 7, expected = 12, summa;
            Calculator calc = new Calculator();

            /* EXECUTE */
            summa = calc.Add(nr1, nr2);

            /* ASSERT */
            Assert.Equal(expected, summa);
        }

        [Fact]
        public void Add10With12WithDecimals()
        {
            /* SETUP */
            double nr1 = 10.3, nr2 = 12.4, expected = 22.7, summa;
            Calculator calc = new Calculator();

            /* EXECUTE */
            summa = calc.Add( nr1,  nr2);

            /* ASSERT */
            Assert.Equal(expected, summa, 2);
        }

        [Fact]
        public void CheckFor0()
        {
            Calculator calc = new Calculator();

            Assert.All(calc.numbers, n => Assert.NotEqual(n, 0));
        }

        [Fact]
        public void CheckFor13()
        {
            Calculator calc = new Calculator();

            Assert.Contains(13, calc.numbers);
        }

        [Fact]
        public void CheckFor11NotIncluded()
        {
            Calculator calc = new Calculator();

            Assert.DoesNotContain(11, calc.numbers);
        }

        [Fact]
        public void CheckNUmbersBetween0To100()
        {
            Calculator calc = new Calculator();
            Assert.All(calc.numbers, n => Assert.InRange(n, 0, 100));
        }
    }
}