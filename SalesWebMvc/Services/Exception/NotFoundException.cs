using System;
namespace SalesWebMvc.Services.Exception
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(String message) : base(message)
        {

        }
    }
}
