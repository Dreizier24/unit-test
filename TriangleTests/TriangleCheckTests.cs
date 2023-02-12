using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;
using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle.Tests
{
    [TestClass()]
    public class TriangleCheckTests
    {
        TriangleCheck tc = new TriangleCheck();

        [TestMethod()]
        public void SideTestArbitrary()
        {
            //Allert
            double a = 3, b = 4, c = 5;

            string expected = "Треугольник произвольный";
            //Act
            var result = tc.Side(a,b,c);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void AngleTestRectangular()
        {
            //Allert
            double a = 6, b = 8, c = 10;

            string expected = "Треугольник прямоугольный";
            //Act
            var result = tc.Angle(a, b, c);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void SideTestIsosceles()
        {
            //Allert
            double a = 3, b = 3, c = 2;

            string expected = "Треугольник равнобедренный";
            //Act
            var result = tc.Side(a, b, c);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void AngleTestAcute()
        {
            //Allert
            double a = 7, b = 5, c = 6;

            string expected = "Треугольник остроугольный";
            //Act
            var result = tc.Angle(a, b, c);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void SideTestEquilateral()
        {
            //Allert
            double a = 6, b = 6, c = 6;

            string expected = "Треугольник равносторонний";
            //Act
            var result = tc.Side(a, b, c);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void AngleTestObtuse()
        {
            //Allert
            double a = 18, b = 12, c = 13;

            string expected = "Треугольник тупоугольный";
            //Act
            var result = tc.Angle(a, b, c);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void SideTestZeroOrLess()
        {
            //Allert
            double a = -1, b = 8, c = 0;

            string expected = "Сторона не может быть <= 0!";
            //Act
            var result = tc.Side(a, b, c);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void AngleTestZeroOrLess()
        {
            //Allert
            double a = 0, b = 4, c = -4;

            string expected = "Сторона не может быть <= 0!";
            //Act
            var result = tc.Angle(a, b, c);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void SideTestDoesNotExist()
        {
            //Allert
            double a = 12, b = 15, c = 247;

            string expected = "Треугольник не существует";
            //Act
            var result = tc.Side(a, b, c);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void AngleTestDoesNotExist()
        {
            //Allert
            double a = 12, b = 15, c = 568;

            string expected = "Треугольник не существует";
            //Act
            var result = tc.Angle(a, b, c);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}