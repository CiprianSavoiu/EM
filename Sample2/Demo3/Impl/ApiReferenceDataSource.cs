using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Sample2.Demo3.Impl
{
    public abstract class ApiDataSource
    {
        public string Name = "API";
    }

    public class ApiReferenceDataSource: ApiDataSource, IReferenceDataSource
    {
        public IEnumerable<ReferenceDataItem> GetItems()
        {
            return new List<ReferenceDataItem>
            {
                new ReferenceDataItem {Code = "xyz", Description = "from API"},
                new ReferenceDataItem {Code = "xyz", Description = "From API 2"}
            };
        }
    }
}
