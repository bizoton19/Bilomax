using Bilomax.Generic.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bilomax.Domain.Core.ResumeManagement
{
   public class PhoneNumber: EntityBase<int>
    {
        
        public virtual int? CountryCode { get; set; }
        public virtual int? AreaCode { get; set; }
        public virtual int? Number { get; set; }
        public PhoneType PhoneType { get; set; }
       //TODO: implement extension method

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
