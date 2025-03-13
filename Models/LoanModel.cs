namespace LibraryVirtual.Models;

public class LoanModel
{
  public long Id { get; set; }
  public string Recipient { get; set; } = string.Empty;
  public string Supplier { get; set; } = string.Empty;
  public string BorrowedBook { get; set; } = string.Empty;

  public DateTime LoanDate { get; set; } = DateTime.UtcNow;
}