//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace UMember
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbMemberAccountChangeRecord
    {
        public int Record_ID { get; set; }
        public int Member_ID { get; set; }
        public double Money { get; set; }
        public int Account_type { get; set; }
        public string Description { get; set; }
        public int Operator_ID { get; set; }
        public int Operator_Type { get; set; }
        public System.DateTime Operator_Time { get; set; }
    
        public virtual tbMemberInfo tbMemberInfo { get; set; }
    }
}
