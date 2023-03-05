using LeetCodeSolutions;

namespace LeetCodeTests
{
    public class UT_1480_Running_Sum_of_1d_Array
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestSet1()
        {
            var nums = new int[] { 1, 2, 3, 4 };

            var outNums = new int[] { 1, 3, 6, 10 };

            Assert.That(outNums, Is.EqualTo(RunningSumOf1dArray.RunningSum(nums)));
        }

        [Test]
        public void TestSet2()
        {
            var nums = new int[] { 1, 1, 1, 1, 1 };

            var outNums = new int[] { 1, 2, 3, 4, 5 };

            Assert.That(outNums, Is.EqualTo(RunningSumOf1dArray.RunningSum(nums)));
        }

        [Test]
        public void TestSet3()
        {
            var nums = new int[] { 3, 1, 2, 10, 1 };

            var outNums = new int[] { 3, 4, 6, 16, 17 };

            Assert.That(outNums, Is.EqualTo(RunningSumOf1dArray.RunningSum(nums)));
        }
    }
}