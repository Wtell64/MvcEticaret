namespace MvcEticaret.Models
{
	public class ProductItem
	{

        public string title { get; set; }
        public int startCount { get; set; }
        public int oldPrice { get; set; }
        public int price { get; set; }
        public string imageUrl { get; set; }
        public bool isSale { get; set; }
    }
}
