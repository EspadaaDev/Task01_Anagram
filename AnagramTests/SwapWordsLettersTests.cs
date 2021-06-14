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
            string testStr = "Привет!";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "тевирП!");
        }

        [TestMethod]
        public void AnagramTest2()
        {
            // Arrange
            string testStr = "!д;е**лвв";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "!в;в**лед");
        }

        [TestMethod]
        public void AnagramTest3()
        {
            // Arrange
            string testStr = "!!!Не?  Шл))( ппо_з";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "!!!зо?  пп))( лШе_Н");
        }

        [TestMethod]
        public void AnagramTest4()
        {
            // Arrange
            string testStr = "Сублимация (возгонка, от лат. sublimo - возносить)";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "ьтисонзовo (milbusта, лт оак. ногзовя - ицамилбуС)");
        }

        [TestMethod]
        public void AnagramTest5()
        {
            // Arrange
            string testStr = "o o - o o - o g";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "g o - o o - o o");
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
            Assert.AreEqual(reversedString, "вокаду ***/С///8/5 длиахиМ");
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
            Assert.AreEqual(reversedString, "   д г в  ба");
        }
    }
}
