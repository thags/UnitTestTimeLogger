using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleTimeLogger;

namespace ConsoleTimeLoggerTests
{
    [TestClass]
    public class WhenUserCorrectYearInputCheckIsCalled
    {
        [TestMethod]
        public void AndYearInputIsCorrect()
        {
            // Arrange
            string input = "2015";

            // Act
            bool result = User.IsCorrectYearInput(input);

            // Assert
            Assert.IsTrue(result, "Correct year input should return true");
        }
        [TestMethod]
        public void AndInputIsTooLong()
        {
            // Arrange
            string input = "2015234423";

            // Act
            bool result = User.IsCorrectYearInput(input);

            // Assert
            Assert.IsFalse(result, "Correct year input should only have a length of 4");
        }
        [TestMethod]
        public void AndInputIsTooShort()
        {
            // Arrange
            string input = "201";

            // Act
            bool result = User.IsCorrectYearInput(input);

            // Assert
            Assert.IsFalse(result, "Correct year input should have a length of 4");
        }
        public void AndAStringIsInputted()
        {
            // Arrange
            string input = "TEST";

            // Act
            bool result = User.IsCorrectYearInput(input);

            // Assert
            Assert.IsFalse(result, "Correct year input should not accept letters");
        }
    }
    [TestClass]
    public class WhenUserCorrectMonthInputCheckIsCalled
    {
        [TestMethod]
        public void AndInputIsCorrect()
        {
            // Arrange
            string monthInput = "8";

            // Act
            bool result = User.IsCorrectMonthInput(monthInput);

            // Assert
            Assert.IsTrue(result, "Correct month input should return true");
        }
        [TestMethod]
        public void AndZeroIsInputted()
        {
            // Arrange
            string input = "0";

            // Act
            bool result = User.IsCorrectMonthInput(input);

            // Assert
            Assert.IsFalse(result, "Zero should not be a month");
        }
        [TestMethod]
        public void AndANegativeIsInput()
        {
            // Arrange
            string input = "-1";

            // Act
            bool result = User.IsCorrectMonthInput(input);

            // Assert
            Assert.IsFalse(result, "Negatives should not be a month");
        }
        [TestMethod]
        public void AndOver12IsInput()
        {
            // Arrange
            string input = "13";

            // Act
            bool result = User.IsCorrectMonthInput(input);

            // Assert
            Assert.IsFalse(result, "Over 12 should not be a month");
        }
        [TestMethod]
        public void AndLettersAreInput()
        {
            // Arrange
            string input = "12Test";

            // Act
            bool result = User.IsCorrectMonthInput(input);

            // Assert
            Assert.IsFalse(result, "Letters should not be excepted in a month");
        }
    }
    [TestClass]
    public class WhenReportsHourParseIsCalled
    {
        [TestMethod]
        public void AndCorrectTickIsInput()
        {
            //Arange
            long ticks = 9999214234;
            string expect = "0hr 16mn 39sec";

            // Act
            string result = Reports.ParseHours(ticks);

            // Assert
            Assert.AreEqual(expect, result, "Ticks should be converted to a readable string");
        }
    }
    [TestClass]
    public class WhenDateParseIsCalledInDBManager
    {
        [TestMethod]
        public void AndCorrectInput()
        {
            //Arange
            string input = "637783200000000000";
            string expect = "01-21-2022";

            // Act
            string result = DatabaseManager.ParseDate(input);

            // Assert
            Assert.AreEqual(expect, result, "Correct date should return properly formatted");
        }
        [TestMethod]
        public void AndLettersAreInput()
        {
            //Arange
            string input = "637783200000000000TEST";
            string expect = "Input string was not in a correct format.";

            // Act
            string result = DatabaseManager.ParseDate(input);

            // Assert
            Assert.AreEqual(expect, result, "Incorrect input string should return \"false\"");
        }
    }
    [TestClass]
    public class WhenParseHoursInDBManagerisCalled
    {
        [TestMethod]
        public void AndCorrectInput()
        {
            //Arange
            string input = "72000000000";
            string expect = "02:00";

            // Act
            string result = DatabaseManager.ParseHours(input);

            // Assert
            Assert.AreEqual(expect, result, "String ticks should return properly formatted");
        }
        [TestMethod]
        public void AndLettersAreInInput()
        {
            //Arange
            string input = "72000000000TEST";
            string expect = "Input string was not in a correct format.";

            // Act
            string result = DatabaseManager.ParseHours(input);

            // Assert
            Assert.AreEqual(expect, result, "Incorrect input string should return \"false\"");
        }
    }
}
