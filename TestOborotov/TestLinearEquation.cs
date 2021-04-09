using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Oborotov;


namespace TestOborotov
{
    [TestClass]
    public class TestLinearEquation
    {
        [TestMethod]
        [ExpectedException(typeof(OborotovException),
        "Уравнение не имеет решения")]
        public void TestMethod1()
        {
            LinearEquation myLinearEquation = new LinearEquation();
            CollectionAssert.AreEqual(new List<float>() { -2f }, myLinearEquation.Solve(10, 20, 0));
            CollectionAssert.AreEqual(new List<float>() { -0.625f }, myLinearEquation.Solve(8, 5, 0));
            myLinearEquation.Solve(0, 2, 0);
        }
    }
}
