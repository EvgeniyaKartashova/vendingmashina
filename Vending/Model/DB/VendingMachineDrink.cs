//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vending.Model.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class VendingMachineDrink
    {
        public int Id { get; set; }
        public int IdMachine { get; set; }
        public int IdDrink { get; set; }
        public int Count { get; set; }
    
        public virtual Drink Drink { get; set; }
        public virtual VendingMachine VendingMachine { get; set; }
    }
}
