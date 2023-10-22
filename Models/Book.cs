namespace BookManagement.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price {  get; set; }
        public string UrlImage {  get; set; }
        public int Quantity {  get; set; }
        public string Category { get; set; }
    }
}
