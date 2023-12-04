using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// IronLevelTestDecorator.cs
// Concrete decorator adding an Iron Level Test to a blood test.
namespace DecoratorPattern
{
    public class IronLevelTestDecorator : AdditionalTestDecorator
    {
        public IronLevelTestDecorator(IBloodTest bloodTest) : base(bloodTest)
        {
        }

        public override string GetDescription()
        {
            return $"{BloodTest.GetDescription()}, Iron Level Test"; // Appending Iron Level Test to the description.
        }

        public override decimal GetCost()
        {
            return base.GetCost() + 15.0m; // Additional cost for Iron Level Test.
        }
    }

}
