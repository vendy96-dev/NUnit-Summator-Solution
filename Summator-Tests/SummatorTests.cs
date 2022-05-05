using NUnit.Framework;
using Summator_Project;

namespace Summator_Tests
{
    public class Tests
    {
        [Test]
       public void Test_Sum_TwoPositiveNumbers()
        {
            int expected = Summator.Sum(new int[] {5,7});
            int actual = 12;
            Assert.That(expected==actual);
        }
        [Test]
        public void Test_Sum_OnePositiveNumbers()
        {
            int expected = Summator.Sum(new int[] {5});
            int actual = 5;
            Assert.That(expected == actual);
        }
        [Test]
        public void Test_Sum_EmptyArray()
        {
            int expected = Summator.Sum(new int[] {});
            int actual = 0;
            Assert.That(expected == actual);
        }
        [Test]
        public void Test_Sum_Negative()
        {
            int expected = Summator.Sum(new int[] {-1,-6 });
            int actual = -7;
            Assert.That(expected == actual);
        }
        [Test]
        public void Test_Sum_BigValue()
        {
            int expected = Summator.Sum(new int[] {300000000,300000000,300000000});
            int actual = 900000000;
            Assert.AreEqual(expected,actual);
        }
        [Test]
        public void Test_Average_TwoPositiveNumbers()
        {
            int expected = Summator.Average(new int[] {2,3,4 });
            int actual = 3;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Average_TwoNegativeNumbers()
        {
            int expected = Summator.Average(new int[] { -2, -3, -4 });
            int actual = -3;
            Assert.AreEqual(expected, actual);
        }
           }
        
}