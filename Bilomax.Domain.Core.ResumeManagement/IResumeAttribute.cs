using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bilomax.Domain.Core.ResumeManagement.Resume
{
    public interface IResumeAttribute
    {
         int Id { get; set; }
         string Name { get;set;}
    }
}
