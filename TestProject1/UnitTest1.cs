using MPT_1lab;

namespace TestProject1
{
    [TestClass]
    public class Fun1_testClass
    {
        [TestMethod]
        public void MultiplyNonZeroValues_ReturnsZero_WhenAllValuesAreZero()
        {
            int[] v = { 0, 0, 0 };
            int[] ind = { 0, 1, 2 };

            int result = Lab_1.MultiplyNonZeroValues(v, ind);

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void MultiplyNonZeroValues_ReturnsProductOfNonZeroValues_WhenValuesAreNonZero()
        {
            int[] v = { 1, 2, 3, 4, 5 };
            int[] ind = { 0, 2, 4 };

            int result = Lab_1.MultiplyNonZeroValues(v, ind);

            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void MultiplyNonZeroValues_IgnoresInvalidIndices_WhenIndicesAreOutOfRange()
        {
            int[] v = { 1, 2, 3 };
            int[] ind = { -1, 1, 5 };

            int result = Lab_1.MultiplyNonZeroValues(v, ind);

            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void MultiplyNonZeroValues_IgnoresZeroValues_WhenValuesAreMixed()
        {
            int[] v = { 1, 0, 3, 0, 5 };
            int[] ind = { 0, 1, 2, 3, 4 };

            int result = Lab_1.MultiplyNonZeroValues(v, ind);

            Assert.AreEqual(15, result);
        }

    }
    [TestClass]
    public class Fun2_testClass
    {
        [TestMethod]
        public void FindMinValueAndIndex_ReturnsMinValueAndIndex_WhenAllPositiveIntegers()
        {
            int[] array = { 5, 10, 2, 8, 3 };

            var result = Lab_1.FindMinValueAndIndex(array);

            Assert.AreEqual(2, result.Item1);
            Assert.AreEqual(2, result.Item2);
        }
        [TestMethod]
        public void FindMinValueAndIndex_ReturnsMinValueAndIndex_WhenAllNegativeIntegers()
        {
            int[] array = { -5, -10, -2, -8, -3 };

            var result = Lab_1.FindMinValueAndIndex(array);

            Assert.AreEqual(-10, result.Item1);
            Assert.AreEqual(1, result.Item2);
        }
        [TestMethod]
        public void FindMinValueAndIndex_ReturnsMinValueAndIndex_WhenMixedIntegers()
        {
            int[] array = { -5, 10, -2, 8, -3 };

            var result = Lab_1.FindMinValueAndIndex(array);

            Assert.AreEqual(-5, result.Item1);
            Assert.AreEqual(0, result.Item2);
        }
        [TestMethod]
        public void FindMinValueAndIndex_ReturnsMinValueAndIndex_WhenDuplicates()
        {
            int[] array = { 5, 10, 2, 2, 3 };

            var result = Lab_1.FindMinValueAndIndex(array);

            Assert.AreEqual(2, result.Item1);
            Assert.AreEqual(2, result.Item2);
        }
    }
    [TestClass]
    public class Fun3_testClass
    {
        [TestMethod]
        public void ReverseArray_ReversesArray_WhenAllPositiveDoubles()
        {
            double[] array = { 5.2, 10.5, 2.1, 8.3, 3.7 };
            double[] expected = { 3.7, 8.3, 2.1, 10.5, 5.2 };

            Lab_1.ReverseArray(array);

            CollectionAssert.AreEqual(expected, array);
        }
        [TestMethod]
        public void ReverseArray_ReversesArray_WhenAllNegativeDoubles()
        {
            double[] array = { -5.2, -10.5, -2.1, -8.3, -3.7 };
            double[] expected = { -3.7, -8.3, -2.1, -10.5, -5.2 };

            Lab_1.ReverseArray(array);

            CollectionAssert.AreEqual(expected, array);
        }
        [TestMethod]
        public void ReverseArray_ReversesArray_WhenMixedDoubles()
        {
            double[] array = { -5.2, 10.5, -2.1, 8.3, -3.7 };
            double[] expected = { -3.7, 8.3, -2.1, 10.5, -5.2 };

            Lab_1.ReverseArray(array);

            CollectionAssert.AreEqual(expected, array);
        }
        [TestMethod]
        public void ReverseArray_DoesNotChangeArray_WhenOnlyOneElement()
        {
            double[] array = { 5.2 };
            double[] expected = { 5.2 };

            Lab_1.ReverseArray(array);

            CollectionAssert.AreEqual(expected, array);
        }
    }
}