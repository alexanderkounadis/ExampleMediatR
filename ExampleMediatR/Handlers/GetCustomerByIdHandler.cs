using ExampleMediatR.Mapping;
using ExampleMediatR.Queries;
using ExampleMediatR.Repositories;
using ExampleMediatR.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExampleMediatR.Handlers
{
    public class GetCustomerByIdHandler : IRequestHandler<GetCustomerByIdQuery, CustomerResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICustomersRepository _customersRepository;

        public GetCustomerByIdHandler(IMapper mapper, ICustomersRepository customersRepository)
        {
            _mapper = mapper;
            _customersRepository = customersRepository;
        }


        public async Task<CustomerResponse> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customerDto = await _customersRepository.GetCustomerAsync(request.CustomerId);
            return customerDto == null ? null : _mapper.MapCustomerDtoToCustomerResponse(customerDto);
        }
    }
}
