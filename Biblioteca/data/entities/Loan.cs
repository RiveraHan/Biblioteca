using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.data.entities
{
    class Loan
    {
        public Guid loanId { get; set; }
        public DateTime date { get; set; }
        public DateTime expirationDate { get; set; }
        public string visitor { get; set; }
        public string concept { get; set; }
        public List<BorrowedBook> borrowedBooks { get; set; }
    }

    class LoanConfig : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.ToTable("tblLoans");
            builder.HasKey(loan => loan.loanId);
        }
    }
}
