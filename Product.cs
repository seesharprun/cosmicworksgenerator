namespace CosmicWorks.Generator;

public record Product(
    string id,
    string categoryId,
    string categoryName,
    string sku,
    string name,
    string description,
    double price,
    IReadOnlyList<Tag> tags
)
{
    public override string ToString() =>
        $"{id,-40}{name,-35}{categoryName,30}";
};