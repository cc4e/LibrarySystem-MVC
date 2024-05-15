using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibrarySystem.Models
{
	[MetadataType(typeof(membermetaData))]
	public partial class member
	{
		public class membermetaData
		{
			[DisplayName("Member Name")]
			public string name { get; set; }

			[DisplayName("Phone Number")]

			public string phone { get; set; }


		}
	}
}