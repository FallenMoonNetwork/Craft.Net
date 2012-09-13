namespace Craft.Net.Data.Items
{
    
    public class DiamondChestplateItem : Item
    {
        public override ushort Id
        {
            get
            {
                return 311;
            }
        }

        public override bool IsArmor
        {
            get { return true; }
        }

        public override int ArmorBonus
        {
            get { return 8; }
        }
    }
}
