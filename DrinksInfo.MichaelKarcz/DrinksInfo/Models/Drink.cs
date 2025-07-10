using Newtonsoft.Json;

namespace DrinksInfo.Models;
public record class Drink
{
    [JsonProperty("idDrink")] public int Id { get; set; }
    [JsonProperty("strDrink")] public string DrinkName { get; set; }

    public override string ToString()
    {
        return DrinkName;
    }
}