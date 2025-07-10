using Newtonsoft.Json;

namespace DrinksInfo.Models
{
    public class Drink
    {
        public int idDrink { get; set; }
        public string strDrink { get; set; } = string.Empty;

        public int GetId()
        {
            return idDrink;
        }
        public override string ToString()
        {
            return strDrink;
        }
    }

    public class Drinks
    {
        [JsonProperty("drinks")]
        public List<Drink> DrinksList;
    }
}
