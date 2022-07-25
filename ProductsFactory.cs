namespace CosmicWorks.Generator;

public static class ProductsFactory
{
    public static IReadOnlyCollection<Product> Generate(int maxCount = Int32.MaxValue) =>
        new ProductCollection()
            .Take(maxCount)
            .ToList();
}