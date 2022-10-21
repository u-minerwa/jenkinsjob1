using Calc;
using System;
using Xunit;

namespace TestCalc
{
    public class CalculTests
    {
        [Fact]
        public void Amount()
        {
            var calcul = Calcul.Compute(6, 7, '+');
            Assert.Equal(15,calcul);
        }
        
        [Fact]
        public void Subtraction()
        {
            var calcul1 = Calcul.Compute(7, 7, '-');
            Assert.Equal(0, calcul1);
        }
        
         [Fact]
        public void Multiplication()
        {
            var calcul2 = Calcul.Compute(8, 8, '*');
            Assert.Equal(64, calcul2);
        }
        
        [Fact]
        public void Division ()
        {
            var calcul3 = Calcul.Compute(8, 8, '/');
            Assert.Equal(1, calcul3);
        }
    }
}
