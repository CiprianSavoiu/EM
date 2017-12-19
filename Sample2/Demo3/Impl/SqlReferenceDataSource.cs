using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Sample2.Demo3.Impl
{
    public abstract class SqlDataSource
    {
        public string Name = "SQL";
    }


    public class SqlReferenceDataSource: SqlDataSource, IReferenceDataSource
    {
        public IEnumerable<ReferenceDataItem> GetItems()
        {
            return new List<ReferenceDataItem>
            {
                new ReferenceDataItem {Code= "xyz", Description = "from SQl"},
                new ReferenceDataItem {Code ="xyz", Description = "from SQl 2"}
            };
        }
    }
}
