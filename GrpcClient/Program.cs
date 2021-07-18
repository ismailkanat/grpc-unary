using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            while (true)
            {
                var channel = GrpcChannel.ForAddress("https://localhost:5001");
                var greeterClient = new GrpcServer.Greeter.GreeterClient(channel);
                Console.WriteLine("Please enter your name.");
                var serviceResult = await greeterClient.SayHelloAsync(new GrpcServer.HelloRequest { Name = Console.ReadLine() });
                Console.WriteLine($"Server Response  : {serviceResult.Message}");
            }
        }
    }
}
