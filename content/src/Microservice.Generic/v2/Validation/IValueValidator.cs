using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Generic.v2.Validation
{
    public interface IValueValidator
    {
        bool IsPositive(int value);
    }
}
