using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
	[TestClass]
	class HomeControllerTests
	{
		[TestMethod]
		public void Index()
		{
			HomeController controller = new HomeController();
			ViewResult result = controller.Index() as ViewResult;
			Assert.IsNotNull(result);
		}
		[TestMethod]
		public void Privacy()
		{
			HomeController controller = new HomeController();
			ViewResult result = controller.Privacy() as ViewResult;
			Assert.IsNotNull(result);
		}
	}
}
