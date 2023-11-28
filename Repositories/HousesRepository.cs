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
    internal House AddHouse(House houseData)
    {
        string sql = @"INSERT INTO houses(name, sqft, bedrooms, bathrooms, description, price) Values (@Name, @Sqft, @Bedrooms, @Bathrooms, @Description, @Price);
        SELECT * FROM houses WHERE id = LAST_INSERT_ID();";
        House house = _db.Query<House>(sql, houseData).FirstOrDefault();
        return house;
    }
    internal void UpdateHouse(House foundHouse)
    {
        string sql = @"UPDATE houses SET
        name = @Name,
        sqft = @Sqft,
        bedrooms = @Bedrooms,
        bathrooms = @Bathrooms,
        description = @Description,
        price = @Price
        WHERE id = @ID;";
        _db.Execute(sql, foundHouse);
    }
}