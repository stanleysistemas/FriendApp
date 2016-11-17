using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendApp.Services
{
    public interface ScreenshotService
    {
        byte[] CaptureScreen();
    }
}
