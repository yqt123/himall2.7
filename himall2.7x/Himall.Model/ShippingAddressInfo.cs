//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Himall.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShippingAddressInfo:BaseModel
    {
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public long UserId { get; set; }
        public int RegionId { get; set; }
        public string ShipTo { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsDefault { get; set; }
        public bool IsQuick { get; set; }
        public Nullable<float> Longitude { get; set; }
        public Nullable<float> Latitude { get; set; }
    
        public virtual UserMemberInfo MemberInfo { get; set; }
    }
}
