using Newtonsoft.Json;

namespace DrinksInfo.Models
{
    public class Category
    {
        public string strCategory { get; set; } = string.Empty;
        public override string ToString()
        {
            return strCategory ?? "";
        }
    }
    
    

    public class Categories
    {
        [JsonProperty("drinks")]
        public List<Category> CategoriesList;
    }
}
