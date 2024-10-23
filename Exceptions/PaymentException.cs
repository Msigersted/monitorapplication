namespace monitorapplication.Exceptions
{
    public class PaymentException : Exception
    {
        // Kasta undantag
        public PaymentException() 
        {

        }

        // Kasta undantag med meddelande
        public PaymentException(string message) 
            : base(message)
        {

        }

       // Kasta undantag när man fångar en annan
        public PaymentException(string message, Exception inner) 
            : base(message, inner)
        {

        }
    }
}
