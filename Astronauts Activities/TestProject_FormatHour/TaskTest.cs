using Astronauts_Activities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject_FormatHour
{
    
    
    /// <summary>
    ///Classe de test pour TaskTest, destinée à contenir tous
    ///les tests unitaires TaskTest
    ///</summary>
    [TestClass()]
    public class TaskTest
    {


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
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion



        /// <summary>
        ///Test pour FormatHour
        ///</summary>
        [TestMethod()]
        public void FormatHourTest()
        {
            Activity Tactivity = new Activity("Test"); // TODO: initialisez à une valeur appropriée
            List<Astronaut> Tastronauts = new List<Astronaut>(); // TODO: initialisez à une valeur appropriée
            int DureeMinute = 130; // TODO: initialisez à une valeur appropriée
            int StartHour = 150; // TODO: initialisez à une valeur appropriée
            int X = 0; // TODO: initialisez à une valeur appropriée
            int Y = 0; // TODO: initialisez à une valeur appropriée
            Task target = new Task(Tactivity, Tastronauts, DureeMinute, StartHour, X, Y); // TODO: initialisez à une valeur appropriée
            int Time = DureeMinute+StartHour ; // TODO: initialisez à une valeur appropriée
            string expected = "4H40"; // TODO: initialisez à une valeur appropriée
            string actual;
            actual = target.FormatHour(Time);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour getInfo
        ///</summary>
        [TestMethod()]
        public void getInfoTest()
        {
            Activity Tactivity = new Activity("Test");
            List<Astronaut> Tastronauts = new List<Astronaut>();
            int DureeMinute = 120; // TODO: initialisez à une valeur appropriée
            int StartHour = 130; // TODO: initialisez à une valeur appropriée
            int X = 0; // TODO: initialisez à une valeur appropriée
            int Y = 0; // TODO: initialisez à une valeur appropriée
            Task target = new Task(Tactivity, Tastronauts, DureeMinute, StartHour, X, Y);
            string[] expected = { "", target.FormatHour(StartHour), target.FormatHour(DureeMinute + StartHour), target.Name };
            string[] actual;
            actual = target.getInfo();
            CollectionAssert.AreEqual(expected, actual);
            
        }
    }
}
