using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// IBloodTest.cs
 // Interface representing a blood test.
namespace DecoratorPattern { 
    public interface IBloodTest
    {
        string GetDescription(); // Get a description of the blood test.
        decimal GetCost(); // Get the cost of the blood test.
    }
}