using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {

        static void Main(string[] args)
        {
            var a = Matrix.GetMatrixFromConsole("A");
            var b = Matrix.GetMatrixFromConsole("B");

            Console.WriteLine("Матрица A:");
            Matrix.PrintMatrix(a);

            Console.WriteLine("Матрица B:");
            Matrix.PrintMatrix(b);
                                   
            var result1 = Matrix.MatrixMultiplication(a, b);
            Console.WriteLine("Умножение матриц:");
            Matrix.PrintMatrix(result1);

            var result2 = Matrix.MatrixSumm(a, b);
            Console.WriteLine("Сумма матриц:");
            Matrix.PrintMatrix(result2);

            var result3 = Matrix.MatrixRaznost(a, b);
            Console.WriteLine("Разность матриц:");
            Matrix.PrintMatrix(result3);

            Console.ReadKey();
        }

    }
}

