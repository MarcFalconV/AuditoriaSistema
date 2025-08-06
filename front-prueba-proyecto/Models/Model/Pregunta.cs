public class Pregunta
{
    public int IdPregunta { get; set; }
    public string Texto { get; set; }
    public Seccion Seccion { get; set; }
    public List<Item> Items { get; set; } = new List<Item>(); // Varios items por pregunta
}
