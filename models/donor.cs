
public class Donor
{
    public int DonorId { get; set; }  
    public string Fullname { get; set; }
    public string BloodType { get; set; }
    public string Town { get; set; }
    public string City { get; set; }
    public string PhoneNumber { get; set; }
    public byte[] Photo { get; set; }  

}

public class BranchAuthentication
{
    public string BranchName { get; set; }
    public string Password { get; set; }
}
