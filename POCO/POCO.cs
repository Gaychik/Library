using System;
using LinqToDB;
using LinqToDB.Mapping;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;

namespace NewLibrary.POCO
{
    public partial class LibraryDB : LinqToDB.Data.DataConnection
    {
        public ITable<Book> Books { get { return this.GetTable<Book>(); } }
       
        public ITable<History> History { get { return this.GetTable<History>(); } }
        public ITable<Person> Persons { get { return this.GetTable<Person>(); } }

       
        public LibraryDB()
            : base("Library") { }

      
        
        

    }

    [Table(Schema = "dbo", Name = "Books")]
    public partial class Book
    {
        [Column(), PrimaryKey, NotNull] public Guid BookId { get; set; } // uniqueidentifier
        [Column("Book"), Nullable] public string Name_Book { get; set; } // nvarchar(50)
        [Column(), Nullable] public string Author { get; set; } // nvarchar(50)
        [Column("Count_copies"), Nullable] public int? CountCopies { get; set; } // int
        [Column("Date_Register"), Nullable] public DateTime? Date_Register { get; set; } // datetime
    }

    

    [Table(Schema = "dbo", Name = "History")]
    public partial class History
    {
        [Column(), PrimaryKey, NotNull] public Guid Id { get; set; } 
        [Column(), NotNull] public Guid PersonId { get; set; } 
        [Column(), Nullable] public string Person { get; set; }
        [Column("BookId"), PrimaryKey, NotNull] public Guid BookId{ get; set; }
        [Column(), Nullable] public string Book { get; set; } 
        [Column("Date of issue"), Nullable] public DateTime? DateOfIssue { get; set; } 
        [Column(), Nullable] public DateTime? DeadLine { get; set; } 
    }

    [Table(Schema = "dbo", Name = "Persons")]
    public partial class Person
    {
        [Column("Person_id"), PrimaryKey, NotNull] public Guid NameId { get; set; }
       
        [Column("Person"), Nullable] public string  Name { get; set; }
        [Column("Count_Books"), Nullable] public int? CountBooks { get; set; } 
       
 
        [Column(), Nullable] public int? Age { get; set; } 
        [Column("Home_address"), Nullable] public string HomeAddress { get; set; } 
        [Column("Telephone_Number"), Nullable] public string TelephoneNumber { get; set; }

        
    }
}
