using NUnit.Framework;
using Roleplay;

namespace Test.Library
{
    public class ExampleTest
    {
        [Test]
        public void ValidNameWizzard()
        {
            string expectedName = "Harry";
            Wizard Harry = new Wizard("Harry");
            Assert.AreEqual(expectedName, Harry.Name);
        }

        [Test]
        public void ValidNameElf()
        {
            string expectedName = "Juan";
            Elf Juan = new Elf("Juan");
            Assert.AreEqual(expectedName, Juan.Name);
        }

        [Test]
        public void ValidNameDwarf()
        {
            string expectedName = "Pedro";
            Dwarf Pedro = new Dwarf("Pedro");
            Assert.AreEqual(expectedName, Pedro.Name);
        }

        [Test]
        public void AttackDwarf()
        {
            double expectedHealPoints = 15;
            Dwarf Pedro = new Dwarf("Pedro");
            Elf Juan = new Elf("Juan");
            Pedro.Attack(Juan);
            Assert.AreEqual(expectedHealPoints, Juan.HealthPoints);
        }

        [Test]
        public void AttackElf()
        {
            double expectedHealPoints = 20;
            Dwarf Pedro = new Dwarf("Pedro");
            Elf Juan = new Elf("Juan");
            Juan.Attack(Pedro);
            Assert.AreEqual(expectedHealPoints, Pedro.HealthPoints);
        }

        [Test]
        public void AttackWizard()
        {
            double expectedHealPoints = 15;
            Wizard Harry = new Wizard("Harry");
            Elf Juan = new Elf("Juan");
            Harry.Attack(Juan);
            Assert.AreEqual(expectedHealPoints, Juan.HealthPoints);
        }

        [Test]
        public void EquipItemWizard()
        {
            int expectedDamage = 5;
            Wizard Harry = new Wizard("Harry");
            Weapon Sword = new Weapon("Sword", 4);
            Harry.AddItem(Sword);
            Assert.AreEqual(expectedDamage, Harry.Damage);
        }
    }
}