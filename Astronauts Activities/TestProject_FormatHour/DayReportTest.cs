using Astronauts_Activities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject_FormatHour
{
    
    
    /// <summary>
    ///Classe de test pour DayReportTest, destinée à contenir tous
    ///les tests unitaires DayReportTest
    ///</summary>
    [TestClass()]
    public class DayReportTest
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
            Day daySelected = new Day(1); // TODO: initialisez à une valeur appropriée
            DayReport target = new DayReport(daySelected); // TODO: initialisez à une valeur appropriée
            int Time = 911; // TODO: initialisez à une valeur appropriée
            string expected = "15H11"; // TODO: initialisez à une valeur appropriée
            string actual;
            actual = target.FormatHour(Time);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour FormatHour
        ///</summary>
        [TestMethod()]
        public void FormatHourTest1()
        {
            Day daySelected = new Day(0); ; // TODO: initialisez à une valeur appropriée
            DayReport target = new DayReport(daySelected); // TODO: initialisez à une valeur appropriée
            int Time = 90; // TODO: initialisez à une valeur appropriée
            string expected = "1H30"; // TODO: initialisez à une valeur appropriée
            string actual;
            actual = target.FormatHour(Time);
            Assert.AreEqual(expected, actual);
        }
    }
}
