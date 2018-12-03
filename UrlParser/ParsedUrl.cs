using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlParser
{
    class ParsedUrl
    {
        public String Protocol = null;
        public String Host = null;
        public String Path = null;
        public String Query = null;
        public System.Collections.Specialized.NameValueCollection Params = null;
    }
}
