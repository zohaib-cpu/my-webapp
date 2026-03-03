using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

public class IndexModel : PageModel
{
    public string CurrentTime { get; set; }

    public void OnGet()
    {
        CurrentTime = DateTime.Now.ToString("dd MMM yyyy HH:mm");
    }
}