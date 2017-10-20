namespace Lloyd.AzureMailGateway.Core
{
    public class From
    {
        public Address Address { get; internal set; }

        //public From(Address address) => Address = address ?? throw new ArgumentNullException(nameof(address));
    }
}