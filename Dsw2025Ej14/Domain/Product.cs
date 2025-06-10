namespace Dsw2025Ej14.Domain
{
    public class Product
    {
        public string sku { get ; set ; }
        public string name { get; set; }
        public decimal CurrentUnitPrice { get; set; }
        public bool IsActive { get; set; }
    }
}
