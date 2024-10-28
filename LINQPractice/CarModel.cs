
// See https://aka.ms/new-console-template for more information

public class CarModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public long Amount { get; set; }

    public string Country { get; set; }
    public int CarType { get; set; }
}

public class CarType
{
    public int Id { get; set; }
    public string Name { get; set; }
}
