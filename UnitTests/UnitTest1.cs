using DecoratorPattern;
using NUnit.Framework;


namespace UnitTests
{
    public class Tests
    {

        [TestFixture]
        public class BloodTestOrderTests
        {
            [Test]
            public void BasicBloodTest_Cost_ShouldBe50()
            {
                IBloodTest basicBloodTest = new BasicBloodTest();
                Assert.AreEqual(50.0m, basicBloodTest.GetCost());
            }

            [Test]
            public void IronLevelTestDecorator_AddedCost_ShouldBe15()
            {
                IBloodTest basicBloodTest = new BasicBloodTest();
                IBloodTest withIronLevelTest = new IronLevelTestDecorator(basicBloodTest);
                Assert.AreEqual(65.0m, withIronLevelTest.GetCost());
            }

            [Test]
            public void CholesterolTestDecorator_AddedCost_ShouldBe20()
            {
                IBloodTest basicBloodTest = new BasicBloodTest();
                IBloodTest withCholesterolTest = new CholesterolTestDecorator(basicBloodTest);
                Assert.AreEqual(70.0m, withCholesterolTest.GetCost());
            }

            [Test]
            public void EnhancedBloodTest_WithBothTests_CostShouldBe85()
            {
                IBloodTest basicBloodTest = new BasicBloodTest();
                IBloodTest withBothTests = new CholesterolTestDecorator(new IronLevelTestDecorator(basicBloodTest));
                Assert.AreEqual(85.0m, withBothTests.GetCost());
            }

            [Test]
            public void EnhancedBloodTest_Description_ShouldBeCorrect()
            {
                IBloodTest basicBloodTest = new BasicBloodTest();
                IBloodTest withBothTests = new CholesterolTestDecorator(new IronLevelTestDecorator(basicBloodTest));
                Assert.AreEqual("Basic Blood Test, Iron Level Test, Cholesterol Test", withBothTests.GetDescription());
            }
        }
    }
}