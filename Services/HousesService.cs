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
        House house = _repository.GetHouseById(houseId);
        return house;
    }
}