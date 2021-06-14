using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task01_Anagram;

namespace AnagramTests
{
    [TestClass]
    public class SwapWordsLettersTests
    {
        [TestMethod]
        public void AnagramTest1()
        {
            // Arrange
            string testStr = "Привет";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "тевирП");
        }

        [TestMethod]
        public void AnagramTest2()
        {
            // Arrange
            string testStr = "Привет Вадим!";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "тевирП мидаВ!");
        }

        [TestMethod]
        public void AnagramTest3()
        {
            // Arrange
            string testStr = "При::вет  Вадим!";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "тев::ирП  мидаВ!");
        }

        [TestMethod]
        public void AnagramTest4()
        {
            // Arrange
            string testStr = "Сублимация (возгонка, от лат. sublimo - возносить)";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "яицамилбуС (акногзов, то тал. omilbus - ьтисонзов)");
        }

        [TestMethod]
        public void AnagramTest5()
        {
            // Arrange
            string testStr = "o o - o o - o g";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "o o - o o - o g");
        }

        [TestMethod]
        public void AnagramTest6()
        {
            // Arrange
            string testStr = "Андрей: 8-925-025-15-44";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "йерднА: 8-925-025-15-44");
        }

        [TestMethod]
        public void AnagramTest7()
        {
            // Arrange
            string testStr = "Михаил ***/д///8/5 Судаков";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "лиахиМ ***/д///8/5 вокадуС");
        }

        [TestMethod]
        public void AnagramTest8()
        {
            // Arrange
            string testStr = "";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "");
        }

        [TestMethod]
        public void AnagramTest9()
        {
            // Arrange
            string testStr = "Р";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "Р");
        }

        [TestMethod]
        public void AnagramTest10()
        {
            // Arrange
            string testStr = "   а б в  гд";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "   а б в  дг");
        }
    }
}
