using LeetCodeSolutions;

namespace LeetCodeTests
{
    public class UT_1342_Number_of_Steps_to_Reduce_a_Number_to_Zero
    {
        [Test]
        public void TestSet1()
        {
            var num = 14;

            var outNums = 6;

            Assert.That(outNums, Is.EqualTo(NumberOfStepsToReduceANumberToZero.NumberOfSteps(num)));
        }

        [Test]
        public void TestSet2()
        {
            var num = 8;

            var outNums = 4;

            Assert.That(outNums, Is.EqualTo(NumberOfStepsToReduceANumberToZero.NumberOfSteps(num)));
        }

        [Test]
        public void TestSet3()
        {
            var num = 123;

            var outNums = 12;

            Assert.That(outNums, Is.EqualTo(NumberOfStepsToReduceANumberToZero.NumberOfSteps(num)));
        }
    }
}
