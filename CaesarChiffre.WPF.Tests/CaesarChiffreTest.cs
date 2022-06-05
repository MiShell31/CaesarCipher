using CaesarChiffre.WPF.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarChiffre.WPF.Tests
{
    [TestFixture]
    public class CaesarChiffreTest
    {
        private CaesarChiffreModel _caesarChiffreModel;

        [SetUp]
        public void SetUp()
        {
            _caesarChiffreModel = new CaesarChiffreModel();
        }

        [Test]
        public void CaesarEncrypt_ValidParameters_ReturnsEncryptedText()
        {
            //Arrange
            string expectedOutput = "Kdoor$";
            int key = 3;
            string inputText = "Hallo!";

            //Act
            string actualOutputText = _caesarChiffreModel.CaesarEncrypt(inputText, key);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutputText);
        }

        [Test]
        public void CaesarDecrypt_ValidParameters_ReturnsDecryptedText()
        {
            //Arrange
            string inputText = "Kdoor$";
            int key = 3;
            string expectedOutput = "Hallo!";

            //Act
            string actualOutputText = _caesarChiffreModel.CaesarDecrypt(inputText, key);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutputText);
        }
    }
}
