using Domain.Models;

string? standardInput = null;
List<Country> countryList = new List<Country>()
{
    new Country()
    {
        Id = 1,
        ISO2 = "rs",
        ISO3 = "srb",
        Name = "Serbia",
        NameSRB = "Srbija"
    },
     new Country()
    {
        Id = 2,
        ISO2 = "ch",
        ISO3 = "nrc",
        Name = "China",
        NameSRB = "Kina"
    }
};
do
{
    Console.WriteLine("Simple menu:");
    Console.WriteLine("1. display all available countries");
    Console.WriteLine("2. display specific country");
    Console.WriteLine("3. add new country");
    Console.WriteLine("4. update existing country");
    Console.WriteLine("5. delete country");
    Console.WriteLine("X. exit app");

    standardInput = Console.ReadLine();

    if(int.TryParse(standardInput, out int selectionFromStandardInput))
    {
        switch(selectionFromStandardInput)
        {
            case 1:
                DisplayAllAvailableCountries();
                break;
            case 2:
                var existingCountry = PickSpecificCountryById();
                if(existingCountry == null)
                {
                    Console.WriteLine("You dont have any country with that id");
                }
                else
                {
                    Console.WriteLine(existingCountry);
                }
                break;
            case 3:
                var newCountry = BuildNewCountry();
                countryList.Add(newCountry);
                break;
            case 4:
                var existingCountryForUpdate = PickSpecificCountryById();
                var updateCountry = BuildNewCountry();
                UpdateExistingCountry(existingCountryForUpdate.Id, updateCountry);
                break;
            case 5:
                var existingCountryForDelete = PickSpecificCountryById();
                DeleteSpecificCountry(existingCountryForDelete);
                break;
            default:
                
                break;
        }
    }

} while (string.IsNullOrWhiteSpace(standardInput) || 
        (standardInput != "x" || 
        standardInput != "X"));

void UpdateExistingCountry(int id, Country updateCountry)
{
    foreach(var country in countryList)
    {
        if(country.Id == id)
        {
            country.Name = updateCountry.Name;
            country.ISO2 = updateCountry.ISO2;
            country.ISO3 = updateCountry.ISO3;
            country.NameSRB = updateCountry.NameSRB;
        }
        return;
    }
}

void DeleteSpecificCountry(Country existingCountry)
{
    countryList.Remove(existingCountry);
}

void DeleteSpecificCountrySoft(Country existingCountry)
{
    foreach(var country in countryList)
    {
        if(country.Id == existingCountry.Id)
        {
            country.Name = string.Empty; 
            country.ISO2 = string.Empty;
            country.ISO3 = string.Empty;
            country.NameSRB = string.Empty;
        }
    }
}

Country? PickSpecificCountryById()
{
    string? standardInput = null;
    Console.WriteLine("Please specify country ID:");
    standardInput = Console.ReadLine();

    Country? selectedCountry = null;
    if (int.TryParse(standardInput, out int selectionFromStandardInput))
    {

        foreach(var currentyCountr in countryList)
        {
            if(currentyCountr.Id == selectionFromStandardInput)
            {
                selectedCountry = currentyCountr;
                break;
            }
        }
    }
    return selectedCountry;
}

void DisplayAllAvailableCountries()
{
    Console.WriteLine("DisplayAllAvailableCountries");
    if (countryList.Any())
    {
        foreach (var currentCountry in countryList)
        {
            Console.WriteLine(currentCountry);
        }
    }
    else
    {
        Console.WriteLine("List of countries is empty");
    }
   
}

//var newCountry = BuildNewCountry();

//Console.WriteLine(newCountry);





Country BuildNewCountry()
{
    string standardInput = null;
    do
    {
        Console.WriteLine("Specify name:");
        standardInput = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(standardInput));
    var name = standardInput.Trim();

    do
    {
        Console.WriteLine("Specify iso2:");
        standardInput = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(standardInput));
    var iso2 = standardInput.Trim();
    do
    {
        Console.WriteLine("Specify iso3:");
        standardInput = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(standardInput));
    var iso3 = standardInput.Trim();
    do
    {
        Console.WriteLine("Specify serbian name:");
        standardInput = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(standardInput));
    var serbianName = standardInput.Trim();

    return new Country(countryList.Count+1, name, iso2, iso3, serbianName);
}