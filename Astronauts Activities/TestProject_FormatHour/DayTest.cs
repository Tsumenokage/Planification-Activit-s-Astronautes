using Astronauts_Activities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject_FormatHour
{
    
    
    /// <summary>
    ///Classe de test pour DayTest, destinée à contenir tous
    ///les tests unitaires DayTest
    ///</summary>
    [TestClass()]
    public class DayTest
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
        ///Test pour ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            int NumberDay = 0; // TODO: initialisez à une valeur appropriée
            Day target = new Day(NumberDay); // TODO: initialisez à une valeur appropriée
            string expected = "Day : 0"; // TODO: initialisez à une valeur appropriée
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour TaskInfo
        ///</summary>
        [TestMethod()]
        public void TaskInfoTest()
        {
            int NumberDay = 0; // TODO: initialisez à une valeur appropriée
            Day target = new Day(NumberDay); // TODO: initialisez à une valeur appropriée
            List<Astronaut> a = new List<Astronaut>();
            Activity act = new Activity("Test");
            Task task = new Task(act,a,50,50,10,10); // TODO: initialisez à une valeur appropriée


            string[] expected = { "", target.ToString(), "0H50", "1H40", task.Name }; // TODO: initialisez à une valeur appropriée
            string[] actual;
            actual = target.TaskInfo(task);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
