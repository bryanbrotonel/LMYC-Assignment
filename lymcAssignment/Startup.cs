﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lymcAssignment.Startup))]
//[assembly: OwinStartupAttribute("lymcAssignmentConfig", typeof(lymcAssignment.Startup))]

namespace lymcAssignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
