using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SportShop.SportStore
{
    public partial class OrderDetailEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SportShop.SportStore.OrderDetailEditor";

        public OrderDetailEditorAttribute()
            : base(Key)
        {
        }
    }
}

