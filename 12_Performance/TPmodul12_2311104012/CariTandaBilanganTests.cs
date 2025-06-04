using Microsoft.VisualStudio.TestTools.UnitTesting;
using tpmodul12_2311104012;

namespace tpmodul12_2311104012.Tests
{
    [TestClass]
    public class CariTandaBilanganTests
    {
        [TestMethod]
        public void TestNegatif()
        {
            var form = new Form1();
            Assert.AreEqual("Negatif", form.CariTandaBilangan(-5));
        }

        [TestMethod]
        public void TestPositif()
        {
            var form = new Form1();
            Assert.AreEqual("Positif", form.CariTandaBilangan(7));
        }

        [TestMethod]
        public void TestNol()
        {
            var form = new Form1();
            Assert.AreEqual("Nol", form.CariTandaBilangan(0));
        }
    }
}
