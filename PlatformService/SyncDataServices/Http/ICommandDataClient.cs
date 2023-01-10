using PlatformService.Dtos;
using System.Threading.Tasks;

namespace CommandsService.SyncDataServices.Http
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto platform);
    }
}
