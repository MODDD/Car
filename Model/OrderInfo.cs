//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderInfo()
        {
            this.Order_Goods = new HashSet<Order_Goods>();
        }
    
        public string order_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<decimal> order_totalMoney { get; set; }
        public Nullable<System.DateTime> order_time { get; set; }
        public string order_express_id { get; set; }
        public Nullable<int> order_flag { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Goods> Order_Goods { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
