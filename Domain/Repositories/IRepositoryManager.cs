using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
   public interface IRepositoryManager
    {

        ICommandRepo CommandRepo { get;  }

     //   object CommandRepo { get; set; }
    }
}
