﻿using Bilomax.Generic.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bilomax.Domain.Core.ResumeManagement.Resume
{
   public class LanguageSpoken: EntityBase<int>, IResumeAttribute
    {
       
        public string  Name { get; set; }

       protected override void Validate()
       {
           throw new NotImplementedException();
       }
    }
}
