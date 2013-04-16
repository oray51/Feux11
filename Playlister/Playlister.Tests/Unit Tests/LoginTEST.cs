using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playlister.web.Controllers;
using System.Web.Mvc;
using Playlister.web.Models;

namespace Playlister.Tests
{
    [TestClass]
    public class LoginTEST : AccountController
    {
        public class AccountService : AccountController
        {
            public bool DoLogin(string username, string password)
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    return false;
                return true;
            }
        }

        [TestMethod]
        //test a successful login
        public void CorrectCredentials()
        {
            var accountService = new AccountService();

            bool result = accountService.DoLogin("test", "test");

            Assert.IsTrue(result);
        }

        [TestMethod]
        //test the return view
        public void TestLoginView()
        {          
            var controller = new AccountController();
            var result = controller.Login(returnUrl) as ViewResult;
            Assert.AreEqual("Login", result.ViewName);
        }
    }
}
