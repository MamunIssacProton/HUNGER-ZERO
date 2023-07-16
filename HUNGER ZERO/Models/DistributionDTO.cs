namespace HUNGER_ZERO.Models
{
    public class DistributionDTO
    {
        public int Id { get; set; }
        public int CollectRequestId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DistributionTime { get; set; }
    }
}