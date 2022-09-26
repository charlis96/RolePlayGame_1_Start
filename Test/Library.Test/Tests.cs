using NUnit.Framework;
using Roleplay;

namespace Test.Library
{
    public class Tests
    {
        [Test]
        public void DwarfValidNameTest()
        {
            Dwarf Pedro = new Dwarf("Pedro");
            string expectedName = "Pedro";
            Assert.AreEqual(expectedName, Pedro.Name);
        }

        [Test]
        public void ElfValidNameTest()
        {
            Elf Juan = new Elf("Juan");
            string expectedName = "Juan";
            Assert.AreEqual(expectedName, Juan.Name);
        }

        [Test]
        public void WizardValidNameTest()
        {
            Wizard Harry = new Wizard("Harry");
            string expectedName = "Harry";
            Assert.AreEqual(expectedName, Harry.Name);
        }

        [Test]
        public void DwarfAttackTest()
        {
            Dwarf Pedro = new Dwarf("Pedro");
            Elf Juan = new Elf("Juan");
            int expectedHealthPoints = 14;
            Pedro.Attack(Juan);
            Assert.AreEqual(expectedHealthPoints, Juan.HealthPoints);
        }

        [Test]
        public void ElfAttackTest()
        {
            Elf Juan = new Elf("Juan");
            Dwarf Pedro = new Dwarf("Pedro");
            int expectedHealthPoints = 18;
            Juan.Attack(Pedro);
            Assert.AreEqual(expectedHealthPoints, Pedro.HealthPoints);
        }

        [Test]
        public void WizardAttackTest()
        {
            Wizard Harry = new Wizard("Harry");
            Elf Juan = new Elf("Juan");
            int expectedHealthPoints = 15;
            Harry.Attack(Juan);
            Assert.AreEqual(expectedHealthPoints, Juan.HealthPoints);
        }

        [Test]
        public void WizardEquipItemTest()
        {
            Wizard Harry = new Wizard("Harry");
            Weapon Sword = new Weapon("Sword", 4);
            int expectedDamage = 5;
            Harry.AddItem(Sword);
            Assert.AreEqual(expectedDamage, Harry.Damage);
        }
    }
}