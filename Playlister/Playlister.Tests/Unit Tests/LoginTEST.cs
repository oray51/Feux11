using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playlister.web.Controllers;
using System.Web.Mvc;

namespace Playlister.Tests
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        //
        public void TestLoginView()
        {          
            var controller = new AccountController();
            var result = controller.Login(returnUrl) as ViewResult;
            Assert.AreEqual("Login", result.ViewName);
        }
    }
}
