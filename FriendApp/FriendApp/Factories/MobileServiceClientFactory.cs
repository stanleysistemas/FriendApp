using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FriendApp.Helpers;
using Microsoft.WindowsAzure.MobileServices;

namespace FriendApp.Factories
{
    public static class MobileServiceClientFactory
    {
        public static MobileServiceClient CreateClient()
        {
            return new MobileServiceClient(Keys.ApplicationURL, Keys.ApplicationKey);
        }

        public static MobileServiceClient CreateClient(params HttpMessageHandler[] handlers)
        {
            return new MobileServiceClient(Keys.ApplicationURL, Keys.ApplicationKey, handlers);
        }
    }
}
