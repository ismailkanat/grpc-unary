using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<ServiceResult> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new ServiceResult
            {
                Message = $"Hello {request.Name}"
            });
        }
    }
}
