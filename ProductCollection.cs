namespace CosmicWorks.Generator;

internal class ProductCollection : IReadOnlyCollection<Product>
{
    public int Count
    {
        get => _data.Count;
    }

    public IEnumerator<Product> GetEnumerator() => _data.GetEnumerator();

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private readonly List<Product> _data = new()
    {
        new Product(
            id: "027D0B9A-F9D9-4C96-8213-C8546C4AAE71",
            categoryId: "26C74104-40BC-4541-8EF5-9892F7F03D72",
            categoryName: "Components, Saddles",
            sku: "SE-R581",
            name: "LL Road Seat/Saddle",
            description: "The product called \"LL Road Seat/Saddle\"",
            price: 27.12,
            tags: new List<Tag>
            {
                new Tag(
                    id: "0573D684-9140-4DEE-89AF-4E4A90E65666",
                    name: "Tag-113"
                ),
                new Tag(
                    id: "6C2F05C8-1E61-4912-BE1A-C67A378429BB",
                    name: "Tag-5"
                ),
                new Tag(
                    id: "B48D6572-67EB-4630-A1DB-AFD4AD7041C9",
                    name: "Tag-100"
                ),
                new Tag(
                    id: "D70F215D-A8AC-483A-9ABD-4A008D2B72B2",
                    name: "Tag-85"
                ),
                new Tag(
                    id: "DCF66D9A-E2BF-4C70-8AC1-AD55E5988E9D",
                    name: "Tag-37"
                )
            }
        ),
        new Product(
            id: "08225A9E-F2B3-4FA3-AB08-8C70ADD6C3C2",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T79U-50",
            name: "Touring-1000 Blue, 50",
            description: "The product called \"Touring-1000 Blue, 50\"",
            price: 2384.07,
            tags: new List<Tag>
            {
                new Tag(
                    id: "27B7F8D5-1009-45B8-88F5-41008A0F0393",
                    name: "Tag-61"
                )
            }
        ),
        new Product(
            id: "0A7E57DA-C73F-467F-954F-17B7AFD6227E",
            categoryId: "4F34E180-384D-42FC-AC10-FEC30227577F",
            categoryName: "Components, Pedals",
            sku: "PD-R563",
            name: "ML Road Pedal",
            description: "The product called \"ML Road Pedal\"",
            price: 62.09,
            tags: new List<Tag>
            {
                new Tag(
                    id: "14CFF1D6-7749-4A57-85B3-783F47731F32",
                    name: "Tag-7"
                ),
                new Tag(
                    id: "319E277F-6B7A-483D-81BA-1EC34CC700EB",
                    name: "Tag-163"
                )
            }
        ),
        new Product(
            id: "14174164-F6C0-47FC-83FB-604C6A63408D",
            categoryId: "006A1D51-28DA-4956-A7FB-C0B2BF6360CA",
            categoryName: "Accessories, Bottles and Cages",
            sku: "BC-M005",
            name: "Mountain Bottle Cage",
            description: "The product called \"Mountain Bottle Cage\"",
            price: 9.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "A49D83E4-E506-4301-8110-E114599B4A35",
                    name: "Tag-27"
                ),
                new Tag(
                    id: "CA7D17BB-45A6-47E6-A3E3-E70AF34C2072",
                    name: "Tag-158"
                ),
                new Tag(
                    id: "ECBBCC15-3016-4075-B084-4B49DA754814",
                    name: "Tag-138"
                )
            }
        ),
        new Product(
            id: "1A176FDB-D9A8-4888-BDD9-CE4F12E97AAE",
            categoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            categoryName: "Accessories, Tires and Tubes",
            sku: "TI-R982",
            name: "HL Road Tire",
            description: "The product called \"HL Road Tire\"",
            price: 32.6,
            tags: new List<Tag>
            {
                new Tag(
                    id: "51CD93BF-098C-4C25-9829-4AD42046D038",
                    name: "Tag-25"
                ),
                new Tag(
                    id: "5D24B427-1402-49DE-B79B-5A7013579FBC",
                    name: "Tag-76"
                ),
                new Tag(
                    id: "8AAFD985-8BCE-4FA8-85A2-2CA67D9DF8E6",
                    name: "Tag-172"
                ),
                new Tag(
                    id: "D4EC9C09-75F3-4ADD-A6EB-ACDD12C648FA",
                    name: "Tag-153"
                )
            }
        ),
        new Product(
            id: "201D0D79-81AD-43D2-AD6E-F09EEE6AC2D7",
            categoryId: "26C74104-40BC-4541-8EF5-9892F7F03D72",
            categoryName: "Components, Saddles",
            sku: "SE-M798",
            name: "ML Mountain Seat/Saddle",
            description: "The product called \"ML Mountain Seat/Saddle\"",
            price: 39.14,
            tags: new List<Tag>
            {
                new Tag(
                    id: "0917B02C-1EAB-4EBA-BA74-5E6D3C5CC96A",
                    name: "Tag-192"
                ),
                new Tag(
                    id: "0C184C69-F4F2-4774-9645-46F53D297D95",
                    name: "Tag-49"
                ),
                new Tag(
                    id: "3A3A99B6-E3BF-46D0-BAD9-F5F4DBB720F4",
                    name: "Tag-70"
                ),
                new Tag(
                    id: "DAC25651-3DD3-4483-8FD1-581DC41EF34B",
                    name: "Tag-56"
                )
            }
        ),
        new Product(
            id: "24BE4267-85D8-4C1A-B184-C08709495752",
            categoryId: "006A1D51-28DA-4956-A7FB-C0B2BF6360CA",
            categoryName: "Accessories, Bottles and Cages",
            sku: "BC-R205",
            name: "Road Bottle Cage",
            description: "The product called \"Road Bottle Cage\"",
            price: 8.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "45CBB7FF-FA48-49D8-89EF-F1D0B8AC3923",
                    name: "Tag-86"
                ),
                new Tag(
                    id: "9653F306-0B3C-4856-ABF8-13C3F04AE4F0",
                    name: "Tag-36"
                ),
                new Tag(
                    id: "A9834752-41CA-47F5-8A5A-D9A878DF0ACB",
                    name: "Tag-198"
                )
            }
        ),
        new Product(
            id: "290B4594-95BE-47C5-863A-4EFAAFC0AED7",
            categoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            categoryName: "Accessories, Tires and Tubes",
            sku: "TI-M602",
            name: "ML Mountain Tire",
            description: "The product called \"ML Mountain Tire\"",
            price: 29.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "0917B02C-1EAB-4EBA-BA74-5E6D3C5CC96A",
                    name: "Tag-192"
                ),
                new Tag(
                    id: "14D5A3F0-7B6D-4D2D-9D45-AC2E35F90298",
                    name: "Tag-166"
                ),
                new Tag(
                    id: "31BDDC90-386A-4EED-A588-751DA0587A0A",
                    name: "Tag-95"
                ),
                new Tag(
                    id: "59676183-1BD7-48A0-B3B0-42B3C0800EB0",
                    name: "Tag-64"
                ),
                new Tag(
                    id: "9C89E562-1247-435D-B786-4E54024E681C",
                    name: "Tag-128"
                )
            }
        ),
        new Product(
            id: "29663491-D2E9-47B4-83AE-D9459B6B5B67",
            categoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            categoryName: "Accessories, Tires and Tubes",
            sku: "TT-T092",
            name: "Touring Tire Tube",
            description: "The product called \"Touring Tire Tube\"",
            price: 4.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "14D5A3F0-7B6D-4D2D-9D45-AC2E35F90298",
                    name: "Tag-166"
                ),
                new Tag(
                    id: "539DF8CA-7DCD-43BC-9F4A-1F6657B61708",
                    name: "Tag-53"
                ),
                new Tag(
                    id: "74680691-FA4C-4721-9CB4-5846B7C3210A",
                    name: "Tag-103"
                ),
                new Tag(
                    id: "94F41BAD-B861-4BB0-A941-89677D04F455",
                    name: "Tag-26"
                )
            }
        ),
        new Product(
            id: "2C981511-AC73-4A65-9DA3-A0577E386394",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T79U-46",
            name: "Touring-1000 Blue, 46",
            description: "The product called \"Touring-1000 Blue, 46\"",
            price: 2384.07,
            tags: new List<Tag>
            {
                new Tag(
                    id: "4E102F3F-7D57-4CD7-88F4-AC5076A42C59",
                    name: "Tag-91"
                ),
                new Tag(
                    id: "52FCE975-91EE-4789-9E36-94EC766F02A0",
                    name: "Tag-35"
                ),
                new Tag(
                    id: "7B37373F-FC14-44FD-96AA-32F4854E0B6B",
                    name: "Tag-63"
                ),
                new Tag(
                    id: "83D720BA-BB31-4BE5-B723-8A836AB6D532",
                    name: "Tag-127"
                ),
                new Tag(
                    id: "DA661FCF-CC7F-4AF9-A9E2-8E7A5570844E",
                    name: "Tag-188"
                )
            }
        ),
        new Product(
            id: "3F105575-8677-42F9-8E1F-76E4B450F136",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T79Y-46",
            name: "Touring-1000 Yellow, 46",
            description: "The product called \"Touring-1000 Yellow, 46\"",
            price: 2384.07,
            tags: new List<Tag>
            {
                new Tag(
                    id: "84C396AD-98C6-4B12-8C3A-1BDA3ABF7D73",
                    name: "Tag-24"
                ),
                new Tag(
                    id: "B1C00DC4-236A-4A5F-844C-3F56BBE87968",
                    name: "Tag-167"
                )
            }
        ),
        new Product(
            id: "3FE1A99E-DE14-4D11-B635-F5D39258A0B9",
            categoryId: "26C74104-40BC-4541-8EF5-9892F7F03D72",
            categoryName: "Components, Saddles",
            sku: "SE-T924",
            name: "HL Touring Seat/Saddle",
            description: "The product called \"HL Touring Seat/Saddle\"",
            price: 52.64,
            tags: new List<Tag>
            {
                new Tag(
                    id: "125497D0-9175-4ECD-844D-DA71E5F4ED43",
                    name: "Tag-42"
                ),
                new Tag(
                    id: "762CE1E0-5615-418E-B476-BCD46AD5E79E",
                    name: "Tag-137"
                ),
                new Tag(
                    id: "A9834752-41CA-47F5-8A5A-D9A878DF0ACB",
                    name: "Tag-198"
                ),
                new Tag(
                    id: "D2427B7F-AF57-498B-A73E-E7D67FD5CFD9",
                    name: "Tag-195"
                ),
                new Tag(
                    id: "D4EC9C09-75F3-4ADD-A6EB-ACDD12C648FA",
                    name: "Tag-153"
                )
            }
        ),
        new Product(
            id: "44873725-7B3B-4B28-804D-963D2D62E761",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T79U-60",
            name: "Touring-1000 Blue, 60",
            description: "The product called \"Touring-1000 Blue, 60\"",
            price: 2384.07,
            tags: new List<Tag>
            {
                new Tag(
                    id: "033D3826-2851-4B97-9464-59D3675175D4",
                    name: "Tag-108"
                ),
                new Tag(
                    id: "511652EB-9EC2-4235-BA77-0C6E4E316679",
                    name: "Tag-199"
                ),
                new Tag(
                    id: "E6CB7972-06F4-47C0-B464-F64E695F89E7",
                    name: "Tag-51"
                )
            }
        ),
        new Product(
            id: "47C70E1E-E500-41B3-8615-DCCB963D9E35",
            categoryId: "AA28AE74-D57C-4B23-B5F7-F919E1C5844E",
            categoryName: "Clothing, Tights",
            sku: "TG-W091-S",
            name: "Women's Tights, S",
            description: "The product called \"Women's Tights, S\"",
            price: 74.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "488BD0F1-AABE-4FC5-BAF2-0B8A077CA3CF",
                    name: "Tag-147"
                ),
                new Tag(
                    id: "CAF27567-B4CB-463C-A54E-5EF1F2657DD2",
                    name: "Tag-75"
                )
            }
        ),
        new Product(
            id: "4B0848F8-7BF5-4DB9-84A7-C4D69F2E3E8E",
            categoryId: "34340561-3D26-4F33-B6AD-09260FC811D6",
            categoryName: "Components, Bottom Brackets",
            sku: "BB-7421",
            name: "LL Bottom Bracket",
            description: "The product called \"LL Bottom Bracket\"",
            price: 53.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "028057B8-8F03-4C18-B853-66510D354A72",
                    name: "Tag-57"
                ),
                new Tag(
                    id: "40525E23-C1FB-4213-BF28-2B4C64BDC29B",
                    name: "Tag-135"
                ),
                new Tag(
                    id: "A07D69D4-B8B9-4662-8148-8033DCDCC000",
                    name: "Tag-142"
                ),
                new Tag(
                    id: "E468DF53-4836-4546-9D05-C855AAC4B0AF",
                    name: "Tag-2"
                )
            }
        ),
        new Product(
            id: "4E4B38CB-0D82-43E5-89AF-20270CD28A04",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T44U-60",
            name: "Touring-2000 Blue, 60",
            description: "The product called \"Touring-2000 Blue, 60\"",
            price: 1214.85,
            tags: new List<Tag>
            {
                new Tag(
                    id: "89FB612A-F9AA-4196-B5F5-B9FA16D558DC",
                    name: "Tag-175"
                ),
                new Tag(
                    id: "A30014DE-B012-4049-B456-4630527AF47F",
                    name: "Tag-9"
                ),
                new Tag(
                    id: "B18FB652-C4B6-4A40-BA22-1E687C1A58CE",
                    name: "Tag-161"
                ),
                new Tag(
                    id: "C6AB3E24-BA48-40F0-A260-CB04EB03D5B0",
                    name: "Tag-73"
                )
            }
        ),
        new Product(
            id: "5089E32E-8A60-4117-AA98-5EF8AB9A61D1",
            categoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            categoryName: "Accessories, Tires and Tubes",
            sku: "TT-R982",
            name: "Road Tire Tube",
            description: "The product called \"Road Tire Tube\"",
            price: 3.99,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "52FAD88C-567E-469D-A35E-574EA3BF147F",
            categoryId: "4F34E180-384D-42FC-AC10-FEC30227577F",
            categoryName: "Components, Pedals",
            sku: "PD-M340",
            name: "ML Mountain Pedal",
            description: "The product called \"ML Mountain Pedal\"",
            price: 62.09,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "5308BAE7-B0CB-4883-9A93-192CB10DC94F",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T18U-44",
            name: "Touring-3000 Blue, 44",
            description: "The product called \"Touring-3000 Blue, 44\"",
            price: 742.35,
            tags: new List<Tag>
            {
                new Tag(
                    id: "A37349FB-4A1C-4382-A845-DF81830A7B4D",
                    name: "Tag-150"
                )
            }
        ),
        new Product(
            id: "5996B5E0-6EC7-4CB7-A924-7B5A053AE980",
            categoryId: "26C74104-40BC-4541-8EF5-9892F7F03D72",
            categoryName: "Components, Saddles",
            sku: "SE-M236",
            name: "LL Mountain Seat/Saddle",
            description: "The product called \"LL Mountain Seat/Saddle\"",
            price: 27.12,
            tags: new List<Tag>
            {
                new Tag(
                    id: "5D24B427-1402-49DE-B79B-5A7013579FBC",
                    name: "Tag-76"
                ),
                new Tag(
                    id: "79E61D0F-3C95-4353-BF27-DB04535088C9",
                    name: "Tag-50"
                ),
                new Tag(
                    id: "BEBD68EF-901A-4282-911F-28AB44B802FE",
                    name: "Tag-139"
                ),
                new Tag(
                    id: "E468DF53-4836-4546-9D05-C855AAC4B0AF",
                    name: "Tag-2"
                )
            }
        ),
        new Product(
            id: "5B5E90B8-FEA2-4D6C-B728-EC586656FA6D",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T79Y-60",
            name: "Touring-1000 Yellow, 60",
            description: "The product called \"Touring-1000 Yellow, 60\"",
            price: 2384.07,
            tags: new List<Tag>
            {
                new Tag(
                    id: "4F67013C-3B5E-4A3D-B4B0-8C597A491EB6",
                    name: "Tag-82"
                ),
                new Tag(
                    id: "6C6D061E-F701-41DC-AEA2-7A5C28061840",
                    name: "Tag-98"
                )
            }
        ),
        new Product(
            id: "5BFADECD-2240-4480-9485-1256D1D60EA8",
            categoryId: "32A9A8E6-7004-4B24-9C2A-BB3E93B9E6BD",
            categoryName: "Clothing, Gloves",
            sku: "GL-F110-S",
            name: "Full-Finger Gloves, S",
            description: "The product called \"Full-Finger Gloves, S\"",
            price: 37.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "84C396AD-98C6-4B12-8C3A-1BDA3ABF7D73",
                    name: "Tag-24"
                )
            }
        ),
        new Product(
            id: "6E3AA511-67DF-4EAD-8F0C-4C9F91F7D335",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T18Y-50",
            name: "Touring-3000 Yellow, 50",
            description: "The product called \"Touring-3000 Yellow, 50\"",
            price: 742.35,
            tags: new List<Tag>
            {
                new Tag(
                    id: "2E7252D2-B646-47FB-B5BB-836643578038",
                    name: "Tag-130"
                )
            }
        ),
        new Product(
            id: "6FB5B2D5-5725-4998-9B6C-2FF2B7A3E3E0",
            categoryId: "32A9A8E6-7004-4B24-9C2A-BB3E93B9E6BD",
            categoryName: "Clothing, Gloves",
            sku: "GL-H102-M",
            name: "Half-Finger Gloves, M",
            description: "The product called \"Half-Finger Gloves, M\"",
            price: 24.49,
            tags: new List<Tag>
            {
                new Tag(
                    id: "12A06E6F-45BF-42DF-9641-F1376CDDB7B1",
                    name: "Tag-22"
                ),
                new Tag(
                    id: "8DC9DFB4-1946-427A-A0A0-E06E1448CC63",
                    name: "Tag-171"
                ),
                new Tag(
                    id: "C1CB0EFE-02BB-4AE5-AA48-3DAC12921450",
                    name: "Tag-109"
                )
            }
        ),
        new Product(
            id: "71BDFE67-6499-4A8E-9CCA-9E9AF7D92A7A",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T18U-54",
            name: "Touring-3000 Blue, 54",
            description: "The product called \"Touring-3000 Blue, 54\"",
            price: 742.35,
            tags: new List<Tag>
            {
                new Tag(
                    id: "5D24B427-1402-49DE-B79B-5A7013579FBC",
                    name: "Tag-76"
                ),
                new Tag(
                    id: "66D8EA21-E1F0-471C-A17F-02F3B149D6E6",
                    name: "Tag-83"
                ),
                new Tag(
                    id: "6FB11EB9-319C-431C-89D7-70113401D186",
                    name: "Tag-154"
                )
            }
        ),
        new Product(
            id: "7BAA49C9-21B5-4EEF-9F6B-BCD6DA7C2239",
            categoryId: "26C74104-40BC-4541-8EF5-9892F7F03D72",
            categoryName: "Components, Saddles",
            sku: "SE-R995",
            name: "HL Road Seat/Saddle",
            description: "The product called \"HL Road Seat/Saddle\"",
            price: 52.64,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "7EA0EEEB-824E-42E9-B787-019219CE4466",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T79U-54",
            name: "Touring-1000 Blue, 54",
            description: "The product called \"Touring-1000 Blue, 54\"",
            price: 2384.07,
            tags: new List<Tag>
            {
                new Tag(
                    id: "23ECB896-D6C6-4E9D-BE43-1908CB5C5E07",
                    name: "Tag-112"
                ),
                new Tag(
                    id: "A9834752-41CA-47F5-8A5A-D9A878DF0ACB",
                    name: "Tag-198"
                ),
                new Tag(
                    id: "D5887E7C-B916-4AF4-BAF8-7B996ADA8C83",
                    name: "Tag-52"
                ),
                new Tag(
                    id: "E1A62ABF-BBC3-48A2-BAC6-E3350D023C83",
                    name: "Tag-194"
                )
            }
        ),
        new Product(
            id: "80D3630F-B661-4FD6-A296-CD03BB7A4A0C",
            categoryId: "629A8F3C-CFB0-4347-8DCC-505A4789876B",
            categoryName: "Clothing, Vests",
            sku: "VE-C304-L",
            name: "Classic Vest, L",
            description: "The product called \"Classic Vest, L\"",
            price: 63.5,
            tags: new List<Tag>
            {
                new Tag(
                    id: "2CE9DADE-DCAC-436C-9D69-B7C886A01B77",
                    name: "Tag-101"
                ),
                new Tag(
                    id: "CA170AAD-A5F6-42FF-B115-146FADD87298",
                    name: "Tag-186"
                )
            }
        ),
        new Product(
            id: "866F8033-A439-42D9-99EE-178C1285F13E",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T18Y-44",
            name: "Touring-3000 Yellow, 44",
            description: "The product called \"Touring-3000 Yellow, 44\"",
            price: 742.35,
            tags: new List<Tag>
            {
                new Tag(
                    id: "31BDDC90-386A-4EED-A588-751DA0587A0A",
                    name: "Tag-95"
                ),
                new Tag(
                    id: "A2AFF2FF-8438-44A3-8AC6-20A50422D82A",
                    name: "Tag-18"
                ),
                new Tag(
                    id: "AA24EC37-7CE3-4ABE-B935-EC62D5FB6947",
                    name: "Tag-148"
                ),
                new Tag(
                    id: "DB21A27B-5A3F-400C-A0DF-69A5266E1447",
                    name: "Tag-34"
                ),
                new Tag(
                    id: "F202FBC3-B5AA-4E0F-950B-2B5715AC0B3B",
                    name: "Tag-173"
                )
            }
        ),
        new Product(
            id: "906A453F-2B5E-469A-87B5-FFA531EE615D",
            categoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            categoryName: "Accessories, Tires and Tubes",
            sku: "PK-7098",
            name: "Patch Kit/8 Patches",
            description: "The product called \"Patch Kit/8 Patches\"",
            price: 2.29,
            tags: new List<Tag>
            {
                new Tag(
                    id: "DBC21C2A-0AF6-45D4-B2C9-703DD708A821",
                    name: "Tag-14"
                )
            }
        ),
        new Product(
            id: "9190229B-1372-4997-8F64-5B3E7A2459C5",
            categoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            categoryName: "Accessories, Tires and Tubes",
            sku: "TT-M928",
            name: "Mountain Tire Tube",
            description: "The product called \"Mountain Tire Tube\"",
            price: 4.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "66D8EA21-E1F0-471C-A17F-02F3B149D6E6",
                    name: "Tag-83"
                ),
                new Tag(
                    id: "6FB11EB9-319C-431C-89D7-70113401D186",
                    name: "Tag-154"
                ),
                new Tag(
                    id: "8AAFD985-8BCE-4FA8-85A2-2CA67D9DF8E6",
                    name: "Tag-172"
                ),
                new Tag(
                    id: "A4D9E596-B630-4792-BDD1-7D6459827820",
                    name: "Tag-164"
                )
            }
        ),
        new Product(
            id: "94265B3D-7718-47F0-ADF7-64DEE36CAC41",
            categoryId: "629A8F3C-CFB0-4347-8DCC-505A4789876B",
            categoryName: "Clothing, Vests",
            sku: "VE-C304-S",
            name: "Classic Vest, S",
            description: "The product called \"Classic Vest, S\"",
            price: 63.5,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "967155B3-9925-4FA3-84B0-B24CDA101C1B",
            categoryId: "629A8F3C-CFB0-4347-8DCC-505A4789876B",
            categoryName: "Clothing, Vests",
            sku: "VE-C304-M",
            name: "Classic Vest, M",
            description: "The product called \"Classic Vest, M\"",
            price: 63.5,
            tags: new List<Tag>
            {
                new Tag(
                    id: "3798DC56-04BE-4A82-B70B-6A0DC7714A36",
                    name: "Tag-105"
                ),
                new Tag(
                    id: "403AE98F-892E-4FEC-B262-A264CF1F52A9",
                    name: "Tag-45"
                ),
                new Tag(
                    id: "A49D83E4-E506-4301-8110-E114599B4A35",
                    name: "Tag-27"
                )
            }
        ),
        new Product(
            id: "98324A24-9D56-4662-93A5-9A7370E7EE5A",
            categoryId: "26C74104-40BC-4541-8EF5-9892F7F03D72",
            categoryName: "Components, Saddles",
            sku: "SE-T762",
            name: "ML Touring Seat/Saddle",
            description: "The product called \"ML Touring Seat/Saddle\"",
            price: 39.14,
            tags: new List<Tag>
            {
                new Tag(
                    id: "2400025E-FB22-4031-B4A2-9C3BD1402A9B",
                    name: "Tag-38"
                ),
                new Tag(
                    id: "537DB3C8-8636-4005-8FE2-32EECEBA5B3F",
                    name: "Tag-80"
                ),
                new Tag(
                    id: "F287FE0A-712B-4B52-925F-5047B34F3610",
                    name: "Tag-197"
                )
            }
        ),
        new Product(
            id: "9851FE19-CCA4-4B94-B6AC-CCE579D7F693",
            categoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            categoryName: "Accessories, Tires and Tubes",
            sku: "TI-M823",
            name: "HL Mountain Tire",
            description: "The product called \"HL Mountain Tire\"",
            price: 35.0,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "987E39AC-6C62-4717-9929-E9BDFF9902ED",
            categoryId: "34340561-3D26-4F33-B6AD-09260FC811D6",
            categoryName: "Components, Bottom Brackets",
            sku: "BB-8107",
            name: "ML Bottom Bracket",
            description: "The product called \"ML Bottom Bracket\"",
            price: 101.24,
            tags: new List<Tag>
            {
                new Tag(
                    id: "9467BA7B-49FB-4AA5-A868-478D94AF2E54",
                    name: "Tag-92"
                )
            }
        ),
        new Product(
            id: "9E6692D7-57E1-4D35-ACD8-105D44A1073B",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T18U-58",
            name: "Touring-3000 Blue, 58",
            description: "The product called \"Touring-3000 Blue, 58\"",
            price: 742.35,
            tags: new List<Tag>
            {
                new Tag(
                    id: "18AC309F-F81C-4234-A752-5DDD2BEAEE83",
                    name: "Tag-32"
                ),
                new Tag(
                    id: "F132E7B8-65B1-471E-8D3E-5E8D7110CA48",
                    name: "Tag-118"
                )
            }
        ),
        new Product(
            id: "9FCA9658-8506-4268-8539-DBAA65C51F41",
            categoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            categoryName: "Accessories, Tires and Tubes",
            sku: "TI-T723",
            name: "Touring Tire",
            description: "The product called \"Touring Tire\"",
            price: 28.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "8BAC6191-1DAE-4F5B-88FC-7081B682095D",
                    name: "Tag-15"
                ),
                new Tag(
                    id: "DBC84212-C3E9-4966-8619-9A4D64EBF517",
                    name: "Tag-125"
                ),
                new Tag(
                    id: "E1A62ABF-BBC3-48A2-BAC6-E3350D023C83",
                    name: "Tag-194"
                ),
                new Tag(
                    id: "F59DC0A2-537E-4A8F-A97D-19C82074D3E7",
                    name: "Tag-146"
                )
            }
        ),
        new Product(
            id: "A042C88C-B060-4A64-B314-ED92124047E5",
            categoryId: "4F34E180-384D-42FC-AC10-FEC30227577F",
            categoryName: "Components, Pedals",
            sku: "PD-R853",
            name: "HL Road Pedal",
            description: "The product called \"HL Road Pedal\"",
            price: 80.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "1B387A00-57D3-4444-8331-18A90725E98B",
                    name: "Tag-43"
                ),
                new Tag(
                    id: "1CFF105D-294E-4E2D-ADE4-0615CBDEBC28",
                    name: "Tag-44"
                ),
                new Tag(
                    id: "40525E23-C1FB-4213-BF28-2B4C64BDC29B",
                    name: "Tag-135"
                ),
                new Tag(
                    id: "59676183-1BD7-48A0-B3B0-42B3C0800EB0",
                    name: "Tag-64"
                ),
                new Tag(
                    id: "89500F13-B516-4F77-8128-47FC412BEFCD",
                    name: "Tag-151"
                )
            }
        ),
        new Product(
            id: "A13C5B23-34DF-41C7-849C-0BA623BEFE02",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T79Y-50",
            name: "Touring-1000 Yellow, 50",
            description: "The product called \"Touring-1000 Yellow, 50\"",
            price: 2384.07,
            tags: new List<Tag>
            {
                new Tag(
                    id: "52FCE975-91EE-4789-9E36-94EC766F02A0",
                    name: "Tag-35"
                ),
                new Tag(
                    id: "AEFA79EF-CBF1-4824-AAF7-1D20EA85119B",
                    name: "Tag-17"
                ),
                new Tag(
                    id: "BE894A90-F425-4BE3-B9DF-56525DD54F62",
                    name: "Tag-62"
                ),
                new Tag(
                    id: "D5887E7C-B916-4AF4-BAF8-7B996ADA8C83",
                    name: "Tag-52"
                ),
                new Tag(
                    id: "DBC21C2A-0AF6-45D4-B2C9-703DD708A821",
                    name: "Tag-14"
                )
            }
        ),
        new Product(
            id: "A6BB4603-7CD5-43DC-920A-2A2F55D52492",
            categoryId: "AB952F9F-5ABA-4251-BC2D-AFF8DF412A4A",
            categoryName: "Components, Headsets",
            sku: "HS-2451",
            name: "ML Headset",
            description: "The product called \"ML Headset\"",
            price: 102.29,
            tags: new List<Tag>
            {
                new Tag(
                    id: "A34D34F7-3286-4FA4-B4B0-5E61CCEEE197",
                    name: "Tag-4"
                ),
                new Tag(
                    id: "BA4D7ABD-2E82-4DC2-ACF2-5D3B0DEAE1C1",
                    name: "Tag-59"
                ),
                new Tag(
                    id: "D69B1B6C-4963-4E85-8FA5-6A3E1CD1C83B",
                    name: "Tag-187"
                )
            }
        ),
        new Product(
            id: "A875BC33-C4AC-4D2B-B018-9FF4672A2BB9",
            categoryId: "32A9A8E6-7004-4B24-9C2A-BB3E93B9E6BD",
            categoryName: "Clothing, Gloves",
            sku: "GL-H102-L",
            name: "Half-Finger Gloves, L",
            description: "The product called \"Half-Finger Gloves, L\"",
            price: 24.49,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "A9EFB9E2-8859-4401-B8A6-F7E2D5264FEE",
            categoryId: "AA28AE74-D57C-4B23-B5F7-F919E1C5844E",
            categoryName: "Clothing, Tights",
            sku: "TG-W091-M",
            name: "Women's Tights, M",
            description: "The product called \"Women's Tights, M\"",
            price: 74.99,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "ABB81D0E-4744-44EC-8AAB-FB3962FD2AF7",
            categoryId: "32A9A8E6-7004-4B24-9C2A-BB3E93B9E6BD",
            categoryName: "Clothing, Gloves",
            sku: "GL-F110-L",
            name: "Full-Finger Gloves, L",
            description: "The product called \"Full-Finger Gloves, L\"",
            price: 37.99,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "ABDE32DD-FADD-4042-9278-0440B7B2F3E0",
            categoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            categoryName: "Accessories, Tires and Tubes",
            sku: "TI-M267",
            name: "LL Mountain Tire",
            description: "The product called \"LL Mountain Tire\"",
            price: 24.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "A34D34F7-3286-4FA4-B4B0-5E61CCEEE197",
                    name: "Tag-4"
                ),
                new Tag(
                    id: "B49C6195-5ABA-42FA-B15C-84CF9FE252FE",
                    name: "Tag-129"
                ),
                new Tag(
                    id: "BF28390C-CBBE-48FC-8EBF-1BD7E6608E59",
                    name: "Tag-193"
                ),
                new Tag(
                    id: "E6CB7972-06F4-47C0-B464-F64E695F89E7",
                    name: "Tag-51"
                ),
                new Tag(
                    id: "F287FE0A-712B-4B52-925F-5047B34F3610",
                    name: "Tag-197"
                )
            }
        ),
        new Product(
            id: "ACC683CB-6199-416E-AE64-7C10D0C72CF9",
            categoryId: "4F34E180-384D-42FC-AC10-FEC30227577F",
            categoryName: "Components, Pedals",
            sku: "PD-M562",
            name: "HL Mountain Pedal",
            description: "The product called \"HL Mountain Pedal\"",
            price: 80.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "66D8EA21-E1F0-471C-A17F-02F3B149D6E6",
                    name: "Tag-83"
                ),
                new Tag(
                    id: "6FB11EB9-319C-431C-89D7-70113401D186",
                    name: "Tag-154"
                ),
                new Tag(
                    id: "7CACE200-11A3-4E2D-A88E-25E9614D2BE9",
                    name: "Tag-97"
                ),
                new Tag(
                    id: "B1EBD7E0-BBE0-4AFB-AC6C-50649484780B",
                    name: "Tag-40"
                )
            }
        ),
        new Product(
            id: "AFED4FD0-17D1-4CD5-8639-13F15B043EC2",
            categoryId: "006A1D51-28DA-4956-A7FB-C0B2BF6360CA",
            categoryName: "Accessories, Bottles and Cages",
            sku: "WB-H098",
            name: "Water Bottle - 30 oz.",
            description: "The product called \"Water Bottle - 30 oz.\"",
            price: 4.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "319E277F-6B7A-483D-81BA-1EC34CC700EB",
                    name: "Tag-163"
                ),
                new Tag(
                    id: "79E61D0F-3C95-4353-BF27-DB04535088C9",
                    name: "Tag-50"
                ),
                new Tag(
                    id: "A2176C7A-4E0D-4283-AFAA-319A77E9C122",
                    name: "Tag-19"
                )
            }
        ),
        new Product(
            id: "B267655B-A7C1-41E3-9682-21730E93FCB5",
            categoryId: "AA28AE74-D57C-4B23-B5F7-F919E1C5844E",
            categoryName: "Clothing, Tights",
            sku: "TG-W091-L",
            name: "Women's Tights, L",
            description: "The product called \"Women's Tights, L\"",
            price: 74.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "9C89E562-1247-435D-B786-4E54024E681C",
                    name: "Tag-128"
                )
            }
        ),
        new Product(
            id: "B2AC17CB-A69E-462E-B72A-917CB544FF81",
            categoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            categoryName: "Accessories, Tires and Tubes",
            sku: "TI-R628",
            name: "ML Road Tire",
            description: "The product called \"ML Road Tire\"",
            price: 24.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "0BC579CA-03FC-4AA6-85AA-A55035201E43",
                    name: "Tag-21"
                ),
                new Tag(
                    id: "4E85E551-E511-4666-BD21-E171C33A7880",
                    name: "Tag-3"
                ),
                new Tag(
                    id: "7F518FB1-4664-4B20-9B9F-23D5B44F6798",
                    name: "Tag-69"
                )
            }
        ),
        new Product(
            id: "B35B87F4-5ADE-4ED4-9469-DF024AC4195D",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T18Y-58",
            name: "Touring-3000 Yellow, 58",
            description: "The product called \"Touring-3000 Yellow, 58\"",
            price: 742.35,
            tags: new List<Tag>
            {
                new Tag(
                    id: "511652EB-9EC2-4235-BA77-0C6E4E316679",
                    name: "Tag-199"
                ),
                new Tag(
                    id: "7F518FB1-4664-4B20-9B9F-23D5B44F6798",
                    name: "Tag-69"
                ),
                new Tag(
                    id: "BEBD68EF-901A-4282-911F-28AB44B802FE",
                    name: "Tag-139"
                ),
                new Tag(
                    id: "C1CB0EFE-02BB-4AE5-AA48-3DAC12921450",
                    name: "Tag-109"
                ),
                new Tag(
                    id: "DBC84212-C3E9-4966-8619-9A4D64EBF517",
                    name: "Tag-125"
                )
            }
        ),
        new Product(
            id: "BCD77A3D-9FF1-4CE4-9327-4C2A41BA9F0F",
            categoryId: "4F34E180-384D-42FC-AC10-FEC30227577F",
            categoryName: "Components, Pedals",
            sku: "PD-T852",
            name: "Touring Pedal",
            description: "The product called \"Touring Pedal\"",
            price: 80.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "72E191A8-F404-48AE-B8BC-2511569C895C",
                    name: "Tag-168"
                ),
                new Tag(
                    id: "BA4D7ABD-2E82-4DC2-ACF2-5D3B0DEAE1C1",
                    name: "Tag-59"
                ),
                new Tag(
                    id: "DBC21C2A-0AF6-45D4-B2C9-703DD708A821",
                    name: "Tag-14"
                )
            }
        ),
        new Product(
            id: "BD340F0A-F661-4ED8-B36F-FBA7623605D9",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T18U-62",
            name: "Touring-3000 Blue, 62",
            description: "The product called \"Touring-3000 Blue, 62\"",
            price: 742.35,
            tags: new List<Tag>
            {
                new Tag(
                    id: "6C2F05C8-1E61-4912-BE1A-C67A378429BB",
                    name: "Tag-5"
                ),
                new Tag(
                    id: "74680691-FA4C-4721-9CB4-5846B7C3210A",
                    name: "Tag-103"
                ),
                new Tag(
                    id: "764C1CC8-2E5F-4EF5-83F6-8FF7441290B3",
                    name: "Tag-190"
                )
            }
        ),
        new Product(
            id: "BF381234-799A-4B1A-BD4B-B55891CC5907",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T44U-50",
            name: "Touring-2000 Blue, 50",
            description: "The product called \"Touring-2000 Blue, 50\"",
            price: 1214.85,
            tags: new List<Tag>
            {
                new Tag(
                    id: "7990C336-92BD-41F9-8FB6-97390BC4D187",
                    name: "Tag-189"
                )
            }
        ),
        new Product(
            id: "DA96F0D0-84C7-42C3-BE74-FEB39BD60EF5",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T18Y-62",
            name: "Touring-3000 Yellow, 62",
            description: "The product called \"Touring-3000 Yellow, 62\"",
            price: 742.35,
            tags: new List<Tag>
            {
                new Tag(
                    id: "A4D9E596-B630-4792-BDD1-7D6459827820",
                    name: "Tag-164"
                )
            }
        ),
        new Product(
            id: "DB89A887-43E3-4D9C-8783-7F034ACD88C0",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T18Y-54",
            name: "Touring-3000 Yellow, 54",
            description: "The product called \"Touring-3000 Yellow, 54\"",
            price: 742.35,
            tags: new List<Tag>
            {
                new Tag(
                    id: "3C26DF5C-CE21-4EF6-AEE2-E8E1066D06B1",
                    name: "Tag-60"
                ),
                new Tag(
                    id: "765EF7D7-331C-42C0-BF23-A3022A723BF7",
                    name: "Tag-191"
                ),
                new Tag(
                    id: "812C1444-1DEA-480D-88E7-B9609ECA783C",
                    name: "Tag-136"
                ),
                new Tag(
                    id: "A37349FB-4A1C-4382-A845-DF81830A7B4D",
                    name: "Tag-150"
                ),
                new Tag(
                    id: "A49D83E4-E506-4301-8110-E114599B4A35",
                    name: "Tag-27"
                )
            }
        ),
        new Product(
            id: "DC8209E8-151E-425C-B7D9-7F082B66E39D",
            categoryId: "26C74104-40BC-4541-8EF5-9892F7F03D72",
            categoryName: "Components, Saddles",
            sku: "SE-M940",
            name: "HL Mountain Seat/Saddle",
            description: "The product called \"HL Mountain Seat/Saddle\"",
            price: 52.64,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "DDD64AA0-30DC-4DC1-BCDC-2882A0FD178C",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T18U-50",
            name: "Touring-3000 Blue, 50",
            description: "The product called \"Touring-3000 Blue, 50\"",
            price: 742.35,
            tags: new List<Tag>
            {
                new Tag(
                    id: "0BC579CA-03FC-4AA6-85AA-A55035201E43",
                    name: "Tag-21"
                ),
                new Tag(
                    id: "304041C4-8C80-4C1E-9EE9-8A1DEFCF39FC",
                    name: "Tag-72"
                ),
                new Tag(
                    id: "3A3A99B6-E3BF-46D0-BAD9-F5F4DBB720F4",
                    name: "Tag-70"
                ),
                new Tag(
                    id: "F287FE0A-712B-4B52-925F-5047B34F3610",
                    name: "Tag-197"
                )
            }
        ),
        new Product(
            id: "DE8C032F-472A-4FFE-A8AE-4C7FFAF06DA8",
            categoryId: "34340561-3D26-4F33-B6AD-09260FC811D6",
            categoryName: "Components, Bottom Brackets",
            sku: "BB-9108",
            name: "HL Bottom Bracket",
            description: "The product called \"HL Bottom Bracket\"",
            price: 121.49,
            tags: new List<Tag>
            {
                new Tag(
                    id: "51CD93BF-098C-4C25-9829-4AD42046D038",
                    name: "Tag-25"
                ),
                new Tag(
                    id: "8AAFD985-8BCE-4FA8-85A2-2CA67D9DF8E6",
                    name: "Tag-172"
                ),
                new Tag(
                    id: "9467BA7B-49FB-4AA5-A868-478D94AF2E54",
                    name: "Tag-92"
                ),
                new Tag(
                    id: "F6B1A09C-BCC9-4A74-8472-D1CA98310501",
                    name: "Tag-185"
                )
            }
        ),
        new Product(
            id: "E08E4507-9666-411B-AAC4-519C00596B0A",
            categoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            categoryName: "Accessories, Tires and Tubes",
            sku: "TI-R092",
            name: "LL Road Tire",
            description: "The product called \"LL Road Tire\"",
            price: 21.49,
            tags: new List<Tag>
            {
                new Tag(
                    id: "567D183B-9ED1-47B4-AE22-80C52BF41067",
                    name: "Tag-165"
                ),
                new Tag(
                    id: "DBC84212-C3E9-4966-8619-9A4D64EBF517",
                    name: "Tag-125"
                )
            }
        ),
        new Product(
            id: "E60D6D23-0151-4B7E-BC56-598B9FEE026B",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T79Y-54",
            name: "Touring-1000 Yellow, 54",
            description: "The product called \"Touring-1000 Yellow, 54\"",
            price: 2384.07,
            tags: new List<Tag>
            {
                new Tag(
                    id: "A2AFF2FF-8438-44A3-8AC6-20A50422D82A",
                    name: "Tag-18"
                )
            }
        ),
        new Product(
            id: "E78CEEF9-A87B-4612-8BD3-4E5DC8AC4700",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T44U-54",
            name: "Touring-2000 Blue, 54",
            description: "The product called \"Touring-2000 Blue, 54\"",
            price: 1214.85,
            tags: new List<Tag>
            {
                new Tag(
                    id: "2400025E-FB22-4031-B4A2-9C3BD1402A9B",
                    name: "Tag-38"
                ),
                new Tag(
                    id: "BF28390C-CBBE-48FC-8EBF-1BD7E6608E59",
                    name: "Tag-193"
                )
            }
        ),
        new Product(
            id: "EDCB55C5-4CF5-424F-9083-310F940879FA",
            categoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            categoryName: "Bikes, Touring Bikes",
            sku: "BK-T44U-46",
            name: "Touring-2000 Blue, 46",
            description: "The product called \"Touring-2000 Blue, 46\"",
            price: 1214.85,
            tags: new List<Tag>
            {
                new Tag(
                    id: "01078B1D-5267-4B35-82B8-57042AA9CABB",
                    name: "Tag-84"
                ),
                new Tag(
                    id: "BF28390C-CBBE-48FC-8EBF-1BD7E6608E59",
                    name: "Tag-193"
                ),
                new Tag(
                    id: "EBDBD608-416A-4FE2-96DF-02367C8D071E",
                    name: "Tag-102"
                )
            }
        ),
        new Product(
            id: "EF16A6FA-9BE2-4AF9-872A-299A9EA88D5F",
            categoryId: "32A9A8E6-7004-4B24-9C2A-BB3E93B9E6BD",
            categoryName: "Clothing, Gloves",
            sku: "GL-F110-M",
            name: "Full-Finger Gloves, M",
            description: "The product called \"Full-Finger Gloves, M\"",
            price: 37.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "94C05E5C-13B7-41DA-89DF-98C11195AE1E",
                    name: "Tag-79"
                ),
                new Tag(
                    id: "AA24EC37-7CE3-4ABE-B935-EC62D5FB6947",
                    name: "Tag-148"
                ),
                new Tag(
                    id: "BEBD68EF-901A-4282-911F-28AB44B802FE",
                    name: "Tag-139"
                ),
                new Tag(
                    id: "D2427B7F-AF57-498B-A73E-E7D67FD5CFD9",
                    name: "Tag-195"
                )
            }
        ),
        new Product(
            id: "F07F8C10-4820-4C80-AAE2-1DDEC41E5A29",
            categoryId: "AB952F9F-5ABA-4251-BC2D-AFF8DF412A4A",
            categoryName: "Components, Headsets",
            sku: "HS-3479",
            name: "HL Headset",
            description: "The product called \"HL Headset\"",
            price: 124.73,
            tags: new List<Tag>
            {
                new Tag(
                    id: "87BC6842-2CCA-4CD3-994C-33AB101455F4",
                    name: "Tag-12"
                ),
                new Tag(
                    id: "F07885AF-BD6C-4B71-88B1-F04295992176",
                    name: "Tag-149"
                )
            }
        ),
        new Product(
            id: "F32990D7-F8E4-4ACD-AA8C-1F03D8299DE7",
            categoryId: "4F34E180-384D-42FC-AC10-FEC30227577F",
            categoryName: "Components, Pedals",
            sku: "PD-M282",
            name: "LL Mountain Pedal",
            description: "The product called \"LL Mountain Pedal\"",
            price: 40.49,
            tags: new List<Tag>
            {
                new Tag(
                    id: "762CE1E0-5615-418E-B476-BCD46AD5E79E",
                    name: "Tag-137"
                )
            }
        ),
        new Product(
            id: "F6628734-A209-46A2-9010-0F19E7D3F3D3",
            categoryId: "26C74104-40BC-4541-8EF5-9892F7F03D72",
            categoryName: "Components, Saddles",
            sku: "SE-R908",
            name: "ML Road Seat/Saddle",
            description: "The product called \"ML Road Seat/Saddle\"",
            price: 39.14,
            tags: new List<Tag>
            {
                new Tag(
                    id: "29CBEDD8-D9C3-43A3-B20F-63224FEE0D34",
                    name: "Tag-11"
                ),
                new Tag(
                    id: "31BDDC90-386A-4EED-A588-751DA0587A0A",
                    name: "Tag-95"
                ),
                new Tag(
                    id: "511652EB-9EC2-4235-BA77-0C6E4E316679",
                    name: "Tag-199"
                ),
                new Tag(
                    id: "52FCE975-91EE-4789-9E36-94EC766F02A0",
                    name: "Tag-35"
                ),
                new Tag(
                    id: "CF3C6F6C-8038-4FAD-A07A-E1AD1C34DE22",
                    name: "Tag-77"
                )
            }
        ),
        new Product(
            id: "F7261436-B748-42D6-A7C9-ACD2B589F0B7",
            categoryId: "32A9A8E6-7004-4B24-9C2A-BB3E93B9E6BD",
            categoryName: "Clothing, Gloves",
            sku: "GL-H102-S",
            name: "Half-Finger Gloves, S",
            description: "The product called \"Half-Finger Gloves, S\"",
            price: 24.49,
            tags: new List<Tag>
            {
                new Tag(
                    id: "033D3826-2851-4B97-9464-59D3675175D4",
                    name: "Tag-108"
                ),
                new Tag(
                    id: "3A3A99B6-E3BF-46D0-BAD9-F5F4DBB720F4",
                    name: "Tag-70"
                )
            }
        ),
        new Product(
            id: "FB118699-4C89-493B-B0AB-DA517935773E",
            categoryId: "26C74104-40BC-4541-8EF5-9892F7F03D72",
            categoryName: "Components, Saddles",
            sku: "SE-T312",
            name: "LL Touring Seat/Saddle",
            description: "The product called \"LL Touring Seat/Saddle\"",
            price: 27.12,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "FC0B659C-C1EF-41F3-AFE2-F87C7F43AD48",
            categoryId: "AB952F9F-5ABA-4251-BC2D-AFF8DF412A4A",
            categoryName: "Components, Headsets",
            sku: "HS-0296",
            name: "LL Headset",
            description: "The product called \"LL Headset\"",
            price: 34.2,
            tags: new List<Tag>
            {
                new Tag(
                    id: "18AC309F-F81C-4234-A752-5DDD2BEAEE83",
                    name: "Tag-32"
                ),
                new Tag(
                    id: "1B387A00-57D3-4444-8331-18A90725E98B",
                    name: "Tag-43"
                ),
                new Tag(
                    id: "C6AB3E24-BA48-40F0-A260-CB04EB03D5B0",
                    name: "Tag-73"
                ),
                new Tag(
                    id: "DAC25651-3DD3-4483-8FD1-581DC41EF34B",
                    name: "Tag-56"
                ),
                new Tag(
                    id: "E6D5275B-8C42-47AE-BDEC-FC708DB3E0AC",
                    name: "Tag-119"
                )
            }
        ),
        new Product(
            id: "FCF95DBC-BBAD-467B-9639-FC6E4EC42B4C",
            categoryId: "4F34E180-384D-42FC-AC10-FEC30227577F",
            categoryName: "Components, Pedals",
            sku: "PD-R347",
            name: "LL Road Pedal",
            description: "The product called \"LL Road Pedal\"",
            price: 40.49,
            tags: new List<Tag>
            {
                new Tag(
                    id: "001C55F4-E7F6-4A7E-A736-79114A0A3A4E",
                    name: "Tag-41"
                ),
                new Tag(
                    id: "A34D34F7-3286-4FA4-B4B0-5E61CCEEE197",
                    name: "Tag-4"
                )
            }
        ),
        new Product(
            id: "0B013EA7-B40E-4996-A494-D1E2840FEAAE",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R72R-44",
            name: "ML Road Frame - Red, 44",
            description: "The product called \"ML Road Frame - Red, 44\"",
            price: 594.83,
            tags: new List<Tag>
            {
                new Tag(
                    id: "9653F306-0B3C-4856-ABF8-13C3F04AE4F0",
                    name: "Tag-36"
                ),
                new Tag(
                    id: "AA35D2EA-24FD-4A62-80FE-83EFF821F019",
                    name: "Tag-10"
                ),
                new Tag(
                    id: "DA661FCF-CC7F-4AF9-A9E2-8E7A5570844E",
                    name: "Tag-188"
                )
            }
        ),
        new Product(
            id: "1BEAE2B0-134A-4780-9A7A-5FA17EADD513",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R92R-48",
            name: "HL Road Frame - Red, 48",
            description: "The product called \"HL Road Frame - Red, 48\"",
            price: 1431.5,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "21756241-F313-4D34-9914-9B7DAC76F9D6",
            categoryId: "973B839C-BF5D-485D-9D17-863C59B262E3",
            categoryName: "Components, Forks",
            sku: "FK-1639",
            name: "LL Fork",
            description: "The product called \"LL Fork\"",
            price: 148.22,
            tags: new List<Tag>
            {
                new Tag(
                    id: "2E7252D2-B646-47FB-B5BB-836643578038",
                    name: "Tag-130"
                ),
                new Tag(
                    id: "84C1934D-F048-4D2B-8525-323AFE2A7C7C",
                    name: "Tag-184"
                ),
                new Tag(
                    id: "8DC9DFB4-1946-427A-A0A0-E06E1448CC63",
                    name: "Tag-171"
                ),
                new Tag(
                    id: "B18FB652-C4B6-4A40-BA22-1E687C1A58CE",
                    name: "Tag-161"
                ),
                new Tag(
                    id: "E6D5275B-8C42-47AE-BDEC-FC708DB3E0AC",
                    name: "Tag-119"
                )
            }
        ),
        new Product(
            id: "26E6C049-667F-4463-AF1D-660953231165",
            categoryId: "8797AB0F-A9A3-475D-925E-56AC73DC206E",
            categoryName: "Components, Chains",
            sku: "CH-0234",
            name: "Chain",
            description: "The product called \"Chain\"",
            price: 20.24,
            tags: new List<Tag>
            {
                new Tag(
                    id: "403AE98F-892E-4FEC-B262-A264CF1F52A9",
                    name: "Tag-45"
                ),
                new Tag(
                    id: "BEBD68EF-901A-4282-911F-28AB44B802FE",
                    name: "Tag-139"
                ),
                new Tag(
                    id: "E80C2AD7-0ABA-4B0E-87B7-46AE28851531",
                    name: "Tag-141"
                )
            }
        ),
        new Product(
            id: "2CE4EFA7-5DC6-4D3E-ACB2-B7DDE4518408",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R92B-58",
            name: "HL Road Frame - Black, 58",
            description: "The product called \"HL Road Frame - Black, 58\"",
            price: 1431.5,
            tags: new List<Tag>
            {
                new Tag(
                    id: "2CE9DADE-DCAC-436C-9D69-B7C886A01B77",
                    name: "Tag-101"
                ),
                new Tag(
                    id: "AEFA79EF-CBF1-4824-AAF7-1D20EA85119B",
                    name: "Tag-17"
                ),
                new Tag(
                    id: "D197C394-FB88-4EFF-B0FB-8BED1A86F294",
                    name: "Tag-182"
                ),
                new Tag(
                    id: "ECBBCC15-3016-4075-B084-4B49DA754814",
                    name: "Tag-138"
                )
            }
        ),
        new Product(
            id: "311D60FC-9EB9-4194-B594-1E5BD87CCF81",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R38R-62",
            name: "LL Road Frame - Red, 62",
            description: "The product called \"LL Road Frame - Red, 62\"",
            price: 337.22,
            tags: new List<Tag>
            {
                new Tag(
                    id: "567D183B-9ED1-47B4-AE22-80C52BF41067",
                    name: "Tag-165"
                ),
                new Tag(
                    id: "9653F306-0B3C-4856-ABF8-13C3F04AE4F0",
                    name: "Tag-36"
                )
            }
        ),
        new Product(
            id: "32C5F63D-CF84-457C-9063-0C758CCDACE7",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R92R-44",
            name: "HL Road Frame - Red, 44",
            description: "The product called \"HL Road Frame - Red, 44\"",
            price: 1431.5,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "332C8377-F7B5-44C2-8DFC-B374294FD9B2",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R92R-62",
            name: "HL Road Frame - Red, 62",
            description: "The product called \"HL Road Frame - Red, 62\"",
            price: 1431.5,
            tags: new List<Tag>
            {
                new Tag(
                    id: "3C26DF5C-CE21-4EF6-AEE2-E8E1066D06B1",
                    name: "Tag-60"
                )
            }
        ),
        new Product(
            id: "34C0090C-B299-433B-8D31-42EFCDC5874D",
            categoryId: "345E8DEC-774F-45F6-BE0C-18CDDB368FC8",
            categoryName: "Accessories, Panniers",
            sku: "PA-T100",
            name: "Touring-Panniers, Large",
            description: "The product called \"Touring-Panniers, Large\"",
            price: 125.0,
            tags: new List<Tag>
            {
                new Tag(
                    id: "50F59C1E-E78D-4543-B4D0-B06E4C59E617",
                    name: "Tag-126"
                )
            }
        ),
        new Product(
            id: "3B52D15D-DF6C-4042-BA15-2EFEA8A2F852",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R92B-62",
            name: "HL Road Frame - Black, 62",
            description: "The product called \"HL Road Frame - Black, 62\"",
            price: 1431.5,
            tags: new List<Tag>
            {
                new Tag(
                    id: "1A2E203E-B80D-4693-A7C2-AB39E31C9C61",
                    name: "Tag-134"
                ),
                new Tag(
                    id: "2E7252D2-B646-47FB-B5BB-836643578038",
                    name: "Tag-130"
                ),
                new Tag(
                    id: "AEFA79EF-CBF1-4824-AAF7-1D20EA85119B",
                    name: "Tag-17"
                ),
                new Tag(
                    id: "E661634D-CDC3-4FA6-BE4B-D1FEEAECB5B9",
                    name: "Tag-121"
                )
            }
        ),
        new Product(
            id: "3FA9E0D9-E6E9-429D-9E24-7DAFE9B99A2C",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R92R-58",
            name: "HL Road Frame - Red, 58",
            description: "The product called \"HL Road Frame - Red, 58\"",
            price: 1431.5,
            tags: new List<Tag>
            {
                new Tag(
                    id: "E661634D-CDC3-4FA6-BE4B-D1FEEAECB5B9",
                    name: "Tag-121"
                )
            }
        ),
        new Product(
            id: "409BC0E0-2B43-4F82-9C36-2E4ABBB7344C",
            categoryId: "ECEEC6AC-3CF1-41A6-8430-A1255F355BB5",
            categoryName: "Components, Brakes",
            sku: "FB-9873",
            name: "Front Brakes",
            description: "The product called \"Front Brakes\"",
            price: 106.5,
            tags: new List<Tag>
            {
                new Tag(
                    id: "18AC309F-F81C-4234-A752-5DDD2BEAEE83",
                    name: "Tag-32"
                ),
                new Tag(
                    id: "29CBEDD8-D9C3-43A3-B20F-63224FEE0D34",
                    name: "Tag-11"
                ),
                new Tag(
                    id: "8AAFD985-8BCE-4FA8-85A2-2CA67D9DF8E6",
                    name: "Tag-172"
                ),
                new Tag(
                    id: "CAF27567-B4CB-463C-A54E-5EF1F2657DD2",
                    name: "Tag-75"
                )
            }
        ),
        new Product(
            id: "435D4B82-D557-4752-B825-D28767FB32D3",
            categoryId: "AA5A82D4-914C-4132-8C08-E7B75DCE3428",
            categoryName: "Components, Cranksets",
            sku: "CS-4759",
            name: "LL Crankset",
            description: "The product called \"LL Crankset\"",
            price: 175.49,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "4424AA2A-CC8D-4471-9478-21E91185593C",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R92B-48",
            name: "HL Road Frame - Black, 48",
            description: "The product called \"HL Road Frame - Black, 48\"",
            price: 1431.5,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "491834BE-AAA5-419D-B166-77B93F20EBA7",
            categoryId: "AA5A82D4-914C-4132-8C08-E7B75DCE3428",
            categoryName: "Components, Cranksets",
            sku: "CS-9183",
            name: "HL Crankset",
            description: "The product called \"HL Crankset\"",
            price: 404.99,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "520E3E6B-95F1-4258-9F74-E434848E88B2",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R38R-48",
            name: "LL Road Frame - Red, 48",
            description: "The product called \"LL Road Frame - Red, 48\"",
            price: 337.22,
            tags: new List<Tag>
            {
                new Tag(
                    id: "033D3826-2851-4B97-9464-59D3675175D4",
                    name: "Tag-108"
                ),
                new Tag(
                    id: "A2176C7A-4E0D-4283-AFAA-319A77E9C122",
                    name: "Tag-19"
                )
            }
        ),
        new Product(
            id: "5253671B-E50E-4686-9A17-4F51C2B65C0F",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R72Y-40",
            name: "ML Road Frame-W - Yellow, 40",
            description: "The product called \"ML Road Frame-W - Yellow, 40\"",
            price: 594.83,
            tags: new List<Tag>
            {
                new Tag(
                    id: "0C184C69-F4F2-4774-9645-46F53D297D95",
                    name: "Tag-49"
                ),
                new Tag(
                    id: "403AE98F-892E-4FEC-B262-A264CF1F52A9",
                    name: "Tag-45"
                )
            }
        ),
        new Product(
            id: "56BB7DD2-2421-4671-A527-7373008DD553",
            categoryId: "975E2A45-DA17-45CE-B65E-575A19334EB2",
            categoryName: "Components, Derailleurs",
            sku: "RD-2308",
            name: "Rear Derailleur",
            description: "The product called \"Rear Derailleur\"",
            price: 121.46,
            tags: new List<Tag>
            {
                new Tag(
                    id: "A2AFF2FF-8438-44A3-8AC6-20A50422D82A",
                    name: "Tag-18"
                )
            }
        ),
        new Product(
            id: "58978B2E-D4C6-4D69-A840-D935688F9C2D",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R92R-56",
            name: "HL Road Frame - Red, 56",
            description: "The product called \"HL Road Frame - Red, 56\"",
            price: 1431.5,
            tags: new List<Tag>
            {
                new Tag(
                    id: "3A3A99B6-E3BF-46D0-BAD9-F5F4DBB720F4",
                    name: "Tag-70"
                ),
                new Tag(
                    id: "66D8EA21-E1F0-471C-A17F-02F3B149D6E6",
                    name: "Tag-83"
                ),
                new Tag(
                    id: "69212884-78CF-48C9-A5C6-B62E76725533",
                    name: "Tag-104"
                ),
                new Tag(
                    id: "A9834752-41CA-47F5-8A5A-D9A878DF0ACB",
                    name: "Tag-198"
                ),
                new Tag(
                    id: "D5887E7C-B916-4AF4-BAF8-7B996ADA8C83",
                    name: "Tag-52"
                )
            }
        ),
        new Product(
            id: "58B0F878-2619-4225-B9B1-9C6C4FFF9C17",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R38B-44",
            name: "LL Road Frame - Black, 44",
            description: "The product called \"LL Road Frame - Black, 44\"",
            price: 337.22,
            tags: new List<Tag>
            {
                new Tag(
                    id: "1830EEDD-AF21-43EA-A13C-393ED77DEAC5",
                    name: "Tag-152"
                ),
                new Tag(
                    id: "812C1444-1DEA-480D-88E7-B9609ECA783C",
                    name: "Tag-136"
                ),
                new Tag(
                    id: "B49C6195-5ABA-42FA-B15C-84CF9FE252FE",
                    name: "Tag-129"
                ),
                new Tag(
                    id: "EBDBD608-416A-4FE2-96DF-02367C8D071E",
                    name: "Tag-102"
                ),
                new Tag(
                    id: "F629F27D-3301-4906-BE9B-C46D6D6F6141",
                    name: "Tag-65"
                )
            }
        ),
        new Product(
            id: "600DDD58-C9D0-4118-9A69-B7716ED3A303",
            categoryId: "340D259D-BFFE-4E2A-9C5E-8B1E473A0322",
            categoryName: "Accessories, Bike Stands",
            sku: "ST-1401",
            name: "All-Purpose Bike Stand",
            description: "The product called \"All-Purpose Bike Stand\"",
            price: 159.0,
            tags: new List<Tag>
            {
                new Tag(
                    id: "2CE9DADE-DCAC-436C-9D69-B7C886A01B77",
                    name: "Tag-101"
                ),
                new Tag(
                    id: "304041C4-8C80-4C1E-9EE9-8A1DEFCF39FC",
                    name: "Tag-72"
                ),
                new Tag(
                    id: "5A94DABD-FD34-48F7-9626-50872E214275",
                    name: "Tag-181"
                ),
                new Tag(
                    id: "6167EE62-5458-45B8-822D-1C10F274D9F1",
                    name: "Tag-170"
                ),
                new Tag(
                    id: "7337386B-E865-4ADC-BA17-4437CB02E3BE",
                    name: "Tag-8"
                )
            }
        ),
        new Product(
            id: "61B55CE9-DEB4-49B3-AB55-0AAC11EBBBBF",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R38R-58",
            name: "LL Road Frame - Red, 58",
            description: "The product called \"LL Road Frame - Red, 58\"",
            price: 337.22,
            tags: new List<Tag>
            {
                new Tag(
                    id: "45CBB7FF-FA48-49D8-89EF-F1D0B8AC3923",
                    name: "Tag-86"
                ),
                new Tag(
                    id: "4B10B00B-C1CA-4508-9848-3B1BD910B724",
                    name: "Tag-30"
                )
            }
        ),
        new Product(
            id: "6374995F-9A78-43CD-AE0D-5F6041078140",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R38R-60",
            name: "LL Road Frame - Red, 60",
            description: "The product called \"LL Road Frame - Red, 60\"",
            price: 337.22,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "7133D6F6-C8FD-4AD1-83E8-5622D1746E25",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R72R-58",
            name: "ML Road Frame - Red, 58",
            description: "The product called \"ML Road Frame - Red, 58\"",
            price: 594.83,
            tags: new List<Tag>
            {
                new Tag(
                    id: "4B10B00B-C1CA-4508-9848-3B1BD910B724",
                    name: "Tag-30"
                ),
                new Tag(
                    id: "CAF27567-B4CB-463C-A54E-5EF1F2657DD2",
                    name: "Tag-75"
                )
            }
        ),
        new Product(
            id: "751115E7-BD5E-45C7-932B-E9DDE9D62579",
            categoryId: "973B839C-BF5D-485D-9D17-863C59B262E3",
            categoryName: "Components, Forks",
            sku: "FK-9939",
            name: "HL Fork",
            description: "The product called \"HL Fork\"",
            price: 229.49,
            tags: new List<Tag>
            {
                new Tag(
                    id: "2400025E-FB22-4031-B4A2-9C3BD1402A9B",
                    name: "Tag-38"
                ),
                new Tag(
                    id: "40525E23-C1FB-4213-BF28-2B4C64BDC29B",
                    name: "Tag-135"
                ),
                new Tag(
                    id: "AA24EC37-7CE3-4ABE-B935-EC62D5FB6947",
                    name: "Tag-148"
                ),
                new Tag(
                    id: "E80C2AD7-0ABA-4B0E-87B7-46AE28851531",
                    name: "Tag-141"
                )
            }
        ),
        new Product(
            id: "794ACC61-01E9-49BF-B150-1D02EE01D76F",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R38B-48",
            name: "LL Road Frame - Black, 48",
            description: "The product called \"LL Road Frame - Black, 48\"",
            price: 337.22,
            tags: new List<Tag>
            {
                new Tag(
                    id: "A2443B36-76AE-4963-9E21-368868F9C514",
                    name: "Tag-6"
                ),
                new Tag(
                    id: "F07885AF-BD6C-4B71-88B1-F04295992176",
                    name: "Tag-149"
                )
            }
        ),
        new Product(
            id: "8826E4D4-36FF-42AD-A33F-0E7794215158",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R38B-58",
            name: "LL Road Frame - Black, 58",
            description: "The product called \"LL Road Frame - Black, 58\"",
            price: 337.22,
            tags: new List<Tag>
            {
                new Tag(
                    id: "1A2E203E-B80D-4693-A7C2-AB39E31C9C61",
                    name: "Tag-134"
                ),
                new Tag(
                    id: "1B387A00-57D3-4444-8331-18A90725E98B",
                    name: "Tag-43"
                ),
                new Tag(
                    id: "69212884-78CF-48C9-A5C6-B62E76725533",
                    name: "Tag-104"
                ),
                new Tag(
                    id: "72E191A8-F404-48AE-B8BC-2511569C895C",
                    name: "Tag-168"
                ),
                new Tag(
                    id: "F629F27D-3301-4906-BE9B-C46D6D6F6141",
                    name: "Tag-65"
                )
            }
        ),
        new Product(
            id: "894D03FA-1A4A-4FA4-9A0B-C3169EBB5674",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R72Y-44",
            name: "ML Road Frame-W - Yellow, 44",
            description: "The product called \"ML Road Frame-W - Yellow, 44\"",
            price: 594.83,
            tags: new List<Tag>
            {
                new Tag(
                    id: "765254E3-8E88-4C57-AADA-9F5126917970",
                    name: "Tag-93"
                ),
                new Tag(
                    id: "76B3C6DC-3411-457B-96F5-A51CE015DAD9",
                    name: "Tag-29"
                ),
                new Tag(
                    id: "C68A2129-1E2B-43EC-95B5-AC56CC200FA4",
                    name: "Tag-180"
                ),
                new Tag(
                    id: "C6AB3E24-BA48-40F0-A260-CB04EB03D5B0",
                    name: "Tag-73"
                ),
                new Tag(
                    id: "E6D5275B-8C42-47AE-BDEC-FC708DB3E0AC",
                    name: "Tag-119"
                )
            }
        ),
        new Product(
            id: "8BAA2AFB-CAE5-4A96-ABB2-46EDF9B5680E",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R38B-60",
            name: "LL Road Frame - Black, 60",
            description: "The product called \"LL Road Frame - Black, 60\"",
            price: 337.22,
            tags: new List<Tag>
            {
                new Tag(
                    id: "274E32EE-612A-4AAB-B91A-C7E8E4D8C2A7",
                    name: "Tag-1"
                ),
                new Tag(
                    id: "AA24EC37-7CE3-4ABE-B935-EC62D5FB6947",
                    name: "Tag-148"
                )
            }
        ),
        new Product(
            id: "8D3DCF87-D1ED-44DD-8DB8-085EB98C8A52",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R92R-52",
            name: "HL Road Frame - Red, 52",
            description: "The product called \"HL Road Frame - Red, 52\"",
            price: 1431.5,
            tags: new List<Tag>
            {
                new Tag(
                    id: "01E0AFB1-867D-4BAA-B0DF-2E99D056EDA2",
                    name: "Tag-107"
                ),
                new Tag(
                    id: "2400025E-FB22-4031-B4A2-9C3BD1402A9B",
                    name: "Tag-38"
                ),
                new Tag(
                    id: "274E32EE-612A-4AAB-B91A-C7E8E4D8C2A7",
                    name: "Tag-1"
                ),
                new Tag(
                    id: "D56040DB-E5DF-40BE-9F2F-7E10F4340BCA",
                    name: "Tag-31"
                ),
                new Tag(
                    id: "E6CB7972-06F4-47C0-B464-F64E695F89E7",
                    name: "Tag-51"
                )
            }
        ),
        new Product(
            id: "916ACEDC-DCF4-4118-90C6-B9572D30714E",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R72R-60",
            name: "ML Road Frame - Red, 60",
            description: "The product called \"ML Road Frame - Red, 60\"",
            price: 594.83,
            tags: new List<Tag>
            {
                new Tag(
                    id: "033D3826-2851-4B97-9464-59D3675175D4",
                    name: "Tag-108"
                ),
                new Tag(
                    id: "69212884-78CF-48C9-A5C6-B62E76725533",
                    name: "Tag-104"
                ),
                new Tag(
                    id: "765EF7D7-331C-42C0-BF23-A3022A723BF7",
                    name: "Tag-191"
                ),
                new Tag(
                    id: "D1E5CB02-8E7B-422F-9421-C0E608F0AC4C",
                    name: "Tag-133"
                )
            }
        ),
        new Product(
            id: "9183E546-A94B-4B7F-845B-A53E0EF5C626",
            categoryId: "973B839C-BF5D-485D-9D17-863C59B262E3",
            categoryName: "Components, Forks",
            sku: "FK-5136",
            name: "ML Fork",
            description: "The product called \"ML Fork\"",
            price: 175.49,
            tags: new List<Tag>
            {
                new Tag(
                    id: "D1E5CB02-8E7B-422F-9421-C0E608F0AC4C",
                    name: "Tag-133"
                ),
                new Tag(
                    id: "DCDBD26C-4D71-4F91-BBE9-98D1897E704D",
                    name: "Tag-68"
                )
            }
        ),
        new Product(
            id: "92413209-8DA6-4661-9E11-26B55990BEB2",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R38R-52",
            name: "LL Road Frame - Red, 52",
            description: "The product called \"LL Road Frame - Red, 52\"",
            price: 337.22,
            tags: new List<Tag>
            {
                new Tag(
                    id: "069169DD-F4B3-4769-8841-13B5FF745932",
                    name: "Tag-157"
                ),
                new Tag(
                    id: "94F41BAD-B861-4BB0-A941-89677D04F455",
                    name: "Tag-26"
                ),
                new Tag(
                    id: "F533A770-1E5D-4B48-8792-E16E155B6E38",
                    name: "Tag-87"
                )
            }
        ),
        new Product(
            id: "92DB7ABD-1C8E-458C-8828-9BFD1984B07D",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R38B-62",
            name: "LL Road Frame - Black, 62",
            description: "The product called \"LL Road Frame - Black, 62\"",
            price: 337.22,
            tags: new List<Tag>
            {
                new Tag(
                    id: "51CD93BF-098C-4C25-9829-4AD42046D038",
                    name: "Tag-25"
                ),
                new Tag(
                    id: "718DAED6-2186-4E09-8C02-CCC58281838D",
                    name: "Tag-94"
                ),
                new Tag(
                    id: "A37349FB-4A1C-4382-A845-DF81830A7B4D",
                    name: "Tag-150"
                ),
                new Tag(
                    id: "A9834752-41CA-47F5-8A5A-D9A878DF0ACB",
                    name: "Tag-198"
                )
            }
        ),
        new Product(
            id: "9351199A-B781-482D-80BE-2C11394002E5",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R72Y-38",
            name: "ML Road Frame-W - Yellow, 38",
            description: "The product called \"ML Road Frame-W - Yellow, 38\"",
            price: 594.83,
            tags: new List<Tag>
            {
                new Tag(
                    id: "59676183-1BD7-48A0-B3B0-42B3C0800EB0",
                    name: "Tag-64"
                ),
                new Tag(
                    id: "762CE1E0-5615-418E-B476-BCD46AD5E79E",
                    name: "Tag-137"
                ),
                new Tag(
                    id: "76B3C6DC-3411-457B-96F5-A51CE015DAD9",
                    name: "Tag-29"
                ),
                new Tag(
                    id: "AC4CC3CC-4E6B-461D-9B0E-4218EDDF3142",
                    name: "Tag-122"
                )
            }
        ),
        new Product(
            id: "A2E169C8-0916-4CAD-9C7B-FBAF463D0DB3",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R72Y-42",
            name: "ML Road Frame-W - Yellow, 42",
            description: "The product called \"ML Road Frame-W - Yellow, 42\"",
            price: 594.83,
            tags: new List<Tag>
            {
                new Tag(
                    id: "1B387A00-57D3-4444-8331-18A90725E98B",
                    name: "Tag-43"
                ),
                new Tag(
                    id: "227FF627-9E87-4BE5-8254-17BB155B0AD7",
                    name: "Tag-23"
                )
            }
        ),
        new Product(
            id: "A6040C40-906B-4A87-9E2C-683A8037A1C3",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R92B-52",
            name: "HL Road Frame - Black, 52",
            description: "The product called \"HL Road Frame - Black, 52\"",
            price: 1431.5,
            tags: new List<Tag>
            {
                new Tag(
                    id: "033D3826-2851-4B97-9464-59D3675175D4",
                    name: "Tag-108"
                ),
                new Tag(
                    id: "4B10B00B-C1CA-4508-9848-3B1BD910B724",
                    name: "Tag-30"
                ),
                new Tag(
                    id: "94C05E5C-13B7-41DA-89DF-98C11195AE1E",
                    name: "Tag-79"
                ),
                new Tag(
                    id: "D1E5CB02-8E7B-422F-9421-C0E608F0AC4C",
                    name: "Tag-133"
                ),
                new Tag(
                    id: "D56040DB-E5DF-40BE-9F2F-7E10F4340BCA",
                    name: "Tag-31"
                )
            }
        ),
        new Product(
            id: "B03973CE-FAAD-4BE2-84FF-5BA5C751B6D0",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R92B-44",
            name: "HL Road Frame - Black, 44",
            description: "The product called \"HL Road Frame - Black, 44\"",
            price: 1431.5,
            tags: new List<Tag>
            {
                new Tag(
                    id: "2400025E-FB22-4031-B4A2-9C3BD1402A9B",
                    name: "Tag-38"
                ),
                new Tag(
                    id: "47A34A77-A9B8-4703-9AEF-3786726C7A31",
                    name: "Tag-176"
                ),
                new Tag(
                    id: "C6AB3E24-BA48-40F0-A260-CB04EB03D5B0",
                    name: "Tag-73"
                ),
                new Tag(
                    id: "F287FE0A-712B-4B52-925F-5047B34F3610",
                    name: "Tag-197"
                ),
                new Tag(
                    id: "F6B1A09C-BCC9-4A74-8472-D1CA98310501",
                    name: "Tag-185"
                )
            }
        ),
        new Product(
            id: "B08450AA-413C-4663-A62D-7291A8ECF1F5",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R38R-44",
            name: "LL Road Frame - Red, 44",
            description: "The product called \"LL Road Frame - Red, 44\"",
            price: 337.22,
            tags: new List<Tag>
            {
                new Tag(
                    id: "4B10B00B-C1CA-4508-9848-3B1BD910B724",
                    name: "Tag-30"
                ),
                new Tag(
                    id: "8CA1BBD8-D00B-4654-AABA-5C8724C6F4BD",
                    name: "Tag-81"
                ),
                new Tag(
                    id: "A4D9E596-B630-4792-BDD1-7D6459827820",
                    name: "Tag-164"
                ),
                new Tag(
                    id: "A50C570B-B3FC-4678-96C8-2D117DD11A12",
                    name: "Tag-66"
                ),
                new Tag(
                    id: "B20574A2-8F94-4CB5-A9A7-2E1E203978D6",
                    name: "Tag-117"
                )
            }
        ),
        new Product(
            id: "B1AAF271-9DFA-4826-91A3-F3B4BFF49B1C",
            categoryId: "AA5A82D4-914C-4132-8C08-E7B75DCE3428",
            categoryName: "Components, Cranksets",
            sku: "CS-6583",
            name: "ML Crankset",
            description: "The product called \"ML Crankset\"",
            price: 256.49,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "B8587D85-224F-4252-9521-A1763D63AEC2",
            categoryId: "ECEEC6AC-3CF1-41A6-8430-A1255F355BB5",
            categoryName: "Components, Brakes",
            sku: "RB-9231",
            name: "Rear Brakes",
            description: "The product called \"Rear Brakes\"",
            price: 106.5,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "BF87ACE3-C52B-44EA-9871-4A6497B3AF9F",
            categoryId: "7FF64215-1F7A-4CDF-9BA1-AD6ADC6B5D1C",
            categoryName: "Accessories, Pumps",
            sku: "PU-0452",
            name: "Minipump",
            description: "The product called \"Minipump\"",
            price: 19.99,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "C310A68D-DBF2-421A-91CA-F09A3B8A1AAA",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R72R-52",
            name: "ML Road Frame - Red, 52",
            description: "The product called \"ML Road Frame - Red, 52\"",
            price: 594.83,
            tags: new List<Tag>
            {
                new Tag(
                    id: "18AC309F-F81C-4234-A752-5DDD2BEAEE83",
                    name: "Tag-32"
                ),
                new Tag(
                    id: "7990C336-92BD-41F9-8FB6-97390BC4D187",
                    name: "Tag-189"
                ),
                new Tag(
                    id: "80F182C6-0619-4547-9A2D-F90A7913FACF",
                    name: "Tag-96"
                ),
                new Tag(
                    id: "9E250CCC-6530-4DC0-9D64-E7777B3C3B73",
                    name: "Tag-177"
                ),
                new Tag(
                    id: "EFD6F482-9619-47C2-94FD-DA5D035DEA7A",
                    name: "Tag-144"
                )
            }
        ),
        new Product(
            id: "CB038CA5-3728-4B59-B209-22FAB210F58B",
            categoryId: "4F2FD0D4-F0E5-4F9E-B049-861E6541B987",
            categoryName: "Accessories, Hydration Packs",
            sku: "HY-1023-70",
            name: "Hydration Pack - 70 oz.",
            description: "The product called \"Hydration Pack - 70 oz.\"",
            price: 54.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "01078B1D-5267-4B35-82B8-57042AA9CABB",
                    name: "Tag-84"
                ),
                new Tag(
                    id: "6FB11EB9-319C-431C-89D7-70113401D186",
                    name: "Tag-154"
                ),
                new Tag(
                    id: "775908D7-2622-4C29-AF4D-F2274824DA3B",
                    name: "Tag-89"
                ),
                new Tag(
                    id: "83D720BA-BB31-4BE5-B723-8A836AB6D532",
                    name: "Tag-127"
                ),
                new Tag(
                    id: "D69B1B6C-4963-4E85-8FA5-6A3E1CD1C83B",
                    name: "Tag-187"
                )
            }
        ),
        new Product(
            id: "E223E34D-E0D0-4DFA-AB7D-8E72F94F2202",
            categoryId: "975E2A45-DA17-45CE-B65E-575A19334EB2",
            categoryName: "Components, Derailleurs",
            sku: "FD-2342",
            name: "Front Derailleur",
            description: "The product called \"Front Derailleur\"",
            price: 91.49,
            tags: new List<Tag>
            {
                new Tag(
                    id: "088B5F10-EB9B-4F33-A2E4-F2E54485B90F",
                    name: "Tag-115"
                ),
                new Tag(
                    id: "AA35D2EA-24FD-4A62-80FE-83EFF821F019",
                    name: "Tag-10"
                )
            }
        ),
        new Product(
            id: "E5A67B5B-B190-45CB-A9E4-BE3F6BD49214",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R72R-48",
            name: "ML Road Frame - Red, 48",
            description: "The product called \"ML Road Frame - Red, 48\"",
            price: 594.83,
            tags: new List<Tag>
            {
                new Tag(
                    id: "2CE9DADE-DCAC-436C-9D69-B7C886A01B77",
                    name: "Tag-101"
                ),
                new Tag(
                    id: "A2AFF2FF-8438-44A3-8AC6-20A50422D82A",
                    name: "Tag-18"
                ),
                new Tag(
                    id: "AC4CC3CC-4E6B-461D-9B0E-4218EDDF3142",
                    name: "Tag-122"
                ),
                new Tag(
                    id: "BDA92549-CBC2-4DC1-9C82-18D1A629C3F3",
                    name: "Tag-145"
                )
            }
        ),
        new Product(
            id: "EEE4159B-F224-4C02-B578-2F398229592D",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R38B-52",
            name: "LL Road Frame - Black, 52",
            description: "The product called \"LL Road Frame - Black, 52\"",
            price: 337.22,
            tags: new List<Tag>
            {
                new Tag(
                    id: "6C6D061E-F701-41DC-AEA2-7A5C28061840",
                    name: "Tag-98"
                ),
                new Tag(
                    id: "7F518FB1-4664-4B20-9B9F-23D5B44F6798",
                    name: "Tag-69"
                ),
                new Tag(
                    id: "87BC6842-2CCA-4CD3-994C-33AB101455F4",
                    name: "Tag-12"
                )
            }
        ),
        new Product(
            id: "FE292D83-1F34-4845-A467-7C62AD3C6CBE",
            categoryId: "7FF64215-1F7A-4CDF-9BA1-AD6ADC6B5D1C",
            categoryName: "Accessories, Pumps",
            sku: "PU-M044",
            name: "Mountain Pump",
            description: "The product called \"Mountain Pump\"",
            price: 24.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "01078B1D-5267-4B35-82B8-57042AA9CABB",
                    name: "Tag-84"
                ),
                new Tag(
                    id: "84C1934D-F048-4D2B-8525-323AFE2A7C7C",
                    name: "Tag-184"
                ),
                new Tag(
                    id: "9653F306-0B3C-4856-ABF8-13C3F04AE4F0",
                    name: "Tag-36"
                )
            }
        ),
        new Product(
            id: "FFCA3096-199F-41C3-99D1-35BC88D8AC6F",
            categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            categoryName: "Components, Road Frames",
            sku: "FR-R72Y-48",
            name: "ML Road Frame-W - Yellow, 48",
            description: "The product called \"ML Road Frame-W - Yellow, 48\"",
            price: 594.83,
            tags: new List<Tag>
            {
                new Tag(
                    id: "14CFF1D6-7749-4A57-85B3-783F47731F32",
                    name: "Tag-7"
                ),
                new Tag(
                    id: "84C396AD-98C6-4B12-8C3A-1BDA3ABF7D73",
                    name: "Tag-24"
                )
            }
        ),
        new Product(
            id: "056C459F-DA40-475E-B7BE-B87B6DB39D33",
            categoryId: "9268EA12-29BA-404B-B514-E4737DB3BFCB",
            categoryName: "Clothing, Bib-Shorts",
            sku: "SB-M891-S",
            name: "Men's Bib-Shorts, S",
            description: "The product called \"Men's Bib-Shorts, S\"",
            price: 89.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "4B10B00B-C1CA-4508-9848-3B1BD910B724",
                    name: "Tag-30"
                ),
                new Tag(
                    id: "89FB612A-F9AA-4196-B5F5-B9FA16D558DC",
                    name: "Tag-175"
                )
            }
        ),
        new Product(
            id: "08CF5494-D064-40CF-952B-E33ED9CE9297",
            categoryId: "9268EA12-29BA-404B-B514-E4737DB3BFCB",
            categoryName: "Clothing, Bib-Shorts",
            sku: "SB-M891-M",
            name: "Men's Bib-Shorts, M",
            description: "The product called \"Men's Bib-Shorts, M\"",
            price: 89.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "0C1DA4B7-676B-413A-A2C5-CCC944837DDC",
                    name: "Tag-39"
                ),
                new Tag(
                    id: "764C1CC8-2E5F-4EF5-83F6-8FF7441290B3",
                    name: "Tag-190"
                ),
                new Tag(
                    id: "76B3C6DC-3411-457B-96F5-A51CE015DAD9",
                    name: "Tag-29"
                ),
                new Tag(
                    id: "DBC21C2A-0AF6-45D4-B2C9-703DD708A821",
                    name: "Tag-14"
                ),
                new Tag(
                    id: "F132E7B8-65B1-471E-8D3E-5E8D7110CA48",
                    name: "Tag-118"
                )
            }
        ),
        new Product(
            id: "0B77351B-8F31-45D2-AECC-85BABD03B24E",
            categoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            categoryName: "Components, Touring Frames",
            sku: "FR-T98Y-50",
            name: "HL Touring Frame - Yellow, 50",
            description: "The product called \"HL Touring Frame - Yellow, 50\"",
            price: 1003.91,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "0F124781-C991-48A9-ACF2-249771D44029",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M68B-42",
            name: "Mountain-200 Black, 42",
            description: "The product called \"Mountain-200 Black, 42\"",
            price: 2294.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "4F67013C-3B5E-4A3D-B4B0-8C597A491EB6",
                    name: "Tag-82"
                ),
                new Tag(
                    id: "59676183-1BD7-48A0-B3B0-42B3C0800EB0",
                    name: "Tag-64"
                ),
                new Tag(
                    id: "89500F13-B516-4F77-8128-47FC412BEFCD",
                    name: "Tag-151"
                ),
                new Tag(
                    id: "8DC9DFB4-1946-427A-A0A0-E06E1448CC63",
                    name: "Tag-171"
                )
            }
        ),
        new Product(
            id: "12DD6F29-6AA2-4C03-8873-19581F97E9CD",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M18B-48",
            name: "Mountain-500 Black, 48",
            description: "The product called \"Mountain-500 Black, 48\"",
            price: 539.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "9E250CCC-6530-4DC0-9D64-E7777B3C3B73",
                    name: "Tag-177"
                )
            }
        ),
        new Product(
            id: "16F9DF28-56B4-4185-9B82-B85666BFA3A6",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M38S-38",
            name: "Mountain-400-W Silver, 38",
            description: "The product called \"Mountain-400-W Silver, 38\"",
            price: 769.49,
            tags: new List<Tag>
            {
                new Tag(
                    id: "125497D0-9175-4ECD-844D-DA71E5F4ED43",
                    name: "Tag-42"
                ),
                new Tag(
                    id: "3BFB03A9-3106-44C7-823A-DB1A67E283C3",
                    name: "Tag-47"
                ),
                new Tag(
                    id: "6C2F05C8-1E61-4912-BE1A-C67A378429BB",
                    name: "Tag-5"
                ),
                new Tag(
                    id: "A07D69D4-B8B9-4662-8148-8033DCDCC000",
                    name: "Tag-142"
                )
            }
        ),
        new Product(
            id: "28A865D5-647E-46B5-B309-CA2B2F524E37",
            categoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            categoryName: "Components, Touring Frames",
            sku: "FR-T98U-60",
            name: "HL Touring Frame - Blue, 60",
            description: "The product called \"HL Touring Frame - Blue, 60\"",
            price: 1003.91,
            tags: new List<Tag>
            {
                new Tag(
                    id: "1745EF28-6E0B-4FED-8925-BC3174F583B0",
                    name: "Tag-48"
                ),
                new Tag(
                    id: "319E277F-6B7A-483D-81BA-1EC34CC700EB",
                    name: "Tag-163"
                ),
                new Tag(
                    id: "4A6ED3A9-AFDA-4994-9C51-CA76256CEF81",
                    name: "Tag-140"
                ),
                new Tag(
                    id: "94C05E5C-13B7-41DA-89DF-98C11195AE1E",
                    name: "Tag-79"
                )
            }
        ),
        new Product(
            id: "2BA4A26C-A8DB-4645-BEB9-F7D42F50262E",
            categoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            categoryName: "Components, Touring Frames",
            sku: "FR-T98U-50",
            name: "HL Touring Frame - Blue, 50",
            description: "The product called \"HL Touring Frame - Blue, 50\"",
            price: 1003.91,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "2EE56307-0398-465E-A340-1C5FB1C85648",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M18S-42",
            name: "Mountain-500 Silver, 42",
            description: "The product called \"Mountain-500 Silver, 42\"",
            price: 564.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "C1CB0EFE-02BB-4AE5-AA48-3DAC12921450",
                    name: "Tag-109"
                )
            }
        ),
        new Product(
            id: "312A464A-1830-4755-8FB2-2ED32DC7FDD6",
            categoryId: "9268EA12-29BA-404B-B514-E4737DB3BFCB",
            categoryName: "Clothing, Bib-Shorts",
            sku: "SB-M891-L",
            name: "Men's Bib-Shorts, L",
            description: "The product called \"Men's Bib-Shorts, L\"",
            price: 89.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "2400025E-FB22-4031-B4A2-9C3BD1402A9B",
                    name: "Tag-38"
                ),
                new Tag(
                    id: "84C396AD-98C6-4B12-8C3A-1BDA3ABF7D73",
                    name: "Tag-24"
                ),
                new Tag(
                    id: "B3EC53EB-000D-4E66-975A-910771520A6E",
                    name: "Tag-54"
                ),
                new Tag(
                    id: "F3A39B6E-753C-4E70-859F-454E8A9624A9",
                    name: "Tag-179"
                )
            }
        ),
        new Product(
            id: "32B61AF2-53BE-4E36-85D8-A24738769352",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M18S-52",
            name: "Mountain-500 Silver, 52",
            description: "The product called \"Mountain-500 Silver, 52\"",
            price: 564.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "511652EB-9EC2-4235-BA77-0C6E4E316679",
                    name: "Tag-199"
                ),
                new Tag(
                    id: "AC4CC3CC-4E6B-461D-9B0E-4218EDDF3142",
                    name: "Tag-122"
                )
            }
        ),
        new Product(
            id: "397635D8-D71F-47B2-AD68-4ECA6A03F84F",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M18B-44",
            name: "Mountain-500 Black, 44",
            description: "The product called \"Mountain-500 Black, 44\"",
            price: 539.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "D887B872-7CE0-467C-9307-1EABD0D06EEA",
                    name: "Tag-20"
                )
            }
        ),
        new Product(
            id: "3ADF5B22-B5B2-43CD-9E07-36A187EB9473",
            categoryId: "C3C57C35-1D80-4EC5-AB12-46C57A017AFB",
            categoryName: "Clothing, Jerseys",
            sku: "LJ-0192-S",
            name: "Long-Sleeve Logo Jersey, S",
            description: "The product called \"Long-Sleeve Logo Jersey, S\"",
            price: 49.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "18AC309F-F81C-4234-A752-5DDD2BEAEE83",
                    name: "Tag-32"
                ),
                new Tag(
                    id: "BBE8A68F-6458-410E-BFF7-759507DCE858",
                    name: "Tag-114"
                )
            }
        ),
        new Product(
            id: "462F8EAF-0988-4D32-B809-EB4362AF48D0",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M68B-38",
            name: "Mountain-200 Black, 38",
            description: "The product called \"Mountain-200 Black, 38\"",
            price: 2294.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "79E61D0F-3C95-4353-BF27-DB04535088C9",
                    name: "Tag-50"
                ),
                new Tag(
                    id: "E83726D0-E486-42C1-BBD3-594C1C5AED6D",
                    name: "Tag-155"
                ),
                new Tag(
                    id: "F41CEB6B-FFD0-40A2-BC0F-F89FC3256F09",
                    name: "Tag-13"
                )
            }
        ),
        new Product(
            id: "47ED1C3B-C205-4507-94EE-3B69A744B261",
            categoryId: "14A1AD5D-59EA-4B63-A189-67B077783B0E",
            categoryName: "Accessories, Helmets",
            sku: "HL-U509",
            name: "Sport-100 Helmet, Black",
            description: "The product called \"Sport-100 Helmet, Black\"",
            price: 34.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "12A06E6F-45BF-42DF-9641-F1376CDDB7B1",
                    name: "Tag-22"
                ),
                new Tag(
                    id: "1745EF28-6E0B-4FED-8925-BC3174F583B0",
                    name: "Tag-48"
                ),
                new Tag(
                    id: "27B7F8D5-1009-45B8-88F5-41008A0F0393",
                    name: "Tag-61"
                ),
                new Tag(
                    id: "CF3C6F6C-8038-4FAD-A07A-E1AD1C34DE22",
                    name: "Tag-77"
                )
            }
        ),
        new Product(
            id: "4DA12D36-495E-4DCA-95B0-F18CAA099779",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M82S-42",
            name: "Mountain-100 Silver, 42",
            description: "The product called \"Mountain-100 Silver, 42\"",
            price: 3399.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "3C26DF5C-CE21-4EF6-AEE2-E8E1066D06B1",
                    name: "Tag-60"
                ),
                new Tag(
                    id: "BB35DF88-8BCE-4267-838B-9265BAE64EDF",
                    name: "Tag-160"
                ),
                new Tag(
                    id: "F629F27D-3301-4906-BE9B-C46D6D6F6141",
                    name: "Tag-65"
                )
            }
        ),
        new Product(
            id: "55594B1E-1E16-4B2E-A16F-983E492321BC",
            categoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            categoryName: "Components, Touring Frames",
            sku: "FR-T67Y-54",
            name: "LL Touring Frame - Yellow, 54",
            description: "The product called \"LL Touring Frame - Yellow, 54\"",
            price: 333.42,
            tags: new List<Tag>
            {
                new Tag(
                    id: "CA7D17BB-45A6-47E6-A3E3-E70AF34C2072",
                    name: "Tag-158"
                )
            }
        ),
        new Product(
            id: "56560B7B-3AC6-4E07-8825-4266A7C98CFE",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M18B-52",
            name: "Mountain-500 Black, 52",
            description: "The product called \"Mountain-500 Black, 52\"",
            price: 539.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "A0BA4E3B-AD4A-42AF-BFA4-5F48E2E57F07",
                    name: "Tag-58"
                )
            }
        ),
        new Product(
            id: "5BC9F76B-7FE9-4DD9-A672-2C5E802B2672",
            categoryId: "C3C57C35-1D80-4EC5-AB12-46C57A017AFB",
            categoryName: "Clothing, Jerseys",
            sku: "SJ-0194-L",
            name: "Short-Sleeve Classic Jersey, L",
            description: "The product called \"Short-Sleeve Classic Jersey, L\"",
            price: 53.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "29CBEDD8-D9C3-43A3-B20F-63224FEE0D34",
                    name: "Tag-11"
                ),
                new Tag(
                    id: "4A6ED3A9-AFDA-4994-9C51-CA76256CEF81",
                    name: "Tag-140"
                ),
                new Tag(
                    id: "FE2975F7-D3D2-42AE-A0BB-D87254E58540",
                    name: "Tag-74"
                )
            }
        ),
        new Product(
            id: "5C30FF31-CAB7-4A99-8FD6-D610F58AC4BA",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M38S-42",
            name: "Mountain-400-W Silver, 42",
            description: "The product called \"Mountain-400-W Silver, 42\"",
            price: 769.49,
            tags: new List<Tag>
            {
                new Tag(
                    id: "01078B1D-5267-4B35-82B8-57042AA9CABB",
                    name: "Tag-84"
                ),
                new Tag(
                    id: "0C1DA4B7-676B-413A-A2C5-CCC944837DDC",
                    name: "Tag-39"
                ),
                new Tag(
                    id: "29CBEDD8-D9C3-43A3-B20F-63224FEE0D34",
                    name: "Tag-11"
                ),
                new Tag(
                    id: "9467BA7B-49FB-4AA5-A868-478D94AF2E54",
                    name: "Tag-92"
                )
            }
        ),
        new Product(
            id: "5D3F5A52-A8BB-448C-B8CF-39D2FA2BDF3C",
            categoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            categoryName: "Components, Touring Frames",
            sku: "FR-T98U-54",
            name: "HL Touring Frame - Blue, 54",
            description: "The product called \"HL Touring Frame - Blue, 54\"",
            price: 1003.91,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "5ED1BF5F-6C1F-4EF8-B1A7-B8A8412C9F72",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M47B-38",
            name: "Mountain-300 Black, 38",
            description: "The product called \"Mountain-300 Black, 38\"",
            price: 1079.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "567D183B-9ED1-47B4-AE22-80C52BF41067",
                    name: "Tag-165"
                )
            }
        ),
        new Product(
            id: "601A5234-644D-4B83-9FDB-326C22C1051D",
            categoryId: "14A1AD5D-59EA-4B63-A189-67B077783B0E",
            categoryName: "Accessories, Helmets",
            sku: "HL-U509-B",
            name: "Sport-100 Helmet, Blue",
            description: "The product called \"Sport-100 Helmet, Blue\"",
            price: 34.99,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "61246D01-7C38-489E-9F49-A526679B568F",
            categoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            categoryName: "Components, Touring Frames",
            sku: "FR-T67U-50",
            name: "LL Touring Frame - Blue, 50",
            description: "The product called \"LL Touring Frame - Blue, 50\"",
            price: 333.42,
            tags: new List<Tag>
            {
                new Tag(
                    id: "227FF627-9E87-4BE5-8254-17BB155B0AD7",
                    name: "Tag-23"
                ),
                new Tag(
                    id: "4B8ECDDE-FF08-4916-8869-372D08EA8BBA",
                    name: "Tag-106"
                )
            }
        ),
        new Product(
            id: "6401B68F-924A-4B2E-AC9E-5660AEA0E848",
            categoryId: "C3C57C35-1D80-4EC5-AB12-46C57A017AFB",
            categoryName: "Clothing, Jerseys",
            sku: "LJ-0192-L",
            name: "Long-Sleeve Logo Jersey, L",
            description: "The product called \"Long-Sleeve Logo Jersey, L\"",
            price: 49.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "B48D6572-67EB-4630-A1DB-AFD4AD7041C9",
                    name: "Tag-100"
                ),
                new Tag(
                    id: "E1A62ABF-BBC3-48A2-BAC6-E3350D023C83",
                    name: "Tag-194"
                )
            }
        ),
        new Product(
            id: "668E6FCE-03E9-49E7-AC33-1B17FEEF5E60",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M18S-40",
            name: "Mountain-500 Silver, 40",
            description: "The product called \"Mountain-500 Silver, 40\"",
            price: 564.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "028057B8-8F03-4C18-B853-66510D354A72",
                    name: "Tag-57"
                ),
                new Tag(
                    id: "23ECB896-D6C6-4E9D-BE43-1908CB5C5E07",
                    name: "Tag-112"
                ),
                new Tag(
                    id: "BA4D7ABD-2E82-4DC2-ACF2-5D3B0DEAE1C1",
                    name: "Tag-59"
                ),
                new Tag(
                    id: "DCDBD26C-4D71-4F91-BBE9-98D1897E704D",
                    name: "Tag-68"
                )
            }
        ),
        new Product(
            id: "6EB9F7AC-7FB0-4D8C-8D3F-76A735A3CB9A",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M18B-40",
            name: "Mountain-500 Black, 40",
            description: "The product called \"Mountain-500 Black, 40\"",
            price: 539.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "088B5F10-EB9B-4F33-A2E4-F2E54485B90F",
                    name: "Tag-115"
                )
            }
        ),
        new Product(
            id: "6F733A5D-9B66-4718-B69C-627DE4E164BA",
            categoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            categoryName: "Components, Touring Frames",
            sku: "FR-T67Y-44",
            name: "LL Touring Frame - Yellow, 44",
            description: "The product called \"LL Touring Frame - Yellow, 44\"",
            price: 333.42,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "824D58CA-ECCA-4E72-965C-66D3A5C0C67C",
            categoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            categoryName: "Components, Touring Frames",
            sku: "FR-T67Y-58",
            name: "LL Touring Frame - Yellow, 58",
            description: "The product called \"LL Touring Frame - Yellow, 58\"",
            price: 333.42,
            tags: new List<Tag>
            {
                new Tag(
                    id: "18AC309F-F81C-4234-A752-5DDD2BEAEE83",
                    name: "Tag-32"
                ),
                new Tag(
                    id: "4E102F3F-7D57-4CD7-88F4-AC5076A42C59",
                    name: "Tag-91"
                ),
                new Tag(
                    id: "84C396AD-98C6-4B12-8C3A-1BDA3ABF7D73",
                    name: "Tag-24"
                ),
                new Tag(
                    id: "D197C394-FB88-4EFF-B0FB-8BED1A86F294",
                    name: "Tag-182"
                ),
                new Tag(
                    id: "D1E5CB02-8E7B-422F-9421-C0E608F0AC4C",
                    name: "Tag-133"
                )
            }
        ),
        new Product(
            id: "840E2138-4265-4AC8-8514-AC0B9C98597C",
            categoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            categoryName: "Components, Touring Frames",
            sku: "FR-T67U-44",
            name: "LL Touring Frame - Blue, 44",
            description: "The product called \"LL Touring Frame - Blue, 44\"",
            price: 333.42,
            tags: new List<Tag>
            {
                new Tag(
                    id: "274E32EE-612A-4AAB-B91A-C7E8E4D8C2A7",
                    name: "Tag-1"
                ),
                new Tag(
                    id: "47A34A77-A9B8-4703-9AEF-3786726C7A31",
                    name: "Tag-176"
                ),
                new Tag(
                    id: "76B3C6DC-3411-457B-96F5-A51CE015DAD9",
                    name: "Tag-29"
                ),
                new Tag(
                    id: "775908D7-2622-4C29-AF4D-F2274824DA3B",
                    name: "Tag-89"
                ),
                new Tag(
                    id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    name: "Tag-183"
                )
            }
        ),
        new Product(
            id: "86FD9250-4BD5-42D2-B941-1C1865A6A65E",
            categoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            categoryName: "Components, Touring Frames",
            sku: "FR-T67U-58",
            name: "LL Touring Frame - Blue, 58",
            description: "The product called \"LL Touring Frame - Blue, 58\"",
            price: 333.42,
            tags: new List<Tag>
            {
                new Tag(
                    id: "764C1CC8-2E5F-4EF5-83F6-8FF7441290B3",
                    name: "Tag-190"
                ),
                new Tag(
                    id: "765EF7D7-331C-42C0-BF23-A3022A723BF7",
                    name: "Tag-191"
                ),
                new Tag(
                    id: "87BC6842-2CCA-4CD3-994C-33AB101455F4",
                    name: "Tag-12"
                ),
                new Tag(
                    id: "EBDBD608-416A-4FE2-96DF-02367C8D071E",
                    name: "Tag-102"
                ),
                new Tag(
                    id: "F8817638-4CF4-423E-B755-2150F02C432D",
                    name: "Tag-71"
                )
            }
        ),
        new Product(
            id: "8B363B8B-378E-402A-9E68-A935302000B8",
            categoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            categoryName: "Components, Touring Frames",
            sku: "FR-T98Y-46",
            name: "HL Touring Frame - Yellow, 46",
            description: "The product called \"HL Touring Frame - Yellow, 46\"",
            price: 1003.91,
            tags: new List<Tag>
            {
                new Tag(
                    id: "6C6D061E-F701-41DC-AEA2-7A5C28061840",
                    name: "Tag-98"
                ),
                new Tag(
                    id: "89500F13-B516-4F77-8128-47FC412BEFCD",
                    name: "Tag-151"
                ),
                new Tag(
                    id: "D5887E7C-B916-4AF4-BAF8-7B996ADA8C83",
                    name: "Tag-52"
                ),
                new Tag(
                    id: "DBC84212-C3E9-4966-8619-9A4D64EBF517",
                    name: "Tag-125"
                )
            }
        ),
        new Product(
            id: "8B541087-A7F5-43B1-AC9F-EEFB4F4ADAFA",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M18B-42",
            name: "Mountain-500 Black, 42",
            description: "The product called \"Mountain-500 Black, 42\"",
            price: 539.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "125497D0-9175-4ECD-844D-DA71E5F4ED43",
                    name: "Tag-42"
                ),
                new Tag(
                    id: "14CFF1D6-7749-4A57-85B3-783F47731F32",
                    name: "Tag-7"
                ),
                new Tag(
                    id: "45CBB7FF-FA48-49D8-89EF-F1D0B8AC3923",
                    name: "Tag-86"
                )
            }
        ),
        new Product(
            id: "91AA100C-D092-4190-92A7-7C02410F04EA",
            categoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            categoryName: "Components, Touring Frames",
            sku: "FR-T67Y-62",
            name: "LL Touring Frame - Yellow, 62",
            description: "The product called \"LL Touring Frame - Yellow, 62\"",
            price: 333.42,
            tags: new List<Tag>
            {
                new Tag(
                    id: "52FCE975-91EE-4789-9E36-94EC766F02A0",
                    name: "Tag-35"
                )
            }
        ),
        new Product(
            id: "91D3C273-9E79-4395-B444-6D39BF9B2F4D",
            categoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            categoryName: "Components, Touring Frames",
            sku: "FR-T98U-46",
            name: "HL Touring Frame - Blue, 46",
            description: "The product called \"HL Touring Frame - Blue, 46\"",
            price: 1003.91,
            tags: new List<Tag>
            {
                new Tag(
                    id: "375399DC-F2B7-4A8C-8A03-C16B849489D3",
                    name: "Tag-78"
                ),
                new Tag(
                    id: "8CA1BBD8-D00B-4654-AABA-5C8724C6F4BD",
                    name: "Tag-81"
                ),
                new Tag(
                    id: "9467BA7B-49FB-4AA5-A868-478D94AF2E54",
                    name: "Tag-92"
                )
            }
        ),
        new Product(
            id: "935EB2B7-8D50-4E20-B01A-570DBA674AD4",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M82S-38",
            name: "Mountain-100 Silver, 38",
            description: "The product called \"Mountain-100 Silver, 38\"",
            price: 3399.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "B18FB652-C4B6-4A40-BA22-1E687C1A58CE",
                    name: "Tag-161"
                ),
                new Tag(
                    id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    name: "Tag-183"
                ),
                new Tag(
                    id: "EFD6F482-9619-47C2-94FD-DA5D035DEA7A",
                    name: "Tag-144"
                )
            }
        ),
        new Product(
            id: "9C0320C4-124B-486A-BA98-B7B82933F324",
            categoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            categoryName: "Components, Touring Frames",
            sku: "FR-T67U-62",
            name: "LL Touring Frame - Blue, 62",
            description: "The product called \"LL Touring Frame - Blue, 62\"",
            price: 333.42,
            tags: new List<Tag>
            {
                new Tag(
                    id: "775908D7-2622-4C29-AF4D-F2274824DA3B",
                    name: "Tag-89"
                ),
                new Tag(
                    id: "7DF71D87-FB6F-498B-9D7B-E7EBE40350E1",
                    name: "Tag-88"
                ),
                new Tag(
                    id: "A50C570B-B3FC-4678-96C8-2D117DD11A12",
                    name: "Tag-66"
                ),
                new Tag(
                    id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    name: "Tag-183"
                ),
                new Tag(
                    id: "F07885AF-BD6C-4B71-88B1-F04295992176",
                    name: "Tag-149"
                )
            }
        ),
        new Product(
            id: "9DB28F2B-ADC8-40A2-A677-B0AAFC32CAC8",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M82S-48",
            name: "Mountain-100 Silver, 48",
            description: "The product called \"Mountain-100 Silver, 48\"",
            price: 3399.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "29CBEDD8-D9C3-43A3-B20F-63224FEE0D34",
                    name: "Tag-11"
                ),
                new Tag(
                    id: "AA35D2EA-24FD-4A62-80FE-83EFF821F019",
                    name: "Tag-10"
                )
            }
        ),
        new Product(
            id: "A6F069C2-EF85-4B79-9CE2-03833343AD92",
            categoryId: "C3C57C35-1D80-4EC5-AB12-46C57A017AFB",
            categoryName: "Clothing, Jerseys",
            sku: "SJ-0194-M",
            name: "Short-Sleeve Classic Jersey, M",
            description: "The product called \"Short-Sleeve Classic Jersey, M\"",
            price: 53.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "088B5F10-EB9B-4F33-A2E4-F2E54485B90F",
                    name: "Tag-115"
                ),
                new Tag(
                    id: "89FB612A-F9AA-4196-B5F5-B9FA16D558DC",
                    name: "Tag-175"
                ),
                new Tag(
                    id: "A0BA4E3B-AD4A-42AF-BFA4-5F48E2E57F07",
                    name: "Tag-58"
                ),
                new Tag(
                    id: "DEDEB715-41D4-4EBF-BC09-5CCC2943D1A2",
                    name: "Tag-131"
                ),
                new Tag(
                    id: "F202FBC3-B5AA-4E0F-950B-2B5715AC0B3B",
                    name: "Tag-173"
                )
            }
        ),
        new Product(
            id: "ACD4ABE3-82D8-4447-B126-2DE03B7DD106",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M38S-40",
            name: "Mountain-400-W Silver, 40",
            description: "The product called \"Mountain-400-W Silver, 40\"",
            price: 769.49,
            tags: new List<Tag>
            {
                new Tag(
                    id: "F59DC0A2-537E-4A8F-A97D-19C82074D3E7",
                    name: "Tag-146"
                )
            }
        ),
        new Product(
            id: "AFBE0496-C372-4885-B509-507B93027174",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M18S-44",
            name: "Mountain-500 Silver, 44",
            description: "The product called \"Mountain-500 Silver, 44\"",
            price: 564.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "069169DD-F4B3-4769-8841-13B5FF745932",
                    name: "Tag-157"
                ),
                new Tag(
                    id: "33AFFF1B-30AA-41C5-8510-34B67A523CA9",
                    name: "Tag-110"
                ),
                new Tag(
                    id: "46AC3482-E9A6-474D-A435-D3399F21991F",
                    name: "Tag-90"
                ),
                new Tag(
                    id: "C68A2129-1E2B-43EC-95B5-AC56CC200FA4",
                    name: "Tag-180"
                ),
                new Tag(
                    id: "CA170AAD-A5F6-42FF-B115-146FADD87298",
                    name: "Tag-186"
                )
            }
        ),
        new Product(
            id: "B0FE1D0A-CED1-49E8-9ACF-E289A631A4ED",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M47B-44",
            name: "Mountain-300 Black, 44",
            description: "The product called \"Mountain-300 Black, 44\"",
            price: 1079.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "812C1444-1DEA-480D-88E7-B9609ECA783C",
                    name: "Tag-136"
                ),
                new Tag(
                    id: "A2443B36-76AE-4963-9E21-368868F9C514",
                    name: "Tag-6"
                ),
                new Tag(
                    id: "B1EBD7E0-BBE0-4AFB-AC6C-50649484780B",
                    name: "Tag-40"
                )
            }
        ),
        new Product(
            id: "B10065F8-543A-49E7-BFE6-3D19B0BE5670",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M68S-46",
            name: "Mountain-200 Silver, 46",
            description: "The product called \"Mountain-200 Silver, 46\"",
            price: 2319.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "274E32EE-612A-4AAB-B91A-C7E8E4D8C2A7",
                    name: "Tag-1"
                ),
                new Tag(
                    id: "764C1CC8-2E5F-4EF5-83F6-8FF7441290B3",
                    name: "Tag-190"
                ),
                new Tag(
                    id: "D56040DB-E5DF-40BE-9F2F-7E10F4340BCA",
                    name: "Tag-31"
                ),
                new Tag(
                    id: "DB21A27B-5A3F-400C-A0DF-69A5266E1447",
                    name: "Tag-34"
                ),
                new Tag(
                    id: "F533A770-1E5D-4B48-8792-E16E155B6E38",
                    name: "Tag-87"
                )
            }
        ),
        new Product(
            id: "B3847F90-FDF3-4529-B7D0-04FE6F94BFB3",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M18S-48",
            name: "Mountain-500 Silver, 48",
            description: "The product called \"Mountain-500 Silver, 48\"",
            price: 564.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "239313C7-6673-47D1-88D9-6AC61F27D30E",
                    name: "Tag-116"
                ),
                new Tag(
                    id: "9653F306-0B3C-4856-ABF8-13C3F04AE4F0",
                    name: "Tag-36"
                ),
                new Tag(
                    id: "B20574A2-8F94-4CB5-A9A7-2E1E203978D6",
                    name: "Tag-117"
                ),
                new Tag(
                    id: "BA4D7ABD-2E82-4DC2-ACF2-5D3B0DEAE1C1",
                    name: "Tag-59"
                ),
                new Tag(
                    id: "DA661FCF-CC7F-4AF9-A9E2-8E7A5570844E",
                    name: "Tag-188"
                )
            }
        ),
        new Product(
            id: "B79B140D-4369-429B-8F20-E28F3ED7F82A",
            categoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            categoryName: "Components, Touring Frames",
            sku: "FR-T98Y-54",
            name: "HL Touring Frame - Yellow, 54",
            description: "The product called \"HL Touring Frame - Yellow, 54\"",
            price: 1003.91,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "BB21E6EF-104A-420B-B9C5-2084118E5A2F",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M68S-42",
            name: "Mountain-200 Silver, 42",
            description: "The product called \"Mountain-200 Silver, 42\"",
            price: 2319.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "18AC309F-F81C-4234-A752-5DDD2BEAEE83",
                    name: "Tag-32"
                ),
                new Tag(
                    id: "A49D83E4-E506-4301-8110-E114599B4A35",
                    name: "Tag-27"
                ),
                new Tag(
                    id: "C8741857-FD6D-4C28-B594-BAF30BCACB6B",
                    name: "Tag-120"
                ),
                new Tag(
                    id: "F202FBC3-B5AA-4E0F-950B-2B5715AC0B3B",
                    name: "Tag-173"
                )
            }
        ),
        new Product(
            id: "C0FBA4E8-B617-4889-B1A5-091D12783313",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M82B-42",
            name: "Mountain-100 Black, 42",
            description: "The product called \"Mountain-100 Black, 42\"",
            price: 3374.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "12A06E6F-45BF-42DF-9641-F1376CDDB7B1",
                    name: "Tag-22"
                ),
                new Tag(
                    id: "2E7252D2-B646-47FB-B5BB-836643578038",
                    name: "Tag-130"
                )
            }
        ),
        new Product(
            id: "CC8D2C8C-AB60-48BE-A019-33F633DB07CD",
            categoryId: "C3C57C35-1D80-4EC5-AB12-46C57A017AFB",
            categoryName: "Clothing, Jerseys",
            sku: "SJ-0194-X",
            name: "Short-Sleeve Classic Jersey, XL",
            description: "The product called \"Short-Sleeve Classic Jersey, XL\"",
            price: 53.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "69B1D1BA-C166-41F2-B2EB-8B2ADE77943C",
                    name: "Tag-196"
                ),
                new Tag(
                    id: "87BC6842-2CCA-4CD3-994C-33AB101455F4",
                    name: "Tag-12"
                ),
                new Tag(
                    id: "A4D9E596-B630-4792-BDD1-7D6459827820",
                    name: "Tag-164"
                ),
                new Tag(
                    id: "F3A39B6E-753C-4E70-859F-454E8A9624A9",
                    name: "Tag-179"
                )
            }
        ),
        new Product(
            id: "CD5FF4D6-7D2D-4BD4-9319-CB38C1939D96",
            categoryId: "11EF8851-816A-49E2-9D5C-8D17AB82C5FF",
            categoryName: "Accessories, Lights",
            sku: "LT-T990",
            name: "Taillights - Battery-Powered",
            description: "The product called \"Taillights - Battery-Powered\"",
            price: 13.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "46C3C4F8-3FA1-44E9-AE78-37DA965EE913",
                    name: "Tag-46"
                ),
                new Tag(
                    id: "69B1D1BA-C166-41F2-B2EB-8B2ADE77943C",
                    name: "Tag-196"
                ),
                new Tag(
                    id: "76B3C6DC-3411-457B-96F5-A51CE015DAD9",
                    name: "Tag-29"
                ),
                new Tag(
                    id: "9653F306-0B3C-4856-ABF8-13C3F04AE4F0",
                    name: "Tag-36"
                )
            }
        ),
        new Product(
            id: "CEA9FD38-517E-474B-A5B1-B17BF1753F9C",
            categoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            categoryName: "Components, Touring Frames",
            sku: "FR-T67Y-50",
            name: "LL Touring Frame - Yellow, 50",
            description: "The product called \"LL Touring Frame - Yellow, 50\"",
            price: 333.42,
            tags: new List<Tag>
            {
                new Tag(
                    id: "3798DC56-04BE-4A82-B70B-6A0DC7714A36",
                    name: "Tag-105"
                ),
                new Tag(
                    id: "47A34A77-A9B8-4703-9AEF-3786726C7A31",
                    name: "Tag-176"
                ),
                new Tag(
                    id: "7337386B-E865-4ADC-BA17-4437CB02E3BE",
                    name: "Tag-8"
                )
            }
        ),
        new Product(
            id: "D47E0CC9-28A0-40A5-AB90-BB29BDBB0578",
            categoryId: "C3C57C35-1D80-4EC5-AB12-46C57A017AFB",
            categoryName: "Clothing, Jerseys",
            sku: "LJ-0192-X",
            name: "Long-Sleeve Logo Jersey, XL",
            description: "The product called \"Long-Sleeve Logo Jersey, XL\"",
            price: 49.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "125497D0-9175-4ECD-844D-DA71E5F4ED43",
                    name: "Tag-42"
                ),
                new Tag(
                    id: "89500F13-B516-4F77-8128-47FC412BEFCD",
                    name: "Tag-151"
                )
            }
        ),
        new Product(
            id: "DE810086-817F-440C-9FEF-471083B8E4A0",
            categoryId: "C3C57C35-1D80-4EC5-AB12-46C57A017AFB",
            categoryName: "Clothing, Jerseys",
            sku: "LJ-0192-M",
            name: "Long-Sleeve Logo Jersey, M",
            description: "The product called \"Long-Sleeve Logo Jersey, M\"",
            price: 49.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "3798DC56-04BE-4A82-B70B-6A0DC7714A36",
                    name: "Tag-105"
                )
            }
        ),
        new Product(
            id: "DF94F21F-4CDB-4E49-B67B-CAD318A31C4A",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M82B-44",
            name: "Mountain-100 Black, 44",
            description: "The product called \"Mountain-100 Black, 44\"",
            price: 3374.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "14CFF1D6-7749-4A57-85B3-783F47731F32",
                    name: "Tag-7"
                ),
                new Tag(
                    id: "3C26DF5C-CE21-4EF6-AEE2-E8E1066D06B1",
                    name: "Tag-60"
                ),
                new Tag(
                    id: "765EF7D7-331C-42C0-BF23-A3022A723BF7",
                    name: "Tag-191"
                ),
                new Tag(
                    id: "7B37373F-FC14-44FD-96AA-32F4854E0B6B",
                    name: "Tag-63"
                ),
                new Tag(
                    id: "8AAFD985-8BCE-4FA8-85A2-2CA67D9DF8E6",
                    name: "Tag-172"
                )
            }
        ),
        new Product(
            id: "DFE5521E-40C6-4A58-8E8D-5FC1BE5EC0FE",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M82S-44",
            name: "Mountain-100 Silver, 44",
            description: "The product called \"Mountain-100 Silver, 44\"",
            price: 3399.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "4B8ECDDE-FF08-4916-8869-372D08EA8BBA",
                    name: "Tag-106"
                ),
                new Tag(
                    id: "511652EB-9EC2-4235-BA77-0C6E4E316679",
                    name: "Tag-199"
                ),
                new Tag(
                    id: "E1A62ABF-BBC3-48A2-BAC6-E3350D023C83",
                    name: "Tag-194"
                )
            }
        ),
        new Product(
            id: "E2CCAF6F-7AB5-4086-86A3-A50B3E6EF101",
            categoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            categoryName: "Components, Touring Frames",
            sku: "FR-T98Y-60",
            name: "HL Touring Frame - Yellow, 60",
            description: "The product called \"HL Touring Frame - Yellow, 60\"",
            price: 1003.91,
            tags: new List<Tag>
            {
                new Tag(
                    id: "7019202D-B11A-4FAB-ACBC-2D0E5A4F72EF",
                    name: "Tag-143"
                ),
                new Tag(
                    id: "762CE1E0-5615-418E-B476-BCD46AD5E79E",
                    name: "Tag-137"
                ),
                new Tag(
                    id: "C1CB0EFE-02BB-4AE5-AA48-3DAC12921450",
                    name: "Tag-109"
                )
            }
        ),
        new Product(
            id: "E681778F-8359-468B-98F9-4D325D6C377F",
            categoryId: "C3C57C35-1D80-4EC5-AB12-46C57A017AFB",
            categoryName: "Clothing, Jerseys",
            sku: "SJ-0194-S",
            name: "Short-Sleeve Classic Jersey, S",
            description: "The product called \"Short-Sleeve Classic Jersey, S\"",
            price: 53.99,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "E8767BC9-D6BA-47FC-9842-3511468869B6",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M47B-48",
            name: "Mountain-300 Black, 48",
            description: "The product called \"Mountain-300 Black, 48\"",
            price: 1079.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "718DAED6-2186-4E09-8C02-CCC58281838D",
                    name: "Tag-94"
                ),
                new Tag(
                    id: "A0BA4E3B-AD4A-42AF-BFA4-5F48E2E57F07",
                    name: "Tag-58"
                )
            }
        ),
        new Product(
            id: "E9FCF7AC-1F45-4857-9E75-BC30A7C7C27B",
            categoryId: "C0EB227A-55A9-498B-8E21-F39EC5088143",
            categoryName: "Accessories, Cleaners",
            sku: "CL-9009",
            name: "Bike Wash - Dissolver",
            description: "The product called \"Bike Wash - Dissolver\"",
            price: 7.95,
            tags: new List<Tag>
            {
                new Tag(
                    id: "0BC579CA-03FC-4AA6-85AA-A55035201E43",
                    name: "Tag-21"
                ),
                new Tag(
                    id: "A2176C7A-4E0D-4283-AFAA-319A77E9C122",
                    name: "Tag-19"
                )
            }
        ),
        new Product(
            id: "EC65B816-A2A7-4245-B138-43C03F14C514",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M68B-46",
            name: "Mountain-200 Black, 46",
            description: "The product called \"Mountain-200 Black, 46\"",
            price: 2294.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "088B5F10-EB9B-4F33-A2E4-F2E54485B90F",
                    name: "Tag-115"
                ),
                new Tag(
                    id: "A2176C7A-4E0D-4283-AFAA-319A77E9C122",
                    name: "Tag-19"
                ),
                new Tag(
                    id: "BB35DF88-8BCE-4267-838B-9265BAE64EDF",
                    name: "Tag-160"
                ),
                new Tag(
                    id: "F202FBC3-B5AA-4E0F-950B-2B5715AC0B3B",
                    name: "Tag-173"
                )
            }
        ),
        new Product(
            id: "EE40F7FD-AB2C-4589-B54D-BEBACB3B083E",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M82B-48",
            name: "Mountain-100 Black, 48",
            description: "The product called \"Mountain-100 Black, 48\"",
            price: 3374.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "DBC21C2A-0AF6-45D4-B2C9-703DD708A821",
                    name: "Tag-14"
                )
            }
        ),
        new Product(
            id: "EF3F4DC1-5F73-4234-B10E-6608F4DC937A",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M68S-38",
            name: "Mountain-200 Silver, 38",
            description: "The product called \"Mountain-200 Silver, 38\"",
            price: 2319.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "3A3A99B6-E3BF-46D0-BAD9-F5F4DBB720F4",
                    name: "Tag-70"
                ),
                new Tag(
                    id: "51CD93BF-098C-4C25-9829-4AD42046D038",
                    name: "Tag-25"
                ),
                new Tag(
                    id: "6C2F05C8-1E61-4912-BE1A-C67A378429BB",
                    name: "Tag-5"
                ),
                new Tag(
                    id: "B48D6572-67EB-4630-A1DB-AFD4AD7041C9",
                    name: "Tag-100"
                )
            }
        ),
        new Product(
            id: "EFD1F33B-94AE-4309-B6E6-F9CCC2B61278",
            categoryId: "11EF8851-816A-49E2-9D5C-8D17AB82C5FF",
            categoryName: "Accessories, Lights",
            sku: "LT-H903",
            name: "Headlights - Weatherproof",
            description: "The product called \"Headlights - Weatherproof\"",
            price: 44.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "45CBB7FF-FA48-49D8-89EF-F1D0B8AC3923",
                    name: "Tag-86"
                ),
                new Tag(
                    id: "775908D7-2622-4C29-AF4D-F2274824DA3B",
                    name: "Tag-89"
                ),
                new Tag(
                    id: "79E61D0F-3C95-4353-BF27-DB04535088C9",
                    name: "Tag-50"
                ),
                new Tag(
                    id: "83D720BA-BB31-4BE5-B723-8A836AB6D532",
                    name: "Tag-127"
                ),
                new Tag(
                    id: "C8741857-FD6D-4C28-B594-BAF30BCACB6B",
                    name: "Tag-120"
                )
            }
        ),
        new Product(
            id: "F2447558-7C01-442E-A7BC-B6D5D8AE1070",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M82B-38",
            name: "Mountain-100 Black, 38",
            description: "The product called \"Mountain-100 Black, 38\"",
            price: 3374.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "227FF627-9E87-4BE5-8254-17BB155B0AD7",
                    name: "Tag-23"
                ),
                new Tag(
                    id: "6C2F05C8-1E61-4912-BE1A-C67A378429BB",
                    name: "Tag-5"
                ),
                new Tag(
                    id: "A2AFF2FF-8438-44A3-8AC6-20A50422D82A",
                    name: "Tag-18"
                ),
                new Tag(
                    id: "C1CB0EFE-02BB-4AE5-AA48-3DAC12921450",
                    name: "Tag-109"
                ),
                new Tag(
                    id: "DBC84212-C3E9-4966-8619-9A4D64EBF517",
                    name: "Tag-125"
                )
            }
        ),
        new Product(
            id: "F5FB0386-C6AC-40AE-9342-7AFB832233A8",
            categoryId: "27A716B2-6F81-4A2C-B7E9-0B2AF5D8E51A",
            categoryName: "Accessories, Locks",
            sku: "LO-C100",
            name: "Cable Lock",
            description: "The product called \"Cable Lock\"",
            price: 25.0,
            tags: new List<Tag>
            {
                new Tag(
                    id: "0BC579CA-03FC-4AA6-85AA-A55035201E43",
                    name: "Tag-21"
                ),
                new Tag(
                    id: "1CFF105D-294E-4E2D-ADE4-0615CBDEBC28",
                    name: "Tag-44"
                ),
                new Tag(
                    id: "606E1794-5457-42A7-90FB-206142EEF023",
                    name: "Tag-132"
                ),
                new Tag(
                    id: "A9834752-41CA-47F5-8A5A-D9A878DF0ACB",
                    name: "Tag-198"
                ),
                new Tag(
                    id: "CA170AAD-A5F6-42FF-B115-146FADD87298",
                    name: "Tag-186"
                )
            }
        ),
        new Product(
            id: "FA06B762-D602-4235-8F77-D8AFB0D3D050",
            categoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            categoryName: "Components, Touring Frames",
            sku: "FR-T67U-54",
            name: "LL Touring Frame - Blue, 54",
            description: "The product called \"LL Touring Frame - Blue, 54\"",
            price: 333.42,
            tags: new List<Tag>
            {
                new Tag(
                    id: "4B10B00B-C1CA-4508-9848-3B1BD910B724",
                    name: "Tag-30"
                ),
                new Tag(
                    id: "84C396AD-98C6-4B12-8C3A-1BDA3ABF7D73",
                    name: "Tag-24"
                ),
                new Tag(
                    id: "89FB612A-F9AA-4196-B5F5-B9FA16D558DC",
                    name: "Tag-175"
                ),
                new Tag(
                    id: "D32CFC73-640F-48B6-976D-B053DCD0F393",
                    name: "Tag-178"
                ),
                new Tag(
                    id: "EBDBD608-416A-4FE2-96DF-02367C8D071E",
                    name: "Tag-102"
                )
            }
        ),
        new Product(
            id: "FADA3DBE-28DC-4FFA-823E-99332AD2EA0C",
            categoryId: "11EF8851-816A-49E2-9D5C-8D17AB82C5FF",
            categoryName: "Accessories, Lights",
            sku: "LT-H902",
            name: "Headlights - Dual-Beam",
            description: "The product called \"Headlights - Dual-Beam\"",
            price: 34.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "E6CB7972-06F4-47C0-B464-F64E695F89E7",
                    name: "Tag-51"
                )
            }
        ),
        new Product(
            id: "FB9A5084-F2B2-4C3B-9CF9-252873CABFF7",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M38S-46",
            name: "Mountain-400-W Silver, 46",
            description: "The product called \"Mountain-400-W Silver, 46\"",
            price: 769.49,
            tags: new List<Tag>
            {
                new Tag(
                    id: "DCDBD26C-4D71-4F91-BBE9-98D1897E704D",
                    name: "Tag-68"
                ),
                new Tag(
                    id: "F6B1A09C-BCC9-4A74-8472-D1CA98310501",
                    name: "Tag-185"
                )
            }
        ),
        new Product(
            id: "FDEF01CB-5067-414F-B0A3-07FF8A4B80DD",
            categoryId: "14A1AD5D-59EA-4B63-A189-67B077783B0E",
            categoryName: "Accessories, Helmets",
            sku: "HL-U509-R",
            name: "Sport-100 Helmet, Red",
            description: "The product called \"Sport-100 Helmet, Red\"",
            price: 34.99,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "FE8FFBD3-99AE-4ECF-AA53-D1304D941EC7",
            categoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            categoryName: "Bikes, Mountain Bikes",
            sku: "BK-M47B-40",
            name: "Mountain-300 Black, 40",
            description: "The product called \"Mountain-300 Black, 40\"",
            price: 1079.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "B1EBD7E0-BBE0-4AFB-AC6C-50649484780B",
                    name: "Tag-40"
                )
            }
        ),
        new Product(
            id: "063F1A00-8CA1-4DB9-8298-BEAC4B8CC238",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R79Y-48",
            name: "Road-350-W Yellow, 48",
            description: "The product called \"Road-350-W Yellow, 48\"",
            price: 1700.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "033D3826-2851-4B97-9464-59D3675175D4",
                    name: "Tag-108"
                ),
                new Tag(
                    id: "E468DF53-4836-4546-9D05-C855AAC4B0AF",
                    name: "Tag-2"
                ),
                new Tag(
                    id: "E661634D-CDC3-4FA6-BE4B-D1FEEAECB5B9",
                    name: "Tag-121"
                )
            }
        ),
        new Product(
            id: "06AC4FFF-9F97-429B-BB15-ED929EFF65EE",
            categoryId: "C48B4EF4-D352-4CD2-BCB8-CE89B7DFA642",
            categoryName: "Clothing, Socks",
            sku: "SO-R809-M",
            name: "Racing Socks, M",
            description: "The product called \"Racing Socks, M\"",
            price: 8.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "125497D0-9175-4ECD-844D-DA71E5F4ED43",
                    name: "Tag-42"
                ),
                new Tag(
                    id: "239313C7-6673-47D1-88D9-6AC61F27D30E",
                    name: "Tag-116"
                )
            }
        ),
        new Product(
            id: "0846D2C3-7E50-4F68-A6CB-F0DC90FD03D0",
            categoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            categoryName: "Components, Wheels",
            sku: "FW-T905",
            name: "Touring Front Wheel",
            description: "The product called \"Touring Front Wheel\"",
            price: 218.01,
            tags: new List<Tag>
            {
                new Tag(
                    id: "7DF71D87-FB6F-498B-9D7B-E7EBE40350E1",
                    name: "Tag-88"
                ),
                new Tag(
                    id: "AA24EC37-7CE3-4ABE-B935-EC62D5FB6947",
                    name: "Tag-148"
                ),
                new Tag(
                    id: "CA7D17BB-45A6-47E6-A3E3-E70AF34C2072",
                    name: "Tag-158"
                ),
                new Tag(
                    id: "D69B1B6C-4963-4E85-8FA5-6A3E1CD1C83B",
                    name: "Tag-187"
                ),
                new Tag(
                    id: "E23954CF-D79A-433E-9BE6-FD787C5E4C9B",
                    name: "Tag-111"
                )
            }
        ),
        new Product(
            id: "0990C3D9-4EC2-4272-ADB6-9481CA12F5F6",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M94B-38",
            name: "HL Mountain Frame - Black, 38",
            description: "The product called \"HL Mountain Frame - Black, 38\"",
            price: 1349.6,
            tags: new List<Tag>
            {
                new Tag(
                    id: "762CE1E0-5615-418E-B476-BCD46AD5E79E",
                    name: "Tag-137"
                ),
                new Tag(
                    id: "7CACE200-11A3-4E2D-A88E-25E9614D2BE9",
                    name: "Tag-97"
                ),
                new Tag(
                    id: "84C1934D-F048-4D2B-8525-323AFE2A7C7C",
                    name: "Tag-184"
                ),
                new Tag(
                    id: "CAF27567-B4CB-463C-A54E-5EF1F2657DD2",
                    name: "Tag-75"
                )
            }
        ),
        new Product(
            id: "0C3D95EB-EE37-44A5-816F-957A98519B03",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R50B-44",
            name: "Road-650 Black, 44",
            description: "The product called \"Road-650 Black, 44\"",
            price: 782.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "1745EF28-6E0B-4FED-8925-BC3174F583B0",
                    name: "Tag-48"
                ),
                new Tag(
                    id: "4B10B00B-C1CA-4508-9848-3B1BD910B724",
                    name: "Tag-30"
                ),
                new Tag(
                    id: "537DB3C8-8636-4005-8FE2-32EECEBA5B3F",
                    name: "Tag-80"
                ),
                new Tag(
                    id: "C68A2129-1E2B-43EC-95B5-AC56CC200FA4",
                    name: "Tag-180"
                )
            }
        ),
        new Product(
            id: "0D7CB85D-4518-4E02-8E46-9683947BBBC4",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R68R-52",
            name: "Road-450 Red, 52",
            description: "The product called \"Road-450 Red, 52\"",
            price: 1457.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "461ADE06-0903-4BAF-97AB-CC713E5B1DD4",
                    name: "Tag-174"
                ),
                new Tag(
                    id: "8CA1BBD8-D00B-4654-AABA-5C8724C6F4BD",
                    name: "Tag-81"
                )
            }
        ),
        new Product(
            id: "0E92DDAC-F969-4F63-8D5E-614AB5199D01",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R89R-44",
            name: "Road-250 Red, 44",
            description: "The product called \"Road-250 Red, 44\"",
            price: 2443.35,
            tags: new List<Tag>
            {
                new Tag(
                    id: "27B7F8D5-1009-45B8-88F5-41008A0F0393",
                    name: "Tag-61"
                ),
                new Tag(
                    id: "29CBEDD8-D9C3-43A3-B20F-63224FEE0D34",
                    name: "Tag-11"
                ),
                new Tag(
                    id: "8CA1BBD8-D00B-4654-AABA-5C8724C6F4BD",
                    name: "Tag-81"
                ),
                new Tag(
                    id: "DBE23FA0-0D99-47F5-BCD7-3D798CE653AE",
                    name: "Tag-55"
                )
            }
        ),
        new Product(
            id: "11E6FD95-0FF1-4FE8-9A6B-EC53F614212D",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R19B-58",
            name: "Road-750 Black, 58",
            description: "The product called \"Road-750 Black, 58\"",
            price: 539.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "375399DC-F2B7-4A8C-8A03-C16B849489D3",
                    name: "Tag-78"
                ),
                new Tag(
                    id: "3BFB03A9-3106-44C7-823A-DB1A67E283C3",
                    name: "Tag-47"
                ),
                new Tag(
                    id: "461ADE06-0903-4BAF-97AB-CC713E5B1DD4",
                    name: "Tag-174"
                ),
                new Tag(
                    id: "9E250CCC-6530-4DC0-9D64-E7777B3C3B73",
                    name: "Tag-177"
                ),
                new Tag(
                    id: "D2427B7F-AF57-498B-A73E-E7D67FD5CFD9",
                    name: "Tag-195"
                )
            }
        ),
        new Product(
            id: "14912B0B-EA77-47B8-8F1C-C8E4BE859D7C",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M21S-42",
            name: "LL Mountain Frame - Silver, 42",
            description: "The product called \"LL Mountain Frame - Silver, 42\"",
            price: 264.05,
            tags: new List<Tag>
            {
                new Tag(
                    id: "4B10B00B-C1CA-4508-9848-3B1BD910B724",
                    name: "Tag-30"
                ),
                new Tag(
                    id: "4E102F3F-7D57-4CD7-88F4-AC5076A42C59",
                    name: "Tag-91"
                ),
                new Tag(
                    id: "7F518FB1-4664-4B20-9B9F-23D5B44F6798",
                    name: "Tag-69"
                ),
                new Tag(
                    id: "A0A28560-17B9-4457-B993-D39AF56B53C8",
                    name: "Tag-99"
                ),
                new Tag(
                    id: "B48D6572-67EB-4630-A1DB-AFD4AD7041C9",
                    name: "Tag-100"
                )
            }
        ),
        new Product(
            id: "18711AD6-0999-4E74-B2F5-81720A6BA5A2",
            categoryId: "B5EF9CFA-FD22-4888-858D-2C8C5E4B2EFA",
            categoryName: "Components, Handlebars",
            sku: "HB-T928",
            name: "HL Touring Handlebars",
            description: "The product called \"HL Touring Handlebars\"",
            price: 91.57,
            tags: new List<Tag>
            {
                new Tag(
                    id: "A9834752-41CA-47F5-8A5A-D9A878DF0ACB",
                    name: "Tag-198"
                )
            }
        ),
        new Product(
            id: "18B722BF-4742-4F1F-8336-3AB2E76B2908",
            categoryId: "E048A761-8038-42C2-8367-F21FF0DAA3F4",
            categoryName: "Accessories, Fenders",
            sku: "FE-6654",
            name: "Fender Set - Mountain",
            description: "The product called \"Fender Set - Mountain\"",
            price: 21.98,
            tags: new List<Tag>
            {
                new Tag(
                    id: "27B7F8D5-1009-45B8-88F5-41008A0F0393",
                    name: "Tag-61"
                ),
                new Tag(
                    id: "40525E23-C1FB-4213-BF28-2B4C64BDC29B",
                    name: "Tag-135"
                ),
                new Tag(
                    id: "6FB11EB9-319C-431C-89D7-70113401D186",
                    name: "Tag-154"
                )
            }
        ),
        new Product(
            id: "1E0D3EBA-563D-4DA1-8D6C-FE9C7A63EE2B",
            categoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            categoryName: "Components, Wheels",
            sku: "FW-R820",
            name: "HL Road Front Wheel",
            description: "The product called \"HL Road Front Wheel\"",
            price: 330.06,
            tags: new List<Tag>
            {
                new Tag(
                    id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    name: "Tag-183"
                ),
                new Tag(
                    id: "D1E5CB02-8E7B-422F-9421-C0E608F0AC4C",
                    name: "Tag-133"
                ),
                new Tag(
                    id: "E6D5275B-8C42-47AE-BDEC-FC708DB3E0AC",
                    name: "Tag-119"
                )
            }
        ),
        new Product(
            id: "209B4171-CB26-4231-8F41-D092F4679BB9",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M94S-52",
            name: "HL Mountain Frame - Silver, 48",
            description: "The product called \"HL Mountain Frame - Silver, 48\"",
            price: 1364.5,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "243AE98C-D657-415C-9EF4-D8FA8F8770AA",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R50R-48",
            name: "Road-650 Red, 48",
            description: "The product called \"Road-650 Red, 48\"",
            price: 782.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "775908D7-2622-4C29-AF4D-F2274824DA3B",
                    name: "Tag-89"
                )
            }
        ),
        new Product(
            id: "2595584F-EA4E-4D45-948E-99A17AF8C519",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R19B-48",
            name: "Road-750 Black, 48",
            description: "The product called \"Road-750 Black, 48\"",
            price: 539.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "52FCE975-91EE-4789-9E36-94EC766F02A0",
                    name: "Tag-35"
                ),
                new Tag(
                    id: "7990C336-92BD-41F9-8FB6-97390BC4D187",
                    name: "Tag-189"
                )
            }
        ),
        new Product(
            id: "25B35002-7F61-45E3-AA55-80A743C3BC36",
            categoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            categoryName: "Components, Wheels",
            sku: "FW-R623",
            name: "LL Road Front Wheel",
            description: "The product called \"LL Road Front Wheel\"",
            price: 85.565,
            tags: new List<Tag>
            {
                new Tag(
                    id: "66D8EA21-E1F0-471C-A17F-02F3B149D6E6",
                    name: "Tag-83"
                ),
                new Tag(
                    id: "DBE23FA0-0D99-47F5-BCD7-3D798CE653AE",
                    name: "Tag-55"
                )
            }
        ),
        new Product(
            id: "26E8185C-782A-4B48-87FA-1E715E3825FB",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R64Y-48",
            name: "Road-550-W Yellow, 48",
            description: "The product called \"Road-550-W Yellow, 48\"",
            price: 1120.49,
            tags: new List<Tag>
            {
                new Tag(
                    id: "46AC3482-E9A6-474D-A435-D3399F21991F",
                    name: "Tag-90"
                ),
                new Tag(
                    id: "9C89E562-1247-435D-B786-4E54024E681C",
                    name: "Tag-128"
                )
            }
        ),
        new Product(
            id: "28A93A52-553C-4755-A2C4-07C1F5BD30F5",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M94B-46",
            name: "HL Mountain Frame - Black, 46",
            description: "The product called \"HL Mountain Frame - Black, 46\"",
            price: 1349.6,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "295ABC00-9080-479C-9733-A9BE712D7A18",
            categoryId: "C48B4EF4-D352-4CD2-BCB8-CE89B7DFA642",
            categoryName: "Clothing, Socks",
            sku: "SO-R809-L",
            name: "Racing Socks, L",
            description: "The product called \"Racing Socks, L\"",
            price: 8.99,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "2BBCE73F-9D1D-4BE1-808C-8B174D0DA1A2",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M21B-52",
            name: "LL Mountain Frame - Black, 52",
            description: "The product called \"LL Mountain Frame - Black, 52\"",
            price: 249.79,
            tags: new List<Tag>
            {
                new Tag(
                    id: "69212884-78CF-48C9-A5C6-B62E76725533",
                    name: "Tag-104"
                )
            }
        ),
        new Product(
            id: "2FBE9F71-86EC-4FEB-BBF4-5580FD28E3FD",
            categoryId: "C7324EF3-D951-45D9-A345-A82EAE344394",
            categoryName: "Clothing, Shorts",
            sku: "SH-M897-X",
            name: "Men's Sports Shorts, XL",
            description: "The product called \"Men's Sports Shorts, XL\"",
            price: 59.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "033D3826-2851-4B97-9464-59D3675175D4",
                    name: "Tag-108"
                )
            }
        ),
        new Product(
            id: "3933505E-7BD5-458D-84FE-546AA3520A66",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R68R-44",
            name: "Road-450 Red, 44",
            description: "The product called \"Road-450 Red, 44\"",
            price: 1457.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "76B3C6DC-3411-457B-96F5-A51CE015DAD9",
                    name: "Tag-29"
                ),
                new Tag(
                    id: "8BAC6191-1DAE-4F5B-88FC-7081B682095D",
                    name: "Tag-15"
                ),
                new Tag(
                    id: "9E250CCC-6530-4DC0-9D64-E7777B3C3B73",
                    name: "Tag-177"
                ),
                new Tag(
                    id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    name: "Tag-183"
                ),
                new Tag(
                    id: "F3A39B6E-753C-4E70-859F-454E8A9624A9",
                    name: "Tag-179"
                )
            }
        ),
        new Product(
            id: "39F4BE10-8C68-4E7E-A185-B05BCA543B9F",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R50B-52",
            name: "Road-650 Black, 52",
            description: "The product called \"Road-650 Black, 52\"",
            price: 782.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "2901FEF6-491C-40F5-B2CE-ECF80735BE5D",
                    name: "Tag-159"
                ),
                new Tag(
                    id: "35047162-8B96-4BC7-A31D-4186126DBF00",
                    name: "Tag-169"
                ),
                new Tag(
                    id: "66D8EA21-E1F0-471C-A17F-02F3B149D6E6",
                    name: "Tag-83"
                ),
                new Tag(
                    id: "80F182C6-0619-4547-9A2D-F90A7913FACF",
                    name: "Tag-96"
                ),
                new Tag(
                    id: "CA170AAD-A5F6-42FF-B115-146FADD87298",
                    name: "Tag-186"
                )
            }
        ),
        new Product(
            id: "3A70EDD4-6C8C-44AA-A13D-49D0F6058699",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R64Y-40",
            name: "Road-550-W Yellow, 40",
            description: "The product called \"Road-550-W Yellow, 40\"",
            price: 1120.49,
            tags: new List<Tag>
            {
                new Tag(
                    id: "2CE9DADE-DCAC-436C-9D69-B7C886A01B77",
                    name: "Tag-101"
                ),
                new Tag(
                    id: "CA7D17BB-45A6-47E6-A3E3-E70AF34C2072",
                    name: "Tag-158"
                )
            }
        ),
        new Product(
            id: "3CE3E061-88E1-4430-BAC7-809B285FC702",
            categoryId: "C7324EF3-D951-45D9-A345-A82EAE344394",
            categoryName: "Clothing, Shorts",
            sku: "SH-M897-M",
            name: "Men's Sports Shorts, M",
            description: "The product called \"Men's Sports Shorts, M\"",
            price: 59.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "B1C00DC4-236A-4A5F-844C-3F56BBE87968",
                    name: "Tag-167"
                )
            }
        ),
        new Product(
            id: "3D9B62A3-3CDF-45A2-B64C-8A9890818E2C",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M21B-48",
            name: "LL Mountain Frame - Black, 48",
            description: "The product called \"LL Mountain Frame - Black, 48\"",
            price: 249.79,
            tags: new List<Tag>
            {
                new Tag(
                    id: "A4D9E596-B630-4792-BDD1-7D6459827820",
                    name: "Tag-164"
                )
            }
        ),
        new Product(
            id: "3E144819-7455-4362-A4BB-FAD007A90AEF",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M94S-44",
            name: "HL Mountain Frame - Silver, 44",
            description: "The product called \"HL Mountain Frame - Silver, 44\"",
            price: 1364.5,
            tags: new List<Tag>
            {
                new Tag(
                    id: "0C184C69-F4F2-4774-9645-46F53D297D95",
                    name: "Tag-49"
                ),
                new Tag(
                    id: "59676183-1BD7-48A0-B3B0-42B3C0800EB0",
                    name: "Tag-64"
                ),
                new Tag(
                    id: "775908D7-2622-4C29-AF4D-F2274824DA3B",
                    name: "Tag-89"
                ),
                new Tag(
                    id: "D32CFC73-640F-48B6-976D-B053DCD0F393",
                    name: "Tag-178"
                )
            }
        ),
        new Product(
            id: "3F3E4045-AC4D-4D28-99D5-6C9C53F1DEAF",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M21B-40",
            name: "LL Mountain Frame - Black, 40",
            description: "The product called \"LL Mountain Frame - Black, 40\"",
            price: 249.79,
            tags: new List<Tag>
            {
                new Tag(
                    id: "375399DC-F2B7-4A8C-8A03-C16B849489D3",
                    name: "Tag-78"
                ),
                new Tag(
                    id: "7019202D-B11A-4FAB-ACBC-2D0E5A4F72EF",
                    name: "Tag-143"
                )
            }
        ),
        new Product(
            id: "42FDA4EC-96CA-4160-956A-3870549AF76E",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R64Y-42",
            name: "Road-550-W Yellow, 42",
            description: "The product called \"Road-550-W Yellow, 42\"",
            price: 1120.49,
            tags: new List<Tag>
            {
                new Tag(
                    id: "BA4D7ABD-2E82-4DC2-ACF2-5D3B0DEAE1C1",
                    name: "Tag-59"
                ),
                new Tag(
                    id: "CA170AAD-A5F6-42FF-B115-146FADD87298",
                    name: "Tag-186"
                ),
                new Tag(
                    id: "DBC21C2A-0AF6-45D4-B2C9-703DD708A821",
                    name: "Tag-14"
                )
            }
        ),
        new Product(
            id: "4973E28A-A70A-45B9-8517-5D3B647E82C2",
            categoryId: "BDC73EF8-1745-4A45-8944-D2868A763819",
            categoryName: "Accessories, Bike Racks",
            sku: "RA-H123",
            name: "Hitch Rack - 4-Bike",
            description: "The product called \"Hitch Rack - 4-Bike\"",
            price: 120.0,
            tags: new List<Tag>
            {
                new Tag(
                    id: "5D24B427-1402-49DE-B79B-5A7013579FBC",
                    name: "Tag-76"
                ),
                new Tag(
                    id: "CA7D17BB-45A6-47E6-A3E3-E70AF34C2072",
                    name: "Tag-158"
                )
            }
        ),
        new Product(
            id: "49ACE2DB-4315-4C16-819E-BE372922C634",
            categoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            categoryName: "Components, Wheels",
            sku: "RW-R820",
            name: "HL Road Rear Wheel",
            description: "The product called \"HL Road Rear Wheel\"",
            price: 357.06,
            tags: new List<Tag>
            {
                new Tag(
                    id: "5A94DABD-FD34-48F7-9626-50872E214275",
                    name: "Tag-181"
                ),
                new Tag(
                    id: "9653F306-0B3C-4856-ABF8-13C3F04AE4F0",
                    name: "Tag-36"
                )
            }
        ),
        new Product(
            id: "49E5C64F-B689-4C0B-9E2C-5DFF006B929D",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M63S-40",
            name: "ML Mountain Frame-W - Silver, 40",
            description: "The product called \"ML Mountain Frame-W - Silver, 40\"",
            price: 364.09,
            tags: new List<Tag>
            {
                new Tag(
                    id: "1A2E203E-B80D-4693-A7C2-AB39E31C9C61",
                    name: "Tag-134"
                ),
                new Tag(
                    id: "B3EC53EB-000D-4E66-975A-910771520A6E",
                    name: "Tag-54"
                ),
                new Tag(
                    id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    name: "Tag-183"
                )
            }
        ),
        new Product(
            id: "4F9FC42A-F43F-4C13-92FC-ADF701F48C36",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R79Y-44",
            name: "Road-350-W Yellow, 44",
            description: "The product called \"Road-350-W Yellow, 44\"",
            price: 1700.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "8BAC6191-1DAE-4F5B-88FC-7081B682095D",
                    name: "Tag-15"
                )
            }
        ),
        new Product(
            id: "50DC9B64-03B8-49AB-9DB4-75D12B3180D8",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M63B-48",
            name: "ML Mountain Frame - Black, 48",
            description: "The product called \"ML Mountain Frame - Black, 48\"",
            price: 348.76,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "58C93A21-73D1-44D8-ACF1-3A9E1DB0CE0D",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R93R-52",
            name: "Road-150 Red, 52",
            description: "The product called \"Road-150 Red, 52\"",
            price: 3578.27,
            tags: new List<Tag>
            {
                new Tag(
                    id: "35047162-8B96-4BC7-A31D-4186126DBF00",
                    name: "Tag-169"
                ),
                new Tag(
                    id: "59676183-1BD7-48A0-B3B0-42B3C0800EB0",
                    name: "Tag-64"
                ),
                new Tag(
                    id: "A07D69D4-B8B9-4662-8148-8033DCDCC000",
                    name: "Tag-142"
                ),
                new Tag(
                    id: "DBC21C2A-0AF6-45D4-B2C9-703DD708A821",
                    name: "Tag-14"
                )
            }
        ),
        new Product(
            id: "5C24E8CD-2BFF-460A-88D4-3A2926407346",
            categoryId: "B5EF9CFA-FD22-4888-858D-2C8C5E4B2EFA",
            categoryName: "Components, Handlebars",
            sku: "HB-M918",
            name: "HL Mountain Handlebars",
            description: "The product called \"HL Mountain Handlebars\"",
            price: 120.27,
            tags: new List<Tag>
            {
                new Tag(
                    id: "4B8ECDDE-FF08-4916-8869-372D08EA8BBA",
                    name: "Tag-106"
                ),
                new Tag(
                    id: "B49C6195-5ABA-42FA-B15C-84CF9FE252FE",
                    name: "Tag-129"
                )
            }
        ),
        new Product(
            id: "626D67C2-C316-49EB-8316-129BDFBFDE8A",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R50R-60",
            name: "Road-650 Red, 60",
            description: "The product called \"Road-650 Red, 60\"",
            price: 782.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "8A104DF9-CB32-4C6E-951F-8F7DAF9E2BC1",
                    name: "Tag-200"
                ),
                new Tag(
                    id: "D56040DB-E5DF-40BE-9F2F-7E10F4340BCA",
                    name: "Tag-31"
                )
            }
        ),
        new Product(
            id: "637D953B-42DB-4219-927F-51687E889A04",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R93R-56",
            name: "Road-150 Red, 56",
            description: "The product called \"Road-150 Red, 56\"",
            price: 3578.27,
            tags: new List<Tag>
            {
                new Tag(
                    id: "764C1CC8-2E5F-4EF5-83F6-8FF7441290B3",
                    name: "Tag-190"
                ),
                new Tag(
                    id: "765254E3-8E88-4C57-AADA-9F5126917970",
                    name: "Tag-93"
                ),
                new Tag(
                    id: "9C89E562-1247-435D-B786-4E54024E681C",
                    name: "Tag-128"
                ),
                new Tag(
                    id: "D77B44A9-7951-4CC8-BB27-8B5D78CFDDF8",
                    name: "Tag-124"
                ),
                new Tag(
                    id: "DBE23FA0-0D99-47F5-BCD7-3D798CE653AE",
                    name: "Tag-55"
                )
            }
        ),
        new Product(
            id: "64B3F15E-3E21-4ECD-9013-E50ABD324337",
            categoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            categoryName: "Components, Wheels",
            sku: "RW-M423",
            name: "LL Mountain Rear Wheel",
            description: "The product called \"LL Mountain Rear Wheel\"",
            price: 87.745,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "6964ECD2-6FC5-4D65-88BC-126BC2BE2CCB",
            categoryId: "C48B4EF4-D352-4CD2-BCB8-CE89B7DFA642",
            categoryName: "Clothing, Socks",
            sku: "SO-B909-L",
            name: "Mountain Bike Socks, L",
            description: "The product called \"Mountain Bike Socks, L\"",
            price: 9.5,
            tags: new List<Tag>
            {
                new Tag(
                    id: "23ECB896-D6C6-4E9D-BE43-1908CB5C5E07",
                    name: "Tag-112"
                ),
                new Tag(
                    id: "567D183B-9ED1-47B4-AE22-80C52BF41067",
                    name: "Tag-165"
                ),
                new Tag(
                    id: "F07885AF-BD6C-4B71-88B1-F04295992176",
                    name: "Tag-149"
                )
            }
        ),
        new Product(
            id: "6AEDC59D-F3E3-4B4F-9290-7EFC225B7F42",
            categoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            categoryName: "Components, Wheels",
            sku: "FW-M928",
            name: "HL Mountain Front Wheel",
            description: "The product called \"HL Mountain Front Wheel\"",
            price: 300.215,
            tags: new List<Tag>
            {
                new Tag(
                    id: "0485B9B8-3A52-49FD-98D4-8515CCD057F3",
                    name: "Tag-162"
                ),
                new Tag(
                    id: "606E1794-5457-42A7-90FB-206142EEF023",
                    name: "Tag-132"
                ),
                new Tag(
                    id: "A30014DE-B012-4049-B456-4630527AF47F",
                    name: "Tag-9"
                )
            }
        ),
        new Product(
            id: "6B41F665-5810-4AFD-8323-6106A8593EFC",
            categoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            categoryName: "Components, Wheels",
            sku: "RW-M928",
            name: "HL Mountain Rear Wheel",
            description: "The product called \"HL Mountain Rear Wheel\"",
            price: 327.215,
            tags: new List<Tag>
            {
                new Tag(
                    id: "1B387A00-57D3-4444-8331-18A90725E98B",
                    name: "Tag-43"
                )
            }
        ),
        new Product(
            id: "6E059A32-56B5-4D98-AC6A-945B488B32A1",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R93R-62",
            name: "Road-150 Red, 62",
            description: "The product called \"Road-150 Red, 62\"",
            price: 3578.27,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "6EAA3D6B-A290-48C4-B3ED-D668261512CD",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M63S-46",
            name: "ML Mountain Frame-W - Silver, 46",
            description: "The product called \"ML Mountain Frame-W - Silver, 46\"",
            price: 364.09,
            tags: new List<Tag>
            {
                new Tag(
                    id: "EBDBD608-416A-4FE2-96DF-02367C8D071E",
                    name: "Tag-102"
                )
            }
        ),
        new Product(
            id: "707106D2-0687-4217-AD2C-A6B828DFE075",
            categoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            categoryName: "Components, Wheels",
            sku: "RW-R762",
            name: "ML Road Rear Wheel",
            description: "The product called \"ML Road Rear Wheel\"",
            price: 275.385,
            tags: new List<Tag>
            {
                new Tag(
                    id: "1830EEDD-AF21-43EA-A13C-393ED77DEAC5",
                    name: "Tag-152"
                ),
                new Tag(
                    id: "6C6D061E-F701-41DC-AEA2-7A5C28061840",
                    name: "Tag-98"
                )
            }
        ),
        new Product(
            id: "71BC9DC2-A409-4B4A-A34B-FCBF1E596FCF",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R93R-48",
            name: "Road-150 Red, 48",
            description: "The product called \"Road-150 Red, 48\"",
            price: 3578.27,
            tags: new List<Tag>
            {
                new Tag(
                    id: "125497D0-9175-4ECD-844D-DA71E5F4ED43",
                    name: "Tag-42"
                ),
                new Tag(
                    id: "227FF627-9E87-4BE5-8254-17BB155B0AD7",
                    name: "Tag-23"
                ),
                new Tag(
                    id: "7B37373F-FC14-44FD-96AA-32F4854E0B6B",
                    name: "Tag-63"
                ),
                new Tag(
                    id: "8AAFD985-8BCE-4FA8-85A2-2CA67D9DF8E6",
                    name: "Tag-172"
                ),
                new Tag(
                    id: "DBC21C2A-0AF6-45D4-B2C9-703DD708A821",
                    name: "Tag-14"
                )
            }
        ),
        new Product(
            id: "7236DDB5-CFE0-4D3D-8FE5-799B398396B1",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R50B-48",
            name: "Road-650 Black, 48",
            description: "The product called \"Road-650 Black, 48\"",
            price: 782.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "01E0AFB1-867D-4BAA-B0DF-2E99D056EDA2",
                    name: "Tag-107"
                ),
                new Tag(
                    id: "69212884-78CF-48C9-A5C6-B62E76725533",
                    name: "Tag-104"
                )
            }
        ),
        new Product(
            id: "7355D821-E33B-410B-AE64-D5A535F767EB",
            categoryId: "B5EF9CFA-FD22-4888-858D-2C8C5E4B2EFA",
            categoryName: "Components, Handlebars",
            sku: "HB-M243",
            name: "LL Mountain Handlebars",
            description: "The product called \"LL Mountain Handlebars\"",
            price: 44.54,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "744A624B-E4C2-429E-8A69-DC3B57682BD5",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M21B-42",
            name: "LL Mountain Frame - Black, 42",
            description: "The product called \"LL Mountain Frame - Black, 42\"",
            price: 249.79,
            tags: new List<Tag>
            {
                new Tag(
                    id: "52FCE975-91EE-4789-9E36-94EC766F02A0",
                    name: "Tag-35"
                ),
                new Tag(
                    id: "ECBBCC15-3016-4075-B084-4B49DA754814",
                    name: "Tag-138"
                ),
                new Tag(
                    id: "F533A770-1E5D-4B48-8792-E16E155B6E38",
                    name: "Tag-87"
                )
            }
        ),
        new Product(
            id: "78E7D28A-2D53-40DC-9ED2-8E2841820DEB",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R50B-62",
            name: "Road-650 Black, 62",
            description: "The product called \"Road-650 Black, 62\"",
            price: 782.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "0BC579CA-03FC-4AA6-85AA-A55035201E43",
                    name: "Tag-21"
                ),
                new Tag(
                    id: "52FCE975-91EE-4789-9E36-94EC766F02A0",
                    name: "Tag-35"
                ),
                new Tag(
                    id: "F202FBC3-B5AA-4E0F-950B-2B5715AC0B3B",
                    name: "Tag-173"
                )
            }
        ),
        new Product(
            id: "7AD4F00E-BB64-4B02-AC6B-0D5F04B01CAB",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R64Y-38",
            name: "Road-550-W Yellow, 38",
            description: "The product called \"Road-550-W Yellow, 38\"",
            price: 1120.49,
            tags: new List<Tag>
            {
                new Tag(
                    id: "028057B8-8F03-4C18-B853-66510D354A72",
                    name: "Tag-57"
                ),
                new Tag(
                    id: "27B7F8D5-1009-45B8-88F5-41008A0F0393",
                    name: "Tag-61"
                ),
                new Tag(
                    id: "84C1934D-F048-4D2B-8525-323AFE2A7C7C",
                    name: "Tag-184"
                ),
                new Tag(
                    id: "D69B1B6C-4963-4E85-8FA5-6A3E1CD1C83B",
                    name: "Tag-187"
                )
            }
        ),
        new Product(
            id: "7EF2B766-E966-4809-B568-372823002877",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M63B-40",
            name: "ML Mountain Frame - Black, 40",
            description: "The product called \"ML Mountain Frame - Black, 40\"",
            price: 348.76,
            tags: new List<Tag>
            {
                new Tag(
                    id: "6FB11EB9-319C-431C-89D7-70113401D186",
                    name: "Tag-154"
                ),
                new Tag(
                    id: "718DAED6-2186-4E09-8C02-CCC58281838D",
                    name: "Tag-94"
                )
            }
        ),
        new Product(
            id: "829B2717-0D74-43D3-BBD8-27CFDEF5ACA1",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M94B-48",
            name: "HL Mountain Frame - Black, 48",
            description: "The product called \"HL Mountain Frame - Black, 48\"",
            price: 1349.6,
            tags: new List<Tag>
            {
                new Tag(
                    id: "46AC3482-E9A6-474D-A435-D3399F21991F",
                    name: "Tag-90"
                ),
                new Tag(
                    id: "7B37373F-FC14-44FD-96AA-32F4854E0B6B",
                    name: "Tag-63"
                ),
                new Tag(
                    id: "A49D83E4-E506-4301-8110-E114599B4A35",
                    name: "Tag-27"
                ),
                new Tag(
                    id: "AEFA79EF-CBF1-4824-AAF7-1D20EA85119B",
                    name: "Tag-17"
                )
            }
        ),
        new Product(
            id: "878C50F0-7E29-4D0D-A52E-6D8B063673E3",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R89R-58",
            name: "Road-250 Red, 58",
            description: "The product called \"Road-250 Red, 58\"",
            price: 2443.35,
            tags: new List<Tag>
            {
                new Tag(
                    id: "2CE9DADE-DCAC-436C-9D69-B7C886A01B77",
                    name: "Tag-101"
                ),
                new Tag(
                    id: "762CE1E0-5615-418E-B476-BCD46AD5E79E",
                    name: "Tag-137"
                )
            }
        ),
        new Product(
            id: "8A4C4A7F-6EE1-4436-89E3-80AA2D8A1154",
            categoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            categoryName: "Components, Wheels",
            sku: "RW-R623",
            name: "LL Road Rear Wheel",
            description: "The product called \"LL Road Rear Wheel\"",
            price: 112.565,
            tags: new List<Tag>
            {
                new Tag(
                    id: "537DB3C8-8636-4005-8FE2-32EECEBA5B3F",
                    name: "Tag-80"
                ),
                new Tag(
                    id: "5D24B427-1402-49DE-B79B-5A7013579FBC",
                    name: "Tag-76"
                ),
                new Tag(
                    id: "7F518FB1-4664-4B20-9B9F-23D5B44F6798",
                    name: "Tag-69"
                ),
                new Tag(
                    id: "BE894A90-F425-4BE3-B9DF-56525DD54F62",
                    name: "Tag-62"
                ),
                new Tag(
                    id: "CAF27567-B4CB-463C-A54E-5EF1F2657DD2",
                    name: "Tag-75"
                )
            }
        ),
        new Product(
            id: "8B8184BF-B79B-4157-BAA6-D30413BCC7A9",
            categoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            categoryName: "Components, Wheels",
            sku: "RW-M762",
            name: "ML Mountain Rear Wheel",
            description: "The product called \"ML Mountain Rear Wheel\"",
            price: 236.025,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "8DB727BC-BE6B-4472-93F9-977B927D0C36",
            categoryId: "ACCC1FC1-7601-4F7A-AFA7-29C892F0FBE3",
            categoryName: "Clothing, Caps",
            sku: "CA-1098",
            name: "AWC Logo Cap",
            description: "The product called \"AWC Logo Cap\"",
            price: 8.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "511652EB-9EC2-4235-BA77-0C6E4E316679",
                    name: "Tag-199"
                ),
                new Tag(
                    id: "BA4D7ABD-2E82-4DC2-ACF2-5D3B0DEAE1C1",
                    name: "Tag-59"
                )
            }
        ),
        new Product(
            id: "8FE13D26-469C-41FE-BD7E-0A856A82F95C",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M94S-38",
            name: "HL Mountain Frame - Silver, 38",
            description: "The product called \"HL Mountain Frame - Silver, 38\"",
            price: 1364.5,
            tags: new List<Tag>
            {
                new Tag(
                    id: "A49D83E4-E506-4301-8110-E114599B4A35",
                    name: "Tag-27"
                ),
                new Tag(
                    id: "D2427B7F-AF57-498B-A73E-E7D67FD5CFD9",
                    name: "Tag-195"
                )
            }
        ),
        new Product(
            id: "90888587-BBBD-4632-8A48-5B979586DEE4",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R50R-62",
            name: "Road-650 Red, 62",
            description: "The product called \"Road-650 Red, 62\"",
            price: 782.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "80F182C6-0619-4547-9A2D-F90A7913FACF",
                    name: "Tag-96"
                ),
                new Tag(
                    id: "8DC9DFB4-1946-427A-A0A0-E06E1448CC63",
                    name: "Tag-171"
                ),
                new Tag(
                    id: "BDA92549-CBC2-4DC1-9C82-18D1A629C3F3",
                    name: "Tag-145"
                ),
                new Tag(
                    id: "BE894A90-F425-4BE3-B9DF-56525DD54F62",
                    name: "Tag-62"
                )
            }
        ),
        new Product(
            id: "91E5405C-DC61-42CE-B900-0F46C94FBBA5",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R64Y-44",
            name: "Road-550-W Yellow, 44",
            description: "The product called \"Road-550-W Yellow, 44\"",
            price: 1120.49,
            tags: new List<Tag>
            {
                new Tag(
                    id: "A2AFF2FF-8438-44A3-8AC6-20A50422D82A",
                    name: "Tag-18"
                ),
                new Tag(
                    id: "A49D83E4-E506-4301-8110-E114599B4A35",
                    name: "Tag-27"
                ),
                new Tag(
                    id: "B1EBD7E0-BBE0-4AFB-AC6C-50649484780B",
                    name: "Tag-40"
                ),
                new Tag(
                    id: "D2427B7F-AF57-498B-A73E-E7D67FD5CFD9",
                    name: "Tag-195"
                ),
                new Tag(
                    id: "D77B44A9-7951-4CC8-BB27-8B5D78CFDDF8",
                    name: "Tag-124"
                )
            }
        ),
        new Product(
            id: "9363838B-2D13-48E8-986D-C9625BE5AB26",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R50B-60",
            name: "Road-650 Black, 60",
            description: "The product called \"Road-650 Black, 60\"",
            price: 782.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "028057B8-8F03-4C18-B853-66510D354A72",
                    name: "Tag-57"
                ),
                new Tag(
                    id: "46AC3482-E9A6-474D-A435-D3399F21991F",
                    name: "Tag-90"
                ),
                new Tag(
                    id: "79E61D0F-3C95-4353-BF27-DB04535088C9",
                    name: "Tag-50"
                ),
                new Tag(
                    id: "B1EBD7E0-BBE0-4AFB-AC6C-50649484780B",
                    name: "Tag-40"
                )
            }
        ),
        new Product(
            id: "93A037C1-7135-4544-A688-3A3A75F25D0E",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M94B-42",
            name: "HL Mountain Frame - Black, 42",
            description: "The product called \"HL Mountain Frame - Black, 42\"",
            price: 1349.6,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "9E5C74FD-F685-45AE-A799-D67EFB5C28A1",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R79Y-40",
            name: "Road-350-W Yellow, 40",
            description: "The product called \"Road-350-W Yellow, 40\"",
            price: 1700.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "069169DD-F4B3-4769-8841-13B5FF745932",
                    name: "Tag-157"
                )
            }
        ),
        new Product(
            id: "9E5DD0E4-89B5-4300-BD49-87518EE9DB6A",
            categoryId: "B5EF9CFA-FD22-4888-858D-2C8C5E4B2EFA",
            categoryName: "Components, Handlebars",
            sku: "HB-R956",
            name: "HL Road Handlebars",
            description: "The product called \"HL Road Handlebars\"",
            price: 120.27,
            tags: new List<Tag>
            {
                new Tag(
                    id: "403AE98F-892E-4FEC-B262-A264CF1F52A9",
                    name: "Tag-45"
                ),
                new Tag(
                    id: "89500F13-B516-4F77-8128-47FC412BEFCD",
                    name: "Tag-151"
                ),
                new Tag(
                    id: "D1E5CB02-8E7B-422F-9421-C0E608F0AC4C",
                    name: "Tag-133"
                )
            }
        ),
        new Product(
            id: "9FEC8F06-D741-42EC-AF1D-E2F83BABC9F5",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M63S-38",
            name: "ML Mountain Frame-W - Silver, 38",
            description: "The product called \"ML Mountain Frame-W - Silver, 38\"",
            price: 364.09,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "A1D803E1-B9DE-49B4-9E61-66F5C3CD679A",
            categoryId: "B5EF9CFA-FD22-4888-858D-2C8C5E4B2EFA",
            categoryName: "Components, Handlebars",
            sku: "HB-R504",
            name: "LL Road Handlebars",
            description: "The product called \"LL Road Handlebars\"",
            price: 44.54,
            tags: new List<Tag>
            {
                new Tag(
                    id: "403AE98F-892E-4FEC-B262-A264CF1F52A9",
                    name: "Tag-45"
                ),
                new Tag(
                    id: "D69B1B6C-4963-4E85-8FA5-6A3E1CD1C83B",
                    name: "Tag-187"
                )
            }
        ),
        new Product(
            id: "A374B506-8D35-456B-8C63-BCE78B5083B8",
            categoryId: "C7324EF3-D951-45D9-A345-A82EAE344394",
            categoryName: "Clothing, Shorts",
            sku: "SH-W890-M",
            name: "Women's Mountain Shorts, M",
            description: "The product called \"Women's Mountain Shorts, M\"",
            price: 69.99,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "B3217262-876C-4C29-A201-06101B710396",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M21S-40",
            name: "LL Mountain Frame - Silver, 40",
            description: "The product called \"LL Mountain Frame - Silver, 40\"",
            price: 264.05,
            tags: new List<Tag>
            {
                new Tag(
                    id: "89FB612A-F9AA-4196-B5F5-B9FA16D558DC",
                    name: "Tag-175"
                ),
                new Tag(
                    id: "8CA1BBD8-D00B-4654-AABA-5C8724C6F4BD",
                    name: "Tag-81"
                ),
                new Tag(
                    id: "BBE8A68F-6458-410E-BFF7-759507DCE858",
                    name: "Tag-114"
                )
            }
        ),
        new Product(
            id: "B39A06DD-3A51-470E-8253-8D6ACB3EA102",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M21S-48",
            name: "LL Mountain Frame - Silver, 48",
            description: "The product called \"LL Mountain Frame - Silver, 48\"",
            price: 264.05,
            tags: new List<Tag>
            {
                new Tag(
                    id: "33AFFF1B-30AA-41C5-8510-34B67A523CA9",
                    name: "Tag-110"
                )
            }
        ),
        new Product(
            id: "B3C8AE66-8E4B-4605-A78D-FF2A8C4EAD9A",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M94S-46",
            name: "HL Mountain Frame - Silver, 46",
            description: "The product called \"HL Mountain Frame - Silver, 46\"",
            price: 1364.5,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "B6591222-0FB9-415F-8F2B-18B56A483AA1",
            categoryId: "B5EF9CFA-FD22-4888-858D-2C8C5E4B2EFA",
            categoryName: "Components, Handlebars",
            sku: "HB-R720",
            name: "ML Road Handlebars",
            description: "The product called \"ML Road Handlebars\"",
            price: 61.92,
            tags: new List<Tag>
            {
                new Tag(
                    id: "E23954CF-D79A-433E-9BE6-FD787C5E4C9B",
                    name: "Tag-111"
                ),
                new Tag(
                    id: "F287FE0A-712B-4B52-925F-5047B34F3610",
                    name: "Tag-197"
                )
            }
        ),
        new Product(
            id: "B73FFF5D-37A0-4A29-A42C-D91CD6743593",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R50R-52",
            name: "Road-650 Red, 52",
            description: "The product called \"Road-650 Red, 52\"",
            price: 782.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "812C1444-1DEA-480D-88E7-B9609ECA783C",
                    name: "Tag-136"
                )
            }
        ),
        new Product(
            id: "B8E30737-758B-49E0-A153-B210B80749F4",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M21S-52",
            name: "LL Mountain Frame - Silver, 52",
            description: "The product called \"LL Mountain Frame - Silver, 52\"",
            price: 264.05,
            tags: new List<Tag>
            {
                new Tag(
                    id: "2CE9DADE-DCAC-436C-9D69-B7C886A01B77",
                    name: "Tag-101"
                )
            }
        ),
        new Product(
            id: "BF3E0E82-DCFC-4EA3-A71C-8C9EAA329E14",
            categoryId: "C48B4EF4-D352-4CD2-BCB8-CE89B7DFA642",
            categoryName: "Clothing, Socks",
            sku: "SO-B909-M",
            name: "Mountain Bike Socks, M",
            description: "The product called \"Mountain Bike Socks, M\"",
            price: 9.5,
            tags: new List<Tag>
            {
                new Tag(
                    id: "F41CEB6B-FFD0-40A2-BC0F-F89FC3256F09",
                    name: "Tag-13"
                )
            }
        ),
        new Product(
            id: "C461038A-6DB6-4EC7-924F-ECA906259A6E",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R79Y-42",
            name: "Road-350-W Yellow, 42",
            description: "The product called \"Road-350-W Yellow, 42\"",
            price: 1700.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "0C184C69-F4F2-4774-9645-46F53D297D95",
                    name: "Tag-49"
                ),
                new Tag(
                    id: "304041C4-8C80-4C1E-9EE9-8A1DEFCF39FC",
                    name: "Tag-72"
                ),
                new Tag(
                    id: "89FB612A-F9AA-4196-B5F5-B9FA16D558DC",
                    name: "Tag-175"
                ),
                new Tag(
                    id: "A2176C7A-4E0D-4283-AFAA-319A77E9C122",
                    name: "Tag-19"
                ),
                new Tag(
                    id: "DCF66D9A-E2BF-4C70-8AC1-AD55E5988E9D",
                    name: "Tag-37"
                )
            }
        ),
        new Product(
            id: "C6941C95-C463-4F66-BE5F-8CA9C5F7FD91",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R89R-52",
            name: "Road-250 Red, 52",
            description: "The product called \"Road-250 Red, 52\"",
            price: 2443.35,
            tags: new List<Tag>
            {
                new Tag(
                    id: "45CBB7FF-FA48-49D8-89EF-F1D0B8AC3923",
                    name: "Tag-86"
                ),
                new Tag(
                    id: "A0BA4E3B-AD4A-42AF-BFA4-5F48E2E57F07",
                    name: "Tag-58"
                ),
                new Tag(
                    id: "F132E7B8-65B1-471E-8D3E-5E8D7110CA48",
                    name: "Tag-118"
                )
            }
        ),
        new Product(
            id: "C7B411C0-31F7-4634-B62F-ED349027EFE0",
            categoryId: "C7324EF3-D951-45D9-A345-A82EAE344394",
            categoryName: "Clothing, Shorts",
            sku: "SH-W890-L",
            name: "Women's Mountain Shorts, L",
            description: "The product called \"Women's Mountain Shorts, L\"",
            price: 69.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "CA170AAD-A5F6-42FF-B115-146FADD87298",
                    name: "Tag-186"
                )
            }
        ),
        new Product(
            id: "C7BE1762-AC9D-4239-BD15-F3096B08AFA9",
            categoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            categoryName: "Components, Wheels",
            sku: "FW-M423",
            name: "LL Mountain Front Wheel",
            description: "The product called \"LL Mountain Front Wheel\"",
            price: 60.745,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "CAC12FD1-C2ED-4B75-9199-86EB2044DB0D",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M63B-44",
            name: "ML Mountain Frame - Black, 44",
            description: "The product called \"ML Mountain Frame - Black, 44\"",
            price: 348.76,
            tags: new List<Tag>
            {
                new Tag(
                    id: "18AC309F-F81C-4234-A752-5DDD2BEAEE83",
                    name: "Tag-32"
                )
            }
        ),
        new Product(
            id: "CB1F441C-90E4-4E0B-ABDA-E0D07AFC2E01",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R89B-58",
            name: "Road-250 Black, 58",
            description: "The product called \"Road-250 Black, 58\"",
            price: 2443.35,
            tags: new List<Tag>
            {
                new Tag(
                    id: "1745EF28-6E0B-4FED-8925-BC3174F583B0",
                    name: "Tag-48"
                )
            }
        ),
        new Product(
            id: "CDFC37BB-8DB8-4D66-841D-7C3FF28B1F0A",
            categoryId: "B5EF9CFA-FD22-4888-858D-2C8C5E4B2EFA",
            categoryName: "Components, Handlebars",
            sku: "HB-T721",
            name: "LL Touring Handlebars",
            description: "The product called \"LL Touring Handlebars\"",
            price: 46.09,
            tags: new List<Tag>
            {
                new Tag(
                    id: "0C184C69-F4F2-4774-9645-46F53D297D95",
                    name: "Tag-49"
                ),
                new Tag(
                    id: "1745EF28-6E0B-4FED-8925-BC3174F583B0",
                    name: "Tag-48"
                ),
                new Tag(
                    id: "1830EEDD-AF21-43EA-A13C-393ED77DEAC5",
                    name: "Tag-152"
                ),
                new Tag(
                    id: "AC4CC3CC-4E6B-461D-9B0E-4218EDDF3142",
                    name: "Tag-122"
                ),
                new Tag(
                    id: "B49C6195-5ABA-42FA-B15C-84CF9FE252FE",
                    name: "Tag-129"
                )
            }
        ),
        new Product(
            id: "CE35E963-F6ED-4108-BC4B-6A3DD0557B47",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M21B-44",
            name: "LL Mountain Frame - Black, 44",
            description: "The product called \"LL Mountain Frame - Black, 44\"",
            price: 249.79,
            tags: new List<Tag>
            {
                new Tag(
                    id: "50F59C1E-E78D-4543-B4D0-B06E4C59E617",
                    name: "Tag-126"
                ),
                new Tag(
                    id: "89500F13-B516-4F77-8128-47FC412BEFCD",
                    name: "Tag-151"
                ),
                new Tag(
                    id: "E1A62ABF-BBC3-48A2-BAC6-E3350D023C83",
                    name: "Tag-194"
                )
            }
        ),
        new Product(
            id: "D17F948A-2316-4E2E-8D89-973C92FAD9ED",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M63S-42",
            name: "ML Mountain Frame-W - Silver, 42",
            description: "The product called \"ML Mountain Frame-W - Silver, 42\"",
            price: 364.09,
            tags: new List<Tag>
            {
                new Tag(
                    id: "14CFF1D6-7749-4A57-85B3-783F47731F32",
                    name: "Tag-7"
                ),
                new Tag(
                    id: "45CBB7FF-FA48-49D8-89EF-F1D0B8AC3923",
                    name: "Tag-86"
                ),
                new Tag(
                    id: "718DAED6-2186-4E09-8C02-CCC58281838D",
                    name: "Tag-94"
                ),
                new Tag(
                    id: "E83726D0-E486-42C1-BBD3-594C1C5AED6D",
                    name: "Tag-155"
                )
            }
        ),
        new Product(
            id: "D1F006A3-C6C0-42A4-B479-FC3A510C9E9E",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M63B-38",
            name: "ML Mountain Frame - Black, 38",
            description: "The product called \"ML Mountain Frame - Black, 38\"",
            price: 348.76,
            tags: new List<Tag>
            {
                new Tag(
                    id: "1A2E203E-B80D-4693-A7C2-AB39E31C9C61",
                    name: "Tag-134"
                ),
                new Tag(
                    id: "7CACE200-11A3-4E2D-A88E-25E9614D2BE9",
                    name: "Tag-97"
                ),
                new Tag(
                    id: "9C89E562-1247-435D-B786-4E54024E681C",
                    name: "Tag-128"
                ),
                new Tag(
                    id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    name: "Tag-183"
                )
            }
        ),
        new Product(
            id: "D616598D-3159-4616-BF9D-FD316BF07224",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R68R-60",
            name: "Road-450 Red, 60",
            description: "The product called \"Road-450 Red, 60\"",
            price: 1457.99,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "D8CA2EB2-7532-4F74-9D1D-E8CCC7326604",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R50R-58",
            name: "Road-650 Red, 58",
            description: "The product called \"Road-650 Red, 58\"",
            price: 782.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "87BC6842-2CCA-4CD3-994C-33AB101455F4",
                    name: "Tag-12"
                ),
                new Tag(
                    id: "A0BA4E3B-AD4A-42AF-BFA4-5F48E2E57F07",
                    name: "Tag-58"
                ),
                new Tag(
                    id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    name: "Tag-183"
                ),
                new Tag(
                    id: "BDA92549-CBC2-4DC1-9C82-18D1A629C3F3",
                    name: "Tag-145"
                ),
                new Tag(
                    id: "E6D5275B-8C42-47AE-BDEC-FC708DB3E0AC",
                    name: "Tag-119"
                )
            }
        ),
        new Product(
            id: "D9FCCC86-10FD-47E9-B68B-F0DFE758AA0E",
            categoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            categoryName: "Components, Wheels",
            sku: "FW-M762",
            name: "ML Mountain Front Wheel",
            description: "The product called \"ML Mountain Front Wheel\"",
            price: 209.025,
            tags: new List<Tag>
            {
                new Tag(
                    id: "0573D684-9140-4DEE-89AF-4E4A90E65666",
                    name: "Tag-113"
                ),
                new Tag(
                    id: "069169DD-F4B3-4769-8841-13B5FF745932",
                    name: "Tag-157"
                ),
                new Tag(
                    id: "2901FEF6-491C-40F5-B2CE-ECF80735BE5D",
                    name: "Tag-159"
                ),
                new Tag(
                    id: "319E277F-6B7A-483D-81BA-1EC34CC700EB",
                    name: "Tag-163"
                ),
                new Tag(
                    id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    name: "Tag-183"
                )
            }
        ),
        new Product(
            id: "E2FD2420-B084-4764-8BC4-94574DFF1AC6",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R68R-48",
            name: "Road-450 Red, 48",
            description: "The product called \"Road-450 Red, 48\"",
            price: 1457.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "1CFF105D-294E-4E2D-ADE4-0615CBDEBC28",
                    name: "Tag-44"
                ),
                new Tag(
                    id: "3A3A99B6-E3BF-46D0-BAD9-F5F4DBB720F4",
                    name: "Tag-70"
                ),
                new Tag(
                    id: "52E5F264-BA4E-4A8B-BF8C-69E50F81B676",
                    name: "Tag-67"
                ),
                new Tag(
                    id: "6FB11EB9-319C-431C-89D7-70113401D186",
                    name: "Tag-154"
                ),
                new Tag(
                    id: "DCDBD26C-4D71-4F91-BBE9-98D1897E704D",
                    name: "Tag-68"
                )
            }
        ),
        new Product(
            id: "E49AE44E-40AC-4FD8-A007-EEC046F02684",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M21S-44",
            name: "LL Mountain Frame - Silver, 44",
            description: "The product called \"LL Mountain Frame - Silver, 44\"",
            price: 264.05,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "E54D5E31-073F-4D37-8400-E63A2994C92C",
            categoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            categoryName: "Components, Wheels",
            sku: "FW-R762",
            name: "ML Road Front Wheel",
            description: "The product called \"ML Road Front Wheel\"",
            price: 248.385,
            tags: new List<Tag>
            {
                new Tag(
                    id: "29CBEDD8-D9C3-43A3-B20F-63224FEE0D34",
                    name: "Tag-11"
                ),
                new Tag(
                    id: "52E5F264-BA4E-4A8B-BF8C-69E50F81B676",
                    name: "Tag-67"
                ),
                new Tag(
                    id: "A0BA4E3B-AD4A-42AF-BFA4-5F48E2E57F07",
                    name: "Tag-58"
                )
            }
        ),
        new Product(
            id: "E5C302BB-43AC-4E47-8355-F0D2165C394A",
            categoryId: "B5EF9CFA-FD22-4888-858D-2C8C5E4B2EFA",
            categoryName: "Components, Handlebars",
            sku: "HB-M763",
            name: "ML Mountain Handlebars",
            description: "The product called \"ML Mountain Handlebars\"",
            price: 61.92,
            tags: new List<Tag>
            {
                new Tag(
                    id: "23ECB896-D6C6-4E9D-BE43-1908CB5C5E07",
                    name: "Tag-112"
                ),
                new Tag(
                    id: "B18FB652-C4B6-4A40-BA22-1E687C1A58CE",
                    name: "Tag-161"
                ),
                new Tag(
                    id: "BEBD68EF-901A-4282-911F-28AB44B802FE",
                    name: "Tag-139"
                )
            }
        ),
        new Product(
            id: "E5CEC513-A0F9-4437-B26D-A9FB28237554",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R89B-44",
            name: "Road-250 Black, 44",
            description: "The product called \"Road-250 Black, 44\"",
            price: 2443.35,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "E9F21624-C055-4D5F-8C02-8F69C1EA0AEE",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R50R-44",
            name: "Road-650 Red, 44",
            description: "The product called \"Road-650 Red, 44\"",
            price: 782.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "6C6D061E-F701-41DC-AEA2-7A5C28061840",
                    name: "Tag-98"
                ),
                new Tag(
                    id: "A37349FB-4A1C-4382-A845-DF81830A7B4D",
                    name: "Tag-150"
                ),
                new Tag(
                    id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    name: "Tag-183"
                ),
                new Tag(
                    id: "D69B1B6C-4963-4E85-8FA5-6A3E1CD1C83B",
                    name: "Tag-187"
                ),
                new Tag(
                    id: "DAC25651-3DD3-4483-8FD1-581DC41EF34B",
                    name: "Tag-56"
                )
            }
        ),
        new Product(
            id: "EB793BFC-82A4-4EF4-BB2A-4FD218DD1843",
            categoryId: "C7324EF3-D951-45D9-A345-A82EAE344394",
            categoryName: "Clothing, Shorts",
            sku: "SH-M897-L",
            name: "Men's Sports Shorts, L",
            description: "The product called \"Men's Sports Shorts, L\"",
            price: 59.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "0C184C69-F4F2-4774-9645-46F53D297D95",
                    name: "Tag-49"
                ),
                new Tag(
                    id: "304041C4-8C80-4C1E-9EE9-8A1DEFCF39FC",
                    name: "Tag-72"
                ),
                new Tag(
                    id: "567D183B-9ED1-47B4-AE22-80C52BF41067",
                    name: "Tag-165"
                ),
                new Tag(
                    id: "A07D69D4-B8B9-4662-8148-8033DCDCC000",
                    name: "Tag-142"
                )
            }
        ),
        new Product(
            id: "EC2ADE30-9132-4DFE-B8FE-D233DDFFAAB3",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R89B-52",
            name: "Road-250 Black, 52",
            description: "The product called \"Road-250 Black, 52\"",
            price: 2443.35,
            tags: new List<Tag>
            {
                new Tag(
                    id: "028057B8-8F03-4C18-B853-66510D354A72",
                    name: "Tag-57"
                ),
                new Tag(
                    id: "52FCE975-91EE-4789-9E36-94EC766F02A0",
                    name: "Tag-35"
                ),
                new Tag(
                    id: "AA24EC37-7CE3-4ABE-B935-EC62D5FB6947",
                    name: "Tag-148"
                ),
                new Tag(
                    id: "F629F27D-3301-4906-BE9B-C46D6D6F6141",
                    name: "Tag-65"
                )
            }
        ),
        new Product(
            id: "F1AA8B6D-4CF2-4DB2-BB17-997C2BD1A6AC",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R68R-58",
            name: "Road-450 Red, 58",
            description: "The product called \"Road-450 Red, 58\"",
            price: 1457.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "1CFF105D-294E-4E2D-ADE4-0615CBDEBC28",
                    name: "Tag-44"
                ),
                new Tag(
                    id: "45CBB7FF-FA48-49D8-89EF-F1D0B8AC3923",
                    name: "Tag-86"
                ),
                new Tag(
                    id: "7337386B-E865-4ADC-BA17-4437CB02E3BE",
                    name: "Tag-8"
                ),
                new Tag(
                    id: "A37349FB-4A1C-4382-A845-DF81830A7B4D",
                    name: "Tag-150"
                )
            }
        ),
        new Product(
            id: "F25B4447-9094-42DB-8244-186A279E461C",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R50B-58",
            name: "Road-650 Black, 58",
            description: "The product called \"Road-650 Black, 58\"",
            price: 782.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "7337386B-E865-4ADC-BA17-4437CB02E3BE",
                    name: "Tag-8"
                ),
                new Tag(
                    id: "8A104DF9-CB32-4C6E-951F-8F7DAF9E2BC1",
                    name: "Tag-200"
                ),
                new Tag(
                    id: "A34D34F7-3286-4FA4-B4B0-5E61CCEEE197",
                    name: "Tag-4"
                ),
                new Tag(
                    id: "A50C570B-B3FC-4678-96C8-2D117DD11A12",
                    name: "Tag-66"
                ),
                new Tag(
                    id: "E23954CF-D79A-433E-9BE6-FD787C5E4C9B",
                    name: "Tag-111"
                )
            }
        ),
        new Product(
            id: "F3012443-6317-4856-800A-6E108A5F8AE5",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M94S-42",
            name: "HL Mountain Frame - Silver, 42",
            description: "The product called \"HL Mountain Frame - Silver, 42\"",
            price: 1364.5,
            tags: new List<Tag>
            {
                new Tag(
                    id: "1830EEDD-AF21-43EA-A13C-393ED77DEAC5",
                    name: "Tag-152"
                ),
                new Tag(
                    id: "9C89E562-1247-435D-B786-4E54024E681C",
                    name: "Tag-128"
                ),
                new Tag(
                    id: "A0BA4E3B-AD4A-42AF-BFA4-5F48E2E57F07",
                    name: "Tag-58"
                ),
                new Tag(
                    id: "BEBD68EF-901A-4282-911F-28AB44B802FE",
                    name: "Tag-139"
                )
            }
        ),
        new Product(
            id: "F42672DA-1B19-463B-B49D-AC4EA2E1F77C",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R89B-48",
            name: "Road-250 Black, 48",
            description: "The product called \"Road-250 Black, 48\"",
            price: 2443.35,
            tags: new List<Tag>
            {
                new Tag(
                    id: "0BC579CA-03FC-4AA6-85AA-A55035201E43",
                    name: "Tag-21"
                ),
                new Tag(
                    id: "45CBB7FF-FA48-49D8-89EF-F1D0B8AC3923",
                    name: "Tag-86"
                ),
                new Tag(
                    id: "6C6D061E-F701-41DC-AEA2-7A5C28061840",
                    name: "Tag-98"
                ),
                new Tag(
                    id: "8A104DF9-CB32-4C6E-951F-8F7DAF9E2BC1",
                    name: "Tag-200"
                ),
                new Tag(
                    id: "94C05E5C-13B7-41DA-89DF-98C11195AE1E",
                    name: "Tag-79"
                )
            }
        ),
        new Product(
            id: "F58F50FB-BE83-4AE1-ACF0-662F702B2E5A",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R89R-48",
            name: "Road-250 Red, 48",
            description: "The product called \"Road-250 Red, 48\"",
            price: 2443.35,
            tags: new List<Tag>
            {
                new Tag(
                    id: "0917B02C-1EAB-4EBA-BA74-5E6D3C5CC96A",
                    name: "Tag-192"
                ),
                new Tag(
                    id: "33AFFF1B-30AA-41C5-8510-34B67A523CA9",
                    name: "Tag-110"
                ),
                new Tag(
                    id: "9653F306-0B3C-4856-ABF8-13C3F04AE4F0",
                    name: "Tag-36"
                )
            }
        ),
        new Product(
            id: "F59ECC09-CAA5-4D3C-87A7-16945A92EA2D",
            categoryId: "C7324EF3-D951-45D9-A345-A82EAE344394",
            categoryName: "Clothing, Shorts",
            sku: "SH-W890-S",
            name: "Women's Mountain Shorts, S",
            description: "The product called \"Women's Mountain Shorts, S\"",
            price: 69.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "4E102F3F-7D57-4CD7-88F4-AC5076A42C59",
                    name: "Tag-91"
                ),
                new Tag(
                    id: "7019202D-B11A-4FAB-ACBC-2D0E5A4F72EF",
                    name: "Tag-143"
                )
            }
        ),
        new Product(
            id: "F7078B88-417F-44C0-9345-DCEDDB5C41F8",
            categoryId: "C7324EF3-D951-45D9-A345-A82EAE344394",
            categoryName: "Clothing, Shorts",
            sku: "SH-M897-S",
            name: "Men's Sports Shorts, S",
            description: "The product called \"Men's Sports Shorts, S\"",
            price: 59.99,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "F741B78B-36F0-42E9-A26A-FAE908E0FB3A",
            categoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            categoryName: "Components, Wheels",
            sku: "RW-T905",
            name: "Touring Rear Wheel",
            description: "The product called \"Touring Rear Wheel\"",
            price: 245.01,
            tags: new List<Tag> { }
        ),
        new Product(
            id: "FD00408C-57B1-431C-B1FA-2CAF41D87CD4",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R19B-44",
            name: "Road-750 Black, 44",
            description: "The product called \"Road-750 Black, 44\"",
            price: 539.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "0BC579CA-03FC-4AA6-85AA-A55035201E43",
                    name: "Tag-21"
                )
            }
        ),
        new Product(
            id: "FD48A179-6CF5-45F2-8605-9DA19B9D4409",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R93R-44",
            name: "Road-150 Red, 44",
            description: "The product called \"Road-150 Red, 44\"",
            price: 3578.27,
            tags: new List<Tag>
            {
                new Tag(
                    id: "765254E3-8E88-4C57-AADA-9F5126917970",
                    name: "Tag-93"
                ),
                new Tag(
                    id: "E23954CF-D79A-433E-9BE6-FD787C5E4C9B",
                    name: "Tag-111"
                )
            }
        ),
        new Product(
            id: "FDD4E68A-6284-4DC7-B48D-232F347CA827",
            categoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            categoryName: "Components, Mountain Frames",
            sku: "FR-M94B-44",
            name: "HL Mountain Frame - Black, 44",
            description: "The product called \"HL Mountain Frame - Black, 44\"",
            price: 1349.6,
            tags: new List<Tag>
            {
                new Tag(
                    id: "3BFB03A9-3106-44C7-823A-DB1A67E283C3",
                    name: "Tag-47"
                ),
                new Tag(
                    id: "54C5E2EB-EE2D-496D-8AE2-200D7575968A",
                    name: "Tag-156"
                ),
                new Tag(
                    id: "7DF71D87-FB6F-498B-9D7B-E7EBE40350E1",
                    name: "Tag-88"
                ),
                new Tag(
                    id: "A0BA4E3B-AD4A-42AF-BFA4-5F48E2E57F07",
                    name: "Tag-58"
                ),
                new Tag(
                    id: "A9834752-41CA-47F5-8A5A-D9A878DF0ACB",
                    name: "Tag-198"
                )
            }
        ),
        new Product(
            id: "FEEFEE3B-6CB9-4A75-B896-5182531F661B",
            categoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            categoryName: "Bikes, Road Bikes",
            sku: "BK-R19B-52",
            name: "Road-750 Black, 52",
            description: "The product called \"Road-750 Black, 52\"",
            price: 539.99,
            tags: new List<Tag>
            {
                new Tag(
                    id: "461ADE06-0903-4BAF-97AB-CC713E5B1DD4",
                    name: "Tag-174"
                ),
                new Tag(
                    id: "AC4CC3CC-4E6B-461D-9B0E-4218EDDF3142",
                    name: "Tag-122"
                ),
                new Tag(
                    id: "D56040DB-E5DF-40BE-9F2F-7E10F4340BCA",
                    name: "Tag-31"
                ),
                new Tag(
                    id: "D77B44A9-7951-4CC8-BB27-8B5D78CFDDF8",
                    name: "Tag-124"
                ),
                new Tag(
                    id: "E468DF53-4836-4546-9D05-C855AAC4B0AF",
                    name: "Tag-2"
                )
            }
        )
    };
}