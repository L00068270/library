﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace library.test
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AzureLibraryEntities : DbContext
    {
        public AzureLibraryEntities()
            : base("name=AzureLibraryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookNumber> BookNumbers { get; set; }
        public virtual DbSet<ConferenceProceeding> ConferenceProceedings { get; set; }
        public virtual DbSet<DVD> DVDs { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<LibraryMember> LibraryMembers { get; set; }
        public virtual DbSet<MemberHistory> MemberHistories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<ReferenceBook> ReferenceBooks { get; set; }
    }
}
