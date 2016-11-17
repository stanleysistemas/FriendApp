using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendApp.Services
{
    public class GravatarService
    {
        public static string CalculateUrl(string email)
        {
            var hash = HashService.CalculateMD5Hash(email);

            return string.Format("http://www.gravatar.com/avatar.php?gravatar_id={0}", hash);
        }
    }
}
