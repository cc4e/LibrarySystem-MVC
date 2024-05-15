using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static LibrarySystem.Models.Category;

namespace LibrarySystem.Models
{
	[MetadataType(typeof(authorMetaData))]
	public partial class author
	{
		public class authorMetaData
		{
			[DisplayName("author name")]
			public string name { get; set; }

			[DisplayName("Address")]

			public string address { get; set; }

			[DisplayName("Phone Number")]

			public string phone { get; set; }


		}
	}
}