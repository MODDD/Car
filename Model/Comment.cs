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
    
    public partial class Comment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comment()
        {
            this.Reply = new HashSet<Reply>();
        }
    
        public int comment_id { get; set; }
        public int goods_id { get; set; }
        public string comment_content { get; set; }
        public System.DateTime comment_time { get; set; }
        public int comment_flag { get; set; }
        public int user_id { get; set; }
    
        public virtual Goods Goods { get; set; }
        public virtual UserInfo UserInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reply> Reply { get; set; }
    }
}
