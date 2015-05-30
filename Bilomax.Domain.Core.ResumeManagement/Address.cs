using Bilomax.Generic.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bilomax.Domain.Core.ResumeManagement
{
   public  class Address: EntityBase<int>
    {
        public string Name { get; set; }
        
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public Country Country { get; set; }



        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
