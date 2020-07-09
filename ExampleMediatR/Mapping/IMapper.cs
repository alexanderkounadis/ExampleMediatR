using ExampleMediatR.Dtos;
using ExampleMediatR.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleMediatR.Mapping
{
    public interface IMapper
    {
        List<CustomerResponse> MapCustomerDtosToCustomerResponses(List<CustomerDto> dtos);

        CustomerResponse MapCustomerDtoToCustomerResponse(CustomerDto customerDto);

        List<OrderResponse> MapOrderDtosToOrderResponses(List<OrderDto> customerOrders);

        OrderResponse MapOrderDtoToOrderResponse(OrderDto order);
    }
}
