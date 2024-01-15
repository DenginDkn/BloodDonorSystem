using Microsoft.AspNetCore.Mvc; 

[ApiController]
[Route("api/blooddonations")]
public class BloodDonationController : ControllerBase
{
    private static List<BloodDonation> _bloodDonations = new List<BloodDonation>();
    private static BloodBank _bloodBank = new BloodBank { BloodBankId = 1, Name = "Kizilay Izmir - Konak branch" };

    [HttpPost]
    public IActionResult AddBloodDonation([FromBody] BloodDonation bloodDonation)
    {
        if (ModelState.IsValid)
        {
            bloodDonation.BloodBankId = _bloodBank.BloodBankId;
            _bloodDonations.Add(bloodDonation);

            return Ok("Blood donation added successfully.");
        }

        return BadRequest("Invalid blood donation data.");
    }
}

internal class BloodBank
{
    public int BloodBankId { get; internal set; }
    public string Name { get; internal set; }
}
