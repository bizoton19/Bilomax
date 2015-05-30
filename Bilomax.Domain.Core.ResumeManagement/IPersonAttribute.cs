using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilomax.Domain.Core.ResumeManagement
{
   public interface IPersonAttribute
   {
       string Name { get; set; }
       int Id { get; set; }
   }
}
