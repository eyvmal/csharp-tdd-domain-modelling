using NUnit.Framework;
using System.Collections;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {
        [TestCase("Apekatter", 1)]
        [TestCase("hval", 3)]
        [TestCase("rumpetroll", 0)]
        public void TestCohort(string a, int b)
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

        [Test]
        public void TestCheckoutA()
        {
            List<Item> list = new List<Item>();
            list.Add(new Item("Brus", 29.90f, 3));
            list.Add(new Item("Banan", 7.50f, 6));
            list.Add(new Item("Tunfisk", 49.90f, 1));
            list.Add(new Item("Sirkelsag", 2999.90f, 1));

            ShoppingCenter sc = new Main.ShoppingCenter();
            float o = sc.Checkout(list);

            Assert.That(o, Is.EqualTo(3184.5f));
        }

        [Test]
        public void TestCheckoutB()
        {
            List<Item> list = new List<Item>();
            list.Add(new Item("Boller", 10f, 1));
            list.Add(new Item("Pantelapp", -13.50f, 1));

            ShoppingCenter sc = new Main.ShoppingCenter();
            float o = sc.Checkout(list);

            Assert.That(o, Is.EqualTo(-3.50f));
        }

        [Test]
        public void TestCheckoutC()
        {
            List<Item> list = new List<Item>();
            list.Add(new Item("Brus", 29.90f, 3));
            list.Add(new Item("Banan", 7.50f, 6));
            list.Add(new Item("Tunfisk", 49.90f, 1));
            list.Add(new Item("Sirkelsag", 2999.90f, 1));

            ShoppingCenter sc = new Main.ShoppingCenter();
            float o = sc.Checkout(list);

            Assert.That(o, Is.EqualTo(3184.5f));
        }

        [Test]
        public void TestReceiptA()
        {
            List<Item> list = new List<Item>();
            list.Add(new Item("Brus", 29.90f, 3));
            list.Add(new Item("Banan", 7.50f, 6));
            list.Add(new Item("Tunfisk", 49.90f, 1));
            list.Add(new Item("Sirkelsag", 2999.90f, 1));

            ShoppingCenter sc = new Main.ShoppingCenter();
            List<string> o = sc.Receipt(list);

            List<string> result = new List<string>();
            result.Add(("3x Brus - 89,7kr"));
            result.Add(("6x Banan - 45kr"));
            result.Add(("1x Tunfisk - 49,9kr"));
            result.Add(("1x Sirkelsag - 2999,9kr"));

            Assert.That(o, Is.EqualTo(result));
        }

        [Test]
        public void TestReceiptB()
        {
            List<Item> list = new List<Item>();
            list.Add(new Item("Boller", 10f, 1));
            list.Add(new Item("Pantelapp", -13.50f, 1));

            ShoppingCenter sc = new Main.ShoppingCenter();
            List<string> o = sc.Receipt(list);

            List<string> result = new List<string>();
            result.Add(("1x Boller - 10kr"));
            result.Add(("1x Pantelapp - -13,5kr"));

            Assert.That(o, Is.EqualTo(result));
        }

        [Test]
        public void TestReceiptC()
        {
            List<Item> list = new List<Item>();
            list.Add(new Item("Albino Nesehorn", 750000f, 1));
            list.Add(new Item("Nesehornmat", 0, 5));
            list.Add(new Item("Leketøy", 49.99f, 1));

            ShoppingCenter sc = new Main.ShoppingCenter();
            List<string> o = sc.Receipt(list);

            List<string> result = new List<string>();
            result.Add(("1x Albino Nesehorn - 750000kr"));
            result.Add(("5x Nesehornmat - 0kr"));
            result.Add(("1x Leketøy - 49,99kr"));

            Assert.That(o, Is.EqualTo(result));
        }
    }
}