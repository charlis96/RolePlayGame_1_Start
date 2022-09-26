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
            string ExpectedName = "Pedro";
            Assert.AreEqual(ExpectedName, Pedro.Name);
        }

        [Test]
        public void ElfValidNameTest()
        {
            Elf Juan = new Elf("Juan");
            string ExpectedName = "Juan";
            Assert.AreEqual(ExpectedName, Juan.Name);
        }

        [Test]
        public void WizardValidNameTest()
        {
            Wizard Harry = new Wizard("Harry");
            string ExpectedName = "Harry";
            Assert.AreEqual(ExpectedName, Harry.Name);
        }

        [Test]
        public void DwarfAttackTest()
        {
            Dwarf Pedro = new Dwarf("Pedro");
            Elf Juan = new Elf("Juan");
            Pedro.Attack(Juan);
            int ExpectedHealthPoints = 14;
            Assert.AreEqual(ExpectedHealthPoints, Juan.HealthPoints);
        }

        [Test]
        public void ElfAttackTest()
        {
            Elf Juan = new Elf("Juan");
            Dwarf Pedro = new Dwarf("Pedro");
            Juan.Attack(Pedro);
            int ExpectedHealthPoints = 18;
            Assert.AreEqual(ExpectedHealthPoints, Pedro.HealthPoints);
        }

        [Test]
        public void WizardAttackTest()
        {
            Wizard Harry = new Wizard("Harry");
            Elf Juan = new Elf("Juan");
            Harry.Attack(Juan);
            int ExpectedHealthPoints = 15;
            Assert.AreEqual(ExpectedHealthPoints, Juan.HealthPoints);
        }

        [Test]
        public void DwarfEquipItemTest()
        {
            Dwarf Pedro = new Dwarf("Pedro");
            Weapon Sword = new Weapon("Sword", 4);
            Pedro.AddItem(Sword);
            int ExpectedDamage = 6;
            Assert.AreEqual(ExpectedDamage, Pedro.Damage);
        }

        [Test]
        public void ElfEquipItemTest()
        {
            Elf Juan = new Elf("Juan");
            Weapon Sword = new Weapon("Sword", 4);
            Juan.AddItem(Sword);
            int ExpectedDamage = 7;
            Assert.AreEqual(ExpectedDamage, Juan.Damage);
        }

        [Test]
        public void WizardEquipItemTest()
        {
            Wizard Harry = new Wizard("Harry");
            Weapon Sword = new Weapon("Sword", 4);
            Harry.AddItem(Sword);
            int ExpectedDamage = 5;
            Assert.AreEqual(ExpectedDamage, Harry.Damage);
        }

        [Test]
        public void WizardEquipMaxItemTest()
        {
            Wizard Harry = new Wizard("Harry");
            Weapon Sword = new Weapon("Sword", 4);
            Armor GoldenChestplate = new Armor("Chestplate", 3);
            Miscellaneous PowerGloves = new Miscellaneous("Power Gloves", 1, 2, 3);
            Weapon Bow = new Weapon("Bow", 5);
            Harry.AddItem(Sword);
            Harry.AddItem(GoldenChestplate);
            Harry.AddItem(PowerGloves);
            Harry.AddItem(Bow);
            int ExpectedItemQuantity = 3;
            Assert.AreEqual(ExpectedItemQuantity, Harry.CharacterInventory.ItemQuantity);
        }

        [Test]
        public void ElfEquipMaxItemTest()
        {
            Elf Juan = new Elf("Juan");
            Weapon Sword = new Weapon("Sword", 4);
            Armor GoldenChestplate = new Armor("Chestplate", 3);
            Miscellaneous PowerGloves = new Miscellaneous("Power Gloves", 1, 2, 3);
            Weapon Bow = new Weapon("Bow", 5);
            Juan.AddItem(Sword);
            Juan.AddItem(GoldenChestplate);
            Juan.AddItem(PowerGloves);
            Juan.AddItem(Bow);
            int ExpectedItemQuantity = 3;
            Assert.AreEqual(ExpectedItemQuantity, Juan.CharacterInventory.ItemQuantity);
        }

        [Test]
        public void DwarfEquipMaxItemTest()
        {
            Dwarf Pedro = new Dwarf("Pedro");
            Weapon Sword = new Weapon("Sword", 4);
            Armor GoldenChestplate = new Armor("Chestplate", 3);
            Miscellaneous PowerGloves = new Miscellaneous("Power Gloves", 1, 2, 3);
            Weapon Bow = new Weapon("Bow", 5);
            Pedro.AddItem(Sword);
            Pedro.AddItem(GoldenChestplate);
            Pedro.AddItem(PowerGloves);
            Pedro.AddItem(Bow);
            int ExpectedItemQuantity = 3;
            Assert.AreEqual(ExpectedItemQuantity, Pedro.CharacterInventory.ItemQuantity);
        }

        [Test]
        public void WizardRemoveItemTest()
        {
            Wizard Harry = new Wizard("Harry");
            Weapon Sword = new Weapon("Sword", 4);
            Armor GoldenChestplate = new Armor("Chestplate", 3);
            Miscellaneous PowerGloves = new Miscellaneous("Power Gloves", 1, 2, 3);
            Weapon Bow = new Weapon("Bow", 5);
            Harry.AddItem(Sword);
            Harry.AddItem(GoldenChestplate);
            Harry.AddItem(PowerGloves);
            Harry.AddItem(Bow);
            Harry.RemoveItem(Bow);
            int ExpectedItemQuantity = 2;
            Assert.AreEqual(ExpectedItemQuantity, Harry.CharacterInventory.ItemQuantity);
        }

        [Test]
        public void ElfRemoveItemTest()
        {
            Elf Juan = new Elf("Juan");
            Weapon Sword = new Weapon("Sword", 4);
            Armor GoldenChestplate = new Armor("Chestplate", 3);
            Miscellaneous PowerGloves = new Miscellaneous("Power Gloves", 1, 2, 3);
            Weapon Bow = new Weapon("Bow", 5);
            Juan.AddItem(Sword);
            Juan.AddItem(GoldenChestplate);
            Juan.AddItem(PowerGloves);
            Juan.AddItem(Bow);
            Juan.RemoveItem(Bow);
            int ExpectedItemQuantity = 2;
            Assert.AreEqual(ExpectedItemQuantity, Juan.CharacterInventory.ItemQuantity);
        }

        [Test]
        public void DwarfRemoveItemTest()
        {
            Dwarf Pedro = new Dwarf("Pedro");
            Weapon Sword = new Weapon("Sword", 4);
            Armor GoldenChestplate = new Armor("Chestplate", 3);
            Miscellaneous PowerGloves = new Miscellaneous("Power Gloves", 1, 2, 3);
            Weapon Bow = new Weapon("Bow", 5);
            Pedro.AddItem(Sword);
            Pedro.AddItem(GoldenChestplate);
            Pedro.AddItem(PowerGloves);
            Pedro.AddItem(Bow);
            Pedro.RemoveItem(Bow);
            int ExpectedItemQuantity = 2;
            Assert.AreEqual(ExpectedItemQuantity, Pedro.CharacterInventory.ItemQuantity);
        }

        [Test]
        public void WizardEquipSpellBookTest()
        {
            Wizard Harry = new Wizard("Harry");
            bool ExpectedHasSpellBook = true;
            Harry.AddSpellBook();
            Assert.AreEqual(ExpectedHasSpellBook, Harry.HasSpellBook);
        }

        [Test]
        public void WizardCannotEquipSpellBookTest()
        {
            Wizard Harry = new Wizard("Harry");
            bool ExpectedHasSpellBook = true;
            Harry.AddSpellBook();
            Assert.AreEqual(ExpectedHasSpellBook, Harry.HasSpellBook);
        }

        [Test]
        public void WizardAddSpellTest()
        {
            Wizard Harry = new Wizard("Harry");
            Harry.AddSpellBook();
            Spell spell = new Spell("Bola de fuego", 3, 0, 0, 2);
            Harry.AddSpell(spell);
            int ExpectedDamage = 4;
            Assert.AreEqual(ExpectedDamage, Harry.Damage);
        }
        
        [Test]
        public void WizardHealTest()
        {
            Wizard Harry = new Wizard("Harry");
            Dwarf Pedro = new Dwarf("Pedro");
            Pedro.Attack(Harry);
            Harry.Heal(Harry);
            int ExpectedHealthPoints = 12;
            int ExpectedHealingPotions = 2;
            Assert.AreEqual(ExpectedHealthPoints, Harry.HealthPoints);
            Assert.AreEqual(ExpectedHealingPotions, Harry.HealingPotions);
        }

        [Test]
        public void ElfHealTest()
        {
            Elf Juan = new Elf("Juan");
            Dwarf Pedro = new Dwarf("Pedro");
            Pedro.Attack(Juan);
            Juan.Heal(Juan);
            int ExpectedHealthPoints = 15;
            int ExpectedHealingPotions = 2;
            Assert.AreEqual(ExpectedHealthPoints, Juan.HealthPoints);
            Assert.AreEqual(ExpectedHealingPotions, Juan.HealingPotions);
        }

        [Test]
        public void DwarfHealTest()
        {
            Dwarf Pedro = new Dwarf("Pedro");
            Elf Juan = new Elf("Juan");
            Juan.Attack(Pedro);
            Pedro.Heal(Pedro);
            int ExpectedHealthPoints = 20;
            int ExpectedHealingPotions = 2;
            Assert.AreEqual(ExpectedHealthPoints, Pedro.HealthPoints);
            Assert.AreEqual(ExpectedHealingPotions, Pedro.HealingPotions);
        }

        [Test]
        public void WizardSheareHealthPotionTest()
        {
            Wizard Harry = new Wizard("Harry");
            Dwarf Pedro = new Dwarf("Pedro");
            Elf Juan = new Elf("Juan");
            Pedro.Attack(Harry);
            Juan.Heal(Harry);
            int ExpectedHealthPoints = 12;
            int ExpectedHealingPotions = 2;
            Assert.AreEqual(ExpectedHealthPoints, Harry.HealthPoints);
            Assert.AreEqual(ExpectedHealingPotions, Juan.HealingPotions);
        }

        [Test]
        public void ElfSheareHealthPotionTest()
        {
            Elf Juan = new Elf("Juan");
            Dwarf Pedro = new Dwarf("Pedro");
            Wizard Harry = new Wizard("Harry");
            Pedro.Attack(Juan);
            Harry.Heal(Juan);
            int ExpectedHealthPoints = 15;
            int ExpectedHealingPotions = 2;
            Assert.AreEqual(ExpectedHealthPoints, Juan.HealthPoints);
            Assert.AreEqual(ExpectedHealingPotions, Harry.HealingPotions);
        }

        [Test]
        public void DwarfSheareHealthPotionTest()
        {
            Dwarf Pedro = new Dwarf("Pedro");
            Elf Juan = new Elf("Juan");
            Wizard Harry = new Wizard("Harry");
            Juan.Attack(Pedro);
            Harry.Heal(Pedro);
            int ExpectedHealthPoints = 20;
            int ExpectedHealingPotions = 2;
            Assert.AreEqual(ExpectedHealthPoints, Pedro.HealthPoints);
            Assert.AreEqual(ExpectedHealingPotions, Harry.HealingPotions);
        }

        [Test]
        public void WizardSpecialAbilityTest()
        {
            Wizard Harry = new Wizard("Harry");
            Dwarf Pedro = new Dwarf("Pedro");
            Harry.SpecialAbility(Pedro);
            int ExpectedDefense = 2;
            Assert.AreEqual(ExpectedDefense, Pedro.Defense);
        }

        [Test]
        public void ElfSpecialAbilityTest()
        {
            Elf Juan = new Elf("Juan");
            Dwarf Pedro = new Dwarf("Pedro");
            Juan.SpecialAbility(Pedro);
            int ExpectedTotalHealthPoints = 21;
            Assert.AreEqual(ExpectedTotalHealthPoints, Pedro.TotalHealthPoints);
        }

        [Test]
        public void DwarfSpecialAbilityTest()
        {
            Dwarf Pedro = new Dwarf("Pedro");
            Elf Juan = new Elf("Juan");
            Pedro.SpecialAbility(Juan);
            int ExpectedHealthPoints = 13;
            Assert.AreEqual(ExpectedHealthPoints, Juan.HealthPoints);
        }
    }
}