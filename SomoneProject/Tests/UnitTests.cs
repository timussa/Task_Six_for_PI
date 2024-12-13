using NUnit.Framework;
using static Lesson4.Program;

namespace TestProject
{
    public class TestDropValueFromMatrix
    {
        [Test]
        public void TestDropValueFromMatrix_InvalidParameters()
        {
            Assert.That(() => DropValueFromMatrix(null, 1), Throws.TypeOf<ArgumentException>());

            var m = new int[,] { };
            Assert.That(() => DropValueFromMatrix(m, 1), Throws.TypeOf<ArgumentException>());

            m = new int[,] {{ 1, 2, 3 },
                            { 2, 1, 3 } };
            Assert.That(() => DropValueFromMatrix(m, 1), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void TestSwapMatrDiags_SeveralReplacements()
        {
            var m = new int[,] {{ 1, 2 },
                                { 2, 1 } };
            Assert.That(DropValueFromMatrix(m, 2), Is.EqualTo(new int[,] { { 1, 0 }, { 0, 1 } }), "Error with 2x2 matrix");

            m = new int[,] {{ 1, 2, 3 },
                            { 4, 5, 6 },
                            { 7, 8, 9 } };
            Assert.That(DropValueFromMatrix(m, 3), Is.EqualTo(new int[,] { { 1, 2, 0 }, { 4, 5, 6 }, { 7, 8, 9 } }), "Error with 3x3 matrix");
        }

        [Test]
        public void TestSwapMatrDiags_NoReplacements()
        {
            var m = new int[,] {{ 1, 2 },
                                { 2, 1 } };
            Assert.That(DropValueFromMatrix(m, 7), Is.EqualTo(new int[,] { { 1, 2 }, { 2, 1 } }), "Error with 2x2 matrix");

            m = new int[,] {{ 1, 2, 3 },
                            { 4, 5, 6 },
                            { 7, 8, 9 } };
            Assert.That(DropValueFromMatrix(m, 666), Is.EqualTo(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }), "Error with 3x3 matrix");
        }

        [Test]
        public void TestSwapMatrDiags_ParameterSafety()
        {
            var m = new int[,] {{ 1, 2 },
                                { 2, 1 } };
            Assert.That(DropValueFromMatrix(m, 2), Is.Not.SameAs(m), "Swapped original matrix!");

            m = new int[,] {{ 1, 2, 3 },
                            { 4, 5, 6 },
                            { 7, 8, 9 } };
            Assert.That(DropValueFromMatrix(m, 3), Is.Not.SameAs(m), "Swapped original matrix!");
        }
    }
}