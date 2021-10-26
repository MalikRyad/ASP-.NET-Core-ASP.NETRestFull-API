using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
   public class CommandRepo : ICommandRepo
    {

        private readonly RepositoryDbContext _dbContext;

        public CommandRepo(RepositoryDbContext dbContext) => _dbContext = dbContext;


        public Command CreateCommand(int platformId, Command command)
        {

            command.PlatformId = platformId;
            _dbContext.Commands.Add(command);

            return command;// throw new NotImplementedException(); // à modifier 
        }

        public Platform CreatePlatform(Platform plat)
        {
             _dbContext.Platforms.Add(plat);

            return plat;//  throw new NotImplementedException(); // à modifier 
        }

        public bool SaveChanges()
        {
            return (_dbContext.SaveChanges() >= 0);
           
        }
    }
}
