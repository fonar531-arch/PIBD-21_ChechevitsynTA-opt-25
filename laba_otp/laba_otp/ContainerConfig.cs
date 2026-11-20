using otp_lab_25;
using Unity;
using Unity.Lifetime;

public static class ContainerConfig
{
    private static IUnityContainer _container;

    public static IUnityContainer GetContainer()
    {
        if (_container == null)
        {
            _container = new UnityContainer();
            _container.RegisterType<ICategoryRepository, CategoryRepositoryStub>(new SingletonLifetimeManager());
            _container.RegisterType<ISupplierRepository, SupplierRepositoryStub>(new SingletonLifetimeManager());
            _container.RegisterType<IProductRepository, ProductRepositoryStub>(new SingletonLifetimeManager());
            _container.RegisterType<IProductBatchRepository, ProductBatchRepositoryStub>(new SingletonLifetimeManager());
            _container.RegisterType<ISaleRepository, SaleRepositoryStub>(new SingletonLifetimeManager());
            _container.RegisterType<IReplenishmentRequestRepository, ReplenishmentRequestRepositoryStub>(new SingletonLifetimeManager());

            _container.RegisterType<MainForm>();
            _container.RegisterType<CategoryListForm>();
            _container.RegisterType<SupplierListForm>();
            _container.RegisterType<ProductListForm>();
            _container.RegisterType<ProductBatchForm>();
            _container.RegisterType<ReplenishmentRequestForm>();
            _container.RegisterType<SaleForm>();
        }
        return _container;
    }
}
