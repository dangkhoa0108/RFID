//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATN
{
    using System;
    using System.Collections.Generic;
    
    public partial class RFIDManage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RFIDManage()
        {
            this.RFID_User = new HashSet<RFID_User>();
        }
    
        public string RFID { get; set; }
        public string RFID_Name { get; set; }
        public string RFID_Address { get; set; }
        public Nullable<double> RFID_Money { get; set; }
        public string RFID_CarID { get; set; }
        public Nullable<int> RFID_LoaiXe { get; set; }
    
        public virtual LoaiXe LoaiXe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RFID_User> RFID_User { get; set; }
    }
}
