using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibrarySystem.Models
{
	[MetadataType(typeof(BookrMetaData))]
	public partial class Book
	{
		public class BookrMetaData
		{
			[DisplayName("Book Name")]
			public string Bname { get; set; }

			[DisplayName("The Category")]
			public Nullable<int> cat_id { get; set; }

			[DisplayName("AuthorName")]
			public Nullable<int> a_id { get; set; }


			[DisplayName("Publishe Name")]
			public Nullable<int> p_id { get; set; }

			[DisplayName("Contents")]
			public string contents { get; set; }

			[DisplayName("Pages")]
			public Nullable<int> pages { get; set; }

			[DisplayName("Edition")]
			public string edition { get; set; }


		}
	}
}