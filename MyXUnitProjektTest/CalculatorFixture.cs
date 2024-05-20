using MyXUnitProjekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyXUnitProjektTest
{
    public class CalculatorFixture : IDisposable
    {
        public Calculator Calc => new Calculator();

        public void Dispose()
        {
            // Cleanup after each test
        }
    }
}
