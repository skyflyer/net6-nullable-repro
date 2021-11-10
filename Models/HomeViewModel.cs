public class HomeViewModel
{
    public string Number { get; set; } = string.Empty;
    public IEnumerable<Asset> Assets { get; set; } = new List<Asset>();
}

public class Asset
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string InventoryNumber { get; set; } = string.Empty;
    public string RowVersion { get; set; } = string.Empty;
    public string Id { get; set; } = string.Empty;
}