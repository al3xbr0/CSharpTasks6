using NUnit.Framework;

namespace ATM.Tests
{
    public class WrongArgumentsTests
    {
        private const string EXPECTED_INVALID = "ERROR: Invalid input!";
        private const string EXPECTED_NEGATIVE = "ERROR: Sum and Values must be positive!";

        private ATM task;

        [SetUp]
        public void Setup()
        {
        }

        [TestCase("", new string[] { "" })]
        [TestCase("qwerty", new string[] { "a" })]
        [TestCase("4", new string[] { "2", "a" })]
        public void InvalidInputTest(string sum, string[] vals)
        {
            Assert.That(
                () => task = new ATM(sum, vals),
                Throws.ArgumentException.With.Message.EqualTo(EXPECTED_INVALID));
        }

        [TestCase("-50", new string[] { "1", "2" })]
        [TestCase("0", new string[] { "4", "2" })]
        [TestCase("10", new string[] { "-3", "7" })]
        public void NegativeInputTest(string sum, string[] vals)
        {
            Assert.That(
                () => task = new ATM(sum, vals),
                Throws.ArgumentException.With.Message.EqualTo(EXPECTED_NEGATIVE));
        }
    }
}