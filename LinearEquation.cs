using System;
using System.Collections.Generic;
using core;

namespace Oborotov
{
    public class LinearEquation : IEquationInterface
    {
        protected List<float> X;
        public List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
            {
                throw new OborotovException("Уравнение не имеет решения, a = 0");
            }
            MyLog.Log("Это линейное уравнение.");
            return X = new List<float> { -b / a };
        }
    }
}