using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<ICommandRepo> _lazyCommandRepository;

        public RepositoryManager(RepositoryDbContext dbContext )
        {
            _lazyCommandRepository = new Lazy<ICommandRepo>(() => new CommandRepo(dbContext));
        }

       // public ICommandRepo CommandService => _lazyCommandRepository.Value;

        public ICommandRepo CommandRepo => _lazyCommandRepository.Value;

         }
}
