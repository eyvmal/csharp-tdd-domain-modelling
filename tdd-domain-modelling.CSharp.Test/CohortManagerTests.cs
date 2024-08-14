using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {
        [TestCase("Apekatter", 1)]
        [TestCase("hval", 3)]
        [TestCase("rumpetroll", 0)]
        public void FirstTest(string a, int b)
        {
            List<string> list = new List<string>();
            list.Add("Apekatter");
            list.Add("Nesehorn");
            list.Add("Narrhval");
            list.Add("Maursluker");
            list.Add("Øyenstikker");
            list.Add("Hvalross");
            list.Add("Blåhval");

            CohortManager core = new CohortManager();

            int count = core.Count(list, a);
            Assert.That(count, Is.EqualTo(b));
        }
    }
}