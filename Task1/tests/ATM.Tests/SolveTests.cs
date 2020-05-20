using NUnit.Framework;
using System;
using System.IO;

namespace ATM.Tests
{
    public class SolveTests
    {
        private StringWriter writer;

        private ATM task;

        [SetUp]
        public void Setup()
        {
            writer = new StringWriter();
            Console.SetOut(writer);
        }

        [Test]
        public void Test1()
        {
            task = new ATM { Sum = "5", Vals = new string[] { "3", "2" } };
            task.Solve(false);
            string[] expected = { "2 3", "1 combinations in total" };
            string[] actual = writer.ToString().Split($" {Environment.NewLine}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            task = new ATM { Sum = "5", Vals = new string[] { "1", "2" } };
            task.Solve(false);
            string[] expected = { "1 2 2", "1 1 1 2", "1 1 1 1 1", "3 combinations in total" };
            string[] actual = writer.ToString().Split($" {Environment.NewLine}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            task = new ATM { Sum = "10", Vals = new string[] { "5", "1", "2" } };
            task.Solve(false);
            string[] expected = { "5 5", "2 2 2 2 2", "1 2 2 5", "1 1 2 2 2 2",
                "1 1 1 2 5", "1 1 1 1 2 2 2", "1 1 1 1 1 5", "1 1 1 1 1 1 2 2",
                "1 1 1 1 1 1 1 1 2", "1 1 1 1 1 1 1 1 1 1", "10 combinations in total" };
            string[] actual = writer.ToString().Split($" {Environment.NewLine}");
            Assert.AreEqual(expected, actual);
        }
    }
}