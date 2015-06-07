using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.ReadifyService;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class RedPill : IRedPill
    {
        RedPillClient redpillClient;
        
        public RedPill()
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
            return new Guid("8c2eef53-96a9-4b0c-81ee-bdae9226765b");            
        }

        public long FibonacciNumber(long n)
        {
            return redpillClient.FibonacciNumber(n);            
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            return redpillClient.WhatShapeIsThis(a, b, c);
        }

        public string ReverseWords(string s)
        {
            return redpillClient.ReverseWords(s);
        }

    }
}
