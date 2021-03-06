﻿using Convey.CQRS.Queries;
using SmartDomainDrivenDesign.Infrastructure.Convey;
using System.Threading.Tasks;

namespace SmartDomainDrivenDesign.OrderSample.Application.Orders
{
    [Contract]
    public class GetOrdersRequest : IQuery<GetOrdersResponse>
    {
    }

    public class GetOrdersResponse
    {
    }

    public class GetOrdersHandler : IQueryHandler<GetOrdersRequest, GetOrdersResponse>
    {
        public async Task<GetOrdersResponse> HandleAsync(GetOrdersRequest request)
        {
            return new GetOrdersResponse();
        }
    }
}
