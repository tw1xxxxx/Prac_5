//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Custumers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Custumers()
        {
            this.Sales = new HashSet<Sales>();
        }
    
        public int EmployeeID { get; set; }
        public string Имя { get; set; }
        public string Фамилия { get; set; }
        public string Логин { get; set; }
        public string Пароль { get; set; }
        public Nullable<int> Role_ID { get; set; }
        public Nullable<int> Post_ID { get; set; }
        public Nullable<decimal> Зарплата { get; set; }
    
        public virtual Posts Posts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
