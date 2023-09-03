using JWT.Models;

namespace JWT.Constants
{
    public class CountryConstants
    {
        public static List<CountryModel> Countrys = new List<CountryModel>()
        {
            new CountryModel () { name = "Peru" },
            new CountryModel () { name = "Argentina" },
            new CountryModel () { name = "Mexico" },
        };
    }
}
