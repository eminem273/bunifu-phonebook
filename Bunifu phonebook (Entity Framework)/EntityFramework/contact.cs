//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bunifu_phonebook__Entity_Framework_.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class contact
    {
        public int ContactID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public bool isFriend { get; set; }
        public bool isFamily { get; set; }
        public bool isCoWorker { get; set; }
        public bool isBusiness { get; set; }
    }
}