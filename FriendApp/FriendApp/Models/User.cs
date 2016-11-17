using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FriendApp.Models
{
    public class User
    {
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profileImage")]
        public string ProfileImage { get; set; }

        [JsonIgnore]
        public bool SendMoment { get; set; }
    }
}
