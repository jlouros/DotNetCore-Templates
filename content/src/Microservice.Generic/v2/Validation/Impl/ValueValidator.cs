using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Generic.v2.Validation.Impl
{
    public class ValueValidator : IValueValidator
    {
        public bool IsPositive(int value)
        {
            return value >= 0;
        }
    }
}
