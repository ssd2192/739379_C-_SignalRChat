using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _739379_17_7_19
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}