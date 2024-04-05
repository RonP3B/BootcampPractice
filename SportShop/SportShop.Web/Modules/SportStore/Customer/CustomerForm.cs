
namespace SportShop.SportStore.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("SportStore.Customer")]
    [BasedOnRow(typeof(Entities.CustomerRow), CheckNames = true)]
    public class CustomerForm
    {
        public String Name { get; set; }
        [EmailEditor]
        public String Email { get; set; }
        public String Phone { get; set; }
        public String Address { get; set; }
        [DefaultValue(CustomerGender.Male)]
        public CustomerGender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        [TextAreaEditor(Rows = 6)]
        public String Notes { get; set; }
    }
}