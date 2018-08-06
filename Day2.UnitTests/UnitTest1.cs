using Day2.Core;
using Day2.Core.Tyans;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Day2.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTyanSearcherSearch_Params_ArrayOfNamesWithSpecifiedParams()
        {
            var tyans = new List<Tyan>();
            tyans.Add(new Tyan("TestTyan1", 22, 4, Tyan.Kawaiiness.Super));
            tyans.Add(new Tyan("TestTyan2", 19, 3, Tyan.Kawaiiness.Middle));

            var expected = new string[1] { "TestTyan1" };
            var actual = new TyanSearcher(
                         new SearcherSettings<Tyan>(tyans.AsReadOnly()), 22, 4, Tyan.Kawaiiness.Super)
                         .Search();

            Assert.AreEqual(expected[0], actual[0]);
        }
    }
}
