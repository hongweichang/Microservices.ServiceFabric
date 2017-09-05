﻿using System.Collections.Generic;
using System.Fabric;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using Microsoft.ServiceFabric.Services.Remoting.Runtime;

namespace OrderChocolate
{
    // TODO 2
    internal sealed class OrderChocolate : StatelessService, IChocolateService
    {
        public OrderChocolate(StatelessServiceContext context)
            : base(context)
        { }

        // TODO 3
        protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners()
        {
            return new[]{ new ServiceInstanceListener(this.CreateServiceRemotingListener) };
        }

        // TODO 4
        public Task<Result> SayHello()
        {
            return Task.FromResult(new Result
            {
                InstanceId = Context.InstanceId,
                Message = "Hello Amsterdam!"
            });
        }
    }
}
