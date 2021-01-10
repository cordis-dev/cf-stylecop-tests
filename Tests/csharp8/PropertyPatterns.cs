namespace Tests
{
    public class PropertyPatterns
    {
        public static decimal ComputeSalesTax(Address location, decimal salePrice) =>
            location switch
            {
                { State: "WA", City: "WA" } => salePrice * 0.06M,
                { State: "MN" } => salePrice * 0.075M,
                { State: "MI" } => salePrice * 0.05M,
                // other cases removed for brevity...
                _ => 0M
            };
    }

    public class Address
    {
        public string State { get; set; }
        public string City { get; set; }
    }
}