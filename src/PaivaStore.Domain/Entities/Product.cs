namespace PaivaStore.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double UnitValue { get; set; }
    public double Amount { get; set; }
}