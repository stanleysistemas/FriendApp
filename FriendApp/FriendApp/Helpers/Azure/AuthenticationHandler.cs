using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FriendApp.Services;
using Newtonsoft.Json.Linq;
using Plugin.Settings;
using Akavache;

namespace FriendApp.Helpers.Azure
{
    public class AuthenticationHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();
            var jsonObject = JObject.Parse(jsonString);
            var token = jsonObject["token"].ToString();
            SaveAuthenticationToken(token);

            return response;
        }

        private void SaveAuthenticationToken(string token)
        {
            AccountService.Instance.AuthenticationToken = token;
            CrossSettings.Current.AddOrUpdateValue<string>("authenticationKey", token);
            CrossSettings.Current.AddOrUpdateValue<DateTime>("tokenExpiration", DateTime.Now.AddDays(30));
        }
    }
}
