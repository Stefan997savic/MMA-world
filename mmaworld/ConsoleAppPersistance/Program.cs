using ConsoleAppPersistance;
using Domain.Models;

List<Country> countriesToAdd = new List<Country> 
{
    new Country()
    {
        Id = 1,
        Name = "Serbia",
        ISO2 = "RS",
        ISO3 = "SRB",
        NameSRB = "Srbija"
    },
    new Country()
    {
        Id = 2,
        Name = "Montenegro",
        ISO2 = "MG",
        ISO3 = "MNE",
        NameSRB = "Crna gora"
    }
};
List<Country> existingCountries = new List<Country>();
List<Country> readyToAdd = new List<Country>();

existingCountries = ReadPersistedItems();
existingCountries.PrintList();

Console.WriteLine("Population started ...");
foreach(var item in countriesToAdd)
{
    if (!existingCountries.Any(x => x.Equals(item)))
    {
        readyToAdd.Add(item);
    }
}
Console.WriteLine("Population ended ...");

WriteItems(readyToAdd);

existingCountries = ReadPersistedItems();
existingCountries.PrintList();

List<Country> ReadPersistedItems()
{
    var existingItems = new List<Country>();
    try
    {
        // Open the text file using a stream reader.
        using (var sr = new StreamReader("countries.txt"))
        {
            // Read the stream as a string, and write the string to the console.
            var item = sr.ReadToEnd();
            existingItems.Add(new Country()
            {
                Name = item
            });
        }
    }
    catch (IOException e)
    {
        Console.WriteLine("The file could not be read:");
        Console.WriteLine(e.Message);
    }

    return existingItems;
}

void WriteItems(List<Country> countriesToAdd)
{

    try
    {
        // Open the text file using a stream reader.
        File.WriteAllLines("countries.txt", countriesToAdd.Select(x=>x.ToString()));
    }
    catch (IOException e)
    {
        Console.WriteLine("The file could not be read:");
        Console.WriteLine(e.Message);
    }
}