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
    
    public partial class DichVu
    {
        public DichVu()
        {
            this.SuDungDichVus = new HashSet<SuDungDichVu>();
        }
    
        public int maDichVu { get; set; }
        public string tenDichVu { get; set; }
        public Nullable<double> donGia { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual ICollection<SuDungDichVu> SuDungDichVus { get; set; }
    }
}
