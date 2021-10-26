using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Service.Abstractions
{

    public interface ICommandService
    {

         bool SaveChanges();
       // IEnumerable<PlatformReadDto> GetAllPlatforms();
        PlatformReadDto CreatePlatform(PlatformCreateDto plat);
        //bool PlatformExists(int platformId);
        

        //IEnumerable<CommandReadDto> GetCommandsForPlatform(int platformId);
        //CommandReadDto GetCommand(int platformId, int commandId);
        //bool ExternalPlatformExist(int ExternelPlatformID);

        CommandReadDto CreateCommand(int platformId, CommandCreateDto command);
       
    }
}