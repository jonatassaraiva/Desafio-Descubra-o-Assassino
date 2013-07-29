﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Desafio.DescubraAssasino.Domain.Tests
{
	[TestClass]
	public class CarregaDadosTests
	{
		private Case caseInvestigation;

		private DataContext context;
		public CarregaDadosTests()
		{
			this.context = new DataContext("c:\\json\\data.json");
			this.caseInvestigation = new Case();
			this.caseInvestigation.Title = "O empresário Bill G.";
		}

		[TestMethod]
		public void Carregar_Suspeitos()
		{
			this.caseInvestigation.Suspects = this.context.Suspects;

			Assert.IsNotNull(this.caseInvestigation.Suspects);
			Assert.IsTrue(this.caseInvestigation.Suspects.Count() == 6);
		}

		[TestMethod]
		public void Carregar_Locais()
		{
			this.caseInvestigation.Locals = this.context.Locals;

			Assert.IsNotNull(this.caseInvestigation.Locals);
			Assert.IsTrue(this.caseInvestigation.Locals.Count() == 10);
		}

		[TestMethod]
		public void Carregar_Armas()
		{
			this.caseInvestigation.Guns = this.context.Guns;

			Assert.IsNotNull(this.caseInvestigation.Guns);
			Assert.IsTrue(this.caseInvestigation.Guns.Count() == 6);
		}
	}
}