public interface IBloodRequestService
{
    Task<bool> ProcessBloodRequestAsync(BloodRequest request);
}