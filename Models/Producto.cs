namespace WFATest.Models;

public class Producto(int argId, string argNombre, decimal argPrecio)
{
    public int Id { get; set; } = argId;
    public string Nombre { get; set; } = argNombre;
    public decimal Precio { get; set; } = argPrecio;
}