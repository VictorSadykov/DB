using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Contracts.Exceptions
{
    public class EntityNotFoundException : NullReferenceException
    {

        public EntityNotFoundException(string message) : base(message)
        {
        }
    }
}
