using System;
using NUnit.Framework;
// using Enium.Common.Core;

namespace Test
{
    public class Class1
    {
        [Test]
        public void OriginalTest()
        {
            Console.WriteLine("Hello World!");
            Assert.That(1, Is.EqualTo(1));
        }

        [Test]
        public void GetWorkingDaysForLoanApplication_NoExcludedDates_ReturnsCorrectWorkingDays()
        {
            // Arrange
            var startDate = new DateTime(2023, 6, 1, 6, 3, 30, DateTimeKind.Utc);
            var countryCode = "US";
            var expectedWorkingDays = 26;

            // Act
            int workingDays = startDate.GetWorkingDaysForLoanApplication(countryCode);

            // Assert
            // Add your assertion here to verify the expected number of working days
            Assert.AreEqual(expectedWorkingDays, workingDays);
        }
    }
}