using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CountWordLibrary;

namespace CountWordTests
{
    [TestClass]
    public class CountWordTest
    {
        //[DataTestMethod]
        //[DataRow(" пи пи пи ля ля ля мышка сэй ми пи пи пи" ,"пи" ,6)]
        //[DataRow("йоу мизев ты крутой лоъ", "мизев", 1)]
        //[DataRow("тестирование предмет важный пуфогарфафафывгафывгшафда", "аниме", 0)]

        //public void AllTests(string str,string word,int expected)
        //{
        //    //Act
        //    int actual = CountWodrClass.WordCount(str, word);
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void CountWordCheck_EmptyString_ReturnedException()
        //{
        //    string str = "";
        //    string word = "пилюля";
        //    //Act
        //    Action actual =() => CountWodrClass.WordCount(str, word);
        //    Assert.ThrowsException<Exception>(actual);
        //}
        //[TestMethod]
        //public void CountWordCheck_OnlySpaces_ReturnedException()
        //{
        //    string str = "    ";
        //    string word = "пилюля";
        //    //Act
        //    Action actual = () => CountWodrClass.WordCount(str, word);
        //    Assert.ThrowsException<Exception>(actual);
        //}


        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"testData.xml", "String", DataAccessMethod.Sequential)]


        [TestMethod]
        public void ClassLibraryPassword_Data()
        {
            string str = Convert.ToString(TestContext.DataRow["str"]);
            string word = Convert.ToString(TestContext.DataRow["word"]);
            int expected = Convert.ToInt32(TestContext.DataRow["expected"]);

            int actual = CountWodrClass.WordCount(str, word);
               //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
