using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using monitorapplication.Exceptions;

namespace monitorapplication.Pages
{
    public class CheckoutModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost() 
        {
            throw new PaymentException("Betalning misslyckades! Kontakta Kundtjänst.");
        }
    }
}
