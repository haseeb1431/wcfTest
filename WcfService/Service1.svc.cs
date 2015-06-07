using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.RedPill;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class GreenPill : IGreenPill
    {
        RedPillClient redpillClient;
        public GreenPill()
        {
            redpillClient = new RedPillClient("BasicHttpsBinding_IRedPill");
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        public Guid WhatIsYourToken()
        {
            return redpillClient.WhatIsYourToken();
        }

        public System.Threading.Tasks.Task<Guid> WhatIsYourTokenAsync()
        {
            return redpillClient.WhatIsYourTokenAsync();
        }

        public long FibonacciNumber(long n)
        {
            return redpillClient.FibonacciNumber(n);            
        }

        public System.Threading.Tasks.Task<long> FibonacciNumberAsync(long n)
        {
            return redpillClient.FibonacciNumberAsync(n);
        }

        public RedPill.TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            return redpillClient.WhatShapeIsThis(a, b, c);
        }

        public System.Threading.Tasks.Task<RedPill.TriangleType> WhatShapeIsThisAsync(int a, int b, int c)
        {
            return redpillClient.WhatShapeIsThisAsync(a, b, c);
        }

        public string ReverseWords(string s)
        {
            return redpillClient.ReverseWords(s);
        }

        public System.Threading.Tasks.Task<string> ReverseWordsAsync(string s)
        {
            return redpillClient.ReverseWordsAsync(s);
        }
    }
}
