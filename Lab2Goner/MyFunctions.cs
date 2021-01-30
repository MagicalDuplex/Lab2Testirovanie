using System;

namespace Lab2
{
    public static class MyFunctions
    {
        public static double CalcFunctionCustom(double x)
        {
            if (x <= 0)
            {
                return MyMath.Pow((((MyMath.Sec(x) - MyMath.Cot(x)) + MyMath.Cos(x)) * MyMath.Tan(x)) + (MyMath.Csc(x) / (MyMath.Csc(x) / MyMath.Cot(x))), 2);
            }
            else
            {
                return (((((MyMath.Log(x, 3) - MyMath.Log(x, 3)) - MyMath.Log(x, 5)) * MyMath.Pow(MyMath.Log(x, 10), 2)) *
                          (MyMath.Ln(x) * (MyMath.Log(x, 3) / MyMath.Ln(x) + MyMath.Log(x, 10)))) + (MyMath.Pow(MyMath.Log(x, 10), 2) + MyMath.Log(x, 10)));
            }
        }

        public static double CalcFunctionSystem(double x)
        {
            if (x <= 0)
            {
                return System.Math.Pow(((((1 / System.Math.Cos(x)) - (System.Math.Cos(x) / System.Math.Sin(x))) + System.Math.Cos(x)) * (System.Math.Sin(x) / System.Math.Cos(x))) + ((1 / System.Math.Sin(x)) / (1 / System.Math.Sin(x)) / (System.Math.Cos(x) / System.Math.Sin(x))), 2);
            }
            else
            {
                return (((((System.Math.Log(x, 3) - System.Math.Log(x, 3)) - System.Math.Log(x, 5)) * System.Math.Pow(System.Math.Log(x, 10), 2)) *
                         (System.Math.Log(x) * (System.Math.Log(x, 3) / System.Math.Log(x) + System.Math.Log(x, 10)))) + (System.Math.Pow(System.Math.Log(x, 10), 2) + System.Math.Log(x, 10)));
            }
        }
    }
}