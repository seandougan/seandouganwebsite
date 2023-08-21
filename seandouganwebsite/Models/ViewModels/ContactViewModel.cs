using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace seandouganwebsite.Models.ViewModels;

public class ContactViewModel
{
    public string? TelegramApiKey { get; set; }

    public ContactViewModel( )
    {
        TelegramApiKey = "6042871782:AAEE9QRCpvjoSSKGcEvKDg1dnN8_QIqbx0o";
    }
}