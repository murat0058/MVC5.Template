﻿using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;

namespace MvcTemplate.Tests.Unit.Components.Security
{
    [ExcludeFromCodeCoverage]
    public class InheritedAllowAnonymousController : AllowAnonymousController
    {
        [HttpGet]
        public ViewResult InheritanceGet()
        {
            return View();
        }

        [HttpPost]
        public ViewResult InheritancePost()
        {
            return View();
        }

        [HttpGet]
        [ActionName("InheritanceGetName")]
        public ViewResult InheritanceGetAction()
        {
            return View();
        }

        [HttpPost]
        [ActionName("InheritancePostName")]
        public ViewResult InheritancePostAction()
        {
            return View();
        }
    }
}
