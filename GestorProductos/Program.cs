IProductoRepository repo = new ProductoRepository();

Console.WriteLine("Productos iniciales:");
MostrarProductos(repo.ObtenerTodos());

Console.WriteLine("\nProducto buscado por ID:");
Producto? productoPorId = repo.ObtenerPorId(2);

if (productoPorId is not null)
{
    MostrarProducto(productoPorId);
}
else
{
    Console.WriteLine("No se encontró un producto con ese ID.");
}

Console.WriteLine("\nProductos de la categoría Tecnología:");
List<Producto> productosTecnologia = repo.BuscarPorCategoria("Tecnología");
MostrarProductos(productosTecnologia);

repo.Agregar(new Producto
{
    Id = 5,
    Nombre = "Mouse",
    Precio = 25000m,
    Categoria = "Tecnología",
    Activo = true
});

Console.WriteLine("\nProductos después de agregar uno nuevo:");
MostrarProductos(repo.ObtenerTodos());

static void MostrarProductos(List<Producto> productos)
{
    foreach (Producto producto in productos)
    {
        MostrarProducto(producto);
    }
}

static void MostrarProducto(Producto producto)
{
    Console.WriteLine($"ID: {producto.Id} - Nombre: {producto.Nombre} - Precio: ${producto.Precio} - Categoría: {producto.Categoria} - Activo: {producto.Activo}");
}
