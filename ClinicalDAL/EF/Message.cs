//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicalDAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int RecieverId { get; set; }
        public System.DateTime Date { get; set; }
        public string Message1 { get; set; }
        public byte Status { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
