using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;

namespace RomanNumeralsTests
{
    /// <summary>
    /// Description résumée pour RomanTranslatorTest
    /// </summary>
    [TestClass]
    public class RomanTranslatorTest
    {
        public RomanTranslatorTest()
        {
            //
            // TODO: ajoutez ici la logique du constructeur
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        //
        // Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        // Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test de la classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilisez ClassCleanup pour exécuter du code une fois que tous les tests d'une classe ont été exécutés
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void testTranslate1shouldReturnI()
        {
            String romanNumber = RomanTranslator.translate(1);
            Assert.AreEqual("I", romanNumber);
        }

        [TestMethod]
        public void testTranslate2shouldReturnII()
        {
            String romanNumber = RomanTranslator.translate(2);
            Assert.AreEqual("II", romanNumber);
        }

        [TestMethod]
        public void testTranslate3ShouldReturnIII()
        {
            String romanNumber = RomanTranslator.translate(3);
            Assert.AreEqual("III", romanNumber);
        }

        [TestMethod]
        public void testTranslate4ShouldReturnIV()
        {
            String romanNumber = RomanTranslator.translate(4);
            Assert.AreEqual("IV", romanNumber);
        }


        [TestMethod]
        public void testTranslate5ShouldReturnV()
        {
            String romanNumber = RomanTranslator.translate(5);
            Assert.AreEqual("V", romanNumber);
        }

        [TestMethod]
        public void testTranslate6ShouldReturnVI()
        {
            String romanNumber = RomanTranslator.translate(6);
            Assert.AreEqual("VI", romanNumber);
        }

        [TestMethod]
        public void testTranslate7ShouldReturnVII()
        {
            String romanNumber = RomanTranslator.translate(7);
            Assert.AreEqual("VII", romanNumber);
        }

        [TestMethod]
        public void testTranslate8ShouldReturnVIII()
        {
            String romanNumber = RomanTranslator.translate(8);
            Assert.AreEqual("VIII", romanNumber);
        }

        [TestMethod]
        public void testTranslate9ShouldReturnIX()
        {
            String romanNumber = RomanTranslator.translate(9);
            Assert.AreEqual("IX", romanNumber);
        }

        [TestMethod]
        public void testTranslate10ShouldReturnX()
        {
            String romanNumber = RomanTranslator.translate(10);
            Assert.AreEqual("X", romanNumber);
        }

        [TestMethod]
        public void testTranslate13ShouldReturnXIII()
        {
            String romanNumber = RomanTranslator.translate(13);
            Assert.AreEqual("XIII", romanNumber);
        }
    }
}
