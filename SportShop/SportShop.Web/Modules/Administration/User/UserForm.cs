namespace SportShop.Administration.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("Administration.User")]
    [BasedOnRow(typeof(Entities.UserRow), CheckNames = true)]
    public class UserForm
    {
        public String Username { get; set; }
        public String DisplayName { get; set; }
        [EmailEditor]
        public String Email { get; set; }
        public String UserImage { get; set; }
        [PasswordEditor, Required(true)]
        public String Password { get; set; }
        [PasswordEditor, OneWay, Required(true)]
        public String PasswordConfirm { get; set; }
        [LookupEditor("SportStore.Customer", InplaceAdd = true)]
        public Int32 CustomerId { get; set; }
        [OneWay]
        public string Source { get; set; }
    }
}