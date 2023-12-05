// BloodTestOrder.cs
using DecoratorPattern;
using System;

class BloodTestOrder
{
    static void Main()
    {
        Console.WriteLine("***Blood Test Ordering System***\n");

        // Scenario: Ordering a basic blood test
        IBloodTest bloodTest = new BasicBloodTest();
        DisplayTestDetails(bloodTest);

        // Allow the user to customize the blood test
        Console.WriteLine("\nDo you want to customize the blood test?");
        Console.WriteLine("1. Add Iron Level Test");
        Console.WriteLine("2. Add Cholesterol Test");
        Console.WriteLine("3. Add both Iron Level and Cholesterol Tests");
        Console.WriteLine("4. No customization (Basic Blood Test only)");

        int choice = GetChoice();

        // Apply user's choice of customization
        switch (choice)
        {
            case 1:
                bloodTest = new IronLevelTestDecorator(bloodTest);
                break;
            case 2:
                bloodTest = new CholesterolTestDecorator(bloodTest);
                break;
            case 3:
                bloodTest = new CholesterolTestDecorator(new IronLevelTestDecorator(bloodTest));
                break;
                // Default case: Basic Blood Test only
        }

        // Display the final customized blood test
        Console.WriteLine("\nFinal Customized Blood Test:");
        DisplayTestDetails(bloodTest);
    }

    static void DisplayTestDetails(IBloodTest bloodTest)
    {
        Console.WriteLine($"Test: {bloodTest.GetDescription()}, Cost: ${bloodTest.GetCost()}");
    }

    static int GetChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
        }
        return choice;
    }
}
