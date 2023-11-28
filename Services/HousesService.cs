namespace gregslist_cSharp.Services;
public class HousesService(HousesRepository housesRepository)
{
    private readonly HousesRepository _repository = housesRepository;
    internal List<House> GetHouses()
    {
        List<House> houses = _repository.GetHouses();
        return houses;
    }
    internal House GetHouseById(int houseId)
    {
        House house = _repository.GetHouseById(houseId) ?? throw new Exception($"{houseId} is not a valid ID");
        return house;
    }
    internal House AddHouse(House HouseData)
    {
        House house = _repository.AddHouse(HouseData);
        return house;
    }
    internal House UpdateHouse(int houseId, House houseData)
    {
        House foundHouse = GetHouseById(houseId);
        foundHouse.Name = houseData.Name ?? foundHouse.Name;
        foundHouse.Sqft = houseData.Sqft ?? foundHouse.Sqft;
        foundHouse.Bathrooms = houseData.Bathrooms ?? foundHouse.Bathrooms;
        foundHouse.Bedrooms = houseData.Bedrooms ?? foundHouse.Bedrooms;
        foundHouse.Description = houseData.Description ?? foundHouse.Description;
        foundHouse.Price = houseData.Price ?? foundHouse.Price;
        _repository.UpdateHouse(foundHouse);
        return foundHouse;
    }
}