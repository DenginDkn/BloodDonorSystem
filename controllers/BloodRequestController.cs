using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/bloodrequests")]
public class BloodRequestController : ControllerBase
{
    private readonly IBloodRequestService _bloodRequestService;

    public BloodRequestController(IBloodRequestService bloodRequestService)
    {
        _bloodRequestService = bloodRequestService;
    }

    [HttpPost]
    public async Task<IActionResult> PostBloodRequest([FromBody] BloodRequest request)
    {
        if (ModelState.IsValid)
        {
            var result = await _bloodRequestService.ProcessBloodRequestAsync(request);

            if (result)
            {
                return Ok("Blood request successful");
            }
            else
            {
                return BadRequest("Blood not available for the request");
            }
        }

        return BadRequest("Invalid blood request data");
    }
}
