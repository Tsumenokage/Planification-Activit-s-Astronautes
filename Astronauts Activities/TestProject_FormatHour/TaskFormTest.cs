using Astronauts_Activities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject_FormatHour
{
    
    
    /// <summary>
    ///Classe de test pour TaskFormTest, destinée à contenir tous
    ///les tests unitaires TaskFormTest
    ///</summary>
    [TestClass()]
    public class TaskFormTest
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
        ///Test pour AstronautIsFree
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Astronauts Activities.exe")]
        public void AstronautIsFreeTest()
        {
            PrivateObject param0 = null; // TODO: initialisez à une valeur appropriée
            TaskForm_Accessor target = new TaskForm(); // TODO: initialisez à une valeur appropriée
            Astronaut A = new Astronaut("Test"); // TODO: initialisez à une valeur appropriée
            bool expected = false; // TODO: initialisez à une valeur appropriée
            bool actual;
            actual = target.AstronautIsFree(A);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
