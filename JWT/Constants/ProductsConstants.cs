using JWT.Models;

namespace JWT.Constants
{
    public class ProductsConstants
    {
        public static List<ProductModel> Products = new List<ProductModel>()
        {
            new ProductModel() {name = "coca cola", descripcion = "muerte segura"},
            new ProductModel() {name = "fanta", descripcion = "diabetes segura"},
        };
    }
}
