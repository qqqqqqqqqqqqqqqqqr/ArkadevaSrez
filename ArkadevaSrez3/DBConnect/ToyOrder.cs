//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArkadevaSrez3.DBConnect
{
    using System;
    using System.Collections.Generic;
    
    public partial class ToyOrder
    {
        public int Id { get; set; }
        public int ToyId { get; set; }
        public Nullable<int> Count { get; set; }
        public int OrderId { get; set; }
    
        public virtual Orderr Orderr { get; set; }
        public virtual Toy Toy { get; set; }
    }
}
