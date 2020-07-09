using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleMediatR.Responses
{
    public class CustomerResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
