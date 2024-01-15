public class DonorService : IDonorService
{
    private static List<Donor> _donors = new List<Donor>();

    public bool CreateDonor(Donor donor)
    {
        if (ValidateDonor(donor))
        {
            donor.DonorId = _donors.Count + 1;
            _donors.Add(donor);
            return true;
        }
        return false;
    }

    private bool ValidateDonor(Donor donor)
    {
        return true;
    }
}
