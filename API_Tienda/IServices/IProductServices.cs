using Entities;

namespace API_Tienda.IServices
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        List<Product> GetProductsByCriteria();
        int InsertProduct(Product product);
        Product DeleteProduct(List<Product> ProductList);
        void UpdateProduct(Product product);

    }
}
