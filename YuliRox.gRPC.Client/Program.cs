using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using YuliRox.gRPC;

namespace YuliRox.gRPC.Client
{
    public class Program
    {
        static async Task Main(string[] args)
        {

            using var channel = GrpcChannel.ForAddress("https://localhost:7260");
            var client = new RecordingService.RecordingServiceClient(channel);

            var rc = await client.StartRecordingAsync(new StartRequest() { Id = 3 });
            Console.WriteLine("Start request " + (rc.Rc == true ? "successful " : "failed"));

            var rc2 = await client.StopRecordingAsync(new StopRequest() { Id = 3 });
            Console.WriteLine("Stop request " + (rc2.Rc == true ? "successful " : "failed"));

            var status = await client.GetRecordingStatusAsync(new StatusRequest());
            Console.WriteLine(status);

            var id = await client.GetCurrentRecordingIdAsync(new CurrentRecordingIdRequest());
            Console.WriteLine(id.Id);

            Console.WriteLine("Shutting down");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}