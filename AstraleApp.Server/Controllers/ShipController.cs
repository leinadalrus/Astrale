using Microsoft.AspNetCore.Mvc;

namespace AstraleApp.Server.Controllers
{
  public class ShipController : ControllerBase
  {
    public ShipController() { }
    
    [HttpGet(Name = "GetShip")]
    public string GetShip()
    {
      return "ship";
    }
  }
}