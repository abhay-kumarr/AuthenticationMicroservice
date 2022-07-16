using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationMicroservice.Helpers
{
    public static class API
    {
        public static class CustomerMicroservice
        {
            private const string BASE_URL = "https://localhost:44366/api/Customer/";

            public static string ValidateUrl()
            {
                return new Uri(new Uri(BASE_URL), "validate").ToString();
            }
        }

        public static class ManagerMicroservice
        {
            private const string BASE_URL = "https://localhost:44348/api/Manager/";

            public static string ValidateExecutiveUrl()
            {
                return new Uri(new Uri(BASE_URL), "validateExecutive").ToString();
            }

            public static string ValidateManagerUrl()
            {
                return new Uri(new Uri(BASE_URL), "validateManager").ToString();
            }
        }
    }
}
