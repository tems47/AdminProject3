//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Admination
{
    using System;
    
    public partial class ProBill_ReadAllBillByCustomer_Result
    {
        public int Id_Bill { get; set; }
        public Nullable<int> Id_Bou { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Nullable<int> Id_Cus { get; set; }
        public Nullable<int> Volume { get; set; }
        public Nullable<System.DateTime> Order_Date { get; set; }
        public Nullable<System.DateTime> Delivery_Date { get; set; }
        public string Cus_Note { get; set; }
        public string Bill_Status { get; set; }
    }
}
