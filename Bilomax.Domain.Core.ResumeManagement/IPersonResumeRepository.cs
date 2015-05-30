using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bilomax.Generic.Infrastructure.Domain;
using Bilomax.Domain.Core.ResumeManagement.Resume;

namespace Bilomax.Domain.Core.ResumeManagement.RepositoryInterfaces
{
   public interface IPersonResumeRepository: IReadOnlyRepository<PersonResume,int>
    {
        IEnumerable<PersonResume> GetAllResumes();
        Person GetOwner(int resumeId);
        IEnumerable<PersonResume> GetAllResumesByPersonId(int id);
        PersonResume GetResumeBy(int id);
       
    }
}
