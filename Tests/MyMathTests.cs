using Lab2;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestSin()
        {
            for (int x = 0; x < 10; x++)
            {
                var actual = MyMath.Sin(x);
                var expected = System.Math.Sin(x);
                Assert.AreEqual(expected, actual, 0.01);
            }
        }

        [Test]
        public void TestCos()
        {
            for (int x = 0; x < 10; x++)
            {
                var actual = MyMath.Cos(x);
                var exp = System.Math.Cos(x);

                Assert.AreEqual(exp, actual, 0.01);
            }
        }

        [Test]
        public void TestCsc()
        {
            for (int x = 0; x < 10; x++)
            {
                var actual = MyMath.Csc(x);
                var exp = 1 / System.Math.Sin(x);

                Assert.AreEqual(exp, actual, 0.01);
            }
        }

        [Test]
        public void TestLn()
        {
            for (int x = 1; x < 10; x++)
            {
                var actual = MyMath.Ln(x);
                var expected = System.Math.Log(x);

                Assert.AreEqual(expected, actual, 0.01);
            }
        }

        [Test]
        public void TestLog()
        {
            for (int x = 1; x < 10; x++)
            {
                var newBase = 3;
                var actual = MyMath.Log(x, newBase);
                var expected = System.Math.Log(x, newBase);

                Assert.AreEqual(expected, actual, 0.01);
            }
        }

        [Test]
        public void TestCot()
        {
            for (int x = 0; x < 10; x++)
            {
                var actual = MyMath.Cot(x);
                var exp = System.Math.Cos(x) / System.Math.Sin(x);

                Assert.AreEqual(exp, actual, 0.01);
            }
        }

        [Test]
        public void TestExp()
        {
            for (int x = 0; x < 10; x++)
            {
                var actual = MyMath.Exp(x);
                var expected = System.Math.Exp(x);

                Assert.AreEqual(expected, actual, 0.01);
            }
        }


        [Test]
        public void TestTan()
        {
            for (int x = 0; x < 10; x++)
            {
                var actual = MyMath.Tan(x);
                var expected = System.Math.Sin(x) / System.Math.Cos(x);

                Assert.AreEqual(expected, actual, 0.01);
            }
        }

        [Test]
        public void TestSec()
        {
            for (int x = 0; x < 10; x++)
            {
                var actual = MyMath.Sec(x);
                var expected = 1 / System.Math.Cos(x);

                Assert.AreEqual(expected, actual, 0.01);
            }
        }


        [Test]
        public void TestPow()
        {
            for (int x = 0; x < 10; x++)
            {
                var radix = 15;
                var actual = MyMath.Pow(x, radix);
                var expected = System.Math.Pow(x, radix);

                Assert.AreEqual(expected, actual, 0.01);
            }
        }

        [Test]
        public void TestFunctions()
        {
            for (int x = 0; x < 10; x++)
            {
                var actual = MyFunctions.CalcFunctionCustom(x);
                var expected = MyFunctions.CalcFunctionSystem(x);

                Assert.AreEqual(expected, actual, 0.05);
            }
        }
    }
}