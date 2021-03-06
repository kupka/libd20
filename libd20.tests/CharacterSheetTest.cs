using System;
using Xunit;

namespace d20 {
    public class CharacterSheetTest {
        [Fact]        
        public void EquipOneHandTest() {
            Thing<Weapon> club = new Thing<Weapon>(Weapons.Club);
            CharacterSheet sheet = new CharacterSheet();
            sheet.Equip(club);
            Assert.Equal(sheet.Inventory.MainHand, club);
        }

        [Fact]
        public void EquipTwoHandTest() {
            Thing<Weapon> greatAxe = new Thing<Weapon>(Weapons.GreatAxe);
            Thing<Weapon> club = new Thing<Weapon>(Weapons.Club);
            CharacterSheet sheet = new CharacterSheet();
            sheet.Equip(club);
            sheet.Equip(greatAxe);
            Assert.Equal(sheet.Inventory.MainHand, greatAxe);
            Assert.Null(sheet.Inventory.OffHand);
        }

        [Fact]
        public void EquipArmorTest() {
            Thing<Armor> chainShirt = new Thing<Armor>(Armors.ChainShirt);
            CharacterSheet sheet = new CharacterSheet();
            sheet.Dexterity.Value = 18;
            Assert.Equal(14, sheet.ArmorClass);
            sheet.Equip(chainShirt);
            Assert.Equal(15, sheet.ArmorClass);
        }

        [Fact]
        public void EquipFullTest() {
            Thing<Weapon> club = new Thing<Weapon>(Weapons.Club);
            
        }
    }
}