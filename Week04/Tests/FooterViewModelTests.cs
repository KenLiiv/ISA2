using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
	[TestClass]
	class FooterViewModelTests
	{
		private FooterViewModel o;

		[TestInitialize]
		public void TestInitialize()
		{
			o = new FooterViewModel(null);
		}
		[TestMethod]
		public void CompanyNameTest()
		{
			o.setCompanyName("TaalTech");
			Assert.AreEqual("TaalTech", o.CompanyName);
		}
		[TestMethod]
		public void YearTest()
		{
			Assert.AreEqual(DateTime.Now.Year.ToString(), o.Year);
		}
	}
}
