using System;

namespace HouseTaxCalcSystem
{
    public class House
    {
        // Private fields (Encapsulation)
        private string address;
        private int numOfRooms;
        private int numOfBathrooms;
        private decimal propertyValue;
        private decimal municipalRate;
        private decimal propertyReduction;

        private decimal adjustedValue;
        private decimal annualTax;
        private decimal monthlyTax;

        // Properties with validation

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int NumOfRooms
        {
            get { return numOfRooms; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Number of rooms must be greater than 0");
                else
                    numOfRooms = value;
            }
        }

        public int NumOfBathrooms
        {
            get { return numOfBathrooms; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Number of bathrooms must be greater than 0");
                else
                    numOfBathrooms = value;
            }
        }

        public decimal PropertyValue
        {
            get { return propertyValue; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Property value must be positive");
                else
                    propertyValue = value;
            }
        }

        public decimal PropertyReduction
        {
            get { return propertyReduction; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Property reduction cannot be negative");
                else
                    propertyReduction = value;
            }
        }

        public decimal MunicipalRate
        {
            get { return municipalRate; }
            set
            {
                if (value <= 0 || value > 1)
                    Console.WriteLine("Municipal rate must be between 0 and 1");
                else
                    municipalRate = value;
            }
        }

        // Constructor
        public House(string address, int rooms, int bathrooms, decimal propertyValue, decimal municipalRate, decimal propertyReduction)
        {
            Address = address;
            NumOfRooms = rooms;
            NumOfBathrooms = bathrooms;
            PropertyValue = propertyValue;
            MunicipalRate = municipalRate;
            PropertyReduction = propertyReduction;
        }

        // Calculate Adjusted Value
        public decimal CalculateAdjustedValue()
        {
            adjustedValue = PropertyValue - PropertyReduction;
            return adjustedValue;
        }

        // Calculate Annual Tax
        public decimal CalculateAnnualTax()
        {
            annualTax = CalculateAdjustedValue() * MunicipalRate;
            return annualTax;
        }

        // Calculate Monthly Tax
        public decimal CalculateMonthlyTax()
        {
            monthlyTax = CalculateAnnualTax() / 12;
            return monthlyTax;
        }

        // Print Details
        public void PrintDetails()
        {
            Console.WriteLine("\n----- Property Details -----");
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Number of Rooms: " + NumOfRooms);
            Console.WriteLine("Number of Bathrooms: " + NumOfBathrooms);
            Console.WriteLine("Property Value: R" + PropertyValue);
            Console.WriteLine("Property Reduction: R" + PropertyReduction);
            Console.WriteLine("Adjusted Value: R" + CalculateAdjustedValue());
            Console.WriteLine("Annual Tax Amount: R" + CalculateAnnualTax());
            Console.WriteLine("Monthly Tax Amount: R" + CalculateMonthlyTax());
        }
    }
}
