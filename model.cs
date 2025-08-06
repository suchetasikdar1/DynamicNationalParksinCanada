public class NationalPark
{
    public required string Name { get; set; }
    public required string ProvinceOrTerritory { get; set; }
    public required List<NotableAnimal> NotableAnimals { get; set; }

}

public class NotableAnimal
{
    public required string AnimalName { get; set; }
    public required string BestTimeToSee { get; set; }
}

