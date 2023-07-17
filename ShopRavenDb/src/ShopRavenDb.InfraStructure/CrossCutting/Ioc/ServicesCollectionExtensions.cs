namespace ShopRavenDb.InfraStructure.CrossCutting.Ioc
{
    public static class ServicesCollectionExtensions
    {
        public static IServiceCollection AddRavenDb(this IServiceCollection servicesCollection)
        {
            servicesCollection.TryAddSingleton<IDocumentStore>(ctx =>
            {
                var store = new DocumentStore
                {
                    Urls = new string[] { "http://127.0.0.1:8080/" },
                    Database = "Shop"
                };

                store.Initialize();

                return store;
            });

            return servicesCollection;
        }

    }
}
