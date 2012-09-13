namespace Craft.Net.Data.Items
{
    
    public class ChainLeggingsItem : Item
    {
        public override ushort Id
        {
            get
            {
                return 304;
            }
        }

        public override bool IsArmor
        {
            get { return true; }
        }

        public override int ArmorBonus
        {
            get { return 4; }
        }
    }
}
