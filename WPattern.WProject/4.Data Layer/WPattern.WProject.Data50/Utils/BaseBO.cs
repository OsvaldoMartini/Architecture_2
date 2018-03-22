using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPattern.WProject.Data50.Utils;

namespace WPattern.WProject.Data50.Utils
{
    public abstract class BaseBO : IValidation
    {
        public virtual void Validation()
        {
        }
    }
}
