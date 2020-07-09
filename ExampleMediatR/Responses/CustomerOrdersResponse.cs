using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleMediatR.Responses
{
    public class CustomerOrdersResponse
    {
        public Guid CustomerId { get; set; }

        public List<OrderResponse> Orders { get; set; }
    }
}
