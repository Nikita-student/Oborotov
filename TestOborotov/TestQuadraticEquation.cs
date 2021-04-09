using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Oborotov;

namespace TestOborotov
{
    [TestClass]
    public class TestQuadraticEquation
    {
        [TestMethod]
        [ExpectedException(typeof(OborotovException),
        "Уравнение не имеет решения.")]
        public void TestMethodSolve()
        {
            QuadraticEquation myQuadraticEquation = new QuadraticEquation();
            CollectionAssert.AreEqual(new List<float>() { 2f }, myQuadraticEquation.Solve(0, 2, -4));
            CollectionAssert.AreEqual(new List<float>() { 3, -2.5f }, myQuadraticEquation.Solve(2, -1, -15));
            CollectionAssert.AreEqual(new List<float>() { 1, 0.6666667f }, myQuadraticEquation.Solve(3, -5, 2));
            myQuadraticEquation.Solve(0, 0, 1);
            OborotovException ex = Assert.ThrowsException<OborotovException>(() => myQuadraticEquation.Solve(0, 0, 5));
            Assert.AreEqual("Такое уравнение не существует", ex.Message);

        }
    }
}
