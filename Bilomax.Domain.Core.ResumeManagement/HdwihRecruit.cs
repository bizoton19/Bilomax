using System.Collections.Generic;
using Bilomax.Domain.Core.ResumeManagement.RepositoryInterfaces;
using Bilomax.Domain.Core.ResumeManagement.Resume;

namespace Bilomax.Domain.Core.ResumeManagement
{
    public class HdwihRecruit 
    {
        private readonly IPersonResumeRepository _pRepository;

        public HdwihRecruit(IPersonResumeRepository pRepository)
        {
            _pRepository = pRepository;
        }

        public string UserId { get; set; }
        //public UserAccountProfile AccountProfile { get; set; }

        public IEnumerable<PersonResume> GetAllResumes()
        {
            return _pRepository.GetAllResumes();
        }

        //public void TagPosting(Bilomax.Generic.Infrastructure.Domain.EntityBase posting, bool tagtype)
        //{
        //}

        

        public void SubscribeToPostingFeeds()
        {
        }

        public void UnSubscribeToPostingFeeds()
        {
        }

       
    }
}