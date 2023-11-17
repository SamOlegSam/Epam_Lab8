using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab8;
namespace MatrixTests
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void MultiplicationTest()
        {
            int[,] a = new int[3, 2];
            int[,] b = new int[2, 3];
            int[,] c = new int[3, 3];

            a[0, 0] = 1; a[0, 1] = 1; a[1, 0] = 2; a[1, 1] = 2; a[2, 0] = 3; a[2, 1] = 3;

            b[0, 0] = 1; b[0, 1] = 1; b[0, 2] = 1; b[1, 0] = 2; b[1, 1] = 2; b[1, 2] = 2;

            c[0, 0] = 3; c[0, 1] = 3; c[0, 2] = 3; c[1, 0] = 6; c[1, 1] = 6; c[1, 2] = 6; c[2, 0] = 9; c[2, 1] = 9; c[2, 2] = 9;

            int[,] actual = Matrix.MatrixMultiplication(a, b);

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Assert.AreEqual(c[i, j], actual[i, j]);
                }
            }
        }
        //----------------------------------------------------------------------------------
        [TestMethod]
        public void SummTest()
        {
            int[,] a = new int[3, 2];
            int[,] b = new int[2, 3];
            int[,] c = new int[3, 3];

            a[0, 0] = 1; a[0, 1] = 1; a[1, 0] = 2; a[1, 1] = 2; a[2, 0] = 3; a[2, 1] = 3;

            b[0, 0] = 1; b[0, 1] = 1; b[0, 2] = 1; b[1, 0] = 2; b[1, 1] = 2; b[1, 2] = 2;

            c[0, 0] = 5; c[0, 1] = 5; c[0, 2] = 5; c[1, 0] = 7; c[1, 1] = 7; c[1, 2] = 7; c[2, 0] = 9; c[2, 1] = 9; c[2, 2] = 9;

            int[,] actual = Matrix.MatrixSumm(a, b);

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Assert.AreEqual(c[i, j], actual[i, j]);
                }
            }
        }
        //----------------------------------------------------------------------------------
        [TestMethod]
        public void RaznostTest()
        {
            int[,] a = new int[3, 2];
            int[,] b = new int[2, 3];
            int[,] c = new int[3, 3];

            a[0, 0] = 1; a[0, 1] = 1; a[1, 0] = 2; a[1, 1] = 2; a[2, 0] = 3; a[2, 1] = 3;

            b[0, 0] = 1; b[0, 1] = 1; b[0, 2] = 1; b[1, 0] = 2; b[1, 1] = 2; b[1, 2] = 2;

            c[0, 0] = -1; c[0, 1] = -1; c[0, 2] = -1; c[1, 0] = 1; c[1, 1] = 1; c[1, 2] = 1; c[2, 0] = 3; c[2, 1] = 3; c[2, 2] = 3;

            int[,] actual = Matrix.MatrixRaznost(a, b);

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Assert.AreEqual(c[i, j], actual[i, j]);
                }
            }
        }
    }
}
