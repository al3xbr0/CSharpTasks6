using NUnit.Framework;

namespace ATM.Tests
{
    public class WrongArgumentsTests
    {
        [TestCase("", new string[] { "" })]
        [TestCase("qwerty", new string[] { "a" })]
        [TestCase("4", new string[] { "2", "a" })]
        [TestCase("-50", new string[] { "1", "2" })]
        [TestCase("0", new string[] { "4", "2" })]
        [TestCase("10", new string[] { "-3", "7" })]
        public void InvalidInputTest(string sum, string[] vals)
        {
            Assert.That(
                () =>
                {
                    ATM task = new ATM { Sum = sum, Vals = vals };
                },
                Throws.ArgumentException.With.Message.EqualTo(ATM.ERROR_MESSAGE));
        }
    }
}