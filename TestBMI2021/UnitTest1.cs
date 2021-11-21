using Microsoft.VisualStudio.TestTools.UnitTesting;
//using BMICalculator;

namespace TestBMI2021
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BMICalculator.BMI bmi = new BMICalculator.BMI() { WeightStones = 13, WeightPounds = 0, HeightFeet = 5, HeightInches = 9 };
            Assert.AreNotEqual(bmi.BMICategory, BMICalculator.BMICategory.Normal);
        }

        [TestMethod]
        public void TestMethod2()
        {
            BMICalculator.BMI bmi = new BMICalculator.BMI() { WeightStones = 13, HeightFeet=6 };
            Assert.AreEqual(bmi.BMICategory, BMICalculator.BMICategory.Normal);
        }
    }
}
