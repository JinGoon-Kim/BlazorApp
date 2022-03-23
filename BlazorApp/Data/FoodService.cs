namespace BlazorApp.Data
{
    public class Food
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public interface IFoodService
    {
        IEnumerable<Food> GetFood();
    }

    public class FoodService : IFoodService
    {
        public IEnumerable<Food> GetFood()
        {
            List<Food> foods = new List<Food>()
            {
                new Food() { Name = "Bibimbap", Price = 7000 },
                new Food() { Name = "Kimbap", Price = 3000 },
                new Food() { Name = "Bossam", Price = 9000 }
            };

            return foods;
        }
    }

    public class FastFoodService : IFoodService
    {
        public IEnumerable<Food> GetFood()
        {
            List<Food> foods = new List<Food>()
            {
                new Food() { Name = "Hamberger", Price = 5000 },
                new Food() { Name = "Fired", Price = 2000 }
            };

            return foods;
        }
    }
}
