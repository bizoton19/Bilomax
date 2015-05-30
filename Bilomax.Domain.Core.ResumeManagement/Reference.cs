using Bilomax.Domain.Core.ResumeManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bilomax.Domain.Core.ResumeManagement
{
    
        public class Reference : Person
        {
            public RelationshipType RelationshipType { get; set; }
        }
    
}
