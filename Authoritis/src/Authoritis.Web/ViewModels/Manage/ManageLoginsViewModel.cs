﻿using System.Collections.Generic;
using Microsoft.AspNet.Http.Authentication;
using Microsoft.AspNet.Identity;

namespace Authoritis.Web.ViewModels.Manage
{
    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }

        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }
}
