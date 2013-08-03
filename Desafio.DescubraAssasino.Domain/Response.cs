﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desafio.DescubraAssasino.Domain
{
	public class Response
	{
		public string Suspect { get; set; }
		public string Gun { get; set; }
		public string Local { get; set; }
	}

	public enum ResponseType
	{
		Right = 0,
		Suspect = 1,
		Local = 2,
		Gun = 3
	}
}
