using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SimpleCalculator
{
    [TestFixture]
    class TestCase
    {
        [TestCase]
        public void User()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual("AndriFankyKurniawan", calculator.User("Andri"));
        }

        [TestCase]
        public void Penjumlahan()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(31, calculator.Penjumlahan(20, 11));
        }

        [TestCase]
        public void Pengurangan()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(9, calculator.Pengurangan(20, 11));
        }

        [TestCase]
        public void Perkalian()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(220, calculator.Perkalian(20, 11));
        }

        [TestCase]
        public void Pembagian()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(2, calculator.Pembagian(20, 10));
        }
    }
}
