using System.Globalization;

namespace FootballApp.Models;

public static class FakeDataService
{
    public static List<string> GetCountryNames()
        => CultureInfo.GetCultures(CultureTypes.SpecificCultures)
            .Select(c => new RegionInfo(c.Name).EnglishName)
            .Distinct()
            .OrderBy(countryName => countryName)
            .ToList();

    public static List<Player> GetPlayers()
    {
        List<int> Number = new List<int>();

        do
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 31);

            if (Number.Contains(number)) continue;
            Number.Add(number);
        }
        while (Number.Count < 11);

        List<Player> players = new List<Player>()
        {
            new Player{ Name = Faker.NameFaker.MaleName(), Number = Number[0]},
            new Player{ Name = Faker.NameFaker.MaleName(), Number = Number[1]},
            new Player{ Name = Faker.NameFaker.MaleName(), Number = Number[2]},
            new Player{ Name = Faker.NameFaker.MaleName(), Number = Number[3]},
            new Player{ Name = Faker.NameFaker.MaleName(),Number =  Number[4]},
            new Player{ Name = Faker.NameFaker.MaleName(), Number = Number[5]},
            new Player{ Name = Faker.NameFaker.MaleName(),Number =  Number[6]},
            new Player{ Name = Faker.NameFaker.MaleName(), Number = Number[7]},
            new Player{ Name = Faker.NameFaker.MaleName(),Number =  Number[8]},
            new Player{ Name = Faker.NameFaker.MaleName(),Number =  Number[9]},
            new Player{ Name = Faker.NameFaker.MaleName(),Number =  Number[10]}
        };

        return players;
    }

    public static List<string> GetTacticFormats()
       => new List<string>
       {
           "4-3-3",
           "4-4-2",
           "4-5-1",
           "3-4-3",
           "3-5-2",
           "2-3-5",
       };
}
