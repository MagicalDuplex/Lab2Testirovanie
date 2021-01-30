using System;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace Lab2
{
    public class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Выберите функцию: sin,cos,log,ln,custF,sysF");
                string function = Console.ReadLine();

                Console.WriteLine("Начинаем от:");
                double from = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Шаг:");
                double step = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Идём до:");
                double to = Convert.ToDouble(Console.ReadLine());

                var stream = new FileStream(AppContext.BaseDirectory + $"\\{function}Result.csv", FileMode.Create,
                    FileAccess.ReadWrite);
                using var writer = new StreamWriter(stream, Encoding.Unicode);
                writer.WriteLine("sep=;");
                using var csv = new CsvWriter(writer,
                    new CsvConfiguration(CultureInfo.InvariantCulture) {Delimiter = ";"});


                for (double x = from; x <= to; x += step)
                {
                    double result = 0;

                    switch (function)
                    {
                        case "sin":
                            result = MyMath.Sin(x);
                            break;
                        case "cos":
                            result = MyMath.Cos(x);
                            break;
                        case "tg":
                            result = MyMath.Tan(x);
                            break;
                        case "ln":
                            result = MyMath.Ln(x);
                            break;
                        case "custF":
                            result = MyFunctions.CalcFunctionCustom(x);
                            break;
                        case "sysF":
                            result = MyFunctions.CalcFunctionSystem(x);
                            break;
                    }

                    csv.WriteRecord(new {X = x, Result = result});
                    csv.NextRecord();
                }

                Console.WriteLine($"Результаты вычисления успешно записаны в {function}Result.csv");
                Console.WriteLine();
            }
        }
    }
}