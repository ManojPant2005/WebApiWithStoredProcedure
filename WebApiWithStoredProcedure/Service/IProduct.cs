using WebApiWithStoredProcedure.Data.Entities;

namespace WebApiWithStoredProcedure.Service
{
    public interface IProduct
    {
        Task InsertProduct(Product product);    
        Task UpdateProduct(Product product);
        Task<IEnumerable<Product>> GetAllProducts();
        Task DeleteProduct(int id);
        Task<Product> GetProductById(int id);
    }
}
