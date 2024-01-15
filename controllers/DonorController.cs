using Microsoft.AspNetCore.Mvc; 

[ApiController]
[Route("api/donors")]
public class DonorController : ControllerBase
{
    private readonly IDonorService _donorService;

    public DonorController(IDonorService donorService)
    {
        _donorService = donorService;
    }

    [HttpPost]
    public IActionResult CreateDonor([FromBody] Donor donor)
    {
        if (_donorService.CreateDonor(donor))
        {
            return Ok("Donor created successfully.");
        }

        return BadRequest("Invalid donor data.");
    }
}
