using Contracts;
using Domain.Entities;
using Domain.Repositories;
using Mapster;
using Service.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public class CommandService : ICommandService 
    {
        private readonly IRepositoryManager _repositoryManager;

        // private readonly IRepositoryManager _repositoryManager;

        public CommandService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;

        CommandReadDto ICommandService.CreateCommand(int platformId, CommandCreateDto commandCreateDto)
        {
            //  var commands = _repositoryManager.CommandRepo.CreateCommand();

            var command = commandCreateDto.Adapt<Command>();

            command.PlatformId = platformId;

            _repositoryManager.CommandRepo.CreateCommand(platformId, command);

            _repositoryManager.CommandRepo.SaveChanges();


           return command.Adapt<CommandReadDto>();
        }

        PlatformReadDto ICommandService.CreatePlatform(PlatformCreateDto PlatCreateDTO)
        {
            var Platform = PlatCreateDTO.Adapt<Platform>();

            _repositoryManager.CommandRepo.CreatePlatform(Platform);

            _repositoryManager.CommandRepo.SaveChanges();


            return Platform.Adapt<PlatformReadDto>();
        }


        bool ICommandService.SaveChanges()
        {
       var tt =   _repositoryManager.CommandRepo.SaveChanges();

            return true;

           
        }
    }
}
