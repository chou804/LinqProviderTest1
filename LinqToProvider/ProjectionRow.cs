using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToProvider
{
    public abstract class ProjectionRow
    {
        public abstract object GetValue(int index);
    }
}
