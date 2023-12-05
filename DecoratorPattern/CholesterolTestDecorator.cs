using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// CholesterolTestDecorator.cs
// Concrete decorator adding a Cholesterol Test to a blood test.
namespace DecoratorPattern
{
    public class CholesterolTestDecorator : AdditionalTestDecorator
    {
        public CholesterolTestDecorator(IBloodTest bloodTest) : base(bloodTest)
        {
        }

        public override string GetDescription()
        {
            return $"{BloodTest.GetDescription()}, Cholesterol Test"; // Appending Cholesterol Test to the description.
        }

        public override decimal GetCost()
        {
            return base.GetCost() + 20.0m; // Additional cost for Cholesterol Test.
        }
    }

}