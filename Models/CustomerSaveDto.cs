namespace CustomerManagement.Web.Models;

// Body sent to the API on create and update.
// The API ignores IsActive on create and uses it on update — one DTO covers both.
public class CustomerSaveDto
{
    public string CustomerName { get; set; } = string.Empty;
    public string? Address { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string CustomerType { get; set; } = "Personal";
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public bool IsActive { get; set; } = true;
}