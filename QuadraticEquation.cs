using System;
using System.Collections.Generic;

namespace Oborotov
{
    public class QuadraticEquation : LinearEquation
    {
        public List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
            {
                return base.Solve(b, c, 0);
            }
            float D = (float) Math.Sqrt (discriminant(a, b, c));
            MyLog.Log("Это квадратное уравнение.");
            if (D == 0)
            {
                return X = new List<float>() { (-b + D) / (2 * a) };
            }
            if (D > 0)
            {
                return X = new List<float>()
                {
                    (-b + D) / (2 * a),
                    (-b - D) / (2 * a)
                };
            }
            if (D < 0)
            {
                throw new OborotovException("Уравнение не имеет решения, D < 0");
            }
            return X;
        }
        protected float discriminant(float a, float b, float c)
        {
            return (float)Math.Pow(b, 2) - 4 * a * c;
        }
    }
}