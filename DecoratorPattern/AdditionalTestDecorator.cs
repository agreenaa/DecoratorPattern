using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// AdditionalTestDecorator.cs
// Abstract decorator providing a base for additional test decorators.
namespace DecoratorPattern
{
    public abstract class AdditionalTestDecorator : IBloodTest
    {
        protected IBloodTest BloodTest; // Reference to the blood test being decorated.

        public AdditionalTestDecorator(IBloodTest bloodTest)
        {
            BloodTest = bloodTest;
        }

        public virtual string GetDescription()
        {
            return BloodTest.GetDescription(); // Delegating description to the wrapped blood test.
        }

        public virtual decimal GetCost()
        {
            return BloodTest.GetCost(); // Delegating cost to the wrapped blood test.
        }
    }

}
