using Grpc.Core;
using YuliRox.gRPC.Server;

namespace YuliRox.gRPC.Server.Services;

public class RecordingService : Server.RecordingService.RecordingServiceBase
{
    private readonly ILogger<RecordingService> _logger;
    public RecordingService(ILogger<RecordingService> logger)
    {
        _logger = logger;
    }

    public override Task<CurrentRecordingIdReply> GetCurrentRecordingId(CurrentRecordingIdRequest request, ServerCallContext context)
    {
        return base.GetCurrentRecordingId(request, context);
    }

    public override Task<StatusReply> GetRecordingStatus(StatusRequest request, ServerCallContext context)
    {
        return base.GetRecordingStatus(request, context);
    }

    public override Task<StartReply> StartRecording(StartRequest request, ServerCallContext context)
    {
        return base.StartRecording(request, context);
    }

    public override Task<StopReply> StopRecording(StopRequest request, ServerCallContext context)
    {
        return base.StopRecording(request, context);
    }
}
