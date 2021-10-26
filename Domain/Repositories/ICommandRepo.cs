using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface ICommandRepo 
    {

         bool SaveChanges();
      //  IEnumerable<Platform> GetAllPlatforms();
        Platform CreatePlatform(Platform plat);
      //  bool PlatformExists(int platformId);
        

     //   IEnumerable<Command> GetCommandsForPlatform(int platformId);
      //  Command GetCommand(int platformId, int commandId);
     //   bool ExternalPlatformExist(int ExternelPlatformID);

         Command CreateCommand(int platformId, Command command);
       


    }
}