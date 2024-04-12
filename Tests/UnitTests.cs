using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_ValidGann()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_InvalidGann()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_NullGann()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Subtract_ValidGann()
        {
            Assert.AreEqual(-1, Program.Subtract("1", "2"));
        }

        [Test]
        public void Subtract_InvalidGann()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
        }

        [Test]
        public void Subtract_NullGann()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
        }

        [Test]
        public void Multiply_ValidGann()
        {
            Assert.AreEqual(2, Program.Multiply("1", "2"));
        }

        [Test]
        public void Multiply_InvalidGann()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
        }

        [Test]
        public void Multiply_NullGann()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
        }

        [Test]
        public void Divide_ValidGann()
        {
            Assert.AreEqual(1, Program.Divide("2", "2"));
        }

        [Test]
        public void Divide_InvalidGann()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
        }

        [Test]
        public void Divide_NullGann()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
        }
        [Test]
        public void Power_ValidGann()
        {
            Assert.AreEqual(4, Program.Power("2", "2"));
        }

        [Test]
        public void Power_InvalidGann()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
        }

        [Test]
        public void Power_NullGann()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
        }
    }
}
