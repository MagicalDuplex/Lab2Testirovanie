using System.Diagnostics.CodeAnalysis;

namespace Lab2
{
    public static class MyMath
    {
        // Вычисляет синус указанного угла через разложение в ряд Тейлора.
        public static double Sin(double x, int nTerms = 25)
        {
            if (nTerms < 2)
                return x;

            if (nTerms == 2)
                return x - (x * x * x) / 6D;

            var multiplyResult = x * x * x;
            var factorialStart = 5;
            double factorialResult = 6;

            var result = x - multiplyResult / factorialResult;

            var sign = 1;
            for (int i = 3; i <= nTerms; i++)
            {
                multiplyResult *= x * x;
                factorialResult *= factorialStart * (factorialStart - 1);
                factorialStart += 2;
                result += sign * (multiplyResult / factorialResult);
                sign *= -1;
            }

            return result;
        }

        // Вычисляет косинус указанного угла через разложение в ряд Тейлора.
        public static double Cos(double x, int nTerms = 25)
        {
            if (nTerms < 2)
                return 1;

            if (nTerms == 2)
                return 1 - (x * x) / 2D;

            var multiplyResult = x * x;
            var factorialStart = 4;
            double factorialResult = 2;

            var result = 1 - multiplyResult / factorialResult;

            var sign = 1;
            for (int i = 3; i <= nTerms; i++)
            {
                multiplyResult *= x * x;
                factorialResult *= factorialStart * (factorialStart - 1);
                factorialStart += 2;
                result += sign * (multiplyResult / factorialResult);
                sign *= -1;
            }

            return result;
        }

        // Вычисляет натуральный логарифм для указанного числа
        public static double Ln(double power)
        {
            if (power == 0) return double.NegativeInfinity;
            if (power == 1) return 0;
            if (power < 0) return double.NaN;

            const double e = 2.71828182845905;
            var p = power;
            var n = 0.0;
            double a;

            // это ускоряет сходимость за счет вычисления интеграла
            while (p >= e)
            {
                p /= e;
                n++;
            }

            n += (p / e);
            p = power;

            do
            {
                a = n;
                var l = (p / (Exp(n - 1.0)));
                var r = ((n - 1.0) * e);
                n = ((l + r) / e);
            } while (Abs(n - a) > 0.00001);

            return n;
        }

        // Вычисляет логарифм для указанного числа и указанного основания
        public static double Log(double x, double newBase)
        {
            if (newBase == 0) return double.NaN;
            if (newBase == 1) return double.NaN;

            return Ln(x) / Ln(newBase);
        }

        // Вычисляет значение константы E, возведённую в указанную степень
        public static double Exp(double n)
        {
            double x = n;
            double p = 1.0 + x;
            double fact = x;
            double i = 1.0;
            double l;

            do
            {
                i++;
                fact *= (x / i);
                l = p;
                p += fact;
            } while (Abs(l - p) > 0.001);

            return p;
        }

        // Вычисляет секанс указанного угла.
        public static double Sec(double x)
        {
            return 1 / Cos(x);
        }

        // Возводит указанное число в указанную степень
        public static double Pow(double x, int radix)
        {
            if (radix == 0) return 1;

            var res = x;
            var absRadix = Abs(radix);

            for (int i = 1; i < absRadix; i++)
            {
                res *= x;
            }

            return radix > 0 ? res : 1 / res;
        }

        // Получает модуль указанного числа
        public static double Abs(double x)
        {
            return x >= 0 ? x : -x;
        }

        // Вычисляет тангенс указанного числа
        public static double Tan(double x)
        {
            return Sin(x) / Cos(x);
        }

        // Вычисляет котангенс указанного числа
        public static double Cot(double x)
        {
            return Cos(x) / Sin(x);
        }

        // Вычисляет косеканс указанного числа
        public static double Csc(double x)
        {
            return 1 / Sin(x);
        }
    }
}