using Astronauts_Activities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjectMartianTime
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
        ///Test pour MartianTime
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Astronauts Activities.exe")]
        public void MartianTimeTest()
        {
            PrivateObject param0 = new PrivateObject(5); // TODO: initialisez à une valeur appropriée
            DayReport_Accessor target = new DayReport_Accessor(param0); // TODO: initialisez à une valeur appropriée
            double SecondsBegin = 88861; // TODO: initialisez à une valeur appropriée
            string expected = "24:01:01";
            string actual;
            actual = target.MartianTime(SecondsBegin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
