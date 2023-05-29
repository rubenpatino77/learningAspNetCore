using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace learningAspNetCore.Models
{
	public class Product
	{

		public string Id { get; set; }

		public string Maker { get; set; }
		[JsonPropertyName("img")]
		public string Image { get; set; }

        public string Url { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Ratings { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Product>(this);
        }
    }
}

