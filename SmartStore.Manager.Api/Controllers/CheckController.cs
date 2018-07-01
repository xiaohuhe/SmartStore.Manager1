﻿using SmartStore.Manager.App.SSO;
using SmartStore.Manager.App.SSO.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartStore.Manager.Api.Controllers
{
    [RoutePrefix("api/check")]
    public class CheckController : ApiController
    {
        [Route("login")]
        [HttpPost]
         public LoginResult GetUserMenus(PassportLoginRequest request)
        {
            return SSOAuthUtil.Parse(request);
        }
    }
}
