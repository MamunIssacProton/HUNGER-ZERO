namespace HUNGER_ZERO.Models
{
      public class CollectRequestDTO
    {
        public int RequestId { get; set; }
        public int RestaurantId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime RequestedTime { get; set; }
        public TimeSpan MaxPreservationTime { get; set; }
        public bool CompletionStatus { get; set; }
    }
}