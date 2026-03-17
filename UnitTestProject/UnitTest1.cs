using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Windows;
using WpfApp1.Pages;
using static System.Math;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMath1()
        {
            var page = new Page2();
            float xx = 2;
            float yy = 3;
            float zz = 1;
            float rez = (float)(Pow(10 * (Pow(xx, 1 / 3) + Pow(xx, yy + 2)), 0.5) * (Pow(Asin(zz), 2) - Abs(xx - yy)));
            Assert.IsTrue(page.Math1(xx, yy, zz), Convert.ToString(rez));

        }
        public void TestMath11()
        {
            var page = new Page2();
            float xx = -2;
            float yy = 123;
            float zz = 1;
            float rez = (float)(Pow(10 * (Pow(xx, 1 / 3) + Pow(xx, yy + 2)), 0.5) * (Pow(Asin(zz), 2) - Abs(xx - yy)));
            Assert.IsTrue(page.Math1(xx, yy, zz), Convert.ToString(rez));

        }

        [TestMethod]
        public void TestMath21()
        {
            var page = new Page3();
            float bb = 2;
            float xx = 3;
            float rez = 0;
            if (0.5 < xx * bb && xx * bb < 10)
            {
                rez = (float)Exp(Sinh(xx) - Abs(bb));
            }
            else if (0.1 < xx * bb && xx * bb < 0.5)
            {
                rez = (float)Pow(Abs(Sinh(xx) + bb), 0.5);
            }
            else
            {
                rez = (float)(2 * Pow(Sinh(xx), 2));
            }
            Assert.IsTrue(page.Math21(bb, xx), Convert.ToString(rez));
        }
        [TestMethod]
        public void TestMath211()
        {
            var page = new Page3();
            float bb = -112;
            float xx = 1233;
            float rez = 0;
            if (0.5 < xx * bb && xx * bb < 10)
            {
                rez = (float)Exp(Sinh(xx) - Abs(bb));
            }
            else if (0.1 < xx * bb && xx * bb < 0.5)
            {
                rez = (float)Pow(Abs(Sinh(xx) + bb), 0.5);
            }
            else
            {
                rez = (float)(2 * Pow(Sinh(xx), 2));
            }
            Assert.IsTrue(page.Math21(bb, xx), Convert.ToString(rez));
        }

        [TestMethod]
        public void TestMath22()
        {
            var page = new Page3();
            float bb = 2;
            float xx = 3;
            float rez = 0;
            if (0.5 < xx * bb && xx * bb < 10)
            {
                rez = (float)Exp(Pow(xx, 2) - Abs(bb));
            }
            else if (0.1 < xx * bb && xx * bb < 0.5)
            {
                rez = (float)Pow(Abs(Pow(xx, 2) + bb), 0.5);
            }
            else
            {
                rez = (float)(2 * Pow(Pow(xx, 2), 2));
            }
            Assert.IsTrue(page.Math21(bb, xx), Convert.ToString(rez));
        }

        [TestMethod]
        public void TestMath222()
        {
            var page = new Page3();
            float bb = -19992;
            float xx = -28883;
            float rez = 0;
            if (0.5 < xx * bb && xx * bb < 10)
            {
                rez = (float)Exp(Pow(xx, 2) - Abs(bb));
            }
            else if (0.1 < xx * bb && xx * bb < 0.5)
            {
                rez = (float)Pow(Abs(Pow(xx, 2) + bb), 0.5);
            }
            else
            {
                rez = (float)(2 * Pow(Pow(xx, 2), 2));
            }
            Assert.IsTrue(page.Math21(bb, xx), Convert.ToString(rez));
        }

        [TestMethod]
        public void TestMath23()
        {
            var page = new Page3();
            float bb = 2;
            float xx = 3;
            float rez = 0;
            if (0.5 < xx * bb && xx * bb < 10)
            {
                rez = (float)Exp(Exp(xx) - Abs(bb));
            }
            else if (0.1 < xx * bb && xx * bb < 0.5)
            {
                rez = (float)Pow(Abs(Exp(xx) + bb), 0.5);
            }
            else
            {
                rez = (float)(2 * Pow(Exp(xx), 2));
            }
            Assert.IsTrue(page.Math21(bb, xx), Convert.ToString(rez));
        }
        [TestMethod]
        public void TestMath233()
        {
            var page = new Page3();
            float bb = 20979;
            float xx = -93;
            float rez = 0;
            if (0.5 < xx * bb && xx * bb < 10)
            {
                rez = (float)Exp(Exp(xx) - Abs(bb));
            }
            else if (0.1 < xx * bb && xx * bb < 0.5)
            {
                rez = (float)Pow(Abs(Exp(xx) + bb), 0.5);
            }
            else
            {
                rez = (float)(2 * Pow(Exp(xx), 2));
            }
            Assert.IsTrue(page.Math21(bb, xx), Convert.ToString(rez));
        }

        [TestMethod]
        public void TestMath3() 
        {
            var page = new Page4();
            float xx0 = 0;
            float xxk = 5;
            float dxx = 1;
            float dd = 1;
            float rez = 0;
            List<float> a = new List<float>();
            if (xx0 <= xxk)
            {
                while (xx0 <= xxk)
                {
                    rez = (float)(Pow(xx0, 2) + Tan(5 * xx0 + (dd / xx0)));
                    a.Add(rez);
                    xx0 += dxx;
                }
            }
            else
            {
                while (xxk >= xx0)
                {
                    rez = (float)(Pow(xx0, 2) + Tan(5 * xx0 + (dd / xx0)));
                    a.Add(rez);
                    xxk -= dxx;
                }
            }
            Assert.IsTrue(page.Math3(xx0, xxk, dxx, dd), Convert.ToString(a));
        }
    }
}
