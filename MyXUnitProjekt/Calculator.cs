using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyXUnitProjekt
{
    public class Calculator
    {

        public List<int> numbers = new List<int>() {1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 100 };

        public double Add(double x, double y) {
            return x + y;
        }
    }
}
