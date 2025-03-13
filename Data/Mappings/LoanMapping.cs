using LibraryVirtual.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryVirtual.Data.Mappings;

public class LoanMapping : IEntityTypeConfiguration<LoanModel>
{
  public void Configure(EntityTypeBuilder<LoanModel> builder)
  {
    builder.ToTable("Loans");

    builder.HasKey(x => x.Id);

    builder.Property(x => x.Id)
      .ValueGeneratedOnAdd()
      .UseIdentityColumn();

    builder.Property(x => x.Recipient)
      .HasColumnType("NVARCHAR")
      .HasMaxLength(120)
      .IsRequired();

    builder.Property(x => x.Supplier)
      .HasColumnType("NVARCHAR")
      .HasMaxLength(120)
      .IsRequired();

    builder.Property(x => x.BorrowedBook)
      .HasColumnType("NVARCHAR")
      .HasMaxLength(255);

    builder.Property(x => x.LoanDate);
  }
}