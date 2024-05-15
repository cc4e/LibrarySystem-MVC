using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using static LibrarySystem.Models.Category;

namespace LibrarySystem.Models
{
	[MetadataType(typeof(CategorymetaData))]
	public partial class Category
	{
		
		public class CategorymetaData
		{
			[DisplayName("Category name")]
			public string catname { get; set; }

			[DisplayName("Status")]

			public string Status { get; set; }


		}

	}
}