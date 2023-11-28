namespace gregslist_cSharp.Repositories;
public class HousesRepository(IDbConnection db)
{
    private readonly IDbConnection _db = db;
    internal List<House> GetHouses()
    {
        string sql = "SELECT * FROM houses;";
        List<House> houses = _db.Query<House>(sql).ToList();
        return houses;
    }
    internal House GetHouseById(int houseId)
    {
        string sql = "SELECT * FROM houses WHERE id = @houseId;";
        House house = _db.Query<House>(sql, new { houseId }).FirstOrDefault();
        return house;
    }
}