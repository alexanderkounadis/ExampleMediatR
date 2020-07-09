using ExampleMediatR.Responses;
using MediatR;
using System;

namespace ExampleMediatR.Queries
{
    public class GetCustomerByIdQuery: IRequest<CustomerResponse>
    {
        public GetCustomerByIdQuery(Guid customerId)
        {
            CustomerId = customerId;
        }

        public Guid CustomerId { get; }
    }
}
