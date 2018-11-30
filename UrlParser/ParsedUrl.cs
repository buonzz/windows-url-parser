using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlParser
{
    class ParsedUrl
    {
        public String Protocol;
        public String Host;
        public String Path;
        public String Query;
        public System.Collections.Specialized.NameValueCollection Params;
    }
}
