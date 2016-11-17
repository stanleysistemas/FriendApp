using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FriendApp.Services;

namespace FriendApp.Helpers.Azure
{
    public class ZumoAuthHeaderHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(AccountService.Instance.AuthenticationToken))
            {
                throw new InvalidOperationException("User is not currently logged in");
            }

            request.Headers.Add("X-ZUMO-AUTH", AccountService.Instance.AuthenticationToken);

            return base.SendAsync(request, cancellationToken);
        }
    }
}
