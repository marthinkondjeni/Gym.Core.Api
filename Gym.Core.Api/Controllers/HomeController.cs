// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;

namespace Gym.Core.Api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() => Ok("Marthin is a man of timber and calimber");


    }
}
