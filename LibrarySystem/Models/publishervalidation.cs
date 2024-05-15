using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibrarySystem.Models
{
	[MetadataType(typeof(publisherNetaData))]
	public partial class publisher
	{
		public class publisherNetaData
		{
			[DisplayName("publisher name")]
			public string name { get; set; }

			[DisplayName("Address")]

			public string address { get; set; }

			[DisplayName("Phone Number")]

			public string phone { get; set; }
		}
	}
}