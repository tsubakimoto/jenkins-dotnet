using jenkins_dotnet;
using NUnit.Framework;
using System;

namespace jenkins_dotnet.test
{
    [TestFixture]
    public class CalculatorTest
    {
        [TestCase(1, 2, Result = 3, TestName = "Add01: 1+2=3")]
        [TestCase(5, 0, Result = 5, TestName = "Add02: 5+0=5")]
        [TestCase(0, 4, Result = 4, TestName = "Add03: 0+4=4")]
        [TestCase(1, -1, Result = 1, TestName = "Add04: 1+(-1)=1")]
        public int AddTest(int x, int y)
        {
            return Calculator.Add(x, y);
        }
    }
}
