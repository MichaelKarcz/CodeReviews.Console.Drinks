using Newtonsoft.Json;

namespace DrinksInfo.Models;

public class DrinkInfos
{
    [JsonProperty("drinks")]
    public List<DrinkInfo> DrinkInfoList;
}
