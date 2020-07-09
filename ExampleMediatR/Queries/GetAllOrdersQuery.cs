using ExampleMediatR.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleMediatR.Queries
{
    public class GetAllOrdersQuery: IRequest<List<OrderResponse>> { }
}
