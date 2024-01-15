using System.Collections.Generic;

public class BloodDonationService : IBloodDonationService
{
    private static List<BloodDonation> _bloodDonations = new List<BloodDonation>();
    private static BloodBank _bloodBank = new BloodBank { BloodBankId = 1, Name = "Kizilay Izmir - Konak branch" };

    public bool AddBloodDonation(BloodDonation bloodDonation)
    {
        if (ValidateBloodDonation(bloodDonation))
        {
            bloodDonation.BloodBankId = _bloodBank.BloodBankId;
            _bloodDonations.Add(bloodDonation);
            return true;
        }
        return false;
    }

    private bool ValidateBloodDonation(BloodDonation bloodDonation)
    {
    
        return true;
    }
}
