//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoaiPhong
    {
        public LoaiPhong()
        {
            this.DonGias = new HashSet<DonGia>();
            this.Phongs = new HashSet<Phong>();
        }
    
        public int maLoaiPhong { get; set; }
        public string tenLoaiPhong { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual ICollection<DonGia> DonGias { get; set; }
        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
