namespace Azure.Cosmos.CosmicWorks.Generator;

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
            Id: "027D0B9A-F9D9-4C96-8213-C8546C4AAE71",
            CategoryId: "26C74104-40BC-4541-8EF5-9892F7F03D72",
            CategoryName: "Components, Saddles",
            SKU: "SE-R581",
            Name: "LL Road Seat/Saddle",
            Description: "The product called \"LL Road Seat/Saddle\"",
            Price: 27.12,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "0573D684-9140-4DEE-89AF-4E4A90E65666",
                    Name: "Tag-113"
                ),
                new Tag(
                    Id: "6C2F05C8-1E61-4912-BE1A-C67A378429BB",
                    Name: "Tag-5"
                ),
                new Tag(
                    Id: "B48D6572-67EB-4630-A1DB-AFD4AD7041C9",
                    Name: "Tag-100"
                ),
                new Tag(
                    Id: "D70F215D-A8AC-483A-9ABD-4A008D2B72B2",
                    Name: "Tag-85"
                ),
                new Tag(
                    Id: "DCF66D9A-E2BF-4C70-8AC1-AD55E5988E9D",
                    Name: "Tag-37"
                )
            }
        ),
        new Product(
            Id: "08225A9E-F2B3-4FA3-AB08-8C70ADD6C3C2",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T79U-50",
            Name: "Touring-1000 Blue, 50",
            Description: "The product called \"Touring-1000 Blue, 50\"",
            Price: 2384.07,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "27B7F8D5-1009-45B8-88F5-41008A0F0393",
                    Name: "Tag-61"
                )
            }
        ),
        new Product(
            Id: "0A7E57DA-C73F-467F-954F-17B7AFD6227E",
            CategoryId: "4F34E180-384D-42FC-AC10-FEC30227577F",
            CategoryName: "Components, Pedals",
            SKU: "PD-R563",
            Name: "ML Road Pedal",
            Description: "The product called \"ML Road Pedal\"",
            Price: 62.09,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "14CFF1D6-7749-4A57-85B3-783F47731F32",
                    Name: "Tag-7"
                ),
                new Tag(
                    Id: "319E277F-6B7A-483D-81BA-1EC34CC700EB",
                    Name: "Tag-163"
                )
            }
        ),
        new Product(
            Id: "14174164-F6C0-47FC-83FB-604C6A63408D",
            CategoryId: "006A1D51-28DA-4956-A7FB-C0B2BF6360CA",
            CategoryName: "Accessories, Bottles and Cages",
            SKU: "BC-M005",
            Name: "Mountain Bottle Cage",
            Description: "The product called \"Mountain Bottle Cage\"",
            Price: 9.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "A49D83E4-E506-4301-8110-E114599B4A35",
                    Name: "Tag-27"
                ),
                new Tag(
                    Id: "CA7D17BB-45A6-47E6-A3E3-E70AF34C2072",
                    Name: "Tag-158"
                ),
                new Tag(
                    Id: "ECBBCC15-3016-4075-B084-4B49DA754814",
                    Name: "Tag-138"
                )
            }
        ),
        new Product(
            Id: "1A176FDB-D9A8-4888-BDD9-CE4F12E97AAE",
            CategoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            CategoryName: "Accessories, Tires and Tubes",
            SKU: "TI-R982",
            Name: "HL Road Tire",
            Description: "The product called \"HL Road Tire\"",
            Price: 32.6,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "51CD93BF-098C-4C25-9829-4AD42046D038",
                    Name: "Tag-25"
                ),
                new Tag(
                    Id: "5D24B427-1402-49DE-B79B-5A7013579FBC",
                    Name: "Tag-76"
                ),
                new Tag(
                    Id: "8AAFD985-8BCE-4FA8-85A2-2CA67D9DF8E6",
                    Name: "Tag-172"
                ),
                new Tag(
                    Id: "D4EC9C09-75F3-4ADD-A6EB-ACDD12C648FA",
                    Name: "Tag-153"
                )
            }
        ),
        new Product(
            Id: "201D0D79-81AD-43D2-AD6E-F09EEE6AC2D7",
            CategoryId: "26C74104-40BC-4541-8EF5-9892F7F03D72",
            CategoryName: "Components, Saddles",
            SKU: "SE-M798",
            Name: "ML Mountain Seat/Saddle",
            Description: "The product called \"ML Mountain Seat/Saddle\"",
            Price: 39.14,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "0917B02C-1EAB-4EBA-BA74-5E6D3C5CC96A",
                    Name: "Tag-192"
                ),
                new Tag(
                    Id: "0C184C69-F4F2-4774-9645-46F53D297D95",
                    Name: "Tag-49"
                ),
                new Tag(
                    Id: "3A3A99B6-E3BF-46D0-BAD9-F5F4DBB720F4",
                    Name: "Tag-70"
                ),
                new Tag(
                    Id: "DAC25651-3DD3-4483-8FD1-581DC41EF34B",
                    Name: "Tag-56"
                )
            }
        ),
        new Product(
            Id: "24BE4267-85D8-4C1A-B184-C08709495752",
            CategoryId: "006A1D51-28DA-4956-A7FB-C0B2BF6360CA",
            CategoryName: "Accessories, Bottles and Cages",
            SKU: "BC-R205",
            Name: "Road Bottle Cage",
            Description: "The product called \"Road Bottle Cage\"",
            Price: 8.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "45CBB7FF-FA48-49D8-89EF-F1D0B8AC3923",
                    Name: "Tag-86"
                ),
                new Tag(
                    Id: "9653F306-0B3C-4856-ABF8-13C3F04AE4F0",
                    Name: "Tag-36"
                ),
                new Tag(
                    Id: "A9834752-41CA-47F5-8A5A-D9A878DF0ACB",
                    Name: "Tag-198"
                )
            }
        ),
        new Product(
            Id: "290B4594-95BE-47C5-863A-4EFAAFC0AED7",
            CategoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            CategoryName: "Accessories, Tires and Tubes",
            SKU: "TI-M602",
            Name: "ML Mountain Tire",
            Description: "The product called \"ML Mountain Tire\"",
            Price: 29.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "0917B02C-1EAB-4EBA-BA74-5E6D3C5CC96A",
                    Name: "Tag-192"
                ),
                new Tag(
                    Id: "14D5A3F0-7B6D-4D2D-9D45-AC2E35F90298",
                    Name: "Tag-166"
                ),
                new Tag(
                    Id: "31BDDC90-386A-4EED-A588-751DA0587A0A",
                    Name: "Tag-95"
                ),
                new Tag(
                    Id: "59676183-1BD7-48A0-B3B0-42B3C0800EB0",
                    Name: "Tag-64"
                ),
                new Tag(
                    Id: "9C89E562-1247-435D-B786-4E54024E681C",
                    Name: "Tag-128"
                )
            }
        ),
        new Product(
            Id: "29663491-D2E9-47B4-83AE-D9459B6B5B67",
            CategoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            CategoryName: "Accessories, Tires and Tubes",
            SKU: "TT-T092",
            Name: "Touring Tire Tube",
            Description: "The product called \"Touring Tire Tube\"",
            Price: 4.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "14D5A3F0-7B6D-4D2D-9D45-AC2E35F90298",
                    Name: "Tag-166"
                ),
                new Tag(
                    Id: "539DF8CA-7DCD-43BC-9F4A-1F6657B61708",
                    Name: "Tag-53"
                ),
                new Tag(
                    Id: "74680691-FA4C-4721-9CB4-5846B7C3210A",
                    Name: "Tag-103"
                ),
                new Tag(
                    Id: "94F41BAD-B861-4BB0-A941-89677D04F455",
                    Name: "Tag-26"
                )
            }
        ),
        new Product(
            Id: "2C981511-AC73-4A65-9DA3-A0577E386394",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T79U-46",
            Name: "Touring-1000 Blue, 46",
            Description: "The product called \"Touring-1000 Blue, 46\"",
            Price: 2384.07,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "4E102F3F-7D57-4CD7-88F4-AC5076A42C59",
                    Name: "Tag-91"
                ),
                new Tag(
                    Id: "52FCE975-91EE-4789-9E36-94EC766F02A0",
                    Name: "Tag-35"
                ),
                new Tag(
                    Id: "7B37373F-FC14-44FD-96AA-32F4854E0B6B",
                    Name: "Tag-63"
                ),
                new Tag(
                    Id: "83D720BA-BB31-4BE5-B723-8A836AB6D532",
                    Name: "Tag-127"
                ),
                new Tag(
                    Id: "DA661FCF-CC7F-4AF9-A9E2-8E7A5570844E",
                    Name: "Tag-188"
                )
            }
        ),
        new Product(
            Id: "3F105575-8677-42F9-8E1F-76E4B450F136",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T79Y-46",
            Name: "Touring-1000 Yellow, 46",
            Description: "The product called \"Touring-1000 Yellow, 46\"",
            Price: 2384.07,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "84C396AD-98C6-4B12-8C3A-1BDA3ABF7D73",
                    Name: "Tag-24"
                ),
                new Tag(
                    Id: "B1C00DC4-236A-4A5F-844C-3F56BBE87968",
                    Name: "Tag-167"
                )
            }
        ),
        new Product(
            Id: "3FE1A99E-DE14-4D11-B635-F5D39258A0B9",
            CategoryId: "26C74104-40BC-4541-8EF5-9892F7F03D72",
            CategoryName: "Components, Saddles",
            SKU: "SE-T924",
            Name: "HL Touring Seat/Saddle",
            Description: "The product called \"HL Touring Seat/Saddle\"",
            Price: 52.64,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "125497D0-9175-4ECD-844D-DA71E5F4ED43",
                    Name: "Tag-42"
                ),
                new Tag(
                    Id: "762CE1E0-5615-418E-B476-BCD46AD5E79E",
                    Name: "Tag-137"
                ),
                new Tag(
                    Id: "A9834752-41CA-47F5-8A5A-D9A878DF0ACB",
                    Name: "Tag-198"
                ),
                new Tag(
                    Id: "D2427B7F-AF57-498B-A73E-E7D67FD5CFD9",
                    Name: "Tag-195"
                ),
                new Tag(
                    Id: "D4EC9C09-75F3-4ADD-A6EB-ACDD12C648FA",
                    Name: "Tag-153"
                )
            }
        ),
        new Product(
            Id: "44873725-7B3B-4B28-804D-963D2D62E761",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T79U-60",
            Name: "Touring-1000 Blue, 60",
            Description: "The product called \"Touring-1000 Blue, 60\"",
            Price: 2384.07,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "033D3826-2851-4B97-9464-59D3675175D4",
                    Name: "Tag-108"
                ),
                new Tag(
                    Id: "511652EB-9EC2-4235-BA77-0C6E4E316679",
                    Name: "Tag-199"
                ),
                new Tag(
                    Id: "E6CB7972-06F4-47C0-B464-F64E695F89E7",
                    Name: "Tag-51"
                )
            }
        ),
        new Product(
            Id: "47C70E1E-E500-41B3-8615-DCCB963D9E35",
            CategoryId: "AA28AE74-D57C-4B23-B5F7-F919E1C5844E",
            CategoryName: "Clothing, Tights",
            SKU: "TG-W091-S",
            Name: "Women's Tights, S",
            Description: "The product called \"Women's Tights, S\"",
            Price: 74.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "488BD0F1-AABE-4FC5-BAF2-0B8A077CA3CF",
                    Name: "Tag-147"
                ),
                new Tag(
                    Id: "CAF27567-B4CB-463C-A54E-5EF1F2657DD2",
                    Name: "Tag-75"
                )
            }
        ),
        new Product(
            Id: "4B0848F8-7BF5-4DB9-84A7-C4D69F2E3E8E",
            CategoryId: "34340561-3D26-4F33-B6AD-09260FC811D6",
            CategoryName: "Components, Bottom Brackets",
            SKU: "BB-7421",
            Name: "LL Bottom Bracket",
            Description: "The product called \"LL Bottom Bracket\"",
            Price: 53.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "028057B8-8F03-4C18-B853-66510D354A72",
                    Name: "Tag-57"
                ),
                new Tag(
                    Id: "40525E23-C1FB-4213-BF28-2B4C64BDC29B",
                    Name: "Tag-135"
                ),
                new Tag(
                    Id: "A07D69D4-B8B9-4662-8148-8033DCDCC000",
                    Name: "Tag-142"
                ),
                new Tag(
                    Id: "E468DF53-4836-4546-9D05-C855AAC4B0AF",
                    Name: "Tag-2"
                )
            }
        ),
        new Product(
            Id: "4E4B38CB-0D82-43E5-89AF-20270CD28A04",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T44U-60",
            Name: "Touring-2000 Blue, 60",
            Description: "The product called \"Touring-2000 Blue, 60\"",
            Price: 1214.85,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "89FB612A-F9AA-4196-B5F5-B9FA16D558DC",
                    Name: "Tag-175"
                ),
                new Tag(
                    Id: "A30014DE-B012-4049-B456-4630527AF47F",
                    Name: "Tag-9"
                ),
                new Tag(
                    Id: "B18FB652-C4B6-4A40-BA22-1E687C1A58CE",
                    Name: "Tag-161"
                ),
                new Tag(
                    Id: "C6AB3E24-BA48-40F0-A260-CB04EB03D5B0",
                    Name: "Tag-73"
                )
            }
        ),
        new Product(
            Id: "5089E32E-8A60-4117-AA98-5EF8AB9A61D1",
            CategoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            CategoryName: "Accessories, Tires and Tubes",
            SKU: "TT-R982",
            Name: "Road Tire Tube",
            Description: "The product called \"Road Tire Tube\"",
            Price: 3.99,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "52FAD88C-567E-469D-A35E-574EA3BF147F",
            CategoryId: "4F34E180-384D-42FC-AC10-FEC30227577F",
            CategoryName: "Components, Pedals",
            SKU: "PD-M340",
            Name: "ML Mountain Pedal",
            Description: "The product called \"ML Mountain Pedal\"",
            Price: 62.09,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "5308BAE7-B0CB-4883-9A93-192CB10DC94F",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T18U-44",
            Name: "Touring-3000 Blue, 44",
            Description: "The product called \"Touring-3000 Blue, 44\"",
            Price: 742.35,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "A37349FB-4A1C-4382-A845-DF81830A7B4D",
                    Name: "Tag-150"
                )
            }
        ),
        new Product(
            Id: "5996B5E0-6EC7-4CB7-A924-7B5A053AE980",
            CategoryId: "26C74104-40BC-4541-8EF5-9892F7F03D72",
            CategoryName: "Components, Saddles",
            SKU: "SE-M236",
            Name: "LL Mountain Seat/Saddle",
            Description: "The product called \"LL Mountain Seat/Saddle\"",
            Price: 27.12,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "5D24B427-1402-49DE-B79B-5A7013579FBC",
                    Name: "Tag-76"
                ),
                new Tag(
                    Id: "79E61D0F-3C95-4353-BF27-DB04535088C9",
                    Name: "Tag-50"
                ),
                new Tag(
                    Id: "BEBD68EF-901A-4282-911F-28AB44B802FE",
                    Name: "Tag-139"
                ),
                new Tag(
                    Id: "E468DF53-4836-4546-9D05-C855AAC4B0AF",
                    Name: "Tag-2"
                )
            }
        ),
        new Product(
            Id: "5B5E90B8-FEA2-4D6C-B728-EC586656FA6D",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T79Y-60",
            Name: "Touring-1000 Yellow, 60",
            Description: "The product called \"Touring-1000 Yellow, 60\"",
            Price: 2384.07,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "4F67013C-3B5E-4A3D-B4B0-8C597A491EB6",
                    Name: "Tag-82"
                ),
                new Tag(
                    Id: "6C6D061E-F701-41DC-AEA2-7A5C28061840",
                    Name: "Tag-98"
                )
            }
        ),
        new Product(
            Id: "5BFADECD-2240-4480-9485-1256D1D60EA8",
            CategoryId: "32A9A8E6-7004-4B24-9C2A-BB3E93B9E6BD",
            CategoryName: "Clothing, Gloves",
            SKU: "GL-F110-S",
            Name: "Full-Finger Gloves, S",
            Description: "The product called \"Full-Finger Gloves, S\"",
            Price: 37.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "84C396AD-98C6-4B12-8C3A-1BDA3ABF7D73",
                    Name: "Tag-24"
                )
            }
        ),
        new Product(
            Id: "6E3AA511-67DF-4EAD-8F0C-4C9F91F7D335",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T18Y-50",
            Name: "Touring-3000 Yellow, 50",
            Description: "The product called \"Touring-3000 Yellow, 50\"",
            Price: 742.35,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "2E7252D2-B646-47FB-B5BB-836643578038",
                    Name: "Tag-130"
                )
            }
        ),
        new Product(
            Id: "6FB5B2D5-5725-4998-9B6C-2FF2B7A3E3E0",
            CategoryId: "32A9A8E6-7004-4B24-9C2A-BB3E93B9E6BD",
            CategoryName: "Clothing, Gloves",
            SKU: "GL-H102-M",
            Name: "Half-Finger Gloves, M",
            Description: "The product called \"Half-Finger Gloves, M\"",
            Price: 24.49,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "12A06E6F-45BF-42DF-9641-F1376CDDB7B1",
                    Name: "Tag-22"
                ),
                new Tag(
                    Id: "8DC9DFB4-1946-427A-A0A0-E06E1448CC63",
                    Name: "Tag-171"
                ),
                new Tag(
                    Id: "C1CB0EFE-02BB-4AE5-AA48-3DAC12921450",
                    Name: "Tag-109"
                )
            }
        ),
        new Product(
            Id: "71BDFE67-6499-4A8E-9CCA-9E9AF7D92A7A",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T18U-54",
            Name: "Touring-3000 Blue, 54",
            Description: "The product called \"Touring-3000 Blue, 54\"",
            Price: 742.35,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "5D24B427-1402-49DE-B79B-5A7013579FBC",
                    Name: "Tag-76"
                ),
                new Tag(
                    Id: "66D8EA21-E1F0-471C-A17F-02F3B149D6E6",
                    Name: "Tag-83"
                ),
                new Tag(
                    Id: "6FB11EB9-319C-431C-89D7-70113401D186",
                    Name: "Tag-154"
                )
            }
        ),
        new Product(
            Id: "7BAA49C9-21B5-4EEF-9F6B-BCD6DA7C2239",
            CategoryId: "26C74104-40BC-4541-8EF5-9892F7F03D72",
            CategoryName: "Components, Saddles",
            SKU: "SE-R995",
            Name: "HL Road Seat/Saddle",
            Description: "The product called \"HL Road Seat/Saddle\"",
            Price: 52.64,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "7EA0EEEB-824E-42E9-B787-019219CE4466",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T79U-54",
            Name: "Touring-1000 Blue, 54",
            Description: "The product called \"Touring-1000 Blue, 54\"",
            Price: 2384.07,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "23ECB896-D6C6-4E9D-BE43-1908CB5C5E07",
                    Name: "Tag-112"
                ),
                new Tag(
                    Id: "A9834752-41CA-47F5-8A5A-D9A878DF0ACB",
                    Name: "Tag-198"
                ),
                new Tag(
                    Id: "D5887E7C-B916-4AF4-BAF8-7B996ADA8C83",
                    Name: "Tag-52"
                ),
                new Tag(
                    Id: "E1A62ABF-BBC3-48A2-BAC6-E3350D023C83",
                    Name: "Tag-194"
                )
            }
        ),
        new Product(
            Id: "80D3630F-B661-4FD6-A296-CD03BB7A4A0C",
            CategoryId: "629A8F3C-CFB0-4347-8DCC-505A4789876B",
            CategoryName: "Clothing, Vests",
            SKU: "VE-C304-L",
            Name: "Classic Vest, L",
            Description: "The product called \"Classic Vest, L\"",
            Price: 63.5,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "2CE9DADE-DCAC-436C-9D69-B7C886A01B77",
                    Name: "Tag-101"
                ),
                new Tag(
                    Id: "CA170AAD-A5F6-42FF-B115-146FADD87298",
                    Name: "Tag-186"
                )
            }
        ),
        new Product(
            Id: "866F8033-A439-42D9-99EE-178C1285F13E",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T18Y-44",
            Name: "Touring-3000 Yellow, 44",
            Description: "The product called \"Touring-3000 Yellow, 44\"",
            Price: 742.35,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "31BDDC90-386A-4EED-A588-751DA0587A0A",
                    Name: "Tag-95"
                ),
                new Tag(
                    Id: "A2AFF2FF-8438-44A3-8AC6-20A50422D82A",
                    Name: "Tag-18"
                ),
                new Tag(
                    Id: "AA24EC37-7CE3-4ABE-B935-EC62D5FB6947",
                    Name: "Tag-148"
                ),
                new Tag(
                    Id: "DB21A27B-5A3F-400C-A0DF-69A5266E1447",
                    Name: "Tag-34"
                ),
                new Tag(
                    Id: "F202FBC3-B5AA-4E0F-950B-2B5715AC0B3B",
                    Name: "Tag-173"
                )
            }
        ),
        new Product(
            Id: "906A453F-2B5E-469A-87B5-FFA531EE615D",
            CategoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            CategoryName: "Accessories, Tires and Tubes",
            SKU: "PK-7098",
            Name: "Patch Kit/8 Patches",
            Description: "The product called \"Patch Kit/8 Patches\"",
            Price: 2.29,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "DBC21C2A-0AF6-45D4-B2C9-703DD708A821",
                    Name: "Tag-14"
                )
            }
        ),
        new Product(
            Id: "9190229B-1372-4997-8F64-5B3E7A2459C5",
            CategoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            CategoryName: "Accessories, Tires and Tubes",
            SKU: "TT-M928",
            Name: "Mountain Tire Tube",
            Description: "The product called \"Mountain Tire Tube\"",
            Price: 4.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "66D8EA21-E1F0-471C-A17F-02F3B149D6E6",
                    Name: "Tag-83"
                ),
                new Tag(
                    Id: "6FB11EB9-319C-431C-89D7-70113401D186",
                    Name: "Tag-154"
                ),
                new Tag(
                    Id: "8AAFD985-8BCE-4FA8-85A2-2CA67D9DF8E6",
                    Name: "Tag-172"
                ),
                new Tag(
                    Id: "A4D9E596-B630-4792-BDD1-7D6459827820",
                    Name: "Tag-164"
                )
            }
        ),
        new Product(
            Id: "94265B3D-7718-47F0-ADF7-64DEE36CAC41",
            CategoryId: "629A8F3C-CFB0-4347-8DCC-505A4789876B",
            CategoryName: "Clothing, Vests",
            SKU: "VE-C304-S",
            Name: "Classic Vest, S",
            Description: "The product called \"Classic Vest, S\"",
            Price: 63.5,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "967155B3-9925-4FA3-84B0-B24CDA101C1B",
            CategoryId: "629A8F3C-CFB0-4347-8DCC-505A4789876B",
            CategoryName: "Clothing, Vests",
            SKU: "VE-C304-M",
            Name: "Classic Vest, M",
            Description: "The product called \"Classic Vest, M\"",
            Price: 63.5,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "3798DC56-04BE-4A82-B70B-6A0DC7714A36",
                    Name: "Tag-105"
                ),
                new Tag(
                    Id: "403AE98F-892E-4FEC-B262-A264CF1F52A9",
                    Name: "Tag-45"
                ),
                new Tag(
                    Id: "A49D83E4-E506-4301-8110-E114599B4A35",
                    Name: "Tag-27"
                )
            }
        ),
        new Product(
            Id: "98324A24-9D56-4662-93A5-9A7370E7EE5A",
            CategoryId: "26C74104-40BC-4541-8EF5-9892F7F03D72",
            CategoryName: "Components, Saddles",
            SKU: "SE-T762",
            Name: "ML Touring Seat/Saddle",
            Description: "The product called \"ML Touring Seat/Saddle\"",
            Price: 39.14,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "2400025E-FB22-4031-B4A2-9C3BD1402A9B",
                    Name: "Tag-38"
                ),
                new Tag(
                    Id: "537DB3C8-8636-4005-8FE2-32EECEBA5B3F",
                    Name: "Tag-80"
                ),
                new Tag(
                    Id: "F287FE0A-712B-4B52-925F-5047B34F3610",
                    Name: "Tag-197"
                )
            }
        ),
        new Product(
            Id: "9851FE19-CCA4-4B94-B6AC-CCE579D7F693",
            CategoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            CategoryName: "Accessories, Tires and Tubes",
            SKU: "TI-M823",
            Name: "HL Mountain Tire",
            Description: "The product called \"HL Mountain Tire\"",
            Price: 35.0,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "987E39AC-6C62-4717-9929-E9BDFF9902ED",
            CategoryId: "34340561-3D26-4F33-B6AD-09260FC811D6",
            CategoryName: "Components, Bottom Brackets",
            SKU: "BB-8107",
            Name: "ML Bottom Bracket",
            Description: "The product called \"ML Bottom Bracket\"",
            Price: 101.24,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "9467BA7B-49FB-4AA5-A868-478D94AF2E54",
                    Name: "Tag-92"
                )
            }
        ),
        new Product(
            Id: "9E6692D7-57E1-4D35-ACD8-105D44A1073B",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T18U-58",
            Name: "Touring-3000 Blue, 58",
            Description: "The product called \"Touring-3000 Blue, 58\"",
            Price: 742.35,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "18AC309F-F81C-4234-A752-5DDD2BEAEE83",
                    Name: "Tag-32"
                ),
                new Tag(
                    Id: "F132E7B8-65B1-471E-8D3E-5E8D7110CA48",
                    Name: "Tag-118"
                )
            }
        ),
        new Product(
            Id: "9FCA9658-8506-4268-8539-DBAA65C51F41",
            CategoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            CategoryName: "Accessories, Tires and Tubes",
            SKU: "TI-T723",
            Name: "Touring Tire",
            Description: "The product called \"Touring Tire\"",
            Price: 28.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "8BAC6191-1DAE-4F5B-88FC-7081B682095D",
                    Name: "Tag-15"
                ),
                new Tag(
                    Id: "DBC84212-C3E9-4966-8619-9A4D64EBF517",
                    Name: "Tag-125"
                ),
                new Tag(
                    Id: "E1A62ABF-BBC3-48A2-BAC6-E3350D023C83",
                    Name: "Tag-194"
                ),
                new Tag(
                    Id: "F59DC0A2-537E-4A8F-A97D-19C82074D3E7",
                    Name: "Tag-146"
                )
            }
        ),
        new Product(
            Id: "A042C88C-B060-4A64-B314-ED92124047E5",
            CategoryId: "4F34E180-384D-42FC-AC10-FEC30227577F",
            CategoryName: "Components, Pedals",
            SKU: "PD-R853",
            Name: "HL Road Pedal",
            Description: "The product called \"HL Road Pedal\"",
            Price: 80.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "1B387A00-57D3-4444-8331-18A90725E98B",
                    Name: "Tag-43"
                ),
                new Tag(
                    Id: "1CFF105D-294E-4E2D-ADE4-0615CBDEBC28",
                    Name: "Tag-44"
                ),
                new Tag(
                    Id: "40525E23-C1FB-4213-BF28-2B4C64BDC29B",
                    Name: "Tag-135"
                ),
                new Tag(
                    Id: "59676183-1BD7-48A0-B3B0-42B3C0800EB0",
                    Name: "Tag-64"
                ),
                new Tag(
                    Id: "89500F13-B516-4F77-8128-47FC412BEFCD",
                    Name: "Tag-151"
                )
            }
        ),
        new Product(
            Id: "A13C5B23-34DF-41C7-849C-0BA623BEFE02",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T79Y-50",
            Name: "Touring-1000 Yellow, 50",
            Description: "The product called \"Touring-1000 Yellow, 50\"",
            Price: 2384.07,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "52FCE975-91EE-4789-9E36-94EC766F02A0",
                    Name: "Tag-35"
                ),
                new Tag(
                    Id: "AEFA79EF-CBF1-4824-AAF7-1D20EA85119B",
                    Name: "Tag-17"
                ),
                new Tag(
                    Id: "BE894A90-F425-4BE3-B9DF-56525DD54F62",
                    Name: "Tag-62"
                ),
                new Tag(
                    Id: "D5887E7C-B916-4AF4-BAF8-7B996ADA8C83",
                    Name: "Tag-52"
                ),
                new Tag(
                    Id: "DBC21C2A-0AF6-45D4-B2C9-703DD708A821",
                    Name: "Tag-14"
                )
            }
        ),
        new Product(
            Id: "A6BB4603-7CD5-43DC-920A-2A2F55D52492",
            CategoryId: "AB952F9F-5ABA-4251-BC2D-AFF8DF412A4A",
            CategoryName: "Components, Headsets",
            SKU: "HS-2451",
            Name: "ML Headset",
            Description: "The product called \"ML Headset\"",
            Price: 102.29,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "A34D34F7-3286-4FA4-B4B0-5E61CCEEE197",
                    Name: "Tag-4"
                ),
                new Tag(
                    Id: "BA4D7ABD-2E82-4DC2-ACF2-5D3B0DEAE1C1",
                    Name: "Tag-59"
                ),
                new Tag(
                    Id: "D69B1B6C-4963-4E85-8FA5-6A3E1CD1C83B",
                    Name: "Tag-187"
                )
            }
        ),
        new Product(
            Id: "A875BC33-C4AC-4D2B-B018-9FF4672A2BB9",
            CategoryId: "32A9A8E6-7004-4B24-9C2A-BB3E93B9E6BD",
            CategoryName: "Clothing, Gloves",
            SKU: "GL-H102-L",
            Name: "Half-Finger Gloves, L",
            Description: "The product called \"Half-Finger Gloves, L\"",
            Price: 24.49,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "A9EFB9E2-8859-4401-B8A6-F7E2D5264FEE",
            CategoryId: "AA28AE74-D57C-4B23-B5F7-F919E1C5844E",
            CategoryName: "Clothing, Tights",
            SKU: "TG-W091-M",
            Name: "Women's Tights, M",
            Description: "The product called \"Women's Tights, M\"",
            Price: 74.99,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "ABB81D0E-4744-44EC-8AAB-FB3962FD2AF7",
            CategoryId: "32A9A8E6-7004-4B24-9C2A-BB3E93B9E6BD",
            CategoryName: "Clothing, Gloves",
            SKU: "GL-F110-L",
            Name: "Full-Finger Gloves, L",
            Description: "The product called \"Full-Finger Gloves, L\"",
            Price: 37.99,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "ABDE32DD-FADD-4042-9278-0440B7B2F3E0",
            CategoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            CategoryName: "Accessories, Tires and Tubes",
            SKU: "TI-M267",
            Name: "LL Mountain Tire",
            Description: "The product called \"LL Mountain Tire\"",
            Price: 24.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "A34D34F7-3286-4FA4-B4B0-5E61CCEEE197",
                    Name: "Tag-4"
                ),
                new Tag(
                    Id: "B49C6195-5ABA-42FA-B15C-84CF9FE252FE",
                    Name: "Tag-129"
                ),
                new Tag(
                    Id: "BF28390C-CBBE-48FC-8EBF-1BD7E6608E59",
                    Name: "Tag-193"
                ),
                new Tag(
                    Id: "E6CB7972-06F4-47C0-B464-F64E695F89E7",
                    Name: "Tag-51"
                ),
                new Tag(
                    Id: "F287FE0A-712B-4B52-925F-5047B34F3610",
                    Name: "Tag-197"
                )
            }
        ),
        new Product(
            Id: "ACC683CB-6199-416E-AE64-7C10D0C72CF9",
            CategoryId: "4F34E180-384D-42FC-AC10-FEC30227577F",
            CategoryName: "Components, Pedals",
            SKU: "PD-M562",
            Name: "HL Mountain Pedal",
            Description: "The product called \"HL Mountain Pedal\"",
            Price: 80.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "66D8EA21-E1F0-471C-A17F-02F3B149D6E6",
                    Name: "Tag-83"
                ),
                new Tag(
                    Id: "6FB11EB9-319C-431C-89D7-70113401D186",
                    Name: "Tag-154"
                ),
                new Tag(
                    Id: "7CACE200-11A3-4E2D-A88E-25E9614D2BE9",
                    Name: "Tag-97"
                ),
                new Tag(
                    Id: "B1EBD7E0-BBE0-4AFB-AC6C-50649484780B",
                    Name: "Tag-40"
                )
            }
        ),
        new Product(
            Id: "AFED4FD0-17D1-4CD5-8639-13F15B043EC2",
            CategoryId: "006A1D51-28DA-4956-A7FB-C0B2BF6360CA",
            CategoryName: "Accessories, Bottles and Cages",
            SKU: "WB-H098",
            Name: "Water Bottle - 30 oz.",
            Description: "The product called \"Water Bottle - 30 oz.\"",
            Price: 4.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "319E277F-6B7A-483D-81BA-1EC34CC700EB",
                    Name: "Tag-163"
                ),
                new Tag(
                    Id: "79E61D0F-3C95-4353-BF27-DB04535088C9",
                    Name: "Tag-50"
                ),
                new Tag(
                    Id: "A2176C7A-4E0D-4283-AFAA-319A77E9C122",
                    Name: "Tag-19"
                )
            }
        ),
        new Product(
            Id: "B267655B-A7C1-41E3-9682-21730E93FCB5",
            CategoryId: "AA28AE74-D57C-4B23-B5F7-F919E1C5844E",
            CategoryName: "Clothing, Tights",
            SKU: "TG-W091-L",
            Name: "Women's Tights, L",
            Description: "The product called \"Women's Tights, L\"",
            Price: 74.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "9C89E562-1247-435D-B786-4E54024E681C",
                    Name: "Tag-128"
                )
            }
        ),
        new Product(
            Id: "B2AC17CB-A69E-462E-B72A-917CB544FF81",
            CategoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            CategoryName: "Accessories, Tires and Tubes",
            SKU: "TI-R628",
            Name: "ML Road Tire",
            Description: "The product called \"ML Road Tire\"",
            Price: 24.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "0BC579CA-03FC-4AA6-85AA-A55035201E43",
                    Name: "Tag-21"
                ),
                new Tag(
                    Id: "4E85E551-E511-4666-BD21-E171C33A7880",
                    Name: "Tag-3"
                ),
                new Tag(
                    Id: "7F518FB1-4664-4B20-9B9F-23D5B44F6798",
                    Name: "Tag-69"
                )
            }
        ),
        new Product(
            Id: "B35B87F4-5ADE-4ED4-9469-DF024AC4195D",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T18Y-58",
            Name: "Touring-3000 Yellow, 58",
            Description: "The product called \"Touring-3000 Yellow, 58\"",
            Price: 742.35,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "511652EB-9EC2-4235-BA77-0C6E4E316679",
                    Name: "Tag-199"
                ),
                new Tag(
                    Id: "7F518FB1-4664-4B20-9B9F-23D5B44F6798",
                    Name: "Tag-69"
                ),
                new Tag(
                    Id: "BEBD68EF-901A-4282-911F-28AB44B802FE",
                    Name: "Tag-139"
                ),
                new Tag(
                    Id: "C1CB0EFE-02BB-4AE5-AA48-3DAC12921450",
                    Name: "Tag-109"
                ),
                new Tag(
                    Id: "DBC84212-C3E9-4966-8619-9A4D64EBF517",
                    Name: "Tag-125"
                )
            }
        ),
        new Product(
            Id: "BCD77A3D-9FF1-4CE4-9327-4C2A41BA9F0F",
            CategoryId: "4F34E180-384D-42FC-AC10-FEC30227577F",
            CategoryName: "Components, Pedals",
            SKU: "PD-T852",
            Name: "Touring Pedal",
            Description: "The product called \"Touring Pedal\"",
            Price: 80.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "72E191A8-F404-48AE-B8BC-2511569C895C",
                    Name: "Tag-168"
                ),
                new Tag(
                    Id: "BA4D7ABD-2E82-4DC2-ACF2-5D3B0DEAE1C1",
                    Name: "Tag-59"
                ),
                new Tag(
                    Id: "DBC21C2A-0AF6-45D4-B2C9-703DD708A821",
                    Name: "Tag-14"
                )
            }
        ),
        new Product(
            Id: "BD340F0A-F661-4ED8-B36F-FBA7623605D9",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T18U-62",
            Name: "Touring-3000 Blue, 62",
            Description: "The product called \"Touring-3000 Blue, 62\"",
            Price: 742.35,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "6C2F05C8-1E61-4912-BE1A-C67A378429BB",
                    Name: "Tag-5"
                ),
                new Tag(
                    Id: "74680691-FA4C-4721-9CB4-5846B7C3210A",
                    Name: "Tag-103"
                ),
                new Tag(
                    Id: "764C1CC8-2E5F-4EF5-83F6-8FF7441290B3",
                    Name: "Tag-190"
                )
            }
        ),
        new Product(
            Id: "BF381234-799A-4B1A-BD4B-B55891CC5907",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T44U-50",
            Name: "Touring-2000 Blue, 50",
            Description: "The product called \"Touring-2000 Blue, 50\"",
            Price: 1214.85,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "7990C336-92BD-41F9-8FB6-97390BC4D187",
                    Name: "Tag-189"
                )
            }
        ),
        new Product(
            Id: "DA96F0D0-84C7-42C3-BE74-FEB39BD60EF5",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T18Y-62",
            Name: "Touring-3000 Yellow, 62",
            Description: "The product called \"Touring-3000 Yellow, 62\"",
            Price: 742.35,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "A4D9E596-B630-4792-BDD1-7D6459827820",
                    Name: "Tag-164"
                )
            }
        ),
        new Product(
            Id: "DB89A887-43E3-4D9C-8783-7F034ACD88C0",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T18Y-54",
            Name: "Touring-3000 Yellow, 54",
            Description: "The product called \"Touring-3000 Yellow, 54\"",
            Price: 742.35,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "3C26DF5C-CE21-4EF6-AEE2-E8E1066D06B1",
                    Name: "Tag-60"
                ),
                new Tag(
                    Id: "765EF7D7-331C-42C0-BF23-A3022A723BF7",
                    Name: "Tag-191"
                ),
                new Tag(
                    Id: "812C1444-1DEA-480D-88E7-B9609ECA783C",
                    Name: "Tag-136"
                ),
                new Tag(
                    Id: "A37349FB-4A1C-4382-A845-DF81830A7B4D",
                    Name: "Tag-150"
                ),
                new Tag(
                    Id: "A49D83E4-E506-4301-8110-E114599B4A35",
                    Name: "Tag-27"
                )
            }
        ),
        new Product(
            Id: "DC8209E8-151E-425C-B7D9-7F082B66E39D",
            CategoryId: "26C74104-40BC-4541-8EF5-9892F7F03D72",
            CategoryName: "Components, Saddles",
            SKU: "SE-M940",
            Name: "HL Mountain Seat/Saddle",
            Description: "The product called \"HL Mountain Seat/Saddle\"",
            Price: 52.64,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "DDD64AA0-30DC-4DC1-BCDC-2882A0FD178C",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T18U-50",
            Name: "Touring-3000 Blue, 50",
            Description: "The product called \"Touring-3000 Blue, 50\"",
            Price: 742.35,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "0BC579CA-03FC-4AA6-85AA-A55035201E43",
                    Name: "Tag-21"
                ),
                new Tag(
                    Id: "304041C4-8C80-4C1E-9EE9-8A1DEFCF39FC",
                    Name: "Tag-72"
                ),
                new Tag(
                    Id: "3A3A99B6-E3BF-46D0-BAD9-F5F4DBB720F4",
                    Name: "Tag-70"
                ),
                new Tag(
                    Id: "F287FE0A-712B-4B52-925F-5047B34F3610",
                    Name: "Tag-197"
                )
            }
        ),
        new Product(
            Id: "DE8C032F-472A-4FFE-A8AE-4C7FFAF06DA8",
            CategoryId: "34340561-3D26-4F33-B6AD-09260FC811D6",
            CategoryName: "Components, Bottom Brackets",
            SKU: "BB-9108",
            Name: "HL Bottom Bracket",
            Description: "The product called \"HL Bottom Bracket\"",
            Price: 121.49,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "51CD93BF-098C-4C25-9829-4AD42046D038",
                    Name: "Tag-25"
                ),
                new Tag(
                    Id: "8AAFD985-8BCE-4FA8-85A2-2CA67D9DF8E6",
                    Name: "Tag-172"
                ),
                new Tag(
                    Id: "9467BA7B-49FB-4AA5-A868-478D94AF2E54",
                    Name: "Tag-92"
                ),
                new Tag(
                    Id: "F6B1A09C-BCC9-4A74-8472-D1CA98310501",
                    Name: "Tag-185"
                )
            }
        ),
        new Product(
            Id: "E08E4507-9666-411B-AAC4-519C00596B0A",
            CategoryId: "86F3CBAB-97A7-4D01-BABB-ADEFFFAED6B4",
            CategoryName: "Accessories, Tires and Tubes",
            SKU: "TI-R092",
            Name: "LL Road Tire",
            Description: "The product called \"LL Road Tire\"",
            Price: 21.49,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "567D183B-9ED1-47B4-AE22-80C52BF41067",
                    Name: "Tag-165"
                ),
                new Tag(
                    Id: "DBC84212-C3E9-4966-8619-9A4D64EBF517",
                    Name: "Tag-125"
                )
            }
        ),
        new Product(
            Id: "E60D6D23-0151-4B7E-BC56-598B9FEE026B",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T79Y-54",
            Name: "Touring-1000 Yellow, 54",
            Description: "The product called \"Touring-1000 Yellow, 54\"",
            Price: 2384.07,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "A2AFF2FF-8438-44A3-8AC6-20A50422D82A",
                    Name: "Tag-18"
                )
            }
        ),
        new Product(
            Id: "E78CEEF9-A87B-4612-8BD3-4E5DC8AC4700",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T44U-54",
            Name: "Touring-2000 Blue, 54",
            Description: "The product called \"Touring-2000 Blue, 54\"",
            Price: 1214.85,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "2400025E-FB22-4031-B4A2-9C3BD1402A9B",
                    Name: "Tag-38"
                ),
                new Tag(
                    Id: "BF28390C-CBBE-48FC-8EBF-1BD7E6608E59",
                    Name: "Tag-193"
                )
            }
        ),
        new Product(
            Id: "EDCB55C5-4CF5-424F-9083-310F940879FA",
            CategoryId: "75BF1ACB-168D-469C-9AA3-1FD26BB4EA4C",
            CategoryName: "Bikes, Touring Bikes",
            SKU: "BK-T44U-46",
            Name: "Touring-2000 Blue, 46",
            Description: "The product called \"Touring-2000 Blue, 46\"",
            Price: 1214.85,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "01078B1D-5267-4B35-82B8-57042AA9CABB",
                    Name: "Tag-84"
                ),
                new Tag(
                    Id: "BF28390C-CBBE-48FC-8EBF-1BD7E6608E59",
                    Name: "Tag-193"
                ),
                new Tag(
                    Id: "EBDBD608-416A-4FE2-96DF-02367C8D071E",
                    Name: "Tag-102"
                )
            }
        ),
        new Product(
            Id: "EF16A6FA-9BE2-4AF9-872A-299A9EA88D5F",
            CategoryId: "32A9A8E6-7004-4B24-9C2A-BB3E93B9E6BD",
            CategoryName: "Clothing, Gloves",
            SKU: "GL-F110-M",
            Name: "Full-Finger Gloves, M",
            Description: "The product called \"Full-Finger Gloves, M\"",
            Price: 37.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "94C05E5C-13B7-41DA-89DF-98C11195AE1E",
                    Name: "Tag-79"
                ),
                new Tag(
                    Id: "AA24EC37-7CE3-4ABE-B935-EC62D5FB6947",
                    Name: "Tag-148"
                ),
                new Tag(
                    Id: "BEBD68EF-901A-4282-911F-28AB44B802FE",
                    Name: "Tag-139"
                ),
                new Tag(
                    Id: "D2427B7F-AF57-498B-A73E-E7D67FD5CFD9",
                    Name: "Tag-195"
                )
            }
        ),
        new Product(
            Id: "F07F8C10-4820-4C80-AAE2-1DDEC41E5A29",
            CategoryId: "AB952F9F-5ABA-4251-BC2D-AFF8DF412A4A",
            CategoryName: "Components, Headsets",
            SKU: "HS-3479",
            Name: "HL Headset",
            Description: "The product called \"HL Headset\"",
            Price: 124.73,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "87BC6842-2CCA-4CD3-994C-33AB101455F4",
                    Name: "Tag-12"
                ),
                new Tag(
                    Id: "F07885AF-BD6C-4B71-88B1-F04295992176",
                    Name: "Tag-149"
                )
            }
        ),
        new Product(
            Id: "F32990D7-F8E4-4ACD-AA8C-1F03D8299DE7",
            CategoryId: "4F34E180-384D-42FC-AC10-FEC30227577F",
            CategoryName: "Components, Pedals",
            SKU: "PD-M282",
            Name: "LL Mountain Pedal",
            Description: "The product called \"LL Mountain Pedal\"",
            Price: 40.49,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "762CE1E0-5615-418E-B476-BCD46AD5E79E",
                    Name: "Tag-137"
                )
            }
        ),
        new Product(
            Id: "F6628734-A209-46A2-9010-0F19E7D3F3D3",
            CategoryId: "26C74104-40BC-4541-8EF5-9892F7F03D72",
            CategoryName: "Components, Saddles",
            SKU: "SE-R908",
            Name: "ML Road Seat/Saddle",
            Description: "The product called \"ML Road Seat/Saddle\"",
            Price: 39.14,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "29CBEDD8-D9C3-43A3-B20F-63224FEE0D34",
                    Name: "Tag-11"
                ),
                new Tag(
                    Id: "31BDDC90-386A-4EED-A588-751DA0587A0A",
                    Name: "Tag-95"
                ),
                new Tag(
                    Id: "511652EB-9EC2-4235-BA77-0C6E4E316679",
                    Name: "Tag-199"
                ),
                new Tag(
                    Id: "52FCE975-91EE-4789-9E36-94EC766F02A0",
                    Name: "Tag-35"
                ),
                new Tag(
                    Id: "CF3C6F6C-8038-4FAD-A07A-E1AD1C34DE22",
                    Name: "Tag-77"
                )
            }
        ),
        new Product(
            Id: "F7261436-B748-42D6-A7C9-ACD2B589F0B7",
            CategoryId: "32A9A8E6-7004-4B24-9C2A-BB3E93B9E6BD",
            CategoryName: "Clothing, Gloves",
            SKU: "GL-H102-S",
            Name: "Half-Finger Gloves, S",
            Description: "The product called \"Half-Finger Gloves, S\"",
            Price: 24.49,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "033D3826-2851-4B97-9464-59D3675175D4",
                    Name: "Tag-108"
                ),
                new Tag(
                    Id: "3A3A99B6-E3BF-46D0-BAD9-F5F4DBB720F4",
                    Name: "Tag-70"
                )
            }
        ),
        new Product(
            Id: "FB118699-4C89-493B-B0AB-DA517935773E",
            CategoryId: "26C74104-40BC-4541-8EF5-9892F7F03D72",
            CategoryName: "Components, Saddles",
            SKU: "SE-T312",
            Name: "LL Touring Seat/Saddle",
            Description: "The product called \"LL Touring Seat/Saddle\"",
            Price: 27.12,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "FC0B659C-C1EF-41F3-AFE2-F87C7F43AD48",
            CategoryId: "AB952F9F-5ABA-4251-BC2D-AFF8DF412A4A",
            CategoryName: "Components, Headsets",
            SKU: "HS-0296",
            Name: "LL Headset",
            Description: "The product called \"LL Headset\"",
            Price: 34.2,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "18AC309F-F81C-4234-A752-5DDD2BEAEE83",
                    Name: "Tag-32"
                ),
                new Tag(
                    Id: "1B387A00-57D3-4444-8331-18A90725E98B",
                    Name: "Tag-43"
                ),
                new Tag(
                    Id: "C6AB3E24-BA48-40F0-A260-CB04EB03D5B0",
                    Name: "Tag-73"
                ),
                new Tag(
                    Id: "DAC25651-3DD3-4483-8FD1-581DC41EF34B",
                    Name: "Tag-56"
                ),
                new Tag(
                    Id: "E6D5275B-8C42-47AE-BDEC-FC708DB3E0AC",
                    Name: "Tag-119"
                )
            }
        ),
        new Product(
            Id: "FCF95DBC-BBAD-467B-9639-FC6E4EC42B4C",
            CategoryId: "4F34E180-384D-42FC-AC10-FEC30227577F",
            CategoryName: "Components, Pedals",
            SKU: "PD-R347",
            Name: "LL Road Pedal",
            Description: "The product called \"LL Road Pedal\"",
            Price: 40.49,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "001C55F4-E7F6-4A7E-A736-79114A0A3A4E",
                    Name: "Tag-41"
                ),
                new Tag(
                    Id: "A34D34F7-3286-4FA4-B4B0-5E61CCEEE197",
                    Name: "Tag-4"
                )
            }
        ),
        new Product(
            Id: "0B013EA7-B40E-4996-A494-D1E2840FEAAE",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R72R-44",
            Name: "ML Road Frame - Red, 44",
            Description: "The product called \"ML Road Frame - Red, 44\"",
            Price: 594.83,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "9653F306-0B3C-4856-ABF8-13C3F04AE4F0",
                    Name: "Tag-36"
                ),
                new Tag(
                    Id: "AA35D2EA-24FD-4A62-80FE-83EFF821F019",
                    Name: "Tag-10"
                ),
                new Tag(
                    Id: "DA661FCF-CC7F-4AF9-A9E2-8E7A5570844E",
                    Name: "Tag-188"
                )
            }
        ),
        new Product(
            Id: "1BEAE2B0-134A-4780-9A7A-5FA17EADD513",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R92R-48",
            Name: "HL Road Frame - Red, 48",
            Description: "The product called \"HL Road Frame - Red, 48\"",
            Price: 1431.5,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "21756241-F313-4D34-9914-9B7DAC76F9D6",
            CategoryId: "973B839C-BF5D-485D-9D17-863C59B262E3",
            CategoryName: "Components, Forks",
            SKU: "FK-1639",
            Name: "LL Fork",
            Description: "The product called \"LL Fork\"",
            Price: 148.22,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "2E7252D2-B646-47FB-B5BB-836643578038",
                    Name: "Tag-130"
                ),
                new Tag(
                    Id: "84C1934D-F048-4D2B-8525-323AFE2A7C7C",
                    Name: "Tag-184"
                ),
                new Tag(
                    Id: "8DC9DFB4-1946-427A-A0A0-E06E1448CC63",
                    Name: "Tag-171"
                ),
                new Tag(
                    Id: "B18FB652-C4B6-4A40-BA22-1E687C1A58CE",
                    Name: "Tag-161"
                ),
                new Tag(
                    Id: "E6D5275B-8C42-47AE-BDEC-FC708DB3E0AC",
                    Name: "Tag-119"
                )
            }
        ),
        new Product(
            Id: "26E6C049-667F-4463-AF1D-660953231165",
            CategoryId: "8797AB0F-A9A3-475D-925E-56AC73DC206E",
            CategoryName: "Components, Chains",
            SKU: "CH-0234",
            Name: "Chain",
            Description: "The product called \"Chain\"",
            Price: 20.24,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "403AE98F-892E-4FEC-B262-A264CF1F52A9",
                    Name: "Tag-45"
                ),
                new Tag(
                    Id: "BEBD68EF-901A-4282-911F-28AB44B802FE",
                    Name: "Tag-139"
                ),
                new Tag(
                    Id: "E80C2AD7-0ABA-4B0E-87B7-46AE28851531",
                    Name: "Tag-141"
                )
            }
        ),
        new Product(
            Id: "2CE4EFA7-5DC6-4D3E-ACB2-B7DDE4518408",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R92B-58",
            Name: "HL Road Frame - Black, 58",
            Description: "The product called \"HL Road Frame - Black, 58\"",
            Price: 1431.5,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "2CE9DADE-DCAC-436C-9D69-B7C886A01B77",
                    Name: "Tag-101"
                ),
                new Tag(
                    Id: "AEFA79EF-CBF1-4824-AAF7-1D20EA85119B",
                    Name: "Tag-17"
                ),
                new Tag(
                    Id: "D197C394-FB88-4EFF-B0FB-8BED1A86F294",
                    Name: "Tag-182"
                ),
                new Tag(
                    Id: "ECBBCC15-3016-4075-B084-4B49DA754814",
                    Name: "Tag-138"
                )
            }
        ),
        new Product(
            Id: "311D60FC-9EB9-4194-B594-1E5BD87CCF81",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R38R-62",
            Name: "LL Road Frame - Red, 62",
            Description: "The product called \"LL Road Frame - Red, 62\"",
            Price: 337.22,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "567D183B-9ED1-47B4-AE22-80C52BF41067",
                    Name: "Tag-165"
                ),
                new Tag(
                    Id: "9653F306-0B3C-4856-ABF8-13C3F04AE4F0",
                    Name: "Tag-36"
                )
            }
        ),
        new Product(
            Id: "32C5F63D-CF84-457C-9063-0C758CCDACE7",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R92R-44",
            Name: "HL Road Frame - Red, 44",
            Description: "The product called \"HL Road Frame - Red, 44\"",
            Price: 1431.5,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "332C8377-F7B5-44C2-8DFC-B374294FD9B2",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R92R-62",
            Name: "HL Road Frame - Red, 62",
            Description: "The product called \"HL Road Frame - Red, 62\"",
            Price: 1431.5,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "3C26DF5C-CE21-4EF6-AEE2-E8E1066D06B1",
                    Name: "Tag-60"
                )
            }
        ),
        new Product(
            Id: "34C0090C-B299-433B-8D31-42EFCDC5874D",
            CategoryId: "345E8DEC-774F-45F6-BE0C-18CDDB368FC8",
            CategoryName: "Accessories, Panniers",
            SKU: "PA-T100",
            Name: "Touring-Panniers, Large",
            Description: "The product called \"Touring-Panniers, Large\"",
            Price: 125.0,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "50F59C1E-E78D-4543-B4D0-B06E4C59E617",
                    Name: "Tag-126"
                )
            }
        ),
        new Product(
            Id: "3B52D15D-DF6C-4042-BA15-2EFEA8A2F852",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R92B-62",
            Name: "HL Road Frame - Black, 62",
            Description: "The product called \"HL Road Frame - Black, 62\"",
            Price: 1431.5,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "1A2E203E-B80D-4693-A7C2-AB39E31C9C61",
                    Name: "Tag-134"
                ),
                new Tag(
                    Id: "2E7252D2-B646-47FB-B5BB-836643578038",
                    Name: "Tag-130"
                ),
                new Tag(
                    Id: "AEFA79EF-CBF1-4824-AAF7-1D20EA85119B",
                    Name: "Tag-17"
                ),
                new Tag(
                    Id: "E661634D-CDC3-4FA6-BE4B-D1FEEAECB5B9",
                    Name: "Tag-121"
                )
            }
        ),
        new Product(
            Id: "3FA9E0D9-E6E9-429D-9E24-7DAFE9B99A2C",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R92R-58",
            Name: "HL Road Frame - Red, 58",
            Description: "The product called \"HL Road Frame - Red, 58\"",
            Price: 1431.5,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "E661634D-CDC3-4FA6-BE4B-D1FEEAECB5B9",
                    Name: "Tag-121"
                )
            }
        ),
        new Product(
            Id: "409BC0E0-2B43-4F82-9C36-2E4ABBB7344C",
            CategoryId: "ECEEC6AC-3CF1-41A6-8430-A1255F355BB5",
            CategoryName: "Components, Brakes",
            SKU: "FB-9873",
            Name: "Front Brakes",
            Description: "The product called \"Front Brakes\"",
            Price: 106.5,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "18AC309F-F81C-4234-A752-5DDD2BEAEE83",
                    Name: "Tag-32"
                ),
                new Tag(
                    Id: "29CBEDD8-D9C3-43A3-B20F-63224FEE0D34",
                    Name: "Tag-11"
                ),
                new Tag(
                    Id: "8AAFD985-8BCE-4FA8-85A2-2CA67D9DF8E6",
                    Name: "Tag-172"
                ),
                new Tag(
                    Id: "CAF27567-B4CB-463C-A54E-5EF1F2657DD2",
                    Name: "Tag-75"
                )
            }
        ),
        new Product(
            Id: "435D4B82-D557-4752-B825-D28767FB32D3",
            CategoryId: "AA5A82D4-914C-4132-8C08-E7B75DCE3428",
            CategoryName: "Components, Cranksets",
            SKU: "CS-4759",
            Name: "LL Crankset",
            Description: "The product called \"LL Crankset\"",
            Price: 175.49,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "4424AA2A-CC8D-4471-9478-21E91185593C",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R92B-48",
            Name: "HL Road Frame - Black, 48",
            Description: "The product called \"HL Road Frame - Black, 48\"",
            Price: 1431.5,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "491834BE-AAA5-419D-B166-77B93F20EBA7",
            CategoryId: "AA5A82D4-914C-4132-8C08-E7B75DCE3428",
            CategoryName: "Components, Cranksets",
            SKU: "CS-9183",
            Name: "HL Crankset",
            Description: "The product called \"HL Crankset\"",
            Price: 404.99,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "520E3E6B-95F1-4258-9F74-E434848E88B2",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R38R-48",
            Name: "LL Road Frame - Red, 48",
            Description: "The product called \"LL Road Frame - Red, 48\"",
            Price: 337.22,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "033D3826-2851-4B97-9464-59D3675175D4",
                    Name: "Tag-108"
                ),
                new Tag(
                    Id: "A2176C7A-4E0D-4283-AFAA-319A77E9C122",
                    Name: "Tag-19"
                )
            }
        ),
        new Product(
            Id: "5253671B-E50E-4686-9A17-4F51C2B65C0F",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R72Y-40",
            Name: "ML Road Frame-W - Yellow, 40",
            Description: "The product called \"ML Road Frame-W - Yellow, 40\"",
            Price: 594.83,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "0C184C69-F4F2-4774-9645-46F53D297D95",
                    Name: "Tag-49"
                ),
                new Tag(
                    Id: "403AE98F-892E-4FEC-B262-A264CF1F52A9",
                    Name: "Tag-45"
                )
            }
        ),
        new Product(
            Id: "56BB7DD2-2421-4671-A527-7373008DD553",
            CategoryId: "975E2A45-DA17-45CE-B65E-575A19334EB2",
            CategoryName: "Components, Derailleurs",
            SKU: "RD-2308",
            Name: "Rear Derailleur",
            Description: "The product called \"Rear Derailleur\"",
            Price: 121.46,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "A2AFF2FF-8438-44A3-8AC6-20A50422D82A",
                    Name: "Tag-18"
                )
            }
        ),
        new Product(
            Id: "58978B2E-D4C6-4D69-A840-D935688F9C2D",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R92R-56",
            Name: "HL Road Frame - Red, 56",
            Description: "The product called \"HL Road Frame - Red, 56\"",
            Price: 1431.5,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "3A3A99B6-E3BF-46D0-BAD9-F5F4DBB720F4",
                    Name: "Tag-70"
                ),
                new Tag(
                    Id: "66D8EA21-E1F0-471C-A17F-02F3B149D6E6",
                    Name: "Tag-83"
                ),
                new Tag(
                    Id: "69212884-78CF-48C9-A5C6-B62E76725533",
                    Name: "Tag-104"
                ),
                new Tag(
                    Id: "A9834752-41CA-47F5-8A5A-D9A878DF0ACB",
                    Name: "Tag-198"
                ),
                new Tag(
                    Id: "D5887E7C-B916-4AF4-BAF8-7B996ADA8C83",
                    Name: "Tag-52"
                )
            }
        ),
        new Product(
            Id: "58B0F878-2619-4225-B9B1-9C6C4FFF9C17",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R38B-44",
            Name: "LL Road Frame - Black, 44",
            Description: "The product called \"LL Road Frame - Black, 44\"",
            Price: 337.22,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "1830EEDD-AF21-43EA-A13C-393ED77DEAC5",
                    Name: "Tag-152"
                ),
                new Tag(
                    Id: "812C1444-1DEA-480D-88E7-B9609ECA783C",
                    Name: "Tag-136"
                ),
                new Tag(
                    Id: "B49C6195-5ABA-42FA-B15C-84CF9FE252FE",
                    Name: "Tag-129"
                ),
                new Tag(
                    Id: "EBDBD608-416A-4FE2-96DF-02367C8D071E",
                    Name: "Tag-102"
                ),
                new Tag(
                    Id: "F629F27D-3301-4906-BE9B-C46D6D6F6141",
                    Name: "Tag-65"
                )
            }
        ),
        new Product(
            Id: "600DDD58-C9D0-4118-9A69-B7716ED3A303",
            CategoryId: "340D259D-BFFE-4E2A-9C5E-8B1E473A0322",
            CategoryName: "Accessories, Bike Stands",
            SKU: "ST-1401",
            Name: "All-Purpose Bike Stand",
            Description: "The product called \"All-Purpose Bike Stand\"",
            Price: 159.0,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "2CE9DADE-DCAC-436C-9D69-B7C886A01B77",
                    Name: "Tag-101"
                ),
                new Tag(
                    Id: "304041C4-8C80-4C1E-9EE9-8A1DEFCF39FC",
                    Name: "Tag-72"
                ),
                new Tag(
                    Id: "5A94DABD-FD34-48F7-9626-50872E214275",
                    Name: "Tag-181"
                ),
                new Tag(
                    Id: "6167EE62-5458-45B8-822D-1C10F274D9F1",
                    Name: "Tag-170"
                ),
                new Tag(
                    Id: "7337386B-E865-4ADC-BA17-4437CB02E3BE",
                    Name: "Tag-8"
                )
            }
        ),
        new Product(
            Id: "61B55CE9-DEB4-49B3-AB55-0AAC11EBBBBF",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R38R-58",
            Name: "LL Road Frame - Red, 58",
            Description: "The product called \"LL Road Frame - Red, 58\"",
            Price: 337.22,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "45CBB7FF-FA48-49D8-89EF-F1D0B8AC3923",
                    Name: "Tag-86"
                ),
                new Tag(
                    Id: "4B10B00B-C1CA-4508-9848-3B1BD910B724",
                    Name: "Tag-30"
                )
            }
        ),
        new Product(
            Id: "6374995F-9A78-43CD-AE0D-5F6041078140",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R38R-60",
            Name: "LL Road Frame - Red, 60",
            Description: "The product called \"LL Road Frame - Red, 60\"",
            Price: 337.22,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "7133D6F6-C8FD-4AD1-83E8-5622D1746E25",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R72R-58",
            Name: "ML Road Frame - Red, 58",
            Description: "The product called \"ML Road Frame - Red, 58\"",
            Price: 594.83,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "4B10B00B-C1CA-4508-9848-3B1BD910B724",
                    Name: "Tag-30"
                ),
                new Tag(
                    Id: "CAF27567-B4CB-463C-A54E-5EF1F2657DD2",
                    Name: "Tag-75"
                )
            }
        ),
        new Product(
            Id: "751115E7-BD5E-45C7-932B-E9DDE9D62579",
            CategoryId: "973B839C-BF5D-485D-9D17-863C59B262E3",
            CategoryName: "Components, Forks",
            SKU: "FK-9939",
            Name: "HL Fork",
            Description: "The product called \"HL Fork\"",
            Price: 229.49,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "2400025E-FB22-4031-B4A2-9C3BD1402A9B",
                    Name: "Tag-38"
                ),
                new Tag(
                    Id: "40525E23-C1FB-4213-BF28-2B4C64BDC29B",
                    Name: "Tag-135"
                ),
                new Tag(
                    Id: "AA24EC37-7CE3-4ABE-B935-EC62D5FB6947",
                    Name: "Tag-148"
                ),
                new Tag(
                    Id: "E80C2AD7-0ABA-4B0E-87B7-46AE28851531",
                    Name: "Tag-141"
                )
            }
        ),
        new Product(
            Id: "794ACC61-01E9-49BF-B150-1D02EE01D76F",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R38B-48",
            Name: "LL Road Frame - Black, 48",
            Description: "The product called \"LL Road Frame - Black, 48\"",
            Price: 337.22,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "A2443B36-76AE-4963-9E21-368868F9C514",
                    Name: "Tag-6"
                ),
                new Tag(
                    Id: "F07885AF-BD6C-4B71-88B1-F04295992176",
                    Name: "Tag-149"
                )
            }
        ),
        new Product(
            Id: "8826E4D4-36FF-42AD-A33F-0E7794215158",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R38B-58",
            Name: "LL Road Frame - Black, 58",
            Description: "The product called \"LL Road Frame - Black, 58\"",
            Price: 337.22,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "1A2E203E-B80D-4693-A7C2-AB39E31C9C61",
                    Name: "Tag-134"
                ),
                new Tag(
                    Id: "1B387A00-57D3-4444-8331-18A90725E98B",
                    Name: "Tag-43"
                ),
                new Tag(
                    Id: "69212884-78CF-48C9-A5C6-B62E76725533",
                    Name: "Tag-104"
                ),
                new Tag(
                    Id: "72E191A8-F404-48AE-B8BC-2511569C895C",
                    Name: "Tag-168"
                ),
                new Tag(
                    Id: "F629F27D-3301-4906-BE9B-C46D6D6F6141",
                    Name: "Tag-65"
                )
            }
        ),
        new Product(
            Id: "894D03FA-1A4A-4FA4-9A0B-C3169EBB5674",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R72Y-44",
            Name: "ML Road Frame-W - Yellow, 44",
            Description: "The product called \"ML Road Frame-W - Yellow, 44\"",
            Price: 594.83,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "765254E3-8E88-4C57-AADA-9F5126917970",
                    Name: "Tag-93"
                ),
                new Tag(
                    Id: "76B3C6DC-3411-457B-96F5-A51CE015DAD9",
                    Name: "Tag-29"
                ),
                new Tag(
                    Id: "C68A2129-1E2B-43EC-95B5-AC56CC200FA4",
                    Name: "Tag-180"
                ),
                new Tag(
                    Id: "C6AB3E24-BA48-40F0-A260-CB04EB03D5B0",
                    Name: "Tag-73"
                ),
                new Tag(
                    Id: "E6D5275B-8C42-47AE-BDEC-FC708DB3E0AC",
                    Name: "Tag-119"
                )
            }
        ),
        new Product(
            Id: "8BAA2AFB-CAE5-4A96-ABB2-46EDF9B5680E",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R38B-60",
            Name: "LL Road Frame - Black, 60",
            Description: "The product called \"LL Road Frame - Black, 60\"",
            Price: 337.22,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "274E32EE-612A-4AAB-B91A-C7E8E4D8C2A7",
                    Name: "Tag-1"
                ),
                new Tag(
                    Id: "AA24EC37-7CE3-4ABE-B935-EC62D5FB6947",
                    Name: "Tag-148"
                )
            }
        ),
        new Product(
            Id: "8D3DCF87-D1ED-44DD-8DB8-085EB98C8A52",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R92R-52",
            Name: "HL Road Frame - Red, 52",
            Description: "The product called \"HL Road Frame - Red, 52\"",
            Price: 1431.5,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "01E0AFB1-867D-4BAA-B0DF-2E99D056EDA2",
                    Name: "Tag-107"
                ),
                new Tag(
                    Id: "2400025E-FB22-4031-B4A2-9C3BD1402A9B",
                    Name: "Tag-38"
                ),
                new Tag(
                    Id: "274E32EE-612A-4AAB-B91A-C7E8E4D8C2A7",
                    Name: "Tag-1"
                ),
                new Tag(
                    Id: "D56040DB-E5DF-40BE-9F2F-7E10F4340BCA",
                    Name: "Tag-31"
                ),
                new Tag(
                    Id: "E6CB7972-06F4-47C0-B464-F64E695F89E7",
                    Name: "Tag-51"
                )
            }
        ),
        new Product(
            Id: "916ACEDC-DCF4-4118-90C6-B9572D30714E",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R72R-60",
            Name: "ML Road Frame - Red, 60",
            Description: "The product called \"ML Road Frame - Red, 60\"",
            Price: 594.83,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "033D3826-2851-4B97-9464-59D3675175D4",
                    Name: "Tag-108"
                ),
                new Tag(
                    Id: "69212884-78CF-48C9-A5C6-B62E76725533",
                    Name: "Tag-104"
                ),
                new Tag(
                    Id: "765EF7D7-331C-42C0-BF23-A3022A723BF7",
                    Name: "Tag-191"
                ),
                new Tag(
                    Id: "D1E5CB02-8E7B-422F-9421-C0E608F0AC4C",
                    Name: "Tag-133"
                )
            }
        ),
        new Product(
            Id: "9183E546-A94B-4B7F-845B-A53E0EF5C626",
            CategoryId: "973B839C-BF5D-485D-9D17-863C59B262E3",
            CategoryName: "Components, Forks",
            SKU: "FK-5136",
            Name: "ML Fork",
            Description: "The product called \"ML Fork\"",
            Price: 175.49,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "D1E5CB02-8E7B-422F-9421-C0E608F0AC4C",
                    Name: "Tag-133"
                ),
                new Tag(
                    Id: "DCDBD26C-4D71-4F91-BBE9-98D1897E704D",
                    Name: "Tag-68"
                )
            }
        ),
        new Product(
            Id: "92413209-8DA6-4661-9E11-26B55990BEB2",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R38R-52",
            Name: "LL Road Frame - Red, 52",
            Description: "The product called \"LL Road Frame - Red, 52\"",
            Price: 337.22,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "069169DD-F4B3-4769-8841-13B5FF745932",
                    Name: "Tag-157"
                ),
                new Tag(
                    Id: "94F41BAD-B861-4BB0-A941-89677D04F455",
                    Name: "Tag-26"
                ),
                new Tag(
                    Id: "F533A770-1E5D-4B48-8792-E16E155B6E38",
                    Name: "Tag-87"
                )
            }
        ),
        new Product(
            Id: "92DB7ABD-1C8E-458C-8828-9BFD1984B07D",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R38B-62",
            Name: "LL Road Frame - Black, 62",
            Description: "The product called \"LL Road Frame - Black, 62\"",
            Price: 337.22,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "51CD93BF-098C-4C25-9829-4AD42046D038",
                    Name: "Tag-25"
                ),
                new Tag(
                    Id: "718DAED6-2186-4E09-8C02-CCC58281838D",
                    Name: "Tag-94"
                ),
                new Tag(
                    Id: "A37349FB-4A1C-4382-A845-DF81830A7B4D",
                    Name: "Tag-150"
                ),
                new Tag(
                    Id: "A9834752-41CA-47F5-8A5A-D9A878DF0ACB",
                    Name: "Tag-198"
                )
            }
        ),
        new Product(
            Id: "9351199A-B781-482D-80BE-2C11394002E5",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R72Y-38",
            Name: "ML Road Frame-W - Yellow, 38",
            Description: "The product called \"ML Road Frame-W - Yellow, 38\"",
            Price: 594.83,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "59676183-1BD7-48A0-B3B0-42B3C0800EB0",
                    Name: "Tag-64"
                ),
                new Tag(
                    Id: "762CE1E0-5615-418E-B476-BCD46AD5E79E",
                    Name: "Tag-137"
                ),
                new Tag(
                    Id: "76B3C6DC-3411-457B-96F5-A51CE015DAD9",
                    Name: "Tag-29"
                ),
                new Tag(
                    Id: "AC4CC3CC-4E6B-461D-9B0E-4218EDDF3142",
                    Name: "Tag-122"
                )
            }
        ),
        new Product(
            Id: "A2E169C8-0916-4CAD-9C7B-FBAF463D0DB3",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R72Y-42",
            Name: "ML Road Frame-W - Yellow, 42",
            Description: "The product called \"ML Road Frame-W - Yellow, 42\"",
            Price: 594.83,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "1B387A00-57D3-4444-8331-18A90725E98B",
                    Name: "Tag-43"
                ),
                new Tag(
                    Id: "227FF627-9E87-4BE5-8254-17BB155B0AD7",
                    Name: "Tag-23"
                )
            }
        ),
        new Product(
            Id: "A6040C40-906B-4A87-9E2C-683A8037A1C3",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R92B-52",
            Name: "HL Road Frame - Black, 52",
            Description: "The product called \"HL Road Frame - Black, 52\"",
            Price: 1431.5,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "033D3826-2851-4B97-9464-59D3675175D4",
                    Name: "Tag-108"
                ),
                new Tag(
                    Id: "4B10B00B-C1CA-4508-9848-3B1BD910B724",
                    Name: "Tag-30"
                ),
                new Tag(
                    Id: "94C05E5C-13B7-41DA-89DF-98C11195AE1E",
                    Name: "Tag-79"
                ),
                new Tag(
                    Id: "D1E5CB02-8E7B-422F-9421-C0E608F0AC4C",
                    Name: "Tag-133"
                ),
                new Tag(
                    Id: "D56040DB-E5DF-40BE-9F2F-7E10F4340BCA",
                    Name: "Tag-31"
                )
            }
        ),
        new Product(
            Id: "B03973CE-FAAD-4BE2-84FF-5BA5C751B6D0",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R92B-44",
            Name: "HL Road Frame - Black, 44",
            Description: "The product called \"HL Road Frame - Black, 44\"",
            Price: 1431.5,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "2400025E-FB22-4031-B4A2-9C3BD1402A9B",
                    Name: "Tag-38"
                ),
                new Tag(
                    Id: "47A34A77-A9B8-4703-9AEF-3786726C7A31",
                    Name: "Tag-176"
                ),
                new Tag(
                    Id: "C6AB3E24-BA48-40F0-A260-CB04EB03D5B0",
                    Name: "Tag-73"
                ),
                new Tag(
                    Id: "F287FE0A-712B-4B52-925F-5047B34F3610",
                    Name: "Tag-197"
                ),
                new Tag(
                    Id: "F6B1A09C-BCC9-4A74-8472-D1CA98310501",
                    Name: "Tag-185"
                )
            }
        ),
        new Product(
            Id: "B08450AA-413C-4663-A62D-7291A8ECF1F5",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R38R-44",
            Name: "LL Road Frame - Red, 44",
            Description: "The product called \"LL Road Frame - Red, 44\"",
            Price: 337.22,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "4B10B00B-C1CA-4508-9848-3B1BD910B724",
                    Name: "Tag-30"
                ),
                new Tag(
                    Id: "8CA1BBD8-D00B-4654-AABA-5C8724C6F4BD",
                    Name: "Tag-81"
                ),
                new Tag(
                    Id: "A4D9E596-B630-4792-BDD1-7D6459827820",
                    Name: "Tag-164"
                ),
                new Tag(
                    Id: "A50C570B-B3FC-4678-96C8-2D117DD11A12",
                    Name: "Tag-66"
                ),
                new Tag(
                    Id: "B20574A2-8F94-4CB5-A9A7-2E1E203978D6",
                    Name: "Tag-117"
                )
            }
        ),
        new Product(
            Id: "B1AAF271-9DFA-4826-91A3-F3B4BFF49B1C",
            CategoryId: "AA5A82D4-914C-4132-8C08-E7B75DCE3428",
            CategoryName: "Components, Cranksets",
            SKU: "CS-6583",
            Name: "ML Crankset",
            Description: "The product called \"ML Crankset\"",
            Price: 256.49,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "B8587D85-224F-4252-9521-A1763D63AEC2",
            CategoryId: "ECEEC6AC-3CF1-41A6-8430-A1255F355BB5",
            CategoryName: "Components, Brakes",
            SKU: "RB-9231",
            Name: "Rear Brakes",
            Description: "The product called \"Rear Brakes\"",
            Price: 106.5,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "BF87ACE3-C52B-44EA-9871-4A6497B3AF9F",
            CategoryId: "7FF64215-1F7A-4CDF-9BA1-AD6ADC6B5D1C",
            CategoryName: "Accessories, Pumps",
            SKU: "PU-0452",
            Name: "Minipump",
            Description: "The product called \"Minipump\"",
            Price: 19.99,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "C310A68D-DBF2-421A-91CA-F09A3B8A1AAA",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R72R-52",
            Name: "ML Road Frame - Red, 52",
            Description: "The product called \"ML Road Frame - Red, 52\"",
            Price: 594.83,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "18AC309F-F81C-4234-A752-5DDD2BEAEE83",
                    Name: "Tag-32"
                ),
                new Tag(
                    Id: "7990C336-92BD-41F9-8FB6-97390BC4D187",
                    Name: "Tag-189"
                ),
                new Tag(
                    Id: "80F182C6-0619-4547-9A2D-F90A7913FACF",
                    Name: "Tag-96"
                ),
                new Tag(
                    Id: "9E250CCC-6530-4DC0-9D64-E7777B3C3B73",
                    Name: "Tag-177"
                ),
                new Tag(
                    Id: "EFD6F482-9619-47C2-94FD-DA5D035DEA7A",
                    Name: "Tag-144"
                )
            }
        ),
        new Product(
            Id: "CB038CA5-3728-4B59-B209-22FAB210F58B",
            CategoryId: "4F2FD0D4-F0E5-4F9E-B049-861E6541B987",
            CategoryName: "Accessories, Hydration Packs",
            SKU: "HY-1023-70",
            Name: "Hydration Pack - 70 oz.",
            Description: "The product called \"Hydration Pack - 70 oz.\"",
            Price: 54.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "01078B1D-5267-4B35-82B8-57042AA9CABB",
                    Name: "Tag-84"
                ),
                new Tag(
                    Id: "6FB11EB9-319C-431C-89D7-70113401D186",
                    Name: "Tag-154"
                ),
                new Tag(
                    Id: "775908D7-2622-4C29-AF4D-F2274824DA3B",
                    Name: "Tag-89"
                ),
                new Tag(
                    Id: "83D720BA-BB31-4BE5-B723-8A836AB6D532",
                    Name: "Tag-127"
                ),
                new Tag(
                    Id: "D69B1B6C-4963-4E85-8FA5-6A3E1CD1C83B",
                    Name: "Tag-187"
                )
            }
        ),
        new Product(
            Id: "E223E34D-E0D0-4DFA-AB7D-8E72F94F2202",
            CategoryId: "975E2A45-DA17-45CE-B65E-575A19334EB2",
            CategoryName: "Components, Derailleurs",
            SKU: "FD-2342",
            Name: "Front Derailleur",
            Description: "The product called \"Front Derailleur\"",
            Price: 91.49,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "088B5F10-EB9B-4F33-A2E4-F2E54485B90F",
                    Name: "Tag-115"
                ),
                new Tag(
                    Id: "AA35D2EA-24FD-4A62-80FE-83EFF821F019",
                    Name: "Tag-10"
                )
            }
        ),
        new Product(
            Id: "E5A67B5B-B190-45CB-A9E4-BE3F6BD49214",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R72R-48",
            Name: "ML Road Frame - Red, 48",
            Description: "The product called \"ML Road Frame - Red, 48\"",
            Price: 594.83,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "2CE9DADE-DCAC-436C-9D69-B7C886A01B77",
                    Name: "Tag-101"
                ),
                new Tag(
                    Id: "A2AFF2FF-8438-44A3-8AC6-20A50422D82A",
                    Name: "Tag-18"
                ),
                new Tag(
                    Id: "AC4CC3CC-4E6B-461D-9B0E-4218EDDF3142",
                    Name: "Tag-122"
                ),
                new Tag(
                    Id: "BDA92549-CBC2-4DC1-9C82-18D1A629C3F3",
                    Name: "Tag-145"
                )
            }
        ),
        new Product(
            Id: "EEE4159B-F224-4C02-B578-2F398229592D",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R38B-52",
            Name: "LL Road Frame - Black, 52",
            Description: "The product called \"LL Road Frame - Black, 52\"",
            Price: 337.22,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "6C6D061E-F701-41DC-AEA2-7A5C28061840",
                    Name: "Tag-98"
                ),
                new Tag(
                    Id: "7F518FB1-4664-4B20-9B9F-23D5B44F6798",
                    Name: "Tag-69"
                ),
                new Tag(
                    Id: "87BC6842-2CCA-4CD3-994C-33AB101455F4",
                    Name: "Tag-12"
                )
            }
        ),
        new Product(
            Id: "FE292D83-1F34-4845-A467-7C62AD3C6CBE",
            CategoryId: "7FF64215-1F7A-4CDF-9BA1-AD6ADC6B5D1C",
            CategoryName: "Accessories, Pumps",
            SKU: "PU-M044",
            Name: "Mountain Pump",
            Description: "The product called \"Mountain Pump\"",
            Price: 24.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "01078B1D-5267-4B35-82B8-57042AA9CABB",
                    Name: "Tag-84"
                ),
                new Tag(
                    Id: "84C1934D-F048-4D2B-8525-323AFE2A7C7C",
                    Name: "Tag-184"
                ),
                new Tag(
                    Id: "9653F306-0B3C-4856-ABF8-13C3F04AE4F0",
                    Name: "Tag-36"
                )
            }
        ),
        new Product(
            Id: "FFCA3096-199F-41C3-99D1-35BC88D8AC6F",
            CategoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2",
            CategoryName: "Components, Road Frames",
            SKU: "FR-R72Y-48",
            Name: "ML Road Frame-W - Yellow, 48",
            Description: "The product called \"ML Road Frame-W - Yellow, 48\"",
            Price: 594.83,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "14CFF1D6-7749-4A57-85B3-783F47731F32",
                    Name: "Tag-7"
                ),
                new Tag(
                    Id: "84C396AD-98C6-4B12-8C3A-1BDA3ABF7D73",
                    Name: "Tag-24"
                )
            }
        ),
        new Product(
            Id: "056C459F-DA40-475E-B7BE-B87B6DB39D33",
            CategoryId: "9268EA12-29BA-404B-B514-E4737DB3BFCB",
            CategoryName: "Clothing, Bib-Shorts",
            SKU: "SB-M891-S",
            Name: "Men's Bib-Shorts, S",
            Description: "The product called \"Men's Bib-Shorts, S\"",
            Price: 89.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "4B10B00B-C1CA-4508-9848-3B1BD910B724",
                    Name: "Tag-30"
                ),
                new Tag(
                    Id: "89FB612A-F9AA-4196-B5F5-B9FA16D558DC",
                    Name: "Tag-175"
                )
            }
        ),
        new Product(
            Id: "08CF5494-D064-40CF-952B-E33ED9CE9297",
            CategoryId: "9268EA12-29BA-404B-B514-E4737DB3BFCB",
            CategoryName: "Clothing, Bib-Shorts",
            SKU: "SB-M891-M",
            Name: "Men's Bib-Shorts, M",
            Description: "The product called \"Men's Bib-Shorts, M\"",
            Price: 89.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "0C1DA4B7-676B-413A-A2C5-CCC944837DDC",
                    Name: "Tag-39"
                ),
                new Tag(
                    Id: "764C1CC8-2E5F-4EF5-83F6-8FF7441290B3",
                    Name: "Tag-190"
                ),
                new Tag(
                    Id: "76B3C6DC-3411-457B-96F5-A51CE015DAD9",
                    Name: "Tag-29"
                ),
                new Tag(
                    Id: "DBC21C2A-0AF6-45D4-B2C9-703DD708A821",
                    Name: "Tag-14"
                ),
                new Tag(
                    Id: "F132E7B8-65B1-471E-8D3E-5E8D7110CA48",
                    Name: "Tag-118"
                )
            }
        ),
        new Product(
            Id: "0B77351B-8F31-45D2-AECC-85BABD03B24E",
            CategoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            CategoryName: "Components, Touring Frames",
            SKU: "FR-T98Y-50",
            Name: "HL Touring Frame - Yellow, 50",
            Description: "The product called \"HL Touring Frame - Yellow, 50\"",
            Price: 1003.91,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "0F124781-C991-48A9-ACF2-249771D44029",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M68B-42",
            Name: "Mountain-200 Black, 42",
            Description: "The product called \"Mountain-200 Black, 42\"",
            Price: 2294.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "4F67013C-3B5E-4A3D-B4B0-8C597A491EB6",
                    Name: "Tag-82"
                ),
                new Tag(
                    Id: "59676183-1BD7-48A0-B3B0-42B3C0800EB0",
                    Name: "Tag-64"
                ),
                new Tag(
                    Id: "89500F13-B516-4F77-8128-47FC412BEFCD",
                    Name: "Tag-151"
                ),
                new Tag(
                    Id: "8DC9DFB4-1946-427A-A0A0-E06E1448CC63",
                    Name: "Tag-171"
                )
            }
        ),
        new Product(
            Id: "12DD6F29-6AA2-4C03-8873-19581F97E9CD",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M18B-48",
            Name: "Mountain-500 Black, 48",
            Description: "The product called \"Mountain-500 Black, 48\"",
            Price: 539.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "9E250CCC-6530-4DC0-9D64-E7777B3C3B73",
                    Name: "Tag-177"
                )
            }
        ),
        new Product(
            Id: "16F9DF28-56B4-4185-9B82-B85666BFA3A6",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M38S-38",
            Name: "Mountain-400-W Silver, 38",
            Description: "The product called \"Mountain-400-W Silver, 38\"",
            Price: 769.49,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "125497D0-9175-4ECD-844D-DA71E5F4ED43",
                    Name: "Tag-42"
                ),
                new Tag(
                    Id: "3BFB03A9-3106-44C7-823A-DB1A67E283C3",
                    Name: "Tag-47"
                ),
                new Tag(
                    Id: "6C2F05C8-1E61-4912-BE1A-C67A378429BB",
                    Name: "Tag-5"
                ),
                new Tag(
                    Id: "A07D69D4-B8B9-4662-8148-8033DCDCC000",
                    Name: "Tag-142"
                )
            }
        ),
        new Product(
            Id: "28A865D5-647E-46B5-B309-CA2B2F524E37",
            CategoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            CategoryName: "Components, Touring Frames",
            SKU: "FR-T98U-60",
            Name: "HL Touring Frame - Blue, 60",
            Description: "The product called \"HL Touring Frame - Blue, 60\"",
            Price: 1003.91,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "1745EF28-6E0B-4FED-8925-BC3174F583B0",
                    Name: "Tag-48"
                ),
                new Tag(
                    Id: "319E277F-6B7A-483D-81BA-1EC34CC700EB",
                    Name: "Tag-163"
                ),
                new Tag(
                    Id: "4A6ED3A9-AFDA-4994-9C51-CA76256CEF81",
                    Name: "Tag-140"
                ),
                new Tag(
                    Id: "94C05E5C-13B7-41DA-89DF-98C11195AE1E",
                    Name: "Tag-79"
                )
            }
        ),
        new Product(
            Id: "2BA4A26C-A8DB-4645-BEB9-F7D42F50262E",
            CategoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            CategoryName: "Components, Touring Frames",
            SKU: "FR-T98U-50",
            Name: "HL Touring Frame - Blue, 50",
            Description: "The product called \"HL Touring Frame - Blue, 50\"",
            Price: 1003.91,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "2EE56307-0398-465E-A340-1C5FB1C85648",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M18S-42",
            Name: "Mountain-500 Silver, 42",
            Description: "The product called \"Mountain-500 Silver, 42\"",
            Price: 564.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "C1CB0EFE-02BB-4AE5-AA48-3DAC12921450",
                    Name: "Tag-109"
                )
            }
        ),
        new Product(
            Id: "312A464A-1830-4755-8FB2-2ED32DC7FDD6",
            CategoryId: "9268EA12-29BA-404B-B514-E4737DB3BFCB",
            CategoryName: "Clothing, Bib-Shorts",
            SKU: "SB-M891-L",
            Name: "Men's Bib-Shorts, L",
            Description: "The product called \"Men's Bib-Shorts, L\"",
            Price: 89.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "2400025E-FB22-4031-B4A2-9C3BD1402A9B",
                    Name: "Tag-38"
                ),
                new Tag(
                    Id: "84C396AD-98C6-4B12-8C3A-1BDA3ABF7D73",
                    Name: "Tag-24"
                ),
                new Tag(
                    Id: "B3EC53EB-000D-4E66-975A-910771520A6E",
                    Name: "Tag-54"
                ),
                new Tag(
                    Id: "F3A39B6E-753C-4E70-859F-454E8A9624A9",
                    Name: "Tag-179"
                )
            }
        ),
        new Product(
            Id: "32B61AF2-53BE-4E36-85D8-A24738769352",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M18S-52",
            Name: "Mountain-500 Silver, 52",
            Description: "The product called \"Mountain-500 Silver, 52\"",
            Price: 564.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "511652EB-9EC2-4235-BA77-0C6E4E316679",
                    Name: "Tag-199"
                ),
                new Tag(
                    Id: "AC4CC3CC-4E6B-461D-9B0E-4218EDDF3142",
                    Name: "Tag-122"
                )
            }
        ),
        new Product(
            Id: "397635D8-D71F-47B2-AD68-4ECA6A03F84F",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M18B-44",
            Name: "Mountain-500 Black, 44",
            Description: "The product called \"Mountain-500 Black, 44\"",
            Price: 539.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "D887B872-7CE0-467C-9307-1EABD0D06EEA",
                    Name: "Tag-20"
                )
            }
        ),
        new Product(
            Id: "3ADF5B22-B5B2-43CD-9E07-36A187EB9473",
            CategoryId: "C3C57C35-1D80-4EC5-AB12-46C57A017AFB",
            CategoryName: "Clothing, Jerseys",
            SKU: "LJ-0192-S",
            Name: "Long-Sleeve Logo Jersey, S",
            Description: "The product called \"Long-Sleeve Logo Jersey, S\"",
            Price: 49.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "18AC309F-F81C-4234-A752-5DDD2BEAEE83",
                    Name: "Tag-32"
                ),
                new Tag(
                    Id: "BBE8A68F-6458-410E-BFF7-759507DCE858",
                    Name: "Tag-114"
                )
            }
        ),
        new Product(
            Id: "462F8EAF-0988-4D32-B809-EB4362AF48D0",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M68B-38",
            Name: "Mountain-200 Black, 38",
            Description: "The product called \"Mountain-200 Black, 38\"",
            Price: 2294.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "79E61D0F-3C95-4353-BF27-DB04535088C9",
                    Name: "Tag-50"
                ),
                new Tag(
                    Id: "E83726D0-E486-42C1-BBD3-594C1C5AED6D",
                    Name: "Tag-155"
                ),
                new Tag(
                    Id: "F41CEB6B-FFD0-40A2-BC0F-F89FC3256F09",
                    Name: "Tag-13"
                )
            }
        ),
        new Product(
            Id: "47ED1C3B-C205-4507-94EE-3B69A744B261",
            CategoryId: "14A1AD5D-59EA-4B63-A189-67B077783B0E",
            CategoryName: "Accessories, Helmets",
            SKU: "HL-U509",
            Name: "Sport-100 Helmet, Black",
            Description: "The product called \"Sport-100 Helmet, Black\"",
            Price: 34.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "12A06E6F-45BF-42DF-9641-F1376CDDB7B1",
                    Name: "Tag-22"
                ),
                new Tag(
                    Id: "1745EF28-6E0B-4FED-8925-BC3174F583B0",
                    Name: "Tag-48"
                ),
                new Tag(
                    Id: "27B7F8D5-1009-45B8-88F5-41008A0F0393",
                    Name: "Tag-61"
                ),
                new Tag(
                    Id: "CF3C6F6C-8038-4FAD-A07A-E1AD1C34DE22",
                    Name: "Tag-77"
                )
            }
        ),
        new Product(
            Id: "4DA12D36-495E-4DCA-95B0-F18CAA099779",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M82S-42",
            Name: "Mountain-100 Silver, 42",
            Description: "The product called \"Mountain-100 Silver, 42\"",
            Price: 3399.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "3C26DF5C-CE21-4EF6-AEE2-E8E1066D06B1",
                    Name: "Tag-60"
                ),
                new Tag(
                    Id: "BB35DF88-8BCE-4267-838B-9265BAE64EDF",
                    Name: "Tag-160"
                ),
                new Tag(
                    Id: "F629F27D-3301-4906-BE9B-C46D6D6F6141",
                    Name: "Tag-65"
                )
            }
        ),
        new Product(
            Id: "55594B1E-1E16-4B2E-A16F-983E492321BC",
            CategoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            CategoryName: "Components, Touring Frames",
            SKU: "FR-T67Y-54",
            Name: "LL Touring Frame - Yellow, 54",
            Description: "The product called \"LL Touring Frame - Yellow, 54\"",
            Price: 333.42,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "CA7D17BB-45A6-47E6-A3E3-E70AF34C2072",
                    Name: "Tag-158"
                )
            }
        ),
        new Product(
            Id: "56560B7B-3AC6-4E07-8825-4266A7C98CFE",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M18B-52",
            Name: "Mountain-500 Black, 52",
            Description: "The product called \"Mountain-500 Black, 52\"",
            Price: 539.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "A0BA4E3B-AD4A-42AF-BFA4-5F48E2E57F07",
                    Name: "Tag-58"
                )
            }
        ),
        new Product(
            Id: "5BC9F76B-7FE9-4DD9-A672-2C5E802B2672",
            CategoryId: "C3C57C35-1D80-4EC5-AB12-46C57A017AFB",
            CategoryName: "Clothing, Jerseys",
            SKU: "SJ-0194-L",
            Name: "Short-Sleeve Classic Jersey, L",
            Description: "The product called \"Short-Sleeve Classic Jersey, L\"",
            Price: 53.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "29CBEDD8-D9C3-43A3-B20F-63224FEE0D34",
                    Name: "Tag-11"
                ),
                new Tag(
                    Id: "4A6ED3A9-AFDA-4994-9C51-CA76256CEF81",
                    Name: "Tag-140"
                ),
                new Tag(
                    Id: "FE2975F7-D3D2-42AE-A0BB-D87254E58540",
                    Name: "Tag-74"
                )
            }
        ),
        new Product(
            Id: "5C30FF31-CAB7-4A99-8FD6-D610F58AC4BA",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M38S-42",
            Name: "Mountain-400-W Silver, 42",
            Description: "The product called \"Mountain-400-W Silver, 42\"",
            Price: 769.49,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "01078B1D-5267-4B35-82B8-57042AA9CABB",
                    Name: "Tag-84"
                ),
                new Tag(
                    Id: "0C1DA4B7-676B-413A-A2C5-CCC944837DDC",
                    Name: "Tag-39"
                ),
                new Tag(
                    Id: "29CBEDD8-D9C3-43A3-B20F-63224FEE0D34",
                    Name: "Tag-11"
                ),
                new Tag(
                    Id: "9467BA7B-49FB-4AA5-A868-478D94AF2E54",
                    Name: "Tag-92"
                )
            }
        ),
        new Product(
            Id: "5D3F5A52-A8BB-448C-B8CF-39D2FA2BDF3C",
            CategoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            CategoryName: "Components, Touring Frames",
            SKU: "FR-T98U-54",
            Name: "HL Touring Frame - Blue, 54",
            Description: "The product called \"HL Touring Frame - Blue, 54\"",
            Price: 1003.91,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "5ED1BF5F-6C1F-4EF8-B1A7-B8A8412C9F72",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M47B-38",
            Name: "Mountain-300 Black, 38",
            Description: "The product called \"Mountain-300 Black, 38\"",
            Price: 1079.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "567D183B-9ED1-47B4-AE22-80C52BF41067",
                    Name: "Tag-165"
                )
            }
        ),
        new Product(
            Id: "601A5234-644D-4B83-9FDB-326C22C1051D",
            CategoryId: "14A1AD5D-59EA-4B63-A189-67B077783B0E",
            CategoryName: "Accessories, Helmets",
            SKU: "HL-U509-B",
            Name: "Sport-100 Helmet, Blue",
            Description: "The product called \"Sport-100 Helmet, Blue\"",
            Price: 34.99,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "61246D01-7C38-489E-9F49-A526679B568F",
            CategoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            CategoryName: "Components, Touring Frames",
            SKU: "FR-T67U-50",
            Name: "LL Touring Frame - Blue, 50",
            Description: "The product called \"LL Touring Frame - Blue, 50\"",
            Price: 333.42,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "227FF627-9E87-4BE5-8254-17BB155B0AD7",
                    Name: "Tag-23"
                ),
                new Tag(
                    Id: "4B8ECDDE-FF08-4916-8869-372D08EA8BBA",
                    Name: "Tag-106"
                )
            }
        ),
        new Product(
            Id: "6401B68F-924A-4B2E-AC9E-5660AEA0E848",
            CategoryId: "C3C57C35-1D80-4EC5-AB12-46C57A017AFB",
            CategoryName: "Clothing, Jerseys",
            SKU: "LJ-0192-L",
            Name: "Long-Sleeve Logo Jersey, L",
            Description: "The product called \"Long-Sleeve Logo Jersey, L\"",
            Price: 49.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "B48D6572-67EB-4630-A1DB-AFD4AD7041C9",
                    Name: "Tag-100"
                ),
                new Tag(
                    Id: "E1A62ABF-BBC3-48A2-BAC6-E3350D023C83",
                    Name: "Tag-194"
                )
            }
        ),
        new Product(
            Id: "668E6FCE-03E9-49E7-AC33-1B17FEEF5E60",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M18S-40",
            Name: "Mountain-500 Silver, 40",
            Description: "The product called \"Mountain-500 Silver, 40\"",
            Price: 564.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "028057B8-8F03-4C18-B853-66510D354A72",
                    Name: "Tag-57"
                ),
                new Tag(
                    Id: "23ECB896-D6C6-4E9D-BE43-1908CB5C5E07",
                    Name: "Tag-112"
                ),
                new Tag(
                    Id: "BA4D7ABD-2E82-4DC2-ACF2-5D3B0DEAE1C1",
                    Name: "Tag-59"
                ),
                new Tag(
                    Id: "DCDBD26C-4D71-4F91-BBE9-98D1897E704D",
                    Name: "Tag-68"
                )
            }
        ),
        new Product(
            Id: "6EB9F7AC-7FB0-4D8C-8D3F-76A735A3CB9A",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M18B-40",
            Name: "Mountain-500 Black, 40",
            Description: "The product called \"Mountain-500 Black, 40\"",
            Price: 539.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "088B5F10-EB9B-4F33-A2E4-F2E54485B90F",
                    Name: "Tag-115"
                )
            }
        ),
        new Product(
            Id: "6F733A5D-9B66-4718-B69C-627DE4E164BA",
            CategoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            CategoryName: "Components, Touring Frames",
            SKU: "FR-T67Y-44",
            Name: "LL Touring Frame - Yellow, 44",
            Description: "The product called \"LL Touring Frame - Yellow, 44\"",
            Price: 333.42,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "824D58CA-ECCA-4E72-965C-66D3A5C0C67C",
            CategoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            CategoryName: "Components, Touring Frames",
            SKU: "FR-T67Y-58",
            Name: "LL Touring Frame - Yellow, 58",
            Description: "The product called \"LL Touring Frame - Yellow, 58\"",
            Price: 333.42,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "18AC309F-F81C-4234-A752-5DDD2BEAEE83",
                    Name: "Tag-32"
                ),
                new Tag(
                    Id: "4E102F3F-7D57-4CD7-88F4-AC5076A42C59",
                    Name: "Tag-91"
                ),
                new Tag(
                    Id: "84C396AD-98C6-4B12-8C3A-1BDA3ABF7D73",
                    Name: "Tag-24"
                ),
                new Tag(
                    Id: "D197C394-FB88-4EFF-B0FB-8BED1A86F294",
                    Name: "Tag-182"
                ),
                new Tag(
                    Id: "D1E5CB02-8E7B-422F-9421-C0E608F0AC4C",
                    Name: "Tag-133"
                )
            }
        ),
        new Product(
            Id: "840E2138-4265-4AC8-8514-AC0B9C98597C",
            CategoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            CategoryName: "Components, Touring Frames",
            SKU: "FR-T67U-44",
            Name: "LL Touring Frame - Blue, 44",
            Description: "The product called \"LL Touring Frame - Blue, 44\"",
            Price: 333.42,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "274E32EE-612A-4AAB-B91A-C7E8E4D8C2A7",
                    Name: "Tag-1"
                ),
                new Tag(
                    Id: "47A34A77-A9B8-4703-9AEF-3786726C7A31",
                    Name: "Tag-176"
                ),
                new Tag(
                    Id: "76B3C6DC-3411-457B-96F5-A51CE015DAD9",
                    Name: "Tag-29"
                ),
                new Tag(
                    Id: "775908D7-2622-4C29-AF4D-F2274824DA3B",
                    Name: "Tag-89"
                ),
                new Tag(
                    Id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    Name: "Tag-183"
                )
            }
        ),
        new Product(
            Id: "86FD9250-4BD5-42D2-B941-1C1865A6A65E",
            CategoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            CategoryName: "Components, Touring Frames",
            SKU: "FR-T67U-58",
            Name: "LL Touring Frame - Blue, 58",
            Description: "The product called \"LL Touring Frame - Blue, 58\"",
            Price: 333.42,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "764C1CC8-2E5F-4EF5-83F6-8FF7441290B3",
                    Name: "Tag-190"
                ),
                new Tag(
                    Id: "765EF7D7-331C-42C0-BF23-A3022A723BF7",
                    Name: "Tag-191"
                ),
                new Tag(
                    Id: "87BC6842-2CCA-4CD3-994C-33AB101455F4",
                    Name: "Tag-12"
                ),
                new Tag(
                    Id: "EBDBD608-416A-4FE2-96DF-02367C8D071E",
                    Name: "Tag-102"
                ),
                new Tag(
                    Id: "F8817638-4CF4-423E-B755-2150F02C432D",
                    Name: "Tag-71"
                )
            }
        ),
        new Product(
            Id: "8B363B8B-378E-402A-9E68-A935302000B8",
            CategoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            CategoryName: "Components, Touring Frames",
            SKU: "FR-T98Y-46",
            Name: "HL Touring Frame - Yellow, 46",
            Description: "The product called \"HL Touring Frame - Yellow, 46\"",
            Price: 1003.91,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "6C6D061E-F701-41DC-AEA2-7A5C28061840",
                    Name: "Tag-98"
                ),
                new Tag(
                    Id: "89500F13-B516-4F77-8128-47FC412BEFCD",
                    Name: "Tag-151"
                ),
                new Tag(
                    Id: "D5887E7C-B916-4AF4-BAF8-7B996ADA8C83",
                    Name: "Tag-52"
                ),
                new Tag(
                    Id: "DBC84212-C3E9-4966-8619-9A4D64EBF517",
                    Name: "Tag-125"
                )
            }
        ),
        new Product(
            Id: "8B541087-A7F5-43B1-AC9F-EEFB4F4ADAFA",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M18B-42",
            Name: "Mountain-500 Black, 42",
            Description: "The product called \"Mountain-500 Black, 42\"",
            Price: 539.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "125497D0-9175-4ECD-844D-DA71E5F4ED43",
                    Name: "Tag-42"
                ),
                new Tag(
                    Id: "14CFF1D6-7749-4A57-85B3-783F47731F32",
                    Name: "Tag-7"
                ),
                new Tag(
                    Id: "45CBB7FF-FA48-49D8-89EF-F1D0B8AC3923",
                    Name: "Tag-86"
                )
            }
        ),
        new Product(
            Id: "91AA100C-D092-4190-92A7-7C02410F04EA",
            CategoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            CategoryName: "Components, Touring Frames",
            SKU: "FR-T67Y-62",
            Name: "LL Touring Frame - Yellow, 62",
            Description: "The product called \"LL Touring Frame - Yellow, 62\"",
            Price: 333.42,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "52FCE975-91EE-4789-9E36-94EC766F02A0",
                    Name: "Tag-35"
                )
            }
        ),
        new Product(
            Id: "91D3C273-9E79-4395-B444-6D39BF9B2F4D",
            CategoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            CategoryName: "Components, Touring Frames",
            SKU: "FR-T98U-46",
            Name: "HL Touring Frame - Blue, 46",
            Description: "The product called \"HL Touring Frame - Blue, 46\"",
            Price: 1003.91,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "375399DC-F2B7-4A8C-8A03-C16B849489D3",
                    Name: "Tag-78"
                ),
                new Tag(
                    Id: "8CA1BBD8-D00B-4654-AABA-5C8724C6F4BD",
                    Name: "Tag-81"
                ),
                new Tag(
                    Id: "9467BA7B-49FB-4AA5-A868-478D94AF2E54",
                    Name: "Tag-92"
                )
            }
        ),
        new Product(
            Id: "935EB2B7-8D50-4E20-B01A-570DBA674AD4",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M82S-38",
            Name: "Mountain-100 Silver, 38",
            Description: "The product called \"Mountain-100 Silver, 38\"",
            Price: 3399.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "B18FB652-C4B6-4A40-BA22-1E687C1A58CE",
                    Name: "Tag-161"
                ),
                new Tag(
                    Id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    Name: "Tag-183"
                ),
                new Tag(
                    Id: "EFD6F482-9619-47C2-94FD-DA5D035DEA7A",
                    Name: "Tag-144"
                )
            }
        ),
        new Product(
            Id: "9C0320C4-124B-486A-BA98-B7B82933F324",
            CategoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            CategoryName: "Components, Touring Frames",
            SKU: "FR-T67U-62",
            Name: "LL Touring Frame - Blue, 62",
            Description: "The product called \"LL Touring Frame - Blue, 62\"",
            Price: 333.42,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "775908D7-2622-4C29-AF4D-F2274824DA3B",
                    Name: "Tag-89"
                ),
                new Tag(
                    Id: "7DF71D87-FB6F-498B-9D7B-E7EBE40350E1",
                    Name: "Tag-88"
                ),
                new Tag(
                    Id: "A50C570B-B3FC-4678-96C8-2D117DD11A12",
                    Name: "Tag-66"
                ),
                new Tag(
                    Id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    Name: "Tag-183"
                ),
                new Tag(
                    Id: "F07885AF-BD6C-4B71-88B1-F04295992176",
                    Name: "Tag-149"
                )
            }
        ),
        new Product(
            Id: "9DB28F2B-ADC8-40A2-A677-B0AAFC32CAC8",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M82S-48",
            Name: "Mountain-100 Silver, 48",
            Description: "The product called \"Mountain-100 Silver, 48\"",
            Price: 3399.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "29CBEDD8-D9C3-43A3-B20F-63224FEE0D34",
                    Name: "Tag-11"
                ),
                new Tag(
                    Id: "AA35D2EA-24FD-4A62-80FE-83EFF821F019",
                    Name: "Tag-10"
                )
            }
        ),
        new Product(
            Id: "A6F069C2-EF85-4B79-9CE2-03833343AD92",
            CategoryId: "C3C57C35-1D80-4EC5-AB12-46C57A017AFB",
            CategoryName: "Clothing, Jerseys",
            SKU: "SJ-0194-M",
            Name: "Short-Sleeve Classic Jersey, M",
            Description: "The product called \"Short-Sleeve Classic Jersey, M\"",
            Price: 53.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "088B5F10-EB9B-4F33-A2E4-F2E54485B90F",
                    Name: "Tag-115"
                ),
                new Tag(
                    Id: "89FB612A-F9AA-4196-B5F5-B9FA16D558DC",
                    Name: "Tag-175"
                ),
                new Tag(
                    Id: "A0BA4E3B-AD4A-42AF-BFA4-5F48E2E57F07",
                    Name: "Tag-58"
                ),
                new Tag(
                    Id: "DEDEB715-41D4-4EBF-BC09-5CCC2943D1A2",
                    Name: "Tag-131"
                ),
                new Tag(
                    Id: "F202FBC3-B5AA-4E0F-950B-2B5715AC0B3B",
                    Name: "Tag-173"
                )
            }
        ),
        new Product(
            Id: "ACD4ABE3-82D8-4447-B126-2DE03B7DD106",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M38S-40",
            Name: "Mountain-400-W Silver, 40",
            Description: "The product called \"Mountain-400-W Silver, 40\"",
            Price: 769.49,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "F59DC0A2-537E-4A8F-A97D-19C82074D3E7",
                    Name: "Tag-146"
                )
            }
        ),
        new Product(
            Id: "AFBE0496-C372-4885-B509-507B93027174",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M18S-44",
            Name: "Mountain-500 Silver, 44",
            Description: "The product called \"Mountain-500 Silver, 44\"",
            Price: 564.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "069169DD-F4B3-4769-8841-13B5FF745932",
                    Name: "Tag-157"
                ),
                new Tag(
                    Id: "33AFFF1B-30AA-41C5-8510-34B67A523CA9",
                    Name: "Tag-110"
                ),
                new Tag(
                    Id: "46AC3482-E9A6-474D-A435-D3399F21991F",
                    Name: "Tag-90"
                ),
                new Tag(
                    Id: "C68A2129-1E2B-43EC-95B5-AC56CC200FA4",
                    Name: "Tag-180"
                ),
                new Tag(
                    Id: "CA170AAD-A5F6-42FF-B115-146FADD87298",
                    Name: "Tag-186"
                )
            }
        ),
        new Product(
            Id: "B0FE1D0A-CED1-49E8-9ACF-E289A631A4ED",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M47B-44",
            Name: "Mountain-300 Black, 44",
            Description: "The product called \"Mountain-300 Black, 44\"",
            Price: 1079.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "812C1444-1DEA-480D-88E7-B9609ECA783C",
                    Name: "Tag-136"
                ),
                new Tag(
                    Id: "A2443B36-76AE-4963-9E21-368868F9C514",
                    Name: "Tag-6"
                ),
                new Tag(
                    Id: "B1EBD7E0-BBE0-4AFB-AC6C-50649484780B",
                    Name: "Tag-40"
                )
            }
        ),
        new Product(
            Id: "B10065F8-543A-49E7-BFE6-3D19B0BE5670",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M68S-46",
            Name: "Mountain-200 Silver, 46",
            Description: "The product called \"Mountain-200 Silver, 46\"",
            Price: 2319.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "274E32EE-612A-4AAB-B91A-C7E8E4D8C2A7",
                    Name: "Tag-1"
                ),
                new Tag(
                    Id: "764C1CC8-2E5F-4EF5-83F6-8FF7441290B3",
                    Name: "Tag-190"
                ),
                new Tag(
                    Id: "D56040DB-E5DF-40BE-9F2F-7E10F4340BCA",
                    Name: "Tag-31"
                ),
                new Tag(
                    Id: "DB21A27B-5A3F-400C-A0DF-69A5266E1447",
                    Name: "Tag-34"
                ),
                new Tag(
                    Id: "F533A770-1E5D-4B48-8792-E16E155B6E38",
                    Name: "Tag-87"
                )
            }
        ),
        new Product(
            Id: "B3847F90-FDF3-4529-B7D0-04FE6F94BFB3",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M18S-48",
            Name: "Mountain-500 Silver, 48",
            Description: "The product called \"Mountain-500 Silver, 48\"",
            Price: 564.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "239313C7-6673-47D1-88D9-6AC61F27D30E",
                    Name: "Tag-116"
                ),
                new Tag(
                    Id: "9653F306-0B3C-4856-ABF8-13C3F04AE4F0",
                    Name: "Tag-36"
                ),
                new Tag(
                    Id: "B20574A2-8F94-4CB5-A9A7-2E1E203978D6",
                    Name: "Tag-117"
                ),
                new Tag(
                    Id: "BA4D7ABD-2E82-4DC2-ACF2-5D3B0DEAE1C1",
                    Name: "Tag-59"
                ),
                new Tag(
                    Id: "DA661FCF-CC7F-4AF9-A9E2-8E7A5570844E",
                    Name: "Tag-188"
                )
            }
        ),
        new Product(
            Id: "B79B140D-4369-429B-8F20-E28F3ED7F82A",
            CategoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            CategoryName: "Components, Touring Frames",
            SKU: "FR-T98Y-54",
            Name: "HL Touring Frame - Yellow, 54",
            Description: "The product called \"HL Touring Frame - Yellow, 54\"",
            Price: 1003.91,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "BB21E6EF-104A-420B-B9C5-2084118E5A2F",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M68S-42",
            Name: "Mountain-200 Silver, 42",
            Description: "The product called \"Mountain-200 Silver, 42\"",
            Price: 2319.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "18AC309F-F81C-4234-A752-5DDD2BEAEE83",
                    Name: "Tag-32"
                ),
                new Tag(
                    Id: "A49D83E4-E506-4301-8110-E114599B4A35",
                    Name: "Tag-27"
                ),
                new Tag(
                    Id: "C8741857-FD6D-4C28-B594-BAF30BCACB6B",
                    Name: "Tag-120"
                ),
                new Tag(
                    Id: "F202FBC3-B5AA-4E0F-950B-2B5715AC0B3B",
                    Name: "Tag-173"
                )
            }
        ),
        new Product(
            Id: "C0FBA4E8-B617-4889-B1A5-091D12783313",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M82B-42",
            Name: "Mountain-100 Black, 42",
            Description: "The product called \"Mountain-100 Black, 42\"",
            Price: 3374.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "12A06E6F-45BF-42DF-9641-F1376CDDB7B1",
                    Name: "Tag-22"
                ),
                new Tag(
                    Id: "2E7252D2-B646-47FB-B5BB-836643578038",
                    Name: "Tag-130"
                )
            }
        ),
        new Product(
            Id: "CC8D2C8C-AB60-48BE-A019-33F633DB07CD",
            CategoryId: "C3C57C35-1D80-4EC5-AB12-46C57A017AFB",
            CategoryName: "Clothing, Jerseys",
            SKU: "SJ-0194-X",
            Name: "Short-Sleeve Classic Jersey, XL",
            Description: "The product called \"Short-Sleeve Classic Jersey, XL\"",
            Price: 53.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "69B1D1BA-C166-41F2-B2EB-8B2ADE77943C",
                    Name: "Tag-196"
                ),
                new Tag(
                    Id: "87BC6842-2CCA-4CD3-994C-33AB101455F4",
                    Name: "Tag-12"
                ),
                new Tag(
                    Id: "A4D9E596-B630-4792-BDD1-7D6459827820",
                    Name: "Tag-164"
                ),
                new Tag(
                    Id: "F3A39B6E-753C-4E70-859F-454E8A9624A9",
                    Name: "Tag-179"
                )
            }
        ),
        new Product(
            Id: "CD5FF4D6-7D2D-4BD4-9319-CB38C1939D96",
            CategoryId: "11EF8851-816A-49E2-9D5C-8D17AB82C5FF",
            CategoryName: "Accessories, Lights",
            SKU: "LT-T990",
            Name: "Taillights - Battery-Powered",
            Description: "The product called \"Taillights - Battery-Powered\"",
            Price: 13.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "46C3C4F8-3FA1-44E9-AE78-37DA965EE913",
                    Name: "Tag-46"
                ),
                new Tag(
                    Id: "69B1D1BA-C166-41F2-B2EB-8B2ADE77943C",
                    Name: "Tag-196"
                ),
                new Tag(
                    Id: "76B3C6DC-3411-457B-96F5-A51CE015DAD9",
                    Name: "Tag-29"
                ),
                new Tag(
                    Id: "9653F306-0B3C-4856-ABF8-13C3F04AE4F0",
                    Name: "Tag-36"
                )
            }
        ),
        new Product(
            Id: "CEA9FD38-517E-474B-A5B1-B17BF1753F9C",
            CategoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            CategoryName: "Components, Touring Frames",
            SKU: "FR-T67Y-50",
            Name: "LL Touring Frame - Yellow, 50",
            Description: "The product called \"LL Touring Frame - Yellow, 50\"",
            Price: 333.42,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "3798DC56-04BE-4A82-B70B-6A0DC7714A36",
                    Name: "Tag-105"
                ),
                new Tag(
                    Id: "47A34A77-A9B8-4703-9AEF-3786726C7A31",
                    Name: "Tag-176"
                ),
                new Tag(
                    Id: "7337386B-E865-4ADC-BA17-4437CB02E3BE",
                    Name: "Tag-8"
                )
            }
        ),
        new Product(
            Id: "D47E0CC9-28A0-40A5-AB90-BB29BDBB0578",
            CategoryId: "C3C57C35-1D80-4EC5-AB12-46C57A017AFB",
            CategoryName: "Clothing, Jerseys",
            SKU: "LJ-0192-X",
            Name: "Long-Sleeve Logo Jersey, XL",
            Description: "The product called \"Long-Sleeve Logo Jersey, XL\"",
            Price: 49.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "125497D0-9175-4ECD-844D-DA71E5F4ED43",
                    Name: "Tag-42"
                ),
                new Tag(
                    Id: "89500F13-B516-4F77-8128-47FC412BEFCD",
                    Name: "Tag-151"
                )
            }
        ),
        new Product(
            Id: "DE810086-817F-440C-9FEF-471083B8E4A0",
            CategoryId: "C3C57C35-1D80-4EC5-AB12-46C57A017AFB",
            CategoryName: "Clothing, Jerseys",
            SKU: "LJ-0192-M",
            Name: "Long-Sleeve Logo Jersey, M",
            Description: "The product called \"Long-Sleeve Logo Jersey, M\"",
            Price: 49.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "3798DC56-04BE-4A82-B70B-6A0DC7714A36",
                    Name: "Tag-105"
                )
            }
        ),
        new Product(
            Id: "DF94F21F-4CDB-4E49-B67B-CAD318A31C4A",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M82B-44",
            Name: "Mountain-100 Black, 44",
            Description: "The product called \"Mountain-100 Black, 44\"",
            Price: 3374.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "14CFF1D6-7749-4A57-85B3-783F47731F32",
                    Name: "Tag-7"
                ),
                new Tag(
                    Id: "3C26DF5C-CE21-4EF6-AEE2-E8E1066D06B1",
                    Name: "Tag-60"
                ),
                new Tag(
                    Id: "765EF7D7-331C-42C0-BF23-A3022A723BF7",
                    Name: "Tag-191"
                ),
                new Tag(
                    Id: "7B37373F-FC14-44FD-96AA-32F4854E0B6B",
                    Name: "Tag-63"
                ),
                new Tag(
                    Id: "8AAFD985-8BCE-4FA8-85A2-2CA67D9DF8E6",
                    Name: "Tag-172"
                )
            }
        ),
        new Product(
            Id: "DFE5521E-40C6-4A58-8E8D-5FC1BE5EC0FE",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M82S-44",
            Name: "Mountain-100 Silver, 44",
            Description: "The product called \"Mountain-100 Silver, 44\"",
            Price: 3399.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "4B8ECDDE-FF08-4916-8869-372D08EA8BBA",
                    Name: "Tag-106"
                ),
                new Tag(
                    Id: "511652EB-9EC2-4235-BA77-0C6E4E316679",
                    Name: "Tag-199"
                ),
                new Tag(
                    Id: "E1A62ABF-BBC3-48A2-BAC6-E3350D023C83",
                    Name: "Tag-194"
                )
            }
        ),
        new Product(
            Id: "E2CCAF6F-7AB5-4086-86A3-A50B3E6EF101",
            CategoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            CategoryName: "Components, Touring Frames",
            SKU: "FR-T98Y-60",
            Name: "HL Touring Frame - Yellow, 60",
            Description: "The product called \"HL Touring Frame - Yellow, 60\"",
            Price: 1003.91,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "7019202D-B11A-4FAB-ACBC-2D0E5A4F72EF",
                    Name: "Tag-143"
                ),
                new Tag(
                    Id: "762CE1E0-5615-418E-B476-BCD46AD5E79E",
                    Name: "Tag-137"
                ),
                new Tag(
                    Id: "C1CB0EFE-02BB-4AE5-AA48-3DAC12921450",
                    Name: "Tag-109"
                )
            }
        ),
        new Product(
            Id: "E681778F-8359-468B-98F9-4D325D6C377F",
            CategoryId: "C3C57C35-1D80-4EC5-AB12-46C57A017AFB",
            CategoryName: "Clothing, Jerseys",
            SKU: "SJ-0194-S",
            Name: "Short-Sleeve Classic Jersey, S",
            Description: "The product called \"Short-Sleeve Classic Jersey, S\"",
            Price: 53.99,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "E8767BC9-D6BA-47FC-9842-3511468869B6",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M47B-48",
            Name: "Mountain-300 Black, 48",
            Description: "The product called \"Mountain-300 Black, 48\"",
            Price: 1079.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "718DAED6-2186-4E09-8C02-CCC58281838D",
                    Name: "Tag-94"
                ),
                new Tag(
                    Id: "A0BA4E3B-AD4A-42AF-BFA4-5F48E2E57F07",
                    Name: "Tag-58"
                )
            }
        ),
        new Product(
            Id: "E9FCF7AC-1F45-4857-9E75-BC30A7C7C27B",
            CategoryId: "C0EB227A-55A9-498B-8E21-F39EC5088143",
            CategoryName: "Accessories, Cleaners",
            SKU: "CL-9009",
            Name: "Bike Wash - Dissolver",
            Description: "The product called \"Bike Wash - Dissolver\"",
            Price: 7.95,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "0BC579CA-03FC-4AA6-85AA-A55035201E43",
                    Name: "Tag-21"
                ),
                new Tag(
                    Id: "A2176C7A-4E0D-4283-AFAA-319A77E9C122",
                    Name: "Tag-19"
                )
            }
        ),
        new Product(
            Id: "EC65B816-A2A7-4245-B138-43C03F14C514",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M68B-46",
            Name: "Mountain-200 Black, 46",
            Description: "The product called \"Mountain-200 Black, 46\"",
            Price: 2294.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "088B5F10-EB9B-4F33-A2E4-F2E54485B90F",
                    Name: "Tag-115"
                ),
                new Tag(
                    Id: "A2176C7A-4E0D-4283-AFAA-319A77E9C122",
                    Name: "Tag-19"
                ),
                new Tag(
                    Id: "BB35DF88-8BCE-4267-838B-9265BAE64EDF",
                    Name: "Tag-160"
                ),
                new Tag(
                    Id: "F202FBC3-B5AA-4E0F-950B-2B5715AC0B3B",
                    Name: "Tag-173"
                )
            }
        ),
        new Product(
            Id: "EE40F7FD-AB2C-4589-B54D-BEBACB3B083E",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M82B-48",
            Name: "Mountain-100 Black, 48",
            Description: "The product called \"Mountain-100 Black, 48\"",
            Price: 3374.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "DBC21C2A-0AF6-45D4-B2C9-703DD708A821",
                    Name: "Tag-14"
                )
            }
        ),
        new Product(
            Id: "EF3F4DC1-5F73-4234-B10E-6608F4DC937A",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M68S-38",
            Name: "Mountain-200 Silver, 38",
            Description: "The product called \"Mountain-200 Silver, 38\"",
            Price: 2319.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "3A3A99B6-E3BF-46D0-BAD9-F5F4DBB720F4",
                    Name: "Tag-70"
                ),
                new Tag(
                    Id: "51CD93BF-098C-4C25-9829-4AD42046D038",
                    Name: "Tag-25"
                ),
                new Tag(
                    Id: "6C2F05C8-1E61-4912-BE1A-C67A378429BB",
                    Name: "Tag-5"
                ),
                new Tag(
                    Id: "B48D6572-67EB-4630-A1DB-AFD4AD7041C9",
                    Name: "Tag-100"
                )
            }
        ),
        new Product(
            Id: "EFD1F33B-94AE-4309-B6E6-F9CCC2B61278",
            CategoryId: "11EF8851-816A-49E2-9D5C-8D17AB82C5FF",
            CategoryName: "Accessories, Lights",
            SKU: "LT-H903",
            Name: "Headlights - Weatherproof",
            Description: "The product called \"Headlights - Weatherproof\"",
            Price: 44.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "45CBB7FF-FA48-49D8-89EF-F1D0B8AC3923",
                    Name: "Tag-86"
                ),
                new Tag(
                    Id: "775908D7-2622-4C29-AF4D-F2274824DA3B",
                    Name: "Tag-89"
                ),
                new Tag(
                    Id: "79E61D0F-3C95-4353-BF27-DB04535088C9",
                    Name: "Tag-50"
                ),
                new Tag(
                    Id: "83D720BA-BB31-4BE5-B723-8A836AB6D532",
                    Name: "Tag-127"
                ),
                new Tag(
                    Id: "C8741857-FD6D-4C28-B594-BAF30BCACB6B",
                    Name: "Tag-120"
                )
            }
        ),
        new Product(
            Id: "F2447558-7C01-442E-A7BC-B6D5D8AE1070",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M82B-38",
            Name: "Mountain-100 Black, 38",
            Description: "The product called \"Mountain-100 Black, 38\"",
            Price: 3374.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "227FF627-9E87-4BE5-8254-17BB155B0AD7",
                    Name: "Tag-23"
                ),
                new Tag(
                    Id: "6C2F05C8-1E61-4912-BE1A-C67A378429BB",
                    Name: "Tag-5"
                ),
                new Tag(
                    Id: "A2AFF2FF-8438-44A3-8AC6-20A50422D82A",
                    Name: "Tag-18"
                ),
                new Tag(
                    Id: "C1CB0EFE-02BB-4AE5-AA48-3DAC12921450",
                    Name: "Tag-109"
                ),
                new Tag(
                    Id: "DBC84212-C3E9-4966-8619-9A4D64EBF517",
                    Name: "Tag-125"
                )
            }
        ),
        new Product(
            Id: "F5FB0386-C6AC-40AE-9342-7AFB832233A8",
            CategoryId: "27A716B2-6F81-4A2C-B7E9-0B2AF5D8E51A",
            CategoryName: "Accessories, Locks",
            SKU: "LO-C100",
            Name: "Cable Lock",
            Description: "The product called \"Cable Lock\"",
            Price: 25.0,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "0BC579CA-03FC-4AA6-85AA-A55035201E43",
                    Name: "Tag-21"
                ),
                new Tag(
                    Id: "1CFF105D-294E-4E2D-ADE4-0615CBDEBC28",
                    Name: "Tag-44"
                ),
                new Tag(
                    Id: "606E1794-5457-42A7-90FB-206142EEF023",
                    Name: "Tag-132"
                ),
                new Tag(
                    Id: "A9834752-41CA-47F5-8A5A-D9A878DF0ACB",
                    Name: "Tag-198"
                ),
                new Tag(
                    Id: "CA170AAD-A5F6-42FF-B115-146FADD87298",
                    Name: "Tag-186"
                )
            }
        ),
        new Product(
            Id: "FA06B762-D602-4235-8F77-D8AFB0D3D050",
            CategoryId: "F3FBB167-11D8-41E4-84B4-5AAA92B1E737",
            CategoryName: "Components, Touring Frames",
            SKU: "FR-T67U-54",
            Name: "LL Touring Frame - Blue, 54",
            Description: "The product called \"LL Touring Frame - Blue, 54\"",
            Price: 333.42,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "4B10B00B-C1CA-4508-9848-3B1BD910B724",
                    Name: "Tag-30"
                ),
                new Tag(
                    Id: "84C396AD-98C6-4B12-8C3A-1BDA3ABF7D73",
                    Name: "Tag-24"
                ),
                new Tag(
                    Id: "89FB612A-F9AA-4196-B5F5-B9FA16D558DC",
                    Name: "Tag-175"
                ),
                new Tag(
                    Id: "D32CFC73-640F-48B6-976D-B053DCD0F393",
                    Name: "Tag-178"
                ),
                new Tag(
                    Id: "EBDBD608-416A-4FE2-96DF-02367C8D071E",
                    Name: "Tag-102"
                )
            }
        ),
        new Product(
            Id: "FADA3DBE-28DC-4FFA-823E-99332AD2EA0C",
            CategoryId: "11EF8851-816A-49E2-9D5C-8D17AB82C5FF",
            CategoryName: "Accessories, Lights",
            SKU: "LT-H902",
            Name: "Headlights - Dual-Beam",
            Description: "The product called \"Headlights - Dual-Beam\"",
            Price: 34.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "E6CB7972-06F4-47C0-B464-F64E695F89E7",
                    Name: "Tag-51"
                )
            }
        ),
        new Product(
            Id: "FB9A5084-F2B2-4C3B-9CF9-252873CABFF7",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M38S-46",
            Name: "Mountain-400-W Silver, 46",
            Description: "The product called \"Mountain-400-W Silver, 46\"",
            Price: 769.49,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "DCDBD26C-4D71-4F91-BBE9-98D1897E704D",
                    Name: "Tag-68"
                ),
                new Tag(
                    Id: "F6B1A09C-BCC9-4A74-8472-D1CA98310501",
                    Name: "Tag-185"
                )
            }
        ),
        new Product(
            Id: "FDEF01CB-5067-414F-B0A3-07FF8A4B80DD",
            CategoryId: "14A1AD5D-59EA-4B63-A189-67B077783B0E",
            CategoryName: "Accessories, Helmets",
            SKU: "HL-U509-R",
            Name: "Sport-100 Helmet, Red",
            Description: "The product called \"Sport-100 Helmet, Red\"",
            Price: 34.99,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "FE8FFBD3-99AE-4ECF-AA53-D1304D941EC7",
            CategoryId: "56400CF3-446D-4C3F-B9B2-68286DA3BB99",
            CategoryName: "Bikes, Mountain Bikes",
            SKU: "BK-M47B-40",
            Name: "Mountain-300 Black, 40",
            Description: "The product called \"Mountain-300 Black, 40\"",
            Price: 1079.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "B1EBD7E0-BBE0-4AFB-AC6C-50649484780B",
                    Name: "Tag-40"
                )
            }
        ),
        new Product(
            Id: "063F1A00-8CA1-4DB9-8298-BEAC4B8CC238",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R79Y-48",
            Name: "Road-350-W Yellow, 48",
            Description: "The product called \"Road-350-W Yellow, 48\"",
            Price: 1700.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "033D3826-2851-4B97-9464-59D3675175D4",
                    Name: "Tag-108"
                ),
                new Tag(
                    Id: "E468DF53-4836-4546-9D05-C855AAC4B0AF",
                    Name: "Tag-2"
                ),
                new Tag(
                    Id: "E661634D-CDC3-4FA6-BE4B-D1FEEAECB5B9",
                    Name: "Tag-121"
                )
            }
        ),
        new Product(
            Id: "06AC4FFF-9F97-429B-BB15-ED929EFF65EE",
            CategoryId: "C48B4EF4-D352-4CD2-BCB8-CE89B7DFA642",
            CategoryName: "Clothing, Socks",
            SKU: "SO-R809-M",
            Name: "Racing Socks, M",
            Description: "The product called \"Racing Socks, M\"",
            Price: 8.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "125497D0-9175-4ECD-844D-DA71E5F4ED43",
                    Name: "Tag-42"
                ),
                new Tag(
                    Id: "239313C7-6673-47D1-88D9-6AC61F27D30E",
                    Name: "Tag-116"
                )
            }
        ),
        new Product(
            Id: "0846D2C3-7E50-4F68-A6CB-F0DC90FD03D0",
            CategoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            CategoryName: "Components, Wheels",
            SKU: "FW-T905",
            Name: "Touring Front Wheel",
            Description: "The product called \"Touring Front Wheel\"",
            Price: 218.01,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "7DF71D87-FB6F-498B-9D7B-E7EBE40350E1",
                    Name: "Tag-88"
                ),
                new Tag(
                    Id: "AA24EC37-7CE3-4ABE-B935-EC62D5FB6947",
                    Name: "Tag-148"
                ),
                new Tag(
                    Id: "CA7D17BB-45A6-47E6-A3E3-E70AF34C2072",
                    Name: "Tag-158"
                ),
                new Tag(
                    Id: "D69B1B6C-4963-4E85-8FA5-6A3E1CD1C83B",
                    Name: "Tag-187"
                ),
                new Tag(
                    Id: "E23954CF-D79A-433E-9BE6-FD787C5E4C9B",
                    Name: "Tag-111"
                )
            }
        ),
        new Product(
            Id: "0990C3D9-4EC2-4272-ADB6-9481CA12F5F6",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M94B-38",
            Name: "HL Mountain Frame - Black, 38",
            Description: "The product called \"HL Mountain Frame - Black, 38\"",
            Price: 1349.6,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "762CE1E0-5615-418E-B476-BCD46AD5E79E",
                    Name: "Tag-137"
                ),
                new Tag(
                    Id: "7CACE200-11A3-4E2D-A88E-25E9614D2BE9",
                    Name: "Tag-97"
                ),
                new Tag(
                    Id: "84C1934D-F048-4D2B-8525-323AFE2A7C7C",
                    Name: "Tag-184"
                ),
                new Tag(
                    Id: "CAF27567-B4CB-463C-A54E-5EF1F2657DD2",
                    Name: "Tag-75"
                )
            }
        ),
        new Product(
            Id: "0C3D95EB-EE37-44A5-816F-957A98519B03",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R50B-44",
            Name: "Road-650 Black, 44",
            Description: "The product called \"Road-650 Black, 44\"",
            Price: 782.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "1745EF28-6E0B-4FED-8925-BC3174F583B0",
                    Name: "Tag-48"
                ),
                new Tag(
                    Id: "4B10B00B-C1CA-4508-9848-3B1BD910B724",
                    Name: "Tag-30"
                ),
                new Tag(
                    Id: "537DB3C8-8636-4005-8FE2-32EECEBA5B3F",
                    Name: "Tag-80"
                ),
                new Tag(
                    Id: "C68A2129-1E2B-43EC-95B5-AC56CC200FA4",
                    Name: "Tag-180"
                )
            }
        ),
        new Product(
            Id: "0D7CB85D-4518-4E02-8E46-9683947BBBC4",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R68R-52",
            Name: "Road-450 Red, 52",
            Description: "The product called \"Road-450 Red, 52\"",
            Price: 1457.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "461ADE06-0903-4BAF-97AB-CC713E5B1DD4",
                    Name: "Tag-174"
                ),
                new Tag(
                    Id: "8CA1BBD8-D00B-4654-AABA-5C8724C6F4BD",
                    Name: "Tag-81"
                )
            }
        ),
        new Product(
            Id: "0E92DDAC-F969-4F63-8D5E-614AB5199D01",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R89R-44",
            Name: "Road-250 Red, 44",
            Description: "The product called \"Road-250 Red, 44\"",
            Price: 2443.35,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "27B7F8D5-1009-45B8-88F5-41008A0F0393",
                    Name: "Tag-61"
                ),
                new Tag(
                    Id: "29CBEDD8-D9C3-43A3-B20F-63224FEE0D34",
                    Name: "Tag-11"
                ),
                new Tag(
                    Id: "8CA1BBD8-D00B-4654-AABA-5C8724C6F4BD",
                    Name: "Tag-81"
                ),
                new Tag(
                    Id: "DBE23FA0-0D99-47F5-BCD7-3D798CE653AE",
                    Name: "Tag-55"
                )
            }
        ),
        new Product(
            Id: "11E6FD95-0FF1-4FE8-9A6B-EC53F614212D",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R19B-58",
            Name: "Road-750 Black, 58",
            Description: "The product called \"Road-750 Black, 58\"",
            Price: 539.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "375399DC-F2B7-4A8C-8A03-C16B849489D3",
                    Name: "Tag-78"
                ),
                new Tag(
                    Id: "3BFB03A9-3106-44C7-823A-DB1A67E283C3",
                    Name: "Tag-47"
                ),
                new Tag(
                    Id: "461ADE06-0903-4BAF-97AB-CC713E5B1DD4",
                    Name: "Tag-174"
                ),
                new Tag(
                    Id: "9E250CCC-6530-4DC0-9D64-E7777B3C3B73",
                    Name: "Tag-177"
                ),
                new Tag(
                    Id: "D2427B7F-AF57-498B-A73E-E7D67FD5CFD9",
                    Name: "Tag-195"
                )
            }
        ),
        new Product(
            Id: "14912B0B-EA77-47B8-8F1C-C8E4BE859D7C",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M21S-42",
            Name: "LL Mountain Frame - Silver, 42",
            Description: "The product called \"LL Mountain Frame - Silver, 42\"",
            Price: 264.05,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "4B10B00B-C1CA-4508-9848-3B1BD910B724",
                    Name: "Tag-30"
                ),
                new Tag(
                    Id: "4E102F3F-7D57-4CD7-88F4-AC5076A42C59",
                    Name: "Tag-91"
                ),
                new Tag(
                    Id: "7F518FB1-4664-4B20-9B9F-23D5B44F6798",
                    Name: "Tag-69"
                ),
                new Tag(
                    Id: "A0A28560-17B9-4457-B993-D39AF56B53C8",
                    Name: "Tag-99"
                ),
                new Tag(
                    Id: "B48D6572-67EB-4630-A1DB-AFD4AD7041C9",
                    Name: "Tag-100"
                )
            }
        ),
        new Product(
            Id: "18711AD6-0999-4E74-B2F5-81720A6BA5A2",
            CategoryId: "B5EF9CFA-FD22-4888-858D-2C8C5E4B2EFA",
            CategoryName: "Components, Handlebars",
            SKU: "HB-T928",
            Name: "HL Touring Handlebars",
            Description: "The product called \"HL Touring Handlebars\"",
            Price: 91.57,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "A9834752-41CA-47F5-8A5A-D9A878DF0ACB",
                    Name: "Tag-198"
                )
            }
        ),
        new Product(
            Id: "18B722BF-4742-4F1F-8336-3AB2E76B2908",
            CategoryId: "E048A761-8038-42C2-8367-F21FF0DAA3F4",
            CategoryName: "Accessories, Fenders",
            SKU: "FE-6654",
            Name: "Fender Set - Mountain",
            Description: "The product called \"Fender Set - Mountain\"",
            Price: 21.98,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "27B7F8D5-1009-45B8-88F5-41008A0F0393",
                    Name: "Tag-61"
                ),
                new Tag(
                    Id: "40525E23-C1FB-4213-BF28-2B4C64BDC29B",
                    Name: "Tag-135"
                ),
                new Tag(
                    Id: "6FB11EB9-319C-431C-89D7-70113401D186",
                    Name: "Tag-154"
                )
            }
        ),
        new Product(
            Id: "1E0D3EBA-563D-4DA1-8D6C-FE9C7A63EE2B",
            CategoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            CategoryName: "Components, Wheels",
            SKU: "FW-R820",
            Name: "HL Road Front Wheel",
            Description: "The product called \"HL Road Front Wheel\"",
            Price: 330.06,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    Name: "Tag-183"
                ),
                new Tag(
                    Id: "D1E5CB02-8E7B-422F-9421-C0E608F0AC4C",
                    Name: "Tag-133"
                ),
                new Tag(
                    Id: "E6D5275B-8C42-47AE-BDEC-FC708DB3E0AC",
                    Name: "Tag-119"
                )
            }
        ),
        new Product(
            Id: "209B4171-CB26-4231-8F41-D092F4679BB9",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M94S-52",
            Name: "HL Mountain Frame - Silver, 48",
            Description: "The product called \"HL Mountain Frame - Silver, 48\"",
            Price: 1364.5,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "243AE98C-D657-415C-9EF4-D8FA8F8770AA",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R50R-48",
            Name: "Road-650 Red, 48",
            Description: "The product called \"Road-650 Red, 48\"",
            Price: 782.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "775908D7-2622-4C29-AF4D-F2274824DA3B",
                    Name: "Tag-89"
                )
            }
        ),
        new Product(
            Id: "2595584F-EA4E-4D45-948E-99A17AF8C519",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R19B-48",
            Name: "Road-750 Black, 48",
            Description: "The product called \"Road-750 Black, 48\"",
            Price: 539.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "52FCE975-91EE-4789-9E36-94EC766F02A0",
                    Name: "Tag-35"
                ),
                new Tag(
                    Id: "7990C336-92BD-41F9-8FB6-97390BC4D187",
                    Name: "Tag-189"
                )
            }
        ),
        new Product(
            Id: "25B35002-7F61-45E3-AA55-80A743C3BC36",
            CategoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            CategoryName: "Components, Wheels",
            SKU: "FW-R623",
            Name: "LL Road Front Wheel",
            Description: "The product called \"LL Road Front Wheel\"",
            Price: 85.565,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "66D8EA21-E1F0-471C-A17F-02F3B149D6E6",
                    Name: "Tag-83"
                ),
                new Tag(
                    Id: "DBE23FA0-0D99-47F5-BCD7-3D798CE653AE",
                    Name: "Tag-55"
                )
            }
        ),
        new Product(
            Id: "26E8185C-782A-4B48-87FA-1E715E3825FB",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R64Y-48",
            Name: "Road-550-W Yellow, 48",
            Description: "The product called \"Road-550-W Yellow, 48\"",
            Price: 1120.49,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "46AC3482-E9A6-474D-A435-D3399F21991F",
                    Name: "Tag-90"
                ),
                new Tag(
                    Id: "9C89E562-1247-435D-B786-4E54024E681C",
                    Name: "Tag-128"
                )
            }
        ),
        new Product(
            Id: "28A93A52-553C-4755-A2C4-07C1F5BD30F5",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M94B-46",
            Name: "HL Mountain Frame - Black, 46",
            Description: "The product called \"HL Mountain Frame - Black, 46\"",
            Price: 1349.6,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "295ABC00-9080-479C-9733-A9BE712D7A18",
            CategoryId: "C48B4EF4-D352-4CD2-BCB8-CE89B7DFA642",
            CategoryName: "Clothing, Socks",
            SKU: "SO-R809-L",
            Name: "Racing Socks, L",
            Description: "The product called \"Racing Socks, L\"",
            Price: 8.99,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "2BBCE73F-9D1D-4BE1-808C-8B174D0DA1A2",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M21B-52",
            Name: "LL Mountain Frame - Black, 52",
            Description: "The product called \"LL Mountain Frame - Black, 52\"",
            Price: 249.79,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "69212884-78CF-48C9-A5C6-B62E76725533",
                    Name: "Tag-104"
                )
            }
        ),
        new Product(
            Id: "2FBE9F71-86EC-4FEB-BBF4-5580FD28E3FD",
            CategoryId: "C7324EF3-D951-45D9-A345-A82EAE344394",
            CategoryName: "Clothing, Shorts",
            SKU: "SH-M897-X",
            Name: "Men's Sports Shorts, XL",
            Description: "The product called \"Men's Sports Shorts, XL\"",
            Price: 59.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "033D3826-2851-4B97-9464-59D3675175D4",
                    Name: "Tag-108"
                )
            }
        ),
        new Product(
            Id: "3933505E-7BD5-458D-84FE-546AA3520A66",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R68R-44",
            Name: "Road-450 Red, 44",
            Description: "The product called \"Road-450 Red, 44\"",
            Price: 1457.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "76B3C6DC-3411-457B-96F5-A51CE015DAD9",
                    Name: "Tag-29"
                ),
                new Tag(
                    Id: "8BAC6191-1DAE-4F5B-88FC-7081B682095D",
                    Name: "Tag-15"
                ),
                new Tag(
                    Id: "9E250CCC-6530-4DC0-9D64-E7777B3C3B73",
                    Name: "Tag-177"
                ),
                new Tag(
                    Id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    Name: "Tag-183"
                ),
                new Tag(
                    Id: "F3A39B6E-753C-4E70-859F-454E8A9624A9",
                    Name: "Tag-179"
                )
            }
        ),
        new Product(
            Id: "39F4BE10-8C68-4E7E-A185-B05BCA543B9F",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R50B-52",
            Name: "Road-650 Black, 52",
            Description: "The product called \"Road-650 Black, 52\"",
            Price: 782.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "2901FEF6-491C-40F5-B2CE-ECF80735BE5D",
                    Name: "Tag-159"
                ),
                new Tag(
                    Id: "35047162-8B96-4BC7-A31D-4186126DBF00",
                    Name: "Tag-169"
                ),
                new Tag(
                    Id: "66D8EA21-E1F0-471C-A17F-02F3B149D6E6",
                    Name: "Tag-83"
                ),
                new Tag(
                    Id: "80F182C6-0619-4547-9A2D-F90A7913FACF",
                    Name: "Tag-96"
                ),
                new Tag(
                    Id: "CA170AAD-A5F6-42FF-B115-146FADD87298",
                    Name: "Tag-186"
                )
            }
        ),
        new Product(
            Id: "3A70EDD4-6C8C-44AA-A13D-49D0F6058699",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R64Y-40",
            Name: "Road-550-W Yellow, 40",
            Description: "The product called \"Road-550-W Yellow, 40\"",
            Price: 1120.49,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "2CE9DADE-DCAC-436C-9D69-B7C886A01B77",
                    Name: "Tag-101"
                ),
                new Tag(
                    Id: "CA7D17BB-45A6-47E6-A3E3-E70AF34C2072",
                    Name: "Tag-158"
                )
            }
        ),
        new Product(
            Id: "3CE3E061-88E1-4430-BAC7-809B285FC702",
            CategoryId: "C7324EF3-D951-45D9-A345-A82EAE344394",
            CategoryName: "Clothing, Shorts",
            SKU: "SH-M897-M",
            Name: "Men's Sports Shorts, M",
            Description: "The product called \"Men's Sports Shorts, M\"",
            Price: 59.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "B1C00DC4-236A-4A5F-844C-3F56BBE87968",
                    Name: "Tag-167"
                )
            }
        ),
        new Product(
            Id: "3D9B62A3-3CDF-45A2-B64C-8A9890818E2C",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M21B-48",
            Name: "LL Mountain Frame - Black, 48",
            Description: "The product called \"LL Mountain Frame - Black, 48\"",
            Price: 249.79,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "A4D9E596-B630-4792-BDD1-7D6459827820",
                    Name: "Tag-164"
                )
            }
        ),
        new Product(
            Id: "3E144819-7455-4362-A4BB-FAD007A90AEF",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M94S-44",
            Name: "HL Mountain Frame - Silver, 44",
            Description: "The product called \"HL Mountain Frame - Silver, 44\"",
            Price: 1364.5,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "0C184C69-F4F2-4774-9645-46F53D297D95",
                    Name: "Tag-49"
                ),
                new Tag(
                    Id: "59676183-1BD7-48A0-B3B0-42B3C0800EB0",
                    Name: "Tag-64"
                ),
                new Tag(
                    Id: "775908D7-2622-4C29-AF4D-F2274824DA3B",
                    Name: "Tag-89"
                ),
                new Tag(
                    Id: "D32CFC73-640F-48B6-976D-B053DCD0F393",
                    Name: "Tag-178"
                )
            }
        ),
        new Product(
            Id: "3F3E4045-AC4D-4D28-99D5-6C9C53F1DEAF",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M21B-40",
            Name: "LL Mountain Frame - Black, 40",
            Description: "The product called \"LL Mountain Frame - Black, 40\"",
            Price: 249.79,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "375399DC-F2B7-4A8C-8A03-C16B849489D3",
                    Name: "Tag-78"
                ),
                new Tag(
                    Id: "7019202D-B11A-4FAB-ACBC-2D0E5A4F72EF",
                    Name: "Tag-143"
                )
            }
        ),
        new Product(
            Id: "42FDA4EC-96CA-4160-956A-3870549AF76E",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R64Y-42",
            Name: "Road-550-W Yellow, 42",
            Description: "The product called \"Road-550-W Yellow, 42\"",
            Price: 1120.49,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "BA4D7ABD-2E82-4DC2-ACF2-5D3B0DEAE1C1",
                    Name: "Tag-59"
                ),
                new Tag(
                    Id: "CA170AAD-A5F6-42FF-B115-146FADD87298",
                    Name: "Tag-186"
                ),
                new Tag(
                    Id: "DBC21C2A-0AF6-45D4-B2C9-703DD708A821",
                    Name: "Tag-14"
                )
            }
        ),
        new Product(
            Id: "4973E28A-A70A-45B9-8517-5D3B647E82C2",
            CategoryId: "BDC73EF8-1745-4A45-8944-D2868A763819",
            CategoryName: "Accessories, Bike Racks",
            SKU: "RA-H123",
            Name: "Hitch Rack - 4-Bike",
            Description: "The product called \"Hitch Rack - 4-Bike\"",
            Price: 120.0,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "5D24B427-1402-49DE-B79B-5A7013579FBC",
                    Name: "Tag-76"
                ),
                new Tag(
                    Id: "CA7D17BB-45A6-47E6-A3E3-E70AF34C2072",
                    Name: "Tag-158"
                )
            }
        ),
        new Product(
            Id: "49ACE2DB-4315-4C16-819E-BE372922C634",
            CategoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            CategoryName: "Components, Wheels",
            SKU: "RW-R820",
            Name: "HL Road Rear Wheel",
            Description: "The product called \"HL Road Rear Wheel\"",
            Price: 357.06,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "5A94DABD-FD34-48F7-9626-50872E214275",
                    Name: "Tag-181"
                ),
                new Tag(
                    Id: "9653F306-0B3C-4856-ABF8-13C3F04AE4F0",
                    Name: "Tag-36"
                )
            }
        ),
        new Product(
            Id: "49E5C64F-B689-4C0B-9E2C-5DFF006B929D",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M63S-40",
            Name: "ML Mountain Frame-W - Silver, 40",
            Description: "The product called \"ML Mountain Frame-W - Silver, 40\"",
            Price: 364.09,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "1A2E203E-B80D-4693-A7C2-AB39E31C9C61",
                    Name: "Tag-134"
                ),
                new Tag(
                    Id: "B3EC53EB-000D-4E66-975A-910771520A6E",
                    Name: "Tag-54"
                ),
                new Tag(
                    Id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    Name: "Tag-183"
                )
            }
        ),
        new Product(
            Id: "4F9FC42A-F43F-4C13-92FC-ADF701F48C36",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R79Y-44",
            Name: "Road-350-W Yellow, 44",
            Description: "The product called \"Road-350-W Yellow, 44\"",
            Price: 1700.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "8BAC6191-1DAE-4F5B-88FC-7081B682095D",
                    Name: "Tag-15"
                )
            }
        ),
        new Product(
            Id: "50DC9B64-03B8-49AB-9DB4-75D12B3180D8",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M63B-48",
            Name: "ML Mountain Frame - Black, 48",
            Description: "The product called \"ML Mountain Frame - Black, 48\"",
            Price: 348.76,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "58C93A21-73D1-44D8-ACF1-3A9E1DB0CE0D",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R93R-52",
            Name: "Road-150 Red, 52",
            Description: "The product called \"Road-150 Red, 52\"",
            Price: 3578.27,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "35047162-8B96-4BC7-A31D-4186126DBF00",
                    Name: "Tag-169"
                ),
                new Tag(
                    Id: "59676183-1BD7-48A0-B3B0-42B3C0800EB0",
                    Name: "Tag-64"
                ),
                new Tag(
                    Id: "A07D69D4-B8B9-4662-8148-8033DCDCC000",
                    Name: "Tag-142"
                ),
                new Tag(
                    Id: "DBC21C2A-0AF6-45D4-B2C9-703DD708A821",
                    Name: "Tag-14"
                )
            }
        ),
        new Product(
            Id: "5C24E8CD-2BFF-460A-88D4-3A2926407346",
            CategoryId: "B5EF9CFA-FD22-4888-858D-2C8C5E4B2EFA",
            CategoryName: "Components, Handlebars",
            SKU: "HB-M918",
            Name: "HL Mountain Handlebars",
            Description: "The product called \"HL Mountain Handlebars\"",
            Price: 120.27,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "4B8ECDDE-FF08-4916-8869-372D08EA8BBA",
                    Name: "Tag-106"
                ),
                new Tag(
                    Id: "B49C6195-5ABA-42FA-B15C-84CF9FE252FE",
                    Name: "Tag-129"
                )
            }
        ),
        new Product(
            Id: "626D67C2-C316-49EB-8316-129BDFBFDE8A",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R50R-60",
            Name: "Road-650 Red, 60",
            Description: "The product called \"Road-650 Red, 60\"",
            Price: 782.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "8A104DF9-CB32-4C6E-951F-8F7DAF9E2BC1",
                    Name: "Tag-200"
                ),
                new Tag(
                    Id: "D56040DB-E5DF-40BE-9F2F-7E10F4340BCA",
                    Name: "Tag-31"
                )
            }
        ),
        new Product(
            Id: "637D953B-42DB-4219-927F-51687E889A04",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R93R-56",
            Name: "Road-150 Red, 56",
            Description: "The product called \"Road-150 Red, 56\"",
            Price: 3578.27,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "764C1CC8-2E5F-4EF5-83F6-8FF7441290B3",
                    Name: "Tag-190"
                ),
                new Tag(
                    Id: "765254E3-8E88-4C57-AADA-9F5126917970",
                    Name: "Tag-93"
                ),
                new Tag(
                    Id: "9C89E562-1247-435D-B786-4E54024E681C",
                    Name: "Tag-128"
                ),
                new Tag(
                    Id: "D77B44A9-7951-4CC8-BB27-8B5D78CFDDF8",
                    Name: "Tag-124"
                ),
                new Tag(
                    Id: "DBE23FA0-0D99-47F5-BCD7-3D798CE653AE",
                    Name: "Tag-55"
                )
            }
        ),
        new Product(
            Id: "64B3F15E-3E21-4ECD-9013-E50ABD324337",
            CategoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            CategoryName: "Components, Wheels",
            SKU: "RW-M423",
            Name: "LL Mountain Rear Wheel",
            Description: "The product called \"LL Mountain Rear Wheel\"",
            Price: 87.745,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "6964ECD2-6FC5-4D65-88BC-126BC2BE2CCB",
            CategoryId: "C48B4EF4-D352-4CD2-BCB8-CE89B7DFA642",
            CategoryName: "Clothing, Socks",
            SKU: "SO-B909-L",
            Name: "Mountain Bike Socks, L",
            Description: "The product called \"Mountain Bike Socks, L\"",
            Price: 9.5,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "23ECB896-D6C6-4E9D-BE43-1908CB5C5E07",
                    Name: "Tag-112"
                ),
                new Tag(
                    Id: "567D183B-9ED1-47B4-AE22-80C52BF41067",
                    Name: "Tag-165"
                ),
                new Tag(
                    Id: "F07885AF-BD6C-4B71-88B1-F04295992176",
                    Name: "Tag-149"
                )
            }
        ),
        new Product(
            Id: "6AEDC59D-F3E3-4B4F-9290-7EFC225B7F42",
            CategoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            CategoryName: "Components, Wheels",
            SKU: "FW-M928",
            Name: "HL Mountain Front Wheel",
            Description: "The product called \"HL Mountain Front Wheel\"",
            Price: 300.215,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "0485B9B8-3A52-49FD-98D4-8515CCD057F3",
                    Name: "Tag-162"
                ),
                new Tag(
                    Id: "606E1794-5457-42A7-90FB-206142EEF023",
                    Name: "Tag-132"
                ),
                new Tag(
                    Id: "A30014DE-B012-4049-B456-4630527AF47F",
                    Name: "Tag-9"
                )
            }
        ),
        new Product(
            Id: "6B41F665-5810-4AFD-8323-6106A8593EFC",
            CategoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            CategoryName: "Components, Wheels",
            SKU: "RW-M928",
            Name: "HL Mountain Rear Wheel",
            Description: "The product called \"HL Mountain Rear Wheel\"",
            Price: 327.215,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "1B387A00-57D3-4444-8331-18A90725E98B",
                    Name: "Tag-43"
                )
            }
        ),
        new Product(
            Id: "6E059A32-56B5-4D98-AC6A-945B488B32A1",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R93R-62",
            Name: "Road-150 Red, 62",
            Description: "The product called \"Road-150 Red, 62\"",
            Price: 3578.27,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "6EAA3D6B-A290-48C4-B3ED-D668261512CD",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M63S-46",
            Name: "ML Mountain Frame-W - Silver, 46",
            Description: "The product called \"ML Mountain Frame-W - Silver, 46\"",
            Price: 364.09,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "EBDBD608-416A-4FE2-96DF-02367C8D071E",
                    Name: "Tag-102"
                )
            }
        ),
        new Product(
            Id: "707106D2-0687-4217-AD2C-A6B828DFE075",
            CategoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            CategoryName: "Components, Wheels",
            SKU: "RW-R762",
            Name: "ML Road Rear Wheel",
            Description: "The product called \"ML Road Rear Wheel\"",
            Price: 275.385,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "1830EEDD-AF21-43EA-A13C-393ED77DEAC5",
                    Name: "Tag-152"
                ),
                new Tag(
                    Id: "6C6D061E-F701-41DC-AEA2-7A5C28061840",
                    Name: "Tag-98"
                )
            }
        ),
        new Product(
            Id: "71BC9DC2-A409-4B4A-A34B-FCBF1E596FCF",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R93R-48",
            Name: "Road-150 Red, 48",
            Description: "The product called \"Road-150 Red, 48\"",
            Price: 3578.27,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "125497D0-9175-4ECD-844D-DA71E5F4ED43",
                    Name: "Tag-42"
                ),
                new Tag(
                    Id: "227FF627-9E87-4BE5-8254-17BB155B0AD7",
                    Name: "Tag-23"
                ),
                new Tag(
                    Id: "7B37373F-FC14-44FD-96AA-32F4854E0B6B",
                    Name: "Tag-63"
                ),
                new Tag(
                    Id: "8AAFD985-8BCE-4FA8-85A2-2CA67D9DF8E6",
                    Name: "Tag-172"
                ),
                new Tag(
                    Id: "DBC21C2A-0AF6-45D4-B2C9-703DD708A821",
                    Name: "Tag-14"
                )
            }
        ),
        new Product(
            Id: "7236DDB5-CFE0-4D3D-8FE5-799B398396B1",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R50B-48",
            Name: "Road-650 Black, 48",
            Description: "The product called \"Road-650 Black, 48\"",
            Price: 782.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "01E0AFB1-867D-4BAA-B0DF-2E99D056EDA2",
                    Name: "Tag-107"
                ),
                new Tag(
                    Id: "69212884-78CF-48C9-A5C6-B62E76725533",
                    Name: "Tag-104"
                )
            }
        ),
        new Product(
            Id: "7355D821-E33B-410B-AE64-D5A535F767EB",
            CategoryId: "B5EF9CFA-FD22-4888-858D-2C8C5E4B2EFA",
            CategoryName: "Components, Handlebars",
            SKU: "HB-M243",
            Name: "LL Mountain Handlebars",
            Description: "The product called \"LL Mountain Handlebars\"",
            Price: 44.54,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "744A624B-E4C2-429E-8A69-DC3B57682BD5",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M21B-42",
            Name: "LL Mountain Frame - Black, 42",
            Description: "The product called \"LL Mountain Frame - Black, 42\"",
            Price: 249.79,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "52FCE975-91EE-4789-9E36-94EC766F02A0",
                    Name: "Tag-35"
                ),
                new Tag(
                    Id: "ECBBCC15-3016-4075-B084-4B49DA754814",
                    Name: "Tag-138"
                ),
                new Tag(
                    Id: "F533A770-1E5D-4B48-8792-E16E155B6E38",
                    Name: "Tag-87"
                )
            }
        ),
        new Product(
            Id: "78E7D28A-2D53-40DC-9ED2-8E2841820DEB",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R50B-62",
            Name: "Road-650 Black, 62",
            Description: "The product called \"Road-650 Black, 62\"",
            Price: 782.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "0BC579CA-03FC-4AA6-85AA-A55035201E43",
                    Name: "Tag-21"
                ),
                new Tag(
                    Id: "52FCE975-91EE-4789-9E36-94EC766F02A0",
                    Name: "Tag-35"
                ),
                new Tag(
                    Id: "F202FBC3-B5AA-4E0F-950B-2B5715AC0B3B",
                    Name: "Tag-173"
                )
            }
        ),
        new Product(
            Id: "7AD4F00E-BB64-4B02-AC6B-0D5F04B01CAB",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R64Y-38",
            Name: "Road-550-W Yellow, 38",
            Description: "The product called \"Road-550-W Yellow, 38\"",
            Price: 1120.49,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "028057B8-8F03-4C18-B853-66510D354A72",
                    Name: "Tag-57"
                ),
                new Tag(
                    Id: "27B7F8D5-1009-45B8-88F5-41008A0F0393",
                    Name: "Tag-61"
                ),
                new Tag(
                    Id: "84C1934D-F048-4D2B-8525-323AFE2A7C7C",
                    Name: "Tag-184"
                ),
                new Tag(
                    Id: "D69B1B6C-4963-4E85-8FA5-6A3E1CD1C83B",
                    Name: "Tag-187"
                )
            }
        ),
        new Product(
            Id: "7EF2B766-E966-4809-B568-372823002877",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M63B-40",
            Name: "ML Mountain Frame - Black, 40",
            Description: "The product called \"ML Mountain Frame - Black, 40\"",
            Price: 348.76,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "6FB11EB9-319C-431C-89D7-70113401D186",
                    Name: "Tag-154"
                ),
                new Tag(
                    Id: "718DAED6-2186-4E09-8C02-CCC58281838D",
                    Name: "Tag-94"
                )
            }
        ),
        new Product(
            Id: "829B2717-0D74-43D3-BBD8-27CFDEF5ACA1",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M94B-48",
            Name: "HL Mountain Frame - Black, 48",
            Description: "The product called \"HL Mountain Frame - Black, 48\"",
            Price: 1349.6,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "46AC3482-E9A6-474D-A435-D3399F21991F",
                    Name: "Tag-90"
                ),
                new Tag(
                    Id: "7B37373F-FC14-44FD-96AA-32F4854E0B6B",
                    Name: "Tag-63"
                ),
                new Tag(
                    Id: "A49D83E4-E506-4301-8110-E114599B4A35",
                    Name: "Tag-27"
                ),
                new Tag(
                    Id: "AEFA79EF-CBF1-4824-AAF7-1D20EA85119B",
                    Name: "Tag-17"
                )
            }
        ),
        new Product(
            Id: "878C50F0-7E29-4D0D-A52E-6D8B063673E3",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R89R-58",
            Name: "Road-250 Red, 58",
            Description: "The product called \"Road-250 Red, 58\"",
            Price: 2443.35,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "2CE9DADE-DCAC-436C-9D69-B7C886A01B77",
                    Name: "Tag-101"
                ),
                new Tag(
                    Id: "762CE1E0-5615-418E-B476-BCD46AD5E79E",
                    Name: "Tag-137"
                )
            }
        ),
        new Product(
            Id: "8A4C4A7F-6EE1-4436-89E3-80AA2D8A1154",
            CategoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            CategoryName: "Components, Wheels",
            SKU: "RW-R623",
            Name: "LL Road Rear Wheel",
            Description: "The product called \"LL Road Rear Wheel\"",
            Price: 112.565,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "537DB3C8-8636-4005-8FE2-32EECEBA5B3F",
                    Name: "Tag-80"
                ),
                new Tag(
                    Id: "5D24B427-1402-49DE-B79B-5A7013579FBC",
                    Name: "Tag-76"
                ),
                new Tag(
                    Id: "7F518FB1-4664-4B20-9B9F-23D5B44F6798",
                    Name: "Tag-69"
                ),
                new Tag(
                    Id: "BE894A90-F425-4BE3-B9DF-56525DD54F62",
                    Name: "Tag-62"
                ),
                new Tag(
                    Id: "CAF27567-B4CB-463C-A54E-5EF1F2657DD2",
                    Name: "Tag-75"
                )
            }
        ),
        new Product(
            Id: "8B8184BF-B79B-4157-BAA6-D30413BCC7A9",
            CategoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            CategoryName: "Components, Wheels",
            SKU: "RW-M762",
            Name: "ML Mountain Rear Wheel",
            Description: "The product called \"ML Mountain Rear Wheel\"",
            Price: 236.025,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "8DB727BC-BE6B-4472-93F9-977B927D0C36",
            CategoryId: "ACCC1FC1-7601-4F7A-AFA7-29C892F0FBE3",
            CategoryName: "Clothing, Caps",
            SKU: "CA-1098",
            Name: "AWC Logo Cap",
            Description: "The product called \"AWC Logo Cap\"",
            Price: 8.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "511652EB-9EC2-4235-BA77-0C6E4E316679",
                    Name: "Tag-199"
                ),
                new Tag(
                    Id: "BA4D7ABD-2E82-4DC2-ACF2-5D3B0DEAE1C1",
                    Name: "Tag-59"
                )
            }
        ),
        new Product(
            Id: "8FE13D26-469C-41FE-BD7E-0A856A82F95C",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M94S-38",
            Name: "HL Mountain Frame - Silver, 38",
            Description: "The product called \"HL Mountain Frame - Silver, 38\"",
            Price: 1364.5,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "A49D83E4-E506-4301-8110-E114599B4A35",
                    Name: "Tag-27"
                ),
                new Tag(
                    Id: "D2427B7F-AF57-498B-A73E-E7D67FD5CFD9",
                    Name: "Tag-195"
                )
            }
        ),
        new Product(
            Id: "90888587-BBBD-4632-8A48-5B979586DEE4",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R50R-62",
            Name: "Road-650 Red, 62",
            Description: "The product called \"Road-650 Red, 62\"",
            Price: 782.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "80F182C6-0619-4547-9A2D-F90A7913FACF",
                    Name: "Tag-96"
                ),
                new Tag(
                    Id: "8DC9DFB4-1946-427A-A0A0-E06E1448CC63",
                    Name: "Tag-171"
                ),
                new Tag(
                    Id: "BDA92549-CBC2-4DC1-9C82-18D1A629C3F3",
                    Name: "Tag-145"
                ),
                new Tag(
                    Id: "BE894A90-F425-4BE3-B9DF-56525DD54F62",
                    Name: "Tag-62"
                )
            }
        ),
        new Product(
            Id: "91E5405C-DC61-42CE-B900-0F46C94FBBA5",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R64Y-44",
            Name: "Road-550-W Yellow, 44",
            Description: "The product called \"Road-550-W Yellow, 44\"",
            Price: 1120.49,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "A2AFF2FF-8438-44A3-8AC6-20A50422D82A",
                    Name: "Tag-18"
                ),
                new Tag(
                    Id: "A49D83E4-E506-4301-8110-E114599B4A35",
                    Name: "Tag-27"
                ),
                new Tag(
                    Id: "B1EBD7E0-BBE0-4AFB-AC6C-50649484780B",
                    Name: "Tag-40"
                ),
                new Tag(
                    Id: "D2427B7F-AF57-498B-A73E-E7D67FD5CFD9",
                    Name: "Tag-195"
                ),
                new Tag(
                    Id: "D77B44A9-7951-4CC8-BB27-8B5D78CFDDF8",
                    Name: "Tag-124"
                )
            }
        ),
        new Product(
            Id: "9363838B-2D13-48E8-986D-C9625BE5AB26",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R50B-60",
            Name: "Road-650 Black, 60",
            Description: "The product called \"Road-650 Black, 60\"",
            Price: 782.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "028057B8-8F03-4C18-B853-66510D354A72",
                    Name: "Tag-57"
                ),
                new Tag(
                    Id: "46AC3482-E9A6-474D-A435-D3399F21991F",
                    Name: "Tag-90"
                ),
                new Tag(
                    Id: "79E61D0F-3C95-4353-BF27-DB04535088C9",
                    Name: "Tag-50"
                ),
                new Tag(
                    Id: "B1EBD7E0-BBE0-4AFB-AC6C-50649484780B",
                    Name: "Tag-40"
                )
            }
        ),
        new Product(
            Id: "93A037C1-7135-4544-A688-3A3A75F25D0E",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M94B-42",
            Name: "HL Mountain Frame - Black, 42",
            Description: "The product called \"HL Mountain Frame - Black, 42\"",
            Price: 1349.6,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "9E5C74FD-F685-45AE-A799-D67EFB5C28A1",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R79Y-40",
            Name: "Road-350-W Yellow, 40",
            Description: "The product called \"Road-350-W Yellow, 40\"",
            Price: 1700.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "069169DD-F4B3-4769-8841-13B5FF745932",
                    Name: "Tag-157"
                )
            }
        ),
        new Product(
            Id: "9E5DD0E4-89B5-4300-BD49-87518EE9DB6A",
            CategoryId: "B5EF9CFA-FD22-4888-858D-2C8C5E4B2EFA",
            CategoryName: "Components, Handlebars",
            SKU: "HB-R956",
            Name: "HL Road Handlebars",
            Description: "The product called \"HL Road Handlebars\"",
            Price: 120.27,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "403AE98F-892E-4FEC-B262-A264CF1F52A9",
                    Name: "Tag-45"
                ),
                new Tag(
                    Id: "89500F13-B516-4F77-8128-47FC412BEFCD",
                    Name: "Tag-151"
                ),
                new Tag(
                    Id: "D1E5CB02-8E7B-422F-9421-C0E608F0AC4C",
                    Name: "Tag-133"
                )
            }
        ),
        new Product(
            Id: "9FEC8F06-D741-42EC-AF1D-E2F83BABC9F5",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M63S-38",
            Name: "ML Mountain Frame-W - Silver, 38",
            Description: "The product called \"ML Mountain Frame-W - Silver, 38\"",
            Price: 364.09,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "A1D803E1-B9DE-49B4-9E61-66F5C3CD679A",
            CategoryId: "B5EF9CFA-FD22-4888-858D-2C8C5E4B2EFA",
            CategoryName: "Components, Handlebars",
            SKU: "HB-R504",
            Name: "LL Road Handlebars",
            Description: "The product called \"LL Road Handlebars\"",
            Price: 44.54,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "403AE98F-892E-4FEC-B262-A264CF1F52A9",
                    Name: "Tag-45"
                ),
                new Tag(
                    Id: "D69B1B6C-4963-4E85-8FA5-6A3E1CD1C83B",
                    Name: "Tag-187"
                )
            }
        ),
        new Product(
            Id: "A374B506-8D35-456B-8C63-BCE78B5083B8",
            CategoryId: "C7324EF3-D951-45D9-A345-A82EAE344394",
            CategoryName: "Clothing, Shorts",
            SKU: "SH-W890-M",
            Name: "Women's Mountain Shorts, M",
            Description: "The product called \"Women's Mountain Shorts, M\"",
            Price: 69.99,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "B3217262-876C-4C29-A201-06101B710396",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M21S-40",
            Name: "LL Mountain Frame - Silver, 40",
            Description: "The product called \"LL Mountain Frame - Silver, 40\"",
            Price: 264.05,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "89FB612A-F9AA-4196-B5F5-B9FA16D558DC",
                    Name: "Tag-175"
                ),
                new Tag(
                    Id: "8CA1BBD8-D00B-4654-AABA-5C8724C6F4BD",
                    Name: "Tag-81"
                ),
                new Tag(
                    Id: "BBE8A68F-6458-410E-BFF7-759507DCE858",
                    Name: "Tag-114"
                )
            }
        ),
        new Product(
            Id: "B39A06DD-3A51-470E-8253-8D6ACB3EA102",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M21S-48",
            Name: "LL Mountain Frame - Silver, 48",
            Description: "The product called \"LL Mountain Frame - Silver, 48\"",
            Price: 264.05,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "33AFFF1B-30AA-41C5-8510-34B67A523CA9",
                    Name: "Tag-110"
                )
            }
        ),
        new Product(
            Id: "B3C8AE66-8E4B-4605-A78D-FF2A8C4EAD9A",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M94S-46",
            Name: "HL Mountain Frame - Silver, 46",
            Description: "The product called \"HL Mountain Frame - Silver, 46\"",
            Price: 1364.5,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "B6591222-0FB9-415F-8F2B-18B56A483AA1",
            CategoryId: "B5EF9CFA-FD22-4888-858D-2C8C5E4B2EFA",
            CategoryName: "Components, Handlebars",
            SKU: "HB-R720",
            Name: "ML Road Handlebars",
            Description: "The product called \"ML Road Handlebars\"",
            Price: 61.92,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "E23954CF-D79A-433E-9BE6-FD787C5E4C9B",
                    Name: "Tag-111"
                ),
                new Tag(
                    Id: "F287FE0A-712B-4B52-925F-5047B34F3610",
                    Name: "Tag-197"
                )
            }
        ),
        new Product(
            Id: "B73FFF5D-37A0-4A29-A42C-D91CD6743593",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R50R-52",
            Name: "Road-650 Red, 52",
            Description: "The product called \"Road-650 Red, 52\"",
            Price: 782.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "812C1444-1DEA-480D-88E7-B9609ECA783C",
                    Name: "Tag-136"
                )
            }
        ),
        new Product(
            Id: "B8E30737-758B-49E0-A153-B210B80749F4",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M21S-52",
            Name: "LL Mountain Frame - Silver, 52",
            Description: "The product called \"LL Mountain Frame - Silver, 52\"",
            Price: 264.05,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "2CE9DADE-DCAC-436C-9D69-B7C886A01B77",
                    Name: "Tag-101"
                )
            }
        ),
        new Product(
            Id: "BF3E0E82-DCFC-4EA3-A71C-8C9EAA329E14",
            CategoryId: "C48B4EF4-D352-4CD2-BCB8-CE89B7DFA642",
            CategoryName: "Clothing, Socks",
            SKU: "SO-B909-M",
            Name: "Mountain Bike Socks, M",
            Description: "The product called \"Mountain Bike Socks, M\"",
            Price: 9.5,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "F41CEB6B-FFD0-40A2-BC0F-F89FC3256F09",
                    Name: "Tag-13"
                )
            }
        ),
        new Product(
            Id: "C461038A-6DB6-4EC7-924F-ECA906259A6E",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R79Y-42",
            Name: "Road-350-W Yellow, 42",
            Description: "The product called \"Road-350-W Yellow, 42\"",
            Price: 1700.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "0C184C69-F4F2-4774-9645-46F53D297D95",
                    Name: "Tag-49"
                ),
                new Tag(
                    Id: "304041C4-8C80-4C1E-9EE9-8A1DEFCF39FC",
                    Name: "Tag-72"
                ),
                new Tag(
                    Id: "89FB612A-F9AA-4196-B5F5-B9FA16D558DC",
                    Name: "Tag-175"
                ),
                new Tag(
                    Id: "A2176C7A-4E0D-4283-AFAA-319A77E9C122",
                    Name: "Tag-19"
                ),
                new Tag(
                    Id: "DCF66D9A-E2BF-4C70-8AC1-AD55E5988E9D",
                    Name: "Tag-37"
                )
            }
        ),
        new Product(
            Id: "C6941C95-C463-4F66-BE5F-8CA9C5F7FD91",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R89R-52",
            Name: "Road-250 Red, 52",
            Description: "The product called \"Road-250 Red, 52\"",
            Price: 2443.35,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "45CBB7FF-FA48-49D8-89EF-F1D0B8AC3923",
                    Name: "Tag-86"
                ),
                new Tag(
                    Id: "A0BA4E3B-AD4A-42AF-BFA4-5F48E2E57F07",
                    Name: "Tag-58"
                ),
                new Tag(
                    Id: "F132E7B8-65B1-471E-8D3E-5E8D7110CA48",
                    Name: "Tag-118"
                )
            }
        ),
        new Product(
            Id: "C7B411C0-31F7-4634-B62F-ED349027EFE0",
            CategoryId: "C7324EF3-D951-45D9-A345-A82EAE344394",
            CategoryName: "Clothing, Shorts",
            SKU: "SH-W890-L",
            Name: "Women's Mountain Shorts, L",
            Description: "The product called \"Women's Mountain Shorts, L\"",
            Price: 69.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "CA170AAD-A5F6-42FF-B115-146FADD87298",
                    Name: "Tag-186"
                )
            }
        ),
        new Product(
            Id: "C7BE1762-AC9D-4239-BD15-F3096B08AFA9",
            CategoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            CategoryName: "Components, Wheels",
            SKU: "FW-M423",
            Name: "LL Mountain Front Wheel",
            Description: "The product called \"LL Mountain Front Wheel\"",
            Price: 60.745,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "CAC12FD1-C2ED-4B75-9199-86EB2044DB0D",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M63B-44",
            Name: "ML Mountain Frame - Black, 44",
            Description: "The product called \"ML Mountain Frame - Black, 44\"",
            Price: 348.76,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "18AC309F-F81C-4234-A752-5DDD2BEAEE83",
                    Name: "Tag-32"
                )
            }
        ),
        new Product(
            Id: "CB1F441C-90E4-4E0B-ABDA-E0D07AFC2E01",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R89B-58",
            Name: "Road-250 Black, 58",
            Description: "The product called \"Road-250 Black, 58\"",
            Price: 2443.35,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "1745EF28-6E0B-4FED-8925-BC3174F583B0",
                    Name: "Tag-48"
                )
            }
        ),
        new Product(
            Id: "CDFC37BB-8DB8-4D66-841D-7C3FF28B1F0A",
            CategoryId: "B5EF9CFA-FD22-4888-858D-2C8C5E4B2EFA",
            CategoryName: "Components, Handlebars",
            SKU: "HB-T721",
            Name: "LL Touring Handlebars",
            Description: "The product called \"LL Touring Handlebars\"",
            Price: 46.09,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "0C184C69-F4F2-4774-9645-46F53D297D95",
                    Name: "Tag-49"
                ),
                new Tag(
                    Id: "1745EF28-6E0B-4FED-8925-BC3174F583B0",
                    Name: "Tag-48"
                ),
                new Tag(
                    Id: "1830EEDD-AF21-43EA-A13C-393ED77DEAC5",
                    Name: "Tag-152"
                ),
                new Tag(
                    Id: "AC4CC3CC-4E6B-461D-9B0E-4218EDDF3142",
                    Name: "Tag-122"
                ),
                new Tag(
                    Id: "B49C6195-5ABA-42FA-B15C-84CF9FE252FE",
                    Name: "Tag-129"
                )
            }
        ),
        new Product(
            Id: "CE35E963-F6ED-4108-BC4B-6A3DD0557B47",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M21B-44",
            Name: "LL Mountain Frame - Black, 44",
            Description: "The product called \"LL Mountain Frame - Black, 44\"",
            Price: 249.79,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "50F59C1E-E78D-4543-B4D0-B06E4C59E617",
                    Name: "Tag-126"
                ),
                new Tag(
                    Id: "89500F13-B516-4F77-8128-47FC412BEFCD",
                    Name: "Tag-151"
                ),
                new Tag(
                    Id: "E1A62ABF-BBC3-48A2-BAC6-E3350D023C83",
                    Name: "Tag-194"
                )
            }
        ),
        new Product(
            Id: "D17F948A-2316-4E2E-8D89-973C92FAD9ED",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M63S-42",
            Name: "ML Mountain Frame-W - Silver, 42",
            Description: "The product called \"ML Mountain Frame-W - Silver, 42\"",
            Price: 364.09,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "14CFF1D6-7749-4A57-85B3-783F47731F32",
                    Name: "Tag-7"
                ),
                new Tag(
                    Id: "45CBB7FF-FA48-49D8-89EF-F1D0B8AC3923",
                    Name: "Tag-86"
                ),
                new Tag(
                    Id: "718DAED6-2186-4E09-8C02-CCC58281838D",
                    Name: "Tag-94"
                ),
                new Tag(
                    Id: "E83726D0-E486-42C1-BBD3-594C1C5AED6D",
                    Name: "Tag-155"
                )
            }
        ),
        new Product(
            Id: "D1F006A3-C6C0-42A4-B479-FC3A510C9E9E",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M63B-38",
            Name: "ML Mountain Frame - Black, 38",
            Description: "The product called \"ML Mountain Frame - Black, 38\"",
            Price: 348.76,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "1A2E203E-B80D-4693-A7C2-AB39E31C9C61",
                    Name: "Tag-134"
                ),
                new Tag(
                    Id: "7CACE200-11A3-4E2D-A88E-25E9614D2BE9",
                    Name: "Tag-97"
                ),
                new Tag(
                    Id: "9C89E562-1247-435D-B786-4E54024E681C",
                    Name: "Tag-128"
                ),
                new Tag(
                    Id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    Name: "Tag-183"
                )
            }
        ),
        new Product(
            Id: "D616598D-3159-4616-BF9D-FD316BF07224",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R68R-60",
            Name: "Road-450 Red, 60",
            Description: "The product called \"Road-450 Red, 60\"",
            Price: 1457.99,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "D8CA2EB2-7532-4F74-9D1D-E8CCC7326604",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R50R-58",
            Name: "Road-650 Red, 58",
            Description: "The product called \"Road-650 Red, 58\"",
            Price: 782.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "87BC6842-2CCA-4CD3-994C-33AB101455F4",
                    Name: "Tag-12"
                ),
                new Tag(
                    Id: "A0BA4E3B-AD4A-42AF-BFA4-5F48E2E57F07",
                    Name: "Tag-58"
                ),
                new Tag(
                    Id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    Name: "Tag-183"
                ),
                new Tag(
                    Id: "BDA92549-CBC2-4DC1-9C82-18D1A629C3F3",
                    Name: "Tag-145"
                ),
                new Tag(
                    Id: "E6D5275B-8C42-47AE-BDEC-FC708DB3E0AC",
                    Name: "Tag-119"
                )
            }
        ),
        new Product(
            Id: "D9FCCC86-10FD-47E9-B68B-F0DFE758AA0E",
            CategoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            CategoryName: "Components, Wheels",
            SKU: "FW-M762",
            Name: "ML Mountain Front Wheel",
            Description: "The product called \"ML Mountain Front Wheel\"",
            Price: 209.025,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "0573D684-9140-4DEE-89AF-4E4A90E65666",
                    Name: "Tag-113"
                ),
                new Tag(
                    Id: "069169DD-F4B3-4769-8841-13B5FF745932",
                    Name: "Tag-157"
                ),
                new Tag(
                    Id: "2901FEF6-491C-40F5-B2CE-ECF80735BE5D",
                    Name: "Tag-159"
                ),
                new Tag(
                    Id: "319E277F-6B7A-483D-81BA-1EC34CC700EB",
                    Name: "Tag-163"
                ),
                new Tag(
                    Id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    Name: "Tag-183"
                )
            }
        ),
        new Product(
            Id: "E2FD2420-B084-4764-8BC4-94574DFF1AC6",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R68R-48",
            Name: "Road-450 Red, 48",
            Description: "The product called \"Road-450 Red, 48\"",
            Price: 1457.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "1CFF105D-294E-4E2D-ADE4-0615CBDEBC28",
                    Name: "Tag-44"
                ),
                new Tag(
                    Id: "3A3A99B6-E3BF-46D0-BAD9-F5F4DBB720F4",
                    Name: "Tag-70"
                ),
                new Tag(
                    Id: "52E5F264-BA4E-4A8B-BF8C-69E50F81B676",
                    Name: "Tag-67"
                ),
                new Tag(
                    Id: "6FB11EB9-319C-431C-89D7-70113401D186",
                    Name: "Tag-154"
                ),
                new Tag(
                    Id: "DCDBD26C-4D71-4F91-BBE9-98D1897E704D",
                    Name: "Tag-68"
                )
            }
        ),
        new Product(
            Id: "E49AE44E-40AC-4FD8-A007-EEC046F02684",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M21S-44",
            Name: "LL Mountain Frame - Silver, 44",
            Description: "The product called \"LL Mountain Frame - Silver, 44\"",
            Price: 264.05,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "E54D5E31-073F-4D37-8400-E63A2994C92C",
            CategoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            CategoryName: "Components, Wheels",
            SKU: "FW-R762",
            Name: "ML Road Front Wheel",
            Description: "The product called \"ML Road Front Wheel\"",
            Price: 248.385,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "29CBEDD8-D9C3-43A3-B20F-63224FEE0D34",
                    Name: "Tag-11"
                ),
                new Tag(
                    Id: "52E5F264-BA4E-4A8B-BF8C-69E50F81B676",
                    Name: "Tag-67"
                ),
                new Tag(
                    Id: "A0BA4E3B-AD4A-42AF-BFA4-5F48E2E57F07",
                    Name: "Tag-58"
                )
            }
        ),
        new Product(
            Id: "E5C302BB-43AC-4E47-8355-F0D2165C394A",
            CategoryId: "B5EF9CFA-FD22-4888-858D-2C8C5E4B2EFA",
            CategoryName: "Components, Handlebars",
            SKU: "HB-M763",
            Name: "ML Mountain Handlebars",
            Description: "The product called \"ML Mountain Handlebars\"",
            Price: 61.92,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "23ECB896-D6C6-4E9D-BE43-1908CB5C5E07",
                    Name: "Tag-112"
                ),
                new Tag(
                    Id: "B18FB652-C4B6-4A40-BA22-1E687C1A58CE",
                    Name: "Tag-161"
                ),
                new Tag(
                    Id: "BEBD68EF-901A-4282-911F-28AB44B802FE",
                    Name: "Tag-139"
                )
            }
        ),
        new Product(
            Id: "E5CEC513-A0F9-4437-B26D-A9FB28237554",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R89B-44",
            Name: "Road-250 Black, 44",
            Description: "The product called \"Road-250 Black, 44\"",
            Price: 2443.35,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "E9F21624-C055-4D5F-8C02-8F69C1EA0AEE",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R50R-44",
            Name: "Road-650 Red, 44",
            Description: "The product called \"Road-650 Red, 44\"",
            Price: 782.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "6C6D061E-F701-41DC-AEA2-7A5C28061840",
                    Name: "Tag-98"
                ),
                new Tag(
                    Id: "A37349FB-4A1C-4382-A845-DF81830A7B4D",
                    Name: "Tag-150"
                ),
                new Tag(
                    Id: "B805F2EF-E936-4A6E-8DBB-0543A8C4F949",
                    Name: "Tag-183"
                ),
                new Tag(
                    Id: "D69B1B6C-4963-4E85-8FA5-6A3E1CD1C83B",
                    Name: "Tag-187"
                ),
                new Tag(
                    Id: "DAC25651-3DD3-4483-8FD1-581DC41EF34B",
                    Name: "Tag-56"
                )
            }
        ),
        new Product(
            Id: "EB793BFC-82A4-4EF4-BB2A-4FD218DD1843",
            CategoryId: "C7324EF3-D951-45D9-A345-A82EAE344394",
            CategoryName: "Clothing, Shorts",
            SKU: "SH-M897-L",
            Name: "Men's Sports Shorts, L",
            Description: "The product called \"Men's Sports Shorts, L\"",
            Price: 59.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "0C184C69-F4F2-4774-9645-46F53D297D95",
                    Name: "Tag-49"
                ),
                new Tag(
                    Id: "304041C4-8C80-4C1E-9EE9-8A1DEFCF39FC",
                    Name: "Tag-72"
                ),
                new Tag(
                    Id: "567D183B-9ED1-47B4-AE22-80C52BF41067",
                    Name: "Tag-165"
                ),
                new Tag(
                    Id: "A07D69D4-B8B9-4662-8148-8033DCDCC000",
                    Name: "Tag-142"
                )
            }
        ),
        new Product(
            Id: "EC2ADE30-9132-4DFE-B8FE-D233DDFFAAB3",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R89B-52",
            Name: "Road-250 Black, 52",
            Description: "The product called \"Road-250 Black, 52\"",
            Price: 2443.35,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "028057B8-8F03-4C18-B853-66510D354A72",
                    Name: "Tag-57"
                ),
                new Tag(
                    Id: "52FCE975-91EE-4789-9E36-94EC766F02A0",
                    Name: "Tag-35"
                ),
                new Tag(
                    Id: "AA24EC37-7CE3-4ABE-B935-EC62D5FB6947",
                    Name: "Tag-148"
                ),
                new Tag(
                    Id: "F629F27D-3301-4906-BE9B-C46D6D6F6141",
                    Name: "Tag-65"
                )
            }
        ),
        new Product(
            Id: "F1AA8B6D-4CF2-4DB2-BB17-997C2BD1A6AC",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R68R-58",
            Name: "Road-450 Red, 58",
            Description: "The product called \"Road-450 Red, 58\"",
            Price: 1457.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "1CFF105D-294E-4E2D-ADE4-0615CBDEBC28",
                    Name: "Tag-44"
                ),
                new Tag(
                    Id: "45CBB7FF-FA48-49D8-89EF-F1D0B8AC3923",
                    Name: "Tag-86"
                ),
                new Tag(
                    Id: "7337386B-E865-4ADC-BA17-4437CB02E3BE",
                    Name: "Tag-8"
                ),
                new Tag(
                    Id: "A37349FB-4A1C-4382-A845-DF81830A7B4D",
                    Name: "Tag-150"
                )
            }
        ),
        new Product(
            Id: "F25B4447-9094-42DB-8244-186A279E461C",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R50B-58",
            Name: "Road-650 Black, 58",
            Description: "The product called \"Road-650 Black, 58\"",
            Price: 782.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "7337386B-E865-4ADC-BA17-4437CB02E3BE",
                    Name: "Tag-8"
                ),
                new Tag(
                    Id: "8A104DF9-CB32-4C6E-951F-8F7DAF9E2BC1",
                    Name: "Tag-200"
                ),
                new Tag(
                    Id: "A34D34F7-3286-4FA4-B4B0-5E61CCEEE197",
                    Name: "Tag-4"
                ),
                new Tag(
                    Id: "A50C570B-B3FC-4678-96C8-2D117DD11A12",
                    Name: "Tag-66"
                ),
                new Tag(
                    Id: "E23954CF-D79A-433E-9BE6-FD787C5E4C9B",
                    Name: "Tag-111"
                )
            }
        ),
        new Product(
            Id: "F3012443-6317-4856-800A-6E108A5F8AE5",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M94S-42",
            Name: "HL Mountain Frame - Silver, 42",
            Description: "The product called \"HL Mountain Frame - Silver, 42\"",
            Price: 1364.5,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "1830EEDD-AF21-43EA-A13C-393ED77DEAC5",
                    Name: "Tag-152"
                ),
                new Tag(
                    Id: "9C89E562-1247-435D-B786-4E54024E681C",
                    Name: "Tag-128"
                ),
                new Tag(
                    Id: "A0BA4E3B-AD4A-42AF-BFA4-5F48E2E57F07",
                    Name: "Tag-58"
                ),
                new Tag(
                    Id: "BEBD68EF-901A-4282-911F-28AB44B802FE",
                    Name: "Tag-139"
                )
            }
        ),
        new Product(
            Id: "F42672DA-1B19-463B-B49D-AC4EA2E1F77C",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R89B-48",
            Name: "Road-250 Black, 48",
            Description: "The product called \"Road-250 Black, 48\"",
            Price: 2443.35,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "0BC579CA-03FC-4AA6-85AA-A55035201E43",
                    Name: "Tag-21"
                ),
                new Tag(
                    Id: "45CBB7FF-FA48-49D8-89EF-F1D0B8AC3923",
                    Name: "Tag-86"
                ),
                new Tag(
                    Id: "6C6D061E-F701-41DC-AEA2-7A5C28061840",
                    Name: "Tag-98"
                ),
                new Tag(
                    Id: "8A104DF9-CB32-4C6E-951F-8F7DAF9E2BC1",
                    Name: "Tag-200"
                ),
                new Tag(
                    Id: "94C05E5C-13B7-41DA-89DF-98C11195AE1E",
                    Name: "Tag-79"
                )
            }
        ),
        new Product(
            Id: "F58F50FB-BE83-4AE1-ACF0-662F702B2E5A",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R89R-48",
            Name: "Road-250 Red, 48",
            Description: "The product called \"Road-250 Red, 48\"",
            Price: 2443.35,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "0917B02C-1EAB-4EBA-BA74-5E6D3C5CC96A",
                    Name: "Tag-192"
                ),
                new Tag(
                    Id: "33AFFF1B-30AA-41C5-8510-34B67A523CA9",
                    Name: "Tag-110"
                ),
                new Tag(
                    Id: "9653F306-0B3C-4856-ABF8-13C3F04AE4F0",
                    Name: "Tag-36"
                )
            }
        ),
        new Product(
            Id: "F59ECC09-CAA5-4D3C-87A7-16945A92EA2D",
            CategoryId: "C7324EF3-D951-45D9-A345-A82EAE344394",
            CategoryName: "Clothing, Shorts",
            SKU: "SH-W890-S",
            Name: "Women's Mountain Shorts, S",
            Description: "The product called \"Women's Mountain Shorts, S\"",
            Price: 69.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "4E102F3F-7D57-4CD7-88F4-AC5076A42C59",
                    Name: "Tag-91"
                ),
                new Tag(
                    Id: "7019202D-B11A-4FAB-ACBC-2D0E5A4F72EF",
                    Name: "Tag-143"
                )
            }
        ),
        new Product(
            Id: "F7078B88-417F-44C0-9345-DCEDDB5C41F8",
            CategoryId: "C7324EF3-D951-45D9-A345-A82EAE344394",
            CategoryName: "Clothing, Shorts",
            SKU: "SH-M897-S",
            Name: "Men's Sports Shorts, S",
            Description: "The product called \"Men's Sports Shorts, S\"",
            Price: 59.99,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "F741B78B-36F0-42E9-A26A-FAE908E0FB3A",
            CategoryId: "C80E3277-604C-4C6D-85AE-FCB237C08751",
            CategoryName: "Components, Wheels",
            SKU: "RW-T905",
            Name: "Touring Rear Wheel",
            Description: "The product called \"Touring Rear Wheel\"",
            Price: 245.01,
            Tags: new List<Tag> { }
        ),
        new Product(
            Id: "FD00408C-57B1-431C-B1FA-2CAF41D87CD4",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R19B-44",
            Name: "Road-750 Black, 44",
            Description: "The product called \"Road-750 Black, 44\"",
            Price: 539.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "0BC579CA-03FC-4AA6-85AA-A55035201E43",
                    Name: "Tag-21"
                )
            }
        ),
        new Product(
            Id: "FD48A179-6CF5-45F2-8605-9DA19B9D4409",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R93R-44",
            Name: "Road-150 Red, 44",
            Description: "The product called \"Road-150 Red, 44\"",
            Price: 3578.27,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "765254E3-8E88-4C57-AADA-9F5126917970",
                    Name: "Tag-93"
                ),
                new Tag(
                    Id: "E23954CF-D79A-433E-9BE6-FD787C5E4C9B",
                    Name: "Tag-111"
                )
            }
        ),
        new Product(
            Id: "FDD4E68A-6284-4DC7-B48D-232F347CA827",
            CategoryId: "3B75F01D-6443-4C83-B182-8BB38192C33B",
            CategoryName: "Components, Mountain Frames",
            SKU: "FR-M94B-44",
            Name: "HL Mountain Frame - Black, 44",
            Description: "The product called \"HL Mountain Frame - Black, 44\"",
            Price: 1349.6,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "3BFB03A9-3106-44C7-823A-DB1A67E283C3",
                    Name: "Tag-47"
                ),
                new Tag(
                    Id: "54C5E2EB-EE2D-496D-8AE2-200D7575968A",
                    Name: "Tag-156"
                ),
                new Tag(
                    Id: "7DF71D87-FB6F-498B-9D7B-E7EBE40350E1",
                    Name: "Tag-88"
                ),
                new Tag(
                    Id: "A0BA4E3B-AD4A-42AF-BFA4-5F48E2E57F07",
                    Name: "Tag-58"
                ),
                new Tag(
                    Id: "A9834752-41CA-47F5-8A5A-D9A878DF0ACB",
                    Name: "Tag-198"
                )
            }
        ),
        new Product(
            Id: "FEEFEE3B-6CB9-4A75-B896-5182531F661B",
            CategoryId: "AE48F0AA-4F65-4734-A4CF-D48B8F82267F",
            CategoryName: "Bikes, Road Bikes",
            SKU: "BK-R19B-52",
            Name: "Road-750 Black, 52",
            Description: "The product called \"Road-750 Black, 52\"",
            Price: 539.99,
            Tags: new List<Tag>
            {
                new Tag(
                    Id: "461ADE06-0903-4BAF-97AB-CC713E5B1DD4",
                    Name: "Tag-174"
                ),
                new Tag(
                    Id: "AC4CC3CC-4E6B-461D-9B0E-4218EDDF3142",
                    Name: "Tag-122"
                ),
                new Tag(
                    Id: "D56040DB-E5DF-40BE-9F2F-7E10F4340BCA",
                    Name: "Tag-31"
                ),
                new Tag(
                    Id: "D77B44A9-7951-4CC8-BB27-8B5D78CFDDF8",
                    Name: "Tag-124"
                ),
                new Tag(
                    Id: "E468DF53-4836-4546-9D05-C855AAC4B0AF",
                    Name: "Tag-2"
                )
            }
        )
    };
}