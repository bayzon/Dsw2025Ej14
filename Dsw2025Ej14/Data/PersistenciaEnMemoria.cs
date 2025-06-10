using Dsw2025Ej14.Domain;
using System.Text.Json;

namespace Dsw2025Ej14.Data
{
    public class PersistenciaEnMemoria
    {
        public void LoadProducto()
        {
            var json = await File.ReadAllTextAsync("products.json");
            var products = JsonSerializer.Deserialize<List<Product>>(json);
        }
    }
}
