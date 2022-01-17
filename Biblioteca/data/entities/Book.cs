using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;   
using System.Text;

namespace Biblioteca.data.entities
{
    class Book
    {
        public Guid bookId { get; set; }
        public string name { get; set; }
        public string autor { get; set; }
        public string description { get; set; }        public string editorial { get; set; }        public List<BorrowedBook> borrowedBooks { get; set; }    }

    class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("tblBooks");
            builder.HasKey(book => book.bookId);
        }
    }
}
