using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.data.entities
{
    class BorrowedBook
    {
        public Guid borrowedBookId { get; set; }
        public Guid bookId { get; set; }
        public Guid loanId { get; set; }
        public Book book { get; set; }
        public Loan loan { get; set; }
    }

    class BorrowedBookConfig : IEntityTypeConfiguration<BorrowedBook>
    {
        public void Configure(EntityTypeBuilder<BorrowedBook> builder)
        {
            builder.ToTable("tblBorrowedBooks");
            builder.HasKey(borrowedBook => borrowedBook.borrowedBookId);
        }
    }
}
