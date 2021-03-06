﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace K19_K32_Cap11_TratamentoDeErros
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
