using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalaizerClassLibrary;
using System.Collections.Generic;
using System;

namespace AnalizerClassLibraryTests
{
    [TestClass]
    public class AnalizerClassTests
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\User\\Desktop\\tests\\Calculator\\AnalizerClassLibraryTests\\test-cases.xml", "TestInsertSymbol", DataAccessMethod.Sequential)]
        [TestMethod]
        public void InsertSymbol_TestCases_ReturnsExpectedResults()
        {
            string input = Convert.ToString(TestContext.DataRow["Input"]);
            char symbol = Convert.ToChar(TestContext.DataRow["Symbol"]);
            int position = Convert.ToInt32(TestContext.DataRow["Position"]);
            string expected = Convert.ToString(TestContext.DataRow["Expected"]);

            string result = AnalaizerClass.InsertSymbol(input, symbol, position);
            
            Assert.AreEqual(expected, result);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\User\\Desktop\\tests\\Calculator\\AnalizerClassLibraryTests\\test-cases.xml", "TestIsOperator", DataAccessMethod.Sequential)]
        [TestMethod]

        public void IsOperator_TestCases_ReturnsExpectedResults()
        {
            string input = Convert.ToString(TestContext.DataRow["Input"]);
            bool expected = Convert.ToBoolean(TestContext.DataRow["Expected"]);

            bool result = AnalaizerClass.IsOperator(input);
            Assert.AreEqual(expected, result);
        }
    }
}
