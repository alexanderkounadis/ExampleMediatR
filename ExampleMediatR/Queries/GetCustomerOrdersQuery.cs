using ExampleMediatR.Responses;
using MediatR;
using System;

namespace ExampleMediatR.Queries
{
    public class GetCustomerOrdersQuery: IRequest<CustomerOrdersResponse>
    {
        public GetCustomerOrdersQuery(Guid customerId)
        {
            CustomerId = customerId;
        }

        public Guid CustomerId { get; }
    }
}
