
namespace SportShop.SportStore
{
    using Serenity.ComponentModel;
    using System.ComponentModel;

    [EnumKey("SportStore.CustomerGender")]
    public enum CustomerGender
    {
        [Description("Male")]
        Male = 1,
        [Description("Female")]
        Female = 2,
    }
}
