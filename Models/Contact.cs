//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhoneBookApp1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Contact
    {
        [DisplayName("Contact Id")]
        public int ContactId { get; set; }
        [DisplayName("Contact Number")]
        public string ContactNumber { get; set; }
        [DisplayName("Contact Type")]
        public string Type { get; set; }
        public int PersonId { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
