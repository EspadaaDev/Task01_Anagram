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
            string testStr = "������!";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "������!");
        }

        [TestMethod]
        public void AnagramTest2()
        {
            // Arrange
            string testStr = "!�;�**���";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "!�;�**���");
        }

        [TestMethod]
        public void AnagramTest3()
        {
            // Arrange
            string testStr = "!!!��?  ��))( ���_�";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "!!!��?  ��))( ���_�");
        }

        [TestMethod]
        public void AnagramTest4()
        {
            // Arrange
            string testStr = "���������� (��������, �� ���. sublimo - ���������)";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "���������o (milbus��, �� ���. ������� - ���������)");
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
            string testStr = "������: 8-925-025-15-44";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "������: 8-925-025-15-44");
        }

        [TestMethod]
        public void AnagramTest7()
        {
            // Arrange
            string testStr = "������ ***/�///8/5 �������";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "������ ***/�///8/5 �������");
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
            string testStr = "�";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "�");
        }

        [TestMethod]
        public void AnagramTest10()
        {
            // Arrange
            string testStr = "   � � �  ��";

            // Act
            string reversedString = testStr.SwapWordsLetters();

            // Assert
            Assert.AreEqual(reversedString, "   � � �  ��");
        }
    }
}
