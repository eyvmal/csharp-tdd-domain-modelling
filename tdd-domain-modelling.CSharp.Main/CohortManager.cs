using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class CohortManager
    {
        public int Count(List<string> cohorts, string name)
        {
            return cohorts.Where(c => c.ToLower().Contains(name.ToLower())).Count();
        }
    }
}
