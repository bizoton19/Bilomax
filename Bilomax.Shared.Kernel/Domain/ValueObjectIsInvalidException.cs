﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilomax.Generic.Infrastructure.Domain
{
  public  class ValueObjectIsInvalidException: Exception
    {
      public ValueObjectIsInvalidException(string message): base(message)
      {


      }
    }
}
