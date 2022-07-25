namespace Azure.Cosmos.CosmicWorks.Generator;

public record Product(
    string Id,
    string CategoryId,
    string CategoryName,
    string SKU,
    string Name,
    string Description,
    double Price,
    IReadOnlyList<Tag> Tags
)
{
    public override string ToString() =>
        $"{Id,-40}{Name,-35}{CategoryName,30}";
};