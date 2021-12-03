using Cypher;
using NUnit.Framework;

namespace Cypher.Test
{
    public class ProgramTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetCypher_abc_bcd()
        {
            string input = "abc defg uvW";
            string expected = "bcd efgh vwX";
            string actual = Program.GetCypher(input, 1, null);

            Assert.AreEqual(expected, actual);
        }
    }
}