namespace Workshop_AspNet_Core_MVC.Models.ViewModels;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}