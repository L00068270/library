//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD_Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookNumber
    {
        public int BookID { get; set; }
        public int ShelfNumber { get; set; }
        public string Condition { get; set; }
        public int PublisherID { get; set; }
    
        public virtual Publisher Publisher { get; set; }
    }
}
