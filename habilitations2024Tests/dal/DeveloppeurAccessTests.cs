using Microsoft.VisualStudio.TestTools.UnitTesting;
using habilitations2024.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using habilitations2024.model;
using habilitations2024.bddmanager;

namespace habilitations2024.dal.Tests
{
    [TestClass()]
    public class DeveloppeurAccessTests
    {
        DeveloppeurAccess developpeurAccess = new DeveloppeurAccess();
        Access access = Access.GetInstance();

        [TestMethod()]
        public void GetLesDeveloppeursTestNombreTousProfils()
        {
            List<Developpeur> listeDevs = developpeurAccess.GetLesDeveloppeurs(0);
            List<Object[]> listeCount = access.Manager.ReqSelect("SELECT COUNT(*) FROM developpeur");
            int expectedCount;
            try
            {
                expectedCount = Convert.ToInt32(listeCount[0][0]);
            }
            catch
            {
                expectedCount = 0;
            }
           
            Assert.AreEqual(expectedCount, listeDevs.Count);

        }

        [TestMethod()]
        public void GetLesDeveloppeursTestNombreDeProfil()
        {
            List<Developpeur> listeDevs = developpeurAccess.GetLesDeveloppeurs(5);
            List<Object[]> listeCount = access.Manager.ReqSelect("SELECT COUNT(*) FROM developpeur where idprofil = 5");
            int expectedCount;
            try
            {
                expectedCount = Convert.ToInt32(listeCount[0][0]);
            }
            catch
            {
                expectedCount = 0;
            }

            Assert.AreEqual(expectedCount, listeDevs.Count);

        }
    }
}