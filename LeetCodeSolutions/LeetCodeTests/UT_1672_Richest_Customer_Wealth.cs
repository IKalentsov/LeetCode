using LeetCodeSolutions;

namespace LeetCodeTests
{
    public class UT_1672_Richest_Customer_Wealth
    {
        [Test]
        public void TestSet1()
        {
            int[][] accounts =
            {
                new int[] { 1, 2, 3 },
                new int[] { 3, 2, 1 }
            };

            var result = 6;

            Assert.That(result, Is.EqualTo(RichestCustomerWealth.MaximumWealth(accounts)));
        }

        [Test]
        public void TestSet2()
        {
            int[][] accounts =
            {
                new int[] { 1, 5 },
                new int[] { 7, 3 }
            };

            var result = 10;

            Assert.That(result, Is.EqualTo(RichestCustomerWealth.MaximumWealth(accounts)));
        }

        [Test]
        public void TestSet3()
        {
            int[][] accounts =
            {
                new int[] { 2, 8, 7 },
                new int[] { 7, 1, 3 },
                new int[] { 1, 9, 5 }
            };

            var result = 17;

            Assert.That(result, Is.EqualTo(RichestCustomerWealth.MaximumWealth(accounts)));
        }
    }
}
