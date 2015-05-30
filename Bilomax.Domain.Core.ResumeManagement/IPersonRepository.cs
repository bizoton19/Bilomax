using Bilomax.Generic.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilomax.Domain.Core.ResumeManagement.RepositoryInterfaces
{
    public interface IPersonRepository : IReadOnlyRepository<Person, int>
    {

    }
}
