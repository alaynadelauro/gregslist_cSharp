namespace gregslist_cSharp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HousesController(HousesService housesService) : ControllerBase
{
    private readonly HousesService _housesService = housesService;
    [HttpGet]
    public ActionResult<List<House>> GetHouses()
    {
        try
        {
            List<House> houses = _housesService.GetHouses();
            return Ok(houses);
        }
        catch (Exception error)
        {
            return BadRequest(error);
        }
    }
    [HttpGet("{houseId}")]
    public ActionResult<House> GetHouseById(int houseId)
    {
        try
        {
            House house = _housesService.GetHouseById(houseId);
            return Ok(house);
        }
        catch (Exception error)
        {
            return BadRequest(error);
        }
    }
    [HttpPost]
    public ActionResult<House> AddHouse([FromBody] House houseData)
    {
        try
        {
            House house = _housesService.AddHouse(houseData);
            return house;
        }
        catch (Exception error)
        {
            return BadRequest(error);
        }
    }
    [HttpPut("{houseId}")]
    public ActionResult<House> UpdateHouse(int houseId, [FromBody] House houseData)
    {
        try
        {
            House house = _housesService.UpdateHouse(houseId, houseData);
            return Ok(house);
        }
        catch (Exception error)
        {
            return BadRequest(error);
        }
    }
    [HttpDelete("{houseId}")]
    public ActionResult<House> RemoveHouse(int houseId)
    {
        try
        {
            House house = _housesService.RemoveHouse(houseId);
            return house;
        }
        catch (Exception error)
        {
            return BadRequest(error);
        }
    }
}