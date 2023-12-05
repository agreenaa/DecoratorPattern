using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// BasicBloodTest.cs
// Concrete component representing a basic blood test.
namespace DecoratorPattern
{
    public class BasicBloodTest : IBloodTest
    {
        public string GetDescription()
        {
            return "Basic Blood Test";
        }

        public decimal GetCost()
        {
            return 50.0m; // Base cost for the basic blood test.
        }
    }

}
