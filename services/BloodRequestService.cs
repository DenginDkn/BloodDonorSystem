public class BloodRequestService : IBloodRequestService
{
    private readonly List<Blood> _bloods; 

    public BloodRequestService(List<Blood> bloods)
    {
        _bloods = bloods;
    }

    public bool ProcessBloodRequest(BloodRequest request)
    {
        var availableBlood = _bloods
            .FirstOrDefault(b => b.City == request.City && b.Town == request.Town && b.BloodType == request.BloodType && b.Quantity >= request.Units);

        if (availableBlood != null)
        {
            SendEmail(availableBlood.Donor, $"Blood Request Successful - {request.BloodType}", $"Your blood has been used for a request. {request.Units} units were used.");

            availableBlood.Quantity -= request.Units;

            return true;  
        }

        return false; 
    }

    private void SendEmail(object contactEmail, string v1, string v2)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ProcessBloodRequestAsync(BloodRequest request)
    {
        throw new NotImplementedException();
    }

    private void SendEmail(string to, string subject, string body)
    {
        Console.WriteLine($"Sending email to: {to}\nSubject: {subject}\nBody: {body}");
    }
}
