using Microsoft.AspNetCore.Mvc;

public class ParksController : Controller
{
    public IActionResult ByProvince(string province)
    {
        var parks = ParkData.GetParks()
            .Where(p => p.ProvinceOrTerritory == province)
            .ToList();
        return Json(parks);
    }
}

