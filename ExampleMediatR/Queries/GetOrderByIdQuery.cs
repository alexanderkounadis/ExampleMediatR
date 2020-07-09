using ExampleMediatR.Responses;
using MediatR;
using System;

namespace ExampleMediatR.Queries
{
    public class GetOrderByIdQuery: IRequest<OrderResponse>
    {
        public GetOrderByIdQuery(Guid orderId)
        {
            OrderId = orderId;
        }

        public Guid OrderId { get; }
    }
}
