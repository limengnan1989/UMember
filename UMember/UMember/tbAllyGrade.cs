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
    
    public partial class tbAllyGrade
    {
        public tbAllyGrade()
        {
            this.tbMemberInfo = new HashSet<tbMemberInfo>();
        }
    
        public int AllyGrade_ID { get; set; }
        public string AllyGrade_Name { get; set; }
        public double Money { get; set; }
        public double PV { get; set; }
        public string Description { get; set; }
        public double Gift_Money { get; set; }
        public double Gift_PV { get; set; }
        public bool Is_Delete { get; set; }
        public bool Is_Hide { get; set; }
        public double MaxZhaoSangJiang { get; set; }
        public double MaxShiCangBuTieFactor { get; set; }
    
        public virtual ICollection<tbMemberInfo> tbMemberInfo { get; set; }
    }
}
