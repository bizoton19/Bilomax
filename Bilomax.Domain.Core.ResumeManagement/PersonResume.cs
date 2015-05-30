using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bilomax.Generic.Infrastructure.Domain;
using Bilomax.Domain.Core.ResumeManagement.RepositoryInterfaces;
using Bilomax.Domain.Core.ResumeManagement;

namespace Bilomax.Domain.Core.ResumeManagement.Resume
{
    /// <summary>
    /// This class represents a person's resumeas an object that contains an PositionDutyId, a Title, a list of previous and current positions
    /// held, languages spoken and references
    /// </summary>
   public class PersonResume: EntityBase<int>,IAggregateRoot
    {
        //public PersonResume(IPersonResumeRepository personResumeData, IPersonRepository personData )
        //{  
        //    _personResumeData = personResumeData;

            
        //}
       // public int PositionDutyId { get; set; }
        
        //private IPersonResumeRepository _personResumeData;
        public string ResumeName { get; set; }
        //public HdwihRecruit ResumeOwner { get; set; }
        //public Gender Gender { get { return this.ResumeOwner.Gender; } }
        public string[] SkillsOrSpecialties { get; set; }
        public IEnumerable<EmploymentPosition> EmploymentHistory { get; set; }
        public IEnumerable<LanguageSpoken> LanguagesSpoken { get; set; }
        public IEnumerable<Reference> References { get; set; }
        public IEnumerable<PersonEducation> EducationHistory { get; set; }
        
        protected override void Validate()
        {
            throw new NotImplementedException();
        }

        public Person GetOwner()
        {
            throw new NotImplementedException();
        }
       public void ConvertToFormat()
        { }
       public void Edit()
       { }
       public void Delete()
       { }

        public void Create()
        {
        }
       public void ForwardToHdwihUser()
        { }
       public void ForwardToEmailList(string[] emaiList) { }
       public void Download()
       { }
    }
}
