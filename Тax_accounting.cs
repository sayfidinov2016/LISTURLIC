//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LISTURLIC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Тax_accounting
    {
        public int ID_accounting { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }
        public System.DateTime Date { get; set; }
        public string Name_authority { get; set; }
    
        public virtual Organizations Organizations { get; set; }
    }
}
