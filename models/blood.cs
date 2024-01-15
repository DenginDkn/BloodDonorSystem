public class Blood
{
    public int BloodId { get; set; } 
    public string BloodType { get; set; }
    public int Quantity { get; set; }
    public string Town { get; internal set; }
    public string City { get; internal set; }
    public object Donor { get; internal set; }
    public string ContactEmail { get; set; }

}

