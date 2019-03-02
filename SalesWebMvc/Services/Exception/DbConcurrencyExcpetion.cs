using System;

namespace SalesWebMvc.Services.Exception
{
    public class DbConcurrencyExcpetion : ApplicationException
    {
        public DbConcurrencyExcpetion(String message) : base(message) 
        {
        }
    }
}
