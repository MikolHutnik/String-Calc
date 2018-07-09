using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Tests
{[TestFixture]
    public class StringCalculatorTests
    {
        [Test]
        public void Add_Returns_0_For_Empty_String()
        {
            var calc = new StringCalculator();
            var result = calc.Add("");
            Assert.That(result, Is.EqualTo(0));
        }


    }
}
