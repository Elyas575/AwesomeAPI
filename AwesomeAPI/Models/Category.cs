using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace AwesomeAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
 
        public string Name { get; set; }
        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
