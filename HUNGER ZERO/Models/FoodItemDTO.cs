namespace HUNGER_ZERO.Models
{
       public class FoodItemDTO
    {
        public int Id { get; set; }
        public int CollectRequestId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}