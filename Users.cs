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
    
    public partial class Users
    {
        public int ID_users { get; set; }
        public string Lastname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Post { get; set; }
        public string Login { get; set; }
        public string Pasword { get; set; }

        public string Allname
        {
            get
            {
                string _Allname = Lastname + " " + Name + " " + Patronymic;
                return _Allname;
            }
        }

        public virtual Post Post1 { get; set; }
    }
}