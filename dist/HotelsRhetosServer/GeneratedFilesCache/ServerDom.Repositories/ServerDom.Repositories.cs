// Reference: C:\GIT\Hotels\dist\HotelsRhetosServer\bin\Autofac.dll
// Reference: C:\GIT\Hotels\dist\HotelsRhetosServer\bin\Rhetos.Extensibility.Interfaces.dll
// Reference: C:\GIT\Hotels\dist\HotelsRhetosServer\bin\Rhetos.Utilities.dll
// Reference: C:\GIT\Hotels\dist\HotelsRhetosServer\bin\Rhetos.Security.Interfaces.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.ComponentModel.Composition\v4.0_4.0.0.0__b77a5c561934e089\System.ComponentModel.Composition.dll
// Reference: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
// Reference: C:\GIT\Hotels\dist\HotelsRhetosServer\bin\Plugins\Rhetos.Dom.DefaultConcepts.dll
// Reference: C:\GIT\Hotels\dist\HotelsRhetosServer\bin\Rhetos.Logging.Interfaces.dll
// Reference: C:\GIT\Hotels\dist\HotelsRhetosServer\bin\EntityFramework.dll
// Reference: C:\GIT\Hotels\dist\HotelsRhetosServer\bin\EntityFramework.SqlServer.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_64\System.Data\v4.0_4.0.0.0__b77a5c561934e089\System.Data.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll
// Reference: C:\GIT\Hotels\dist\HotelsRhetosServer\bin\Rhetos.Persistence.Interfaces.dll
// Reference: C:\GIT\Hotels\dist\HotelsRhetosServer\bin\Plugins\Rhetos.Processing.DefaultCommands.Interfaces.dll
// Reference: C:\GIT\Hotels\dist\HotelsRhetosServer\bin\Rhetos.Processing.Interfaces.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Core\v4.0_4.0.0.0__b77a5c561934e089\System.Core.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\Microsoft.CSharp\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.CSharp.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Data.DataSetExtensions\v4.0_4.0.0.0__b77a5c561934e089\System.Data.DataSetExtensions.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Xml\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Xml.Linq\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.Linq.dll
// Reference: C:\GIT\Hotels\dist\HotelsRhetosServer\bin\Plugins\Rhetos.Dom.DefaultConcepts.Interfaces.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Serialization\v4.0_4.0.0.0__b77a5c561934e089\System.Runtime.Serialization.dll
// Reference: C:\GIT\Hotels\dist\HotelsRhetosServer\bin\Generated\ServerDom.Model.dll
// Reference: C:\GIT\Hotels\dist\HotelsRhetosServer\bin\Generated\ServerDom.Orm.dll
// CompilerOptions: "/optimize"

namespace Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;
    using Autofac;
    /*CommonUsing*/

    public class DomRepository
    {
        private readonly Rhetos.Extensibility.INamedPlugins<IRepository> _repositories;

        public DomRepository(Rhetos.Extensibility.INamedPlugins<IRepository> repositories)
        {
            _repositories = repositories;
        }

        private Hotels._Helper._ModuleRepository _Hotels;
        public Hotels._Helper._ModuleRepository Hotels { get { return _Hotels ?? (_Hotels = new Hotels._Helper._ModuleRepository(_repositories)); } }

        private Common._Helper._ModuleRepository _Common;
        public Common._Helper._ModuleRepository Common { get { return _Common ?? (_Common = new Common._Helper._ModuleRepository(_repositories)); } }

        /*CommonDomRepositoryMembers*/
    }

    public static class Infrastructure
    {
        public static readonly RegisteredInterfaceImplementations RegisteredInterfaceImplementationName = new RegisteredInterfaceImplementations
        {
            { typeof(Rhetos.Dom.DefaultConcepts.ICommonFilterId), @"Common.FilterId" },
            { typeof(Rhetos.Dom.DefaultConcepts.IKeepSynchronizedMetadata), @"Common.KeepSynchronizedMetadata" },
            { typeof(Rhetos.Dom.DefaultConcepts.ICommonClaim), @"Common.Claim" },
            { typeof(Rhetos.Dom.DefaultConcepts.IPrincipal), @"Common.Principal" },
            { typeof(Rhetos.Dom.DefaultConcepts.IPrincipalHasRole), @"Common.PrincipalHasRole" },
            { typeof(Rhetos.Dom.DefaultConcepts.IRole), @"Common.Role" },
            { typeof(Rhetos.Dom.DefaultConcepts.IRoleInheritsRole), @"Common.RoleInheritsRole" },
            { typeof(Rhetos.Dom.DefaultConcepts.IPrincipalPermission), @"Common.PrincipalPermission" },
            { typeof(Rhetos.Dom.DefaultConcepts.IRolePermission), @"Common.RolePermission" },
            /*RegisteredInterfaceImplementationName*/
        };

        public static readonly ApplyFiltersOnClientRead ApplyFiltersOnClientRead = new ApplyFiltersOnClientRead
        {
            /*ApplyFiltersOnClientRead*/
        };

        public static readonly CurrentKeepSynchronizedMetadata CurrentKeepSynchronizedMetadata = new CurrentKeepSynchronizedMetadata
        {
            /*AddKeepSynchronizedMetadata*/
        };

        /*CommonInfrastructureMembers*/
    }

    public class ExecutionContext
    {
        protected Lazy<Rhetos.Persistence.IPersistenceTransaction> _persistenceTransaction;
        public Rhetos.Persistence.IPersistenceTransaction PersistenceTransaction { get { return _persistenceTransaction.Value; } }

        protected Lazy<Rhetos.Utilities.IUserInfo> _userInfo;
        public Rhetos.Utilities.IUserInfo UserInfo { get { return _userInfo.Value; } }

        protected Lazy<Rhetos.Utilities.ISqlExecuter> _sqlExecuter;
        public Rhetos.Utilities.ISqlExecuter SqlExecuter { get { return _sqlExecuter.Value; } }

        protected Lazy<Rhetos.Security.IAuthorizationManager> _authorizationManager;
        public Rhetos.Security.IAuthorizationManager AuthorizationManager { get { return _authorizationManager.Value; } }

        protected Lazy<Rhetos.Dom.DefaultConcepts.GenericRepositories> _genericRepositories;
        public Rhetos.Dom.DefaultConcepts.GenericRepositories GenericRepositories { get { return _genericRepositories.Value; } }

        public Rhetos.Dom.DefaultConcepts.GenericRepository<TEntity> GenericRepository<TEntity>() where TEntity : class, IEntity
        {
            return GenericRepositories.GetGenericRepository<TEntity>();
        }

        public Rhetos.Dom.DefaultConcepts.GenericRepository<TEntity> GenericRepository<TEntity>(string entityName) where TEntity : class, IEntity
        {
            return GenericRepositories.GetGenericRepository<TEntity>(entityName);
        }

        public Rhetos.Dom.DefaultConcepts.GenericRepository<IEntity> GenericRepository(string entityName)
        {
            return GenericRepositories.GetGenericRepository(entityName);
        }

        protected Lazy<Common.DomRepository> _repository;
        public Common.DomRepository Repository { get { return _repository.Value; } }

        public Rhetos.Logging.ILogProvider LogProvider { get; private set; }

        protected Lazy<Rhetos.Security.IWindowsSecurity> _windowsSecurity;
        public Rhetos.Security.IWindowsSecurity WindowsSecurity { get { return _windowsSecurity.Value; } }

        public EntityFrameworkContext EntityFrameworkContext { get; private set; }

        /*ExecutionContextMember*/

        // This constructor is used for automatic parameter injection with autofac.
        public ExecutionContext(
            Lazy<Rhetos.Persistence.IPersistenceTransaction> persistenceTransaction,
            Lazy<Rhetos.Utilities.IUserInfo> userInfo,
            Lazy<Rhetos.Utilities.ISqlExecuter> sqlExecuter,
            Lazy<Rhetos.Security.IAuthorizationManager> authorizationManager,
            Lazy<Rhetos.Dom.DefaultConcepts.GenericRepositories> genericRepositories,
            Lazy<Common.DomRepository> repository,
            Rhetos.Logging.ILogProvider logProvider,
            Lazy<Rhetos.Security.IWindowsSecurity> windowsSecurity/*ExecutionContextConstructorArgument*/,
            EntityFrameworkContext entityFrameworkContext)
        {
            _persistenceTransaction = persistenceTransaction;
            _userInfo = userInfo;
            _sqlExecuter = sqlExecuter;
            _authorizationManager = authorizationManager;
            _genericRepositories = genericRepositories;
            _repository = repository;
            LogProvider = logProvider;
            _windowsSecurity = windowsSecurity;
            EntityFrameworkContext = entityFrameworkContext;
            /*ExecutionContextConstructorAssignment*/
        }

        // This constructor is used for manual context creation (unit testing)
        public ExecutionContext()
        {
        }
    }

    [System.ComponentModel.Composition.Export(typeof(Autofac.Module))]
    public class AutofacModuleConfiguration : Autofac.Module
    {
        protected override void Load(Autofac.ContainerBuilder builder)
        {
            builder.RegisterType<DomRepository>().InstancePerLifetimeScope();
            builder.RegisterType<EntityFrameworkConfiguration>().SingleInstance();
            builder.RegisterType<EntityFrameworkContext>()
                .As<EntityFrameworkContext>()
                .As<System.Data.Entity.DbContext>()
                .As<Rhetos.Persistence.IPersistenceCache>()
                .InstancePerLifetimeScope();
            builder.RegisterType<ExecutionContext>().InstancePerLifetimeScope();
            builder.RegisterInstance(Infrastructure.RegisteredInterfaceImplementationName).ExternallyOwned();
            builder.RegisterInstance(Infrastructure.ApplyFiltersOnClientRead).ExternallyOwned();
            builder.RegisterInstance(Infrastructure.CurrentKeepSynchronizedMetadata).ExternallyOwned();
            builder.RegisterType<Hotels._Helper.Hotel_Repository>().Keyed<IRepository>("Hotels.Hotel").InstancePerLifetimeScope();
            builder.RegisterType<Hotels._Helper.Guest_Repository>().Keyed<IRepository>("Hotels.Guest").InstancePerLifetimeScope();
            builder.RegisterType<Hotels._Helper.RoomKind_Repository>().Keyed<IRepository>("Hotels.RoomKind").InstancePerLifetimeScope();
            builder.RegisterType<Hotels._Helper.Room_Repository>().Keyed<IRepository>("Hotels.Room").InstancePerLifetimeScope();
            builder.RegisterType<Hotels._Helper.Good_Repository>().Keyed<IRepository>("Hotels.Good").InstancePerLifetimeScope();
            builder.RegisterType<Hotels._Helper.GoodKind_Repository>().Keyed<IRepository>("Hotels.GoodKind").InstancePerLifetimeScope();
            builder.RegisterType<Hotels._Helper.Service_Repository>().Keyed<IRepository>("Hotels.Service").InstancePerLifetimeScope();
            builder.RegisterType<Hotels._Helper.Product_Repository>().Keyed<IRepository>("Hotels.Product").InstancePerLifetimeScope();
            builder.RegisterType<Hotels._Helper.Reservation_Repository>().Keyed<IRepository>("Hotels.Reservation").InstancePerLifetimeScope();
            builder.RegisterType<Hotels._Helper.Invoice_Repository>().Keyed<IRepository>("Hotels.Invoice").InstancePerLifetimeScope();
            builder.RegisterType<Hotels._Helper.Item_Repository>().Keyed<IRepository>("Hotels.Item").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.AutoCodeCache_Repository>().Keyed<IRepository>("Common.AutoCodeCache").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.FilterId_Repository>().Keyed<IRepository>("Common.FilterId").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.KeepSynchronizedMetadata_Repository>().Keyed<IRepository>("Common.KeepSynchronizedMetadata").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.ExclusiveLock_Repository>().Keyed<IRepository>("Common.ExclusiveLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.SetLock_Repository>().Keyed<IRepository>("Common.SetLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.SetLock_Repository>().Keyed<IActionRepository>("Common.SetLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.ReleaseLock_Repository>().Keyed<IRepository>("Common.ReleaseLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.ReleaseLock_Repository>().Keyed<IActionRepository>("Common.ReleaseLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.LogReader_Repository>().Keyed<IRepository>("Common.LogReader").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.LogRelatedItemReader_Repository>().Keyed<IRepository>("Common.LogRelatedItemReader").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Log_Repository>().Keyed<IRepository>("Common.Log").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.AddToLog_Repository>().Keyed<IRepository>("Common.AddToLog").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.AddToLog_Repository>().Keyed<IActionRepository>("Common.AddToLog").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.LogRelatedItem_Repository>().Keyed<IRepository>("Common.LogRelatedItem").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RelatedEventsSource_Repository>().Keyed<IRepository>("Common.RelatedEventsSource").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Claim_Repository>().Keyed<IRepository>("Common.Claim").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.MyClaim_Repository>().Keyed<IRepository>("Common.MyClaim").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Principal_Repository>().Keyed<IRepository>("Common.Principal").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.PrincipalHasRole_Repository>().Keyed<IRepository>("Common.PrincipalHasRole").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Role_Repository>().Keyed<IRepository>("Common.Role").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RoleInheritsRole_Repository>().Keyed<IRepository>("Common.RoleInheritsRole").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.PrincipalPermission_Repository>().Keyed<IRepository>("Common.PrincipalPermission").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RolePermission_Repository>().Keyed<IRepository>("Common.RolePermission").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.FilterId_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.ICommonFilterId>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.KeepSynchronizedMetadata_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IKeepSynchronizedMetadata>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Claim_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.ICommonClaim>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Principal_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IPrincipal>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.PrincipalHasRole_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IPrincipalHasRole>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Role_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IRole>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RoleInheritsRole_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IRoleInheritsRole>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.PrincipalPermission_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IPrincipalPermission>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RolePermission_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IRolePermission>>().InstancePerLifetimeScope();
            /*CommonAutofacConfigurationMembers*/

            base.Load(builder);
        }
    }

    public abstract class RepositoryBase : IRepository
    {
        protected Common.DomRepository _domRepository;
        protected Common.ExecutionContext _executionContext;
    }

    public abstract class ReadableRepositoryBase<TEntity> : RepositoryBase, IReadableRepository<TEntity>
        where TEntity : class, IEntity
    {
        public IEnumerable<TEntity> Load(object parameter, Type parameterType)
        {
            var items = _executionContext.GenericRepository(typeof(TEntity).FullName)
                .Load(parameter, parameterType);
            return (IEnumerable<TEntity>)items;
        }

        public IEnumerable<TEntity> Read(object parameter, Type parameterType, bool preferQuery)
        {
            var items = _executionContext.GenericRepository(typeof(TEntity).FullName)
                .Read(parameter, parameterType, preferQuery);
            return (IEnumerable<TEntity>)items;
        }

        [Obsolete("Use Load() or Query() method.")]
        public abstract TEntity[] All();

        [Obsolete("Use Load() or Query() method.")]
        public TEntity[] Filter(FilterAll filterAll)
        {
            return All();
        }
    }

    public abstract class QueryableRepositoryBase<TQueryableEntity, TEntity> : ReadableRepositoryBase<TEntity>, IQueryableRepository<TQueryableEntity, TEntity>
        where TEntity : class, IEntity
        where TQueryableEntity : class, IEntity, TEntity, IQueryableEntity<TEntity>
    {
        [Obsolete("Use Load(identifiers) or Query(identifiers) method.")]
        public TEntity[] Filter(IEnumerable<Guid> identifiers)
        {
            const int BufferSize = 500; // EF 6.1.3 LINQ query has O(n^2) time complexity. Batch size of 500 results with optimal total time on the test system.
            int n = identifiers.Count();
            var result = new List<TEntity>(n);
            for (int i = 0; i < (n + BufferSize - 1) / BufferSize; i++)
            {
                Guid[] idBuffer = identifiers.Skip(i * BufferSize).Take(BufferSize).ToArray();
                List<TEntity> itemBuffer;
                if (idBuffer.Count() == 1) // EF 6.1.3. does not use parametrized SQL query for Contains() function. The equality comparer is used instead, to reuse cached execution plans.
                {
                    Guid id = idBuffer.Single();
                    itemBuffer = Query().Where(item => item.ID == id).GenericToSimple<TEntity>().ToList();
                }
                else
                    itemBuffer = Query().Where(item => idBuffer.Contains(item.ID)).GenericToSimple<TEntity>().ToList();
                result.AddRange(itemBuffer);
            }
            return result.ToArray();
        }

        public abstract IQueryable<TQueryableEntity> Query();

        // LINQ to Entity does not support Query() method in subqueries.
        public IQueryable<TQueryableEntity> Subquery { get { return Query(); } }

        public IQueryable<TQueryableEntity> Query(object parameter, Type parameterType)
        {
            var query = _executionContext.GenericRepository(typeof(TEntity).FullName).Query(parameter, parameterType);
            return (IQueryable<TQueryableEntity>)query;
        }
    }

    public abstract class OrmRepositoryBase<TQueryableEntity, TEntity> : QueryableRepositoryBase<TQueryableEntity, TEntity>
        where TEntity : class, IEntity
        where TQueryableEntity : class, IEntity, TEntity, IQueryableEntity<TEntity>
    {
        public IQueryable<TQueryableEntity> Filter(IQueryable<TQueryableEntity> items, IEnumerable<Guid> ids)
        {
            if (!(ids is System.Collections.IList))
                ids = ids.ToList();

            if (ids.Count() == 1) // EF 6.1.3. does not use parametrized SQL query for Contains() function. The equality comparer is used instead, to reuse cached execution plans.
            {
                Guid id = ids.Single();
                return items.Where(item => item.ID == id);
            }
            else
            {
                // Depending on the ids count, this method will return the list of IDs, or insert the ids to the database and return an SQL query that selects the ids.
                var idsQuery = _domRepository.Common.FilterId.CreateQueryableFilterIds(ids);
                return items.Where(item => idsQuery.Contains(item.ID));
            }
        }
    }

    internal class DontTrackHistory<T> : List<T>
    {
    }
    /*CommonNamespaceMembers*/
}

namespace Hotels._Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*ModuleInfo Using Hotels*/

    public class _ModuleRepository
    {
        private readonly Rhetos.Extensibility.INamedPlugins<IRepository> _repositories;

        public _ModuleRepository(Rhetos.Extensibility.INamedPlugins<IRepository> repositories)
        {
            _repositories = repositories;
        }

        private Hotel_Repository _Hotel_Repository;
        public Hotel_Repository Hotel { get { return _Hotel_Repository ?? (_Hotel_Repository = (Hotel_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Hotels.Hotel")); } }

        private Guest_Repository _Guest_Repository;
        public Guest_Repository Guest { get { return _Guest_Repository ?? (_Guest_Repository = (Guest_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Hotels.Guest")); } }

        private RoomKind_Repository _RoomKind_Repository;
        public RoomKind_Repository RoomKind { get { return _RoomKind_Repository ?? (_RoomKind_Repository = (RoomKind_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Hotels.RoomKind")); } }

        private Room_Repository _Room_Repository;
        public Room_Repository Room { get { return _Room_Repository ?? (_Room_Repository = (Room_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Hotels.Room")); } }

        private Good_Repository _Good_Repository;
        public Good_Repository Good { get { return _Good_Repository ?? (_Good_Repository = (Good_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Hotels.Good")); } }

        private GoodKind_Repository _GoodKind_Repository;
        public GoodKind_Repository GoodKind { get { return _GoodKind_Repository ?? (_GoodKind_Repository = (GoodKind_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Hotels.GoodKind")); } }

        private Service_Repository _Service_Repository;
        public Service_Repository Service { get { return _Service_Repository ?? (_Service_Repository = (Service_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Hotels.Service")); } }

        private Product_Repository _Product_Repository;
        public Product_Repository Product { get { return _Product_Repository ?? (_Product_Repository = (Product_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Hotels.Product")); } }

        private Reservation_Repository _Reservation_Repository;
        public Reservation_Repository Reservation { get { return _Reservation_Repository ?? (_Reservation_Repository = (Reservation_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Hotels.Reservation")); } }

        private Invoice_Repository _Invoice_Repository;
        public Invoice_Repository Invoice { get { return _Invoice_Repository ?? (_Invoice_Repository = (Invoice_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Hotels.Invoice")); } }

        private Item_Repository _Item_Repository;
        public Item_Repository Item { get { return _Item_Repository ?? (_Item_Repository = (Item_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Hotels.Item")); } }

        /*ModuleInfo RepositoryMembers Hotels*/
    }

    /*DataStructureInfo RepositoryAttributes Hotels.Hotel*/
    public class Hotel_Repository : /*DataStructureInfo OverrideBaseType Hotels.Hotel*/ Common.OrmRepositoryBase<Common.Queryable.Hotels_Hotel, Hotels.Hotel> // Common.QueryableRepositoryBase<Common.Queryable.Hotels_Hotel, Hotels.Hotel> // Common.ReadableRepositoryBase<Hotels.Hotel> // global::Common.RepositoryBase
        , IWritableRepository<Hotels.Hotel>, IValidateRepository/*DataStructureInfo RepositoryInterface Hotels.Hotel*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Hotels.Hotel*/

        public Hotel_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Hotels.Hotel*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Hotels.Hotel*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Hotels.Hotel[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Hotels_Hotel> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Hotels.Hotel*/
            return _executionContext.EntityFrameworkContext.Hotels_Hotel.AsNoTracking();
        }

        public void Save(IEnumerable<Hotels.Hotel> insertedNew, IEnumerable<Hotels.Hotel> updatedNew, IEnumerable<Hotels.Hotel> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Hotels.Hotel*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Name != null && newItem.Name.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Hotel.Name", "256" },
                        "DataStructure:Hotels.Hotel,ID:" + invalidItem.ID.ToString() + ",Property:Name",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Address != null && newItem.Address.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Hotel.Address", "256" },
                        "DataStructure:Hotels.Hotel,ID:" + invalidItem.ID.ToString() + ",Property:Address",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Hotels.Hotel*/

            /*DataStructureInfo WritableOrm Initialization Hotels.Hotel*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Hotels_Hotel> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_Hotel>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Hotels_Hotel> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_Hotel>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            if (updatedNew.Count() > 0 || deletedIds.Count() > 0)
            {
                Hotels.Hotel[] changedItems = updated.Concat(deleted).ToArray();

                var lockedItems = _domRepository.Hotels.Hotel.Filter(this.Query(changedItems.Select(item => item.ID)), new ContainsLockMark());
                if (lockedItems.Count() > 0)
                    throw new Rhetos.UserException(@"[Test] Name contains lock mark.", "DataStructure:Hotels.Hotel,ID:" + lockedItems.First().ID.ToString()/*LockItemsInfo ClientMessage Hotels.Hotel.ContainsLockMark*/);
            }
            if (deletedIds.Count() > 0)
            {
                List<Hotels.Room> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Hotels.Room.Query()
                        .Where(child => child.HotelID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Hotels.Room { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Hotels.Room.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Hotels.Hotel*/

            /*DataStructureInfo WritableOrm ProcessedOldData Hotels.Hotel*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Hotels_Hotel.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Hotels.Room", @"HotelID", @"FK_Room_Hotel_HotelID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Room,Property:HotelID,Referenced:Hotels.Hotel";
                /*DataStructureInfo WritableOrm OnDatabaseError Hotels.Hotel*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Hotels.Hotel");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Hotels_Hotel> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Hotels.Hotel*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Hotels.Hotel*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Hotels.Hotel");

                /*DataStructureInfo WritableOrm AfterSave Hotels.Hotel*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Hotels.Hotel*/
            yield break;
        }

        public IQueryable<Common.Queryable.Hotels_Hotel> Filter(IQueryable<Common.Queryable.Hotels_Hotel> localSource, Hotels.ContainsLockMark localParameter)
        {
            Func<IQueryable<Common.Queryable.Hotels_Hotel>, Common.DomRepository, Hotels.ContainsLockMark/*ComposableFilterByInfo AdditionalParametersType Hotels.Hotel.'Hotels.ContainsLockMark'*/, IQueryable<Common.Queryable.Hotels_Hotel>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Name.Contains("lock"));

            /*ComposableFilterByInfo BeforeFilter Hotels.Hotel.'Hotels.ContainsLockMark'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Hotels.Hotel.'Hotels.ContainsLockMark'*/);
        }

        public global::Hotels.Hotel[] Filter(Hotels.ContainsLockMark filter_Parameter)
        {
            Func<Common.DomRepository, Hotels.ContainsLockMark/*FilterByInfo AdditionalParametersType Hotels.Hotel.'Hotels.ContainsLockMark'*/, Hotels.Hotel[]> filter_Function =
                (repository, parameter) => repository.Hotels.Hotel.Filter(repository.Hotels.Hotel.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Hotels.Hotel.'Hotels.ContainsLockMark'*/);
        }

        /*DataStructureInfo RepositoryMembers Hotels.Hotel*/
    }

    /*DataStructureInfo RepositoryAttributes Hotels.Guest*/
    public class Guest_Repository : /*DataStructureInfo OverrideBaseType Hotels.Guest*/ Common.OrmRepositoryBase<Common.Queryable.Hotels_Guest, Hotels.Guest> // Common.QueryableRepositoryBase<Common.Queryable.Hotels_Guest, Hotels.Guest> // Common.ReadableRepositoryBase<Hotels.Guest> // global::Common.RepositoryBase
        , IWritableRepository<Hotels.Guest>, IValidateRepository/*DataStructureInfo RepositoryInterface Hotels.Guest*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Hotels.Guest*/

        public Guest_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Hotels.Guest*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Hotels.Guest*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Hotels.Guest[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Hotels_Guest> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Hotels.Guest*/
            return _executionContext.EntityFrameworkContext.Hotels_Guest.AsNoTracking();
        }

        public void Save(IEnumerable<Hotels.Guest> insertedNew, IEnumerable<Hotels.Guest> updatedNew, IEnumerable<Hotels.Guest> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Hotels.Guest*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Name != null && newItem.Name.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Guest.Name", "256" },
                        "DataStructure:Hotels.Guest,ID:" + invalidItem.ID.ToString() + ",Property:Name",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Surname != null && newItem.Surname.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Guest.Surname", "256" },
                        "DataStructure:Hotels.Guest,ID:" + invalidItem.ID.ToString() + ",Property:Surname",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Phone != null && newItem.Phone.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Guest.Phone", "256" },
                        "DataStructure:Hotels.Guest,ID:" + invalidItem.ID.ToString() + ",Property:Phone",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Email != null && newItem.Email.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Guest.Email", "256" },
                        "DataStructure:Hotels.Guest,ID:" + invalidItem.ID.ToString() + ",Property:Email",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Hotels.Guest*/

            /*DataStructureInfo WritableOrm Initialization Hotels.Guest*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Hotels_Guest> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_Guest>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Hotels_Guest> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_Guest>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Hotels.Guest*/

            /*DataStructureInfo WritableOrm ProcessedOldData Hotels.Guest*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Hotels_Guest.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Hotels.Reservation", @"GuestID", @"FK_Reservation_Guest_GuestID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Reservation,Property:GuestID,Referenced:Hotels.Guest";
                /*DataStructureInfo WritableOrm OnDatabaseError Hotels.Guest*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Hotels.Guest");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Hotels_Guest> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Hotels.Guest*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Hotels.Guest*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Hotels.Guest");

                /*DataStructureInfo WritableOrm AfterSave Hotels.Guest*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new Hotels.Email_RegExMatchFilter()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_Email_RegExMatchFilter(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Hotels.Guest*/
            yield break;
        }

        public IQueryable<Common.Queryable.Hotels_Guest> Filter(IQueryable<Common.Queryable.Hotels_Guest> localSource, Hotels.Email_RegExMatchFilter localParameter)
        {
            Func<IQueryable<Common.Queryable.Hotels_Guest>, Common.DomRepository, Hotels.Email_RegExMatchFilter/*ComposableFilterByInfo AdditionalParametersType Hotels.Guest.'Hotels.Email_RegExMatchFilter'*/, IQueryable<Common.Queryable.Hotels_Guest>> filterFunction =
            (source, repository, parameter) =>
                {
                    var items = source.Where(item => !string.IsNullOrEmpty(item.Email)).Select(item => new { item.ID, item.Email }).ToList();
                    var regex = new System.Text.RegularExpressions.Regex(@"^(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*)@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])$");
                    var invalidItemIds = items.Where(item => !regex.IsMatch(item.Email)).Select(item => item.ID).ToList();
                    return Filter(source, invalidItemIds);
                };

            /*ComposableFilterByInfo BeforeFilter Hotels.Guest.'Hotels.Email_RegExMatchFilter'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Hotels.Guest.'Hotels.Email_RegExMatchFilter'*/);
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_Email_RegExMatchFilter(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"Neispravna e-mail adresa.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"Hotels.Email_RegExMatchFilter";
            metadata[@"Property"] = @"Email";
            /*InvalidDataInfo ErrorMetadata Hotels.Guest.'Hotels.Email_RegExMatchFilter'*/
            /*InvalidDataInfo OverrideUserMessages Hotels.Guest.'Hotels.Email_RegExMatchFilter'*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public global::Hotels.Guest[] Filter(Hotels.Email_RegExMatchFilter filter_Parameter)
        {
            Func<Common.DomRepository, Hotels.Email_RegExMatchFilter/*FilterByInfo AdditionalParametersType Hotels.Guest.'Hotels.Email_RegExMatchFilter'*/, Hotels.Guest[]> filter_Function =
                (repository, parameter) => repository.Hotels.Guest.Filter(repository.Hotels.Guest.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Hotels.Guest.'Hotels.Email_RegExMatchFilter'*/);
        }

        /*DataStructureInfo RepositoryMembers Hotels.Guest*/
    }

    /*DataStructureInfo RepositoryAttributes Hotels.RoomKind*/
    public class RoomKind_Repository : /*DataStructureInfo OverrideBaseType Hotels.RoomKind*/ Common.OrmRepositoryBase<Common.Queryable.Hotels_RoomKind, Hotels.RoomKind> // Common.QueryableRepositoryBase<Common.Queryable.Hotels_RoomKind, Hotels.RoomKind> // Common.ReadableRepositoryBase<Hotels.RoomKind> // global::Common.RepositoryBase
        , IWritableRepository<Hotels.RoomKind>, IValidateRepository/*DataStructureInfo RepositoryInterface Hotels.RoomKind*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Hotels.RoomKind*/

        public RoomKind_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Hotels.RoomKind*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Hotels.RoomKind*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Hotels.RoomKind[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Hotels_RoomKind> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Hotels.RoomKind*/
            return _executionContext.EntityFrameworkContext.Hotels_RoomKind.AsNoTracking();
        }

        public void Save(IEnumerable<Hotels.RoomKind> insertedNew, IEnumerable<Hotels.RoomKind> updatedNew, IEnumerable<Hotels.RoomKind> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Hotels.RoomKind*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Name != null && newItem.Name.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "RoomKind.Name", "256" },
                        "DataStructure:Hotels.RoomKind,ID:" + invalidItem.ID.ToString() + ",Property:Name",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Hotels.RoomKind*/

            /*DataStructureInfo WritableOrm Initialization Hotels.RoomKind*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Hotels_RoomKind> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_RoomKind>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Hotels_RoomKind> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_RoomKind>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Hotels.RoomKind*/

            /*DataStructureInfo WritableOrm ProcessedOldData Hotels.RoomKind*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Hotels_RoomKind.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Hotels.Room", @"RoomKindID", @"FK_Room_RoomKind_RoomKindID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Room,Property:RoomKindID,Referenced:Hotels.RoomKind";
                /*DataStructureInfo WritableOrm OnDatabaseError Hotels.RoomKind*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Hotels.RoomKind");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Hotels_RoomKind> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Hotels.RoomKind*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Hotels.RoomKind*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Hotels.RoomKind");

                /*DataStructureInfo WritableOrm AfterSave Hotels.RoomKind*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Hotels.RoomKind*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Hotels.RoomKind*/
    }

    /*DataStructureInfo RepositoryAttributes Hotels.Room*/
    public class Room_Repository : /*DataStructureInfo OverrideBaseType Hotels.Room*/ Common.OrmRepositoryBase<Common.Queryable.Hotels_Room, Hotels.Room> // Common.QueryableRepositoryBase<Common.Queryable.Hotels_Room, Hotels.Room> // Common.ReadableRepositoryBase<Hotels.Room> // global::Common.RepositoryBase
        , IWritableRepository<Hotels.Room>, IValidateRepository/*DataStructureInfo RepositoryInterface Hotels.Room*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Hotels.Room*/

        public Room_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Hotels.Room*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Hotels.Room*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Hotels.Room[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Hotels_Room> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Hotels.Room*/
            return _executionContext.EntityFrameworkContext.Hotels_Room.AsNoTracking();
        }

        public void Save(IEnumerable<Hotels.Room> insertedNew, IEnumerable<Hotels.Room> updatedNew, IEnumerable<Hotels.Room> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Hotels.Room*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.RoomNumber != null && newItem.RoomNumber.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Room.RoomNumber", "256" },
                        "DataStructure:Hotels.Room,ID:" + invalidItem.ID.ToString() + ",Property:RoomNumber",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Hotels.Room*/

            /*DataStructureInfo WritableOrm Initialization Hotels.Room*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Hotels_Room> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_Room>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Hotels_Room> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_Room>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Hotels.Room*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.RoomNumber == null || string.IsNullOrWhiteSpace(item.RoomNumber) /*RequiredPropertyInfo OrCondition Hotels.Room.RoomNumber*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Hotels.Room", "RoomNumber" },
                        "DataStructure:Hotels.Room,ID:" + invalid.ID.ToString() + ",Property:RoomNumber", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.RoomKindID == null /*RequiredPropertyInfo OrCondition Hotels.Room.RoomKind*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Hotels.Room", "RoomKind" },
                        "DataStructure:Hotels.Room,ID:" + invalid.ID.ToString() + ",Property:RoomKindID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Hotels.Room*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Hotels_Room.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Hotels.Hotel", @"ID", @"FK_Room_Hotel_HotelID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Room,Property:HotelID,Referenced:Hotels.Hotel";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Hotels.RoomKind", @"ID", @"FK_Room_RoomKind_RoomKindID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Room,Property:RoomKindID,Referenced:Hotels.RoomKind";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Hotels.Room", @"IX_Room_Hotel_RoomKind"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Room,Property:Hotel RoomKind";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Hotels.Reservation", @"RoomID", @"FK_Reservation_Room_RoomID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Reservation,Property:RoomID,Referenced:Hotels.Room";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Hotels.Room", @"IX_Room_RoomNumber"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Room,Property:RoomNumber";
                /*DataStructureInfo WritableOrm OnDatabaseError Hotels.Room*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Hotels.Room");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Hotels_Room> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Hotels.Room*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Hotels.Room*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Hotels.Room");

                /*DataStructureInfo WritableOrm AfterSave Hotels.Room*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new RoomNumber_MaxLengthFilter()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_RoomNumber__MaxLengthFilter(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new RoomNumber_MinLengthFilter()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_RoomNumber__MinLengthFilter(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredHotel()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredHotel(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Hotels.Room*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_RoomNumber__MaxLengthFilter(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"Maximum allowed length of {0} is {1} characters.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"RoomNumber_MaxLengthFilter";
            metadata[@"Property"] = @"RoomNumber";
            /*InvalidDataInfo ErrorMetadata Hotels.Room.RoomNumber_MaxLengthFilter*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"RoomNumber", 5 },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Hotels.Room.RoomNumber_MaxLengthFilter*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_RoomNumber__MinLengthFilter(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"Minimum allowed length of {0} is {1} characters.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"RoomNumber_MinLengthFilter";
            metadata[@"Property"] = @"RoomNumber";
            /*InvalidDataInfo ErrorMetadata Hotels.Room.RoomNumber_MinLengthFilter*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"RoomNumber", 1 },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Hotels.Room.RoomNumber_MinLengthFilter*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredHotel(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredHotel";
            metadata[@"Property"] = @"Hotel";
            /*InvalidDataInfo ErrorMetadata Hotels.Room.SystemRequiredHotel*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Hotels.Room.Hotel" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Hotels.Room.SystemRequiredHotel*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Hotels_Room> Filter(IQueryable<Common.Queryable.Hotels_Room> localSource, Hotels.RoomNumber_MaxLengthFilter localParameter)
        {
            Func<IQueryable<Common.Queryable.Hotels_Room>, Common.DomRepository, Hotels.RoomNumber_MaxLengthFilter/*ComposableFilterByInfo AdditionalParametersType Hotels.Room.'Hotels.RoomNumber_MaxLengthFilter'*/, IQueryable<Common.Queryable.Hotels_Room>> filterFunction =
            (source, repository, parameter) => source.Where(item => !String.IsNullOrEmpty(item.RoomNumber) && item.RoomNumber.Length > 5);

            /*ComposableFilterByInfo BeforeFilter Hotels.Room.'Hotels.RoomNumber_MaxLengthFilter'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Hotels.Room.'Hotels.RoomNumber_MaxLengthFilter'*/);
        }

        public IQueryable<Common.Queryable.Hotels_Room> Filter(IQueryable<Common.Queryable.Hotels_Room> localSource, Hotels.RoomNumber_MinLengthFilter localParameter)
        {
            Func<IQueryable<Common.Queryable.Hotels_Room>, Common.DomRepository, Hotels.RoomNumber_MinLengthFilter/*ComposableFilterByInfo AdditionalParametersType Hotels.Room.'Hotels.RoomNumber_MinLengthFilter'*/, IQueryable<Common.Queryable.Hotels_Room>> filterFunction =
            (source, repository, parameter) => source.Where(item => !String.IsNullOrEmpty(item.RoomNumber) && item.RoomNumber.Length < 1);

            /*ComposableFilterByInfo BeforeFilter Hotels.Room.'Hotels.RoomNumber_MinLengthFilter'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Hotels.Room.'Hotels.RoomNumber_MinLengthFilter'*/);
        }

        public IQueryable<Common.Queryable.Hotels_Room> Filter(IQueryable<Common.Queryable.Hotels_Room> localSource, Hotels.SystemRequiredHotel localParameter)
        {
            Func<IQueryable<Common.Queryable.Hotels_Room>, Common.DomRepository, Hotels.SystemRequiredHotel/*ComposableFilterByInfo AdditionalParametersType Hotels.Room.'Hotels.SystemRequiredHotel'*/, IQueryable<Common.Queryable.Hotels_Room>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Hotel == null);

            /*ComposableFilterByInfo BeforeFilter Hotels.Room.'Hotels.SystemRequiredHotel'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Hotels.Room.'Hotels.SystemRequiredHotel'*/);
        }

        public global::Hotels.Room[] Filter(Hotels.RoomNumber_MaxLengthFilter filter_Parameter)
        {
            Func<Common.DomRepository, Hotels.RoomNumber_MaxLengthFilter/*FilterByInfo AdditionalParametersType Hotels.Room.'Hotels.RoomNumber_MaxLengthFilter'*/, Hotels.Room[]> filter_Function =
                (repository, parameter) => repository.Hotels.Room.Filter(repository.Hotels.Room.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Hotels.Room.'Hotels.RoomNumber_MaxLengthFilter'*/);
        }

        public global::Hotels.Room[] Filter(Hotels.RoomNumber_MinLengthFilter filter_Parameter)
        {
            Func<Common.DomRepository, Hotels.RoomNumber_MinLengthFilter/*FilterByInfo AdditionalParametersType Hotels.Room.'Hotels.RoomNumber_MinLengthFilter'*/, Hotels.Room[]> filter_Function =
                (repository, parameter) => repository.Hotels.Room.Filter(repository.Hotels.Room.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Hotels.Room.'Hotels.RoomNumber_MinLengthFilter'*/);
        }

        public global::Hotels.Room[] Filter(Hotels.SystemRequiredHotel filter_Parameter)
        {
            Func<Common.DomRepository, Hotels.SystemRequiredHotel/*FilterByInfo AdditionalParametersType Hotels.Room.'Hotels.SystemRequiredHotel'*/, Hotels.Room[]> filter_Function =
                (repository, parameter) => repository.Hotels.Room.Filter(repository.Hotels.Room.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Hotels.Room.'Hotels.SystemRequiredHotel'*/);
        }

        /*DataStructureInfo RepositoryMembers Hotels.Room*/
    }

    /*DataStructureInfo RepositoryAttributes Hotels.Good*/
    public class Good_Repository : /*DataStructureInfo OverrideBaseType Hotels.Good*/ Common.OrmRepositoryBase<Common.Queryable.Hotels_Good, Hotels.Good> // Common.QueryableRepositoryBase<Common.Queryable.Hotels_Good, Hotels.Good> // Common.ReadableRepositoryBase<Hotels.Good> // global::Common.RepositoryBase
        , IWritableRepository<Hotels.Good>, IValidateRepository/*DataStructureInfo RepositoryInterface Hotels.Good*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Hotels.Good*/

        public Good_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Hotels.Good*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Hotels.Good*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Hotels.Good[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Hotels_Good> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Hotels.Good*/
            return _executionContext.EntityFrameworkContext.Hotels_Good.AsNoTracking();
        }

        public void Save(IEnumerable<Hotels.Good> insertedNew, IEnumerable<Hotels.Good> updatedNew, IEnumerable<Hotels.Good> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Hotels.Good*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Name != null && newItem.Name.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Good.Name", "256" },
                        "DataStructure:Hotels.Good,ID:" + invalidItem.ID.ToString() + ",Property:Name",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Hotels.Good*/

            /*DataStructureInfo WritableOrm Initialization Hotels.Good*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Hotels_Good> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_Good>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Hotels_Good> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_Good>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            if (deletedIds.Count() > 0)
            {
                List<Hotels.Service> childItems = _executionContext.Repository.Hotels.Service
                    .Query(deletedIds.Select(parent => parent.ID))
                    .Select(child => child.ID).ToList()
                    .Select(childId => new Hotels.Service { ID = childId }).ToList();

                if (childItems.Count() > 0)
                    _domRepository.Hotels.Service.Delete(childItems);
            }

            if (deletedIds.Count() > 0)
            {
                List<Hotels.Product> childItems = _executionContext.Repository.Hotels.Product
                    .Query(deletedIds.Select(parent => parent.ID))
                    .Select(child => child.ID).ToList()
                    .Select(childId => new Hotels.Product { ID = childId }).ToList();

                if (childItems.Count() > 0)
                    _domRepository.Hotels.Product.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Hotels.Good*/

            /*DataStructureInfo WritableOrm ProcessedOldData Hotels.Good*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Hotels_Good.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Hotels.Service", @"ID", @"FK_Service_Good_ID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Service,Property:ID,Referenced:Hotels.Good";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Hotels.Product", @"ID", @"FK_Product_Good_ID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Product,Property:ID,Referenced:Hotels.Good";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Hotels.Item", @"GoodID", @"FK_Item_Good_GoodID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Item,Property:GoodID,Referenced:Hotels.Good";
                /*DataStructureInfo WritableOrm OnDatabaseError Hotels.Good*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Hotels.Good");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Hotels_Good> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Hotels.Good*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Hotels.Good*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Hotels.Good");

                /*DataStructureInfo WritableOrm AfterSave Hotels.Good*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Hotels.Good*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Hotels.Good*/
    }

    /*DataStructureInfo RepositoryAttributes Hotels.GoodKind*/
    public class GoodKind_Repository : /*DataStructureInfo OverrideBaseType Hotels.GoodKind*/ Common.OrmRepositoryBase<Common.Queryable.Hotels_GoodKind, Hotels.GoodKind> // Common.QueryableRepositoryBase<Common.Queryable.Hotels_GoodKind, Hotels.GoodKind> // Common.ReadableRepositoryBase<Hotels.GoodKind> // global::Common.RepositoryBase
        , IWritableRepository<Hotels.GoodKind>, IValidateRepository/*DataStructureInfo RepositoryInterface Hotels.GoodKind*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Hotels.GoodKind*/

        public GoodKind_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Hotels.GoodKind*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Hotels.GoodKind*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Hotels.GoodKind[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Hotels_GoodKind> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Hotels.GoodKind*/
            return _executionContext.EntityFrameworkContext.Hotels_GoodKind.AsNoTracking();
        }

        public void Save(IEnumerable<Hotels.GoodKind> insertedNew, IEnumerable<Hotels.GoodKind> updatedNew, IEnumerable<Hotels.GoodKind> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Hotels.GoodKind*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Name != null && newItem.Name.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "GoodKind.Name", "256" },
                        "DataStructure:Hotels.GoodKind,ID:" + invalidItem.ID.ToString() + ",Property:Name",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Hotels.GoodKind*/

            /*DataStructureInfo WritableOrm Initialization Hotels.GoodKind*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Hotels_GoodKind> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_GoodKind>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Hotels_GoodKind> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_GoodKind>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Hotels.GoodKind*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Name == null || string.IsNullOrWhiteSpace(item.Name) /*RequiredPropertyInfo OrCondition Hotels.GoodKind.Name*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Hotels.GoodKind", "Name" },
                        "DataStructure:Hotels.GoodKind,ID:" + invalid.ID.ToString() + ",Property:Name", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Hotels.GoodKind*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Hotels_GoodKind.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Hotels.Service", @"GoodKindID", @"FK_Service_GoodKind_GoodKindID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Service,Property:GoodKindID,Referenced:Hotels.GoodKind";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Hotels.Product", @"GoodKindID", @"FK_Product_GoodKind_GoodKindID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Product,Property:GoodKindID,Referenced:Hotels.GoodKind";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Hotels.GoodKind", @"IX_GoodKind_Name"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.GoodKind,Property:Name";
                /*DataStructureInfo WritableOrm OnDatabaseError Hotels.GoodKind*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Hotels.GoodKind");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Hotels_GoodKind> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Hotels.GoodKind*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Hotels.GoodKind*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Hotels.GoodKind");

                /*DataStructureInfo WritableOrm AfterSave Hotels.GoodKind*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Hotels.GoodKind*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Hotels.GoodKind*/
    }

    /*DataStructureInfo RepositoryAttributes Hotels.Service*/
    public class Service_Repository : /*DataStructureInfo OverrideBaseType Hotels.Service*/ Common.OrmRepositoryBase<Common.Queryable.Hotels_Service, Hotels.Service> // Common.QueryableRepositoryBase<Common.Queryable.Hotels_Service, Hotels.Service> // Common.ReadableRepositoryBase<Hotels.Service> // global::Common.RepositoryBase
        , IWritableRepository<Hotels.Service>, IValidateRepository/*DataStructureInfo RepositoryInterface Hotels.Service*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Hotels.Service*/

        public Service_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Hotels.Service*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Hotels.Service*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Hotels.Service[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Hotels_Service> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Hotels.Service*/
            return _executionContext.EntityFrameworkContext.Hotels_Service.AsNoTracking();
        }

        public void Save(IEnumerable<Hotels.Service> insertedNew, IEnumerable<Hotels.Service> updatedNew, IEnumerable<Hotels.Service> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Hotels.Service*/

            /*DataStructureInfo WritableOrm ArgumentValidation Hotels.Service*/

            /*DataStructureInfo WritableOrm Initialization Hotels.Service*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Hotels_Service> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_Service>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Hotels_Service> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_Service>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Hotels.Service*/

            /*DataStructureInfo WritableOrm ProcessedOldData Hotels.Service*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Hotels_Service.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Hotels.GoodKind", @"ID", @"FK_Service_GoodKind_GoodKindID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Service,Property:GoodKindID,Referenced:Hotels.GoodKind";
                /*DataStructureInfo WritableOrm OnDatabaseError Hotels.Service*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Hotels.Service");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Hotels_Service> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Hotels.Service*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Hotels.Service*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Hotels.Service");

                /*DataStructureInfo WritableOrm AfterSave Hotels.Service*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Hotels.Service*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Hotels.Service*/
    }

    /*DataStructureInfo RepositoryAttributes Hotels.Product*/
    public class Product_Repository : /*DataStructureInfo OverrideBaseType Hotels.Product*/ Common.OrmRepositoryBase<Common.Queryable.Hotels_Product, Hotels.Product> // Common.QueryableRepositoryBase<Common.Queryable.Hotels_Product, Hotels.Product> // Common.ReadableRepositoryBase<Hotels.Product> // global::Common.RepositoryBase
        , IWritableRepository<Hotels.Product>, IValidateRepository/*DataStructureInfo RepositoryInterface Hotels.Product*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Hotels.Product*/

        public Product_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Hotels.Product*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Hotels.Product*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Hotels.Product[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Hotels_Product> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Hotels.Product*/
            return _executionContext.EntityFrameworkContext.Hotels_Product.AsNoTracking();
        }

        public void Save(IEnumerable<Hotels.Product> insertedNew, IEnumerable<Hotels.Product> updatedNew, IEnumerable<Hotels.Product> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Hotels.Product*/

            /*DataStructureInfo WritableOrm ArgumentValidation Hotels.Product*/

            /*DataStructureInfo WritableOrm Initialization Hotels.Product*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Hotels_Product> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_Product>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Hotels_Product> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_Product>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Hotels.Product*/

            /*DataStructureInfo WritableOrm ProcessedOldData Hotels.Product*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Hotels_Product.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Hotels.GoodKind", @"ID", @"FK_Product_GoodKind_GoodKindID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Product,Property:GoodKindID,Referenced:Hotels.GoodKind";
                /*DataStructureInfo WritableOrm OnDatabaseError Hotels.Product*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Hotels.Product");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Hotels_Product> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Hotels.Product*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Hotels.Product*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Hotels.Product");

                /*DataStructureInfo WritableOrm AfterSave Hotels.Product*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Hotels.Product*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Hotels.Product*/
    }

    /*DataStructureInfo RepositoryAttributes Hotels.Reservation*/
    public class Reservation_Repository : /*DataStructureInfo OverrideBaseType Hotels.Reservation*/ Common.OrmRepositoryBase<Common.Queryable.Hotels_Reservation, Hotels.Reservation> // Common.QueryableRepositoryBase<Common.Queryable.Hotels_Reservation, Hotels.Reservation> // Common.ReadableRepositoryBase<Hotels.Reservation> // global::Common.RepositoryBase
        , IWritableRepository<Hotels.Reservation>, IValidateRepository/*DataStructureInfo RepositoryInterface Hotels.Reservation*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Hotels.Reservation*/

        public Reservation_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Hotels.Reservation*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Hotels.Reservation*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Hotels.Reservation[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Hotels_Reservation> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Hotels.Reservation*/
            return _executionContext.EntityFrameworkContext.Hotels_Reservation.AsNoTracking();
        }

        public void Save(IEnumerable<Hotels.Reservation> insertedNew, IEnumerable<Hotels.Reservation> updatedNew, IEnumerable<Hotels.Reservation> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Hotels.Reservation*/

            /*DataStructureInfo WritableOrm ArgumentValidation Hotels.Reservation*/

            /*DataStructureInfo WritableOrm Initialization Hotels.Reservation*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Hotels_Reservation> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_Reservation>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Hotels_Reservation> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_Reservation>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Hotels.Reservation*/

            /*DataStructureInfo WritableOrm ProcessedOldData Hotels.Reservation*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Hotels_Reservation.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Hotels.Guest", @"ID", @"FK_Reservation_Guest_GuestID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Reservation,Property:GuestID,Referenced:Hotels.Guest";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Hotels.Room", @"ID", @"FK_Reservation_Room_RoomID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Reservation,Property:RoomID,Referenced:Hotels.Room";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Hotels.Invoice", @"ReservationID", @"FK_Invoice_Reservation_ReservationID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Invoice,Property:ReservationID,Referenced:Hotels.Reservation";
                /*DataStructureInfo WritableOrm OnDatabaseError Hotels.Reservation*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Hotels.Reservation");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Hotels_Reservation> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Hotels.Reservation*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Hotels.Reservation*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Hotels.Reservation");

                /*DataStructureInfo WritableOrm AfterSave Hotels.Reservation*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Hotels.Reservation*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Hotels.Reservation*/
    }

    /*DataStructureInfo RepositoryAttributes Hotels.Invoice*/
    public class Invoice_Repository : /*DataStructureInfo OverrideBaseType Hotels.Invoice*/ Common.OrmRepositoryBase<Common.Queryable.Hotels_Invoice, Hotels.Invoice> // Common.QueryableRepositoryBase<Common.Queryable.Hotels_Invoice, Hotels.Invoice> // Common.ReadableRepositoryBase<Hotels.Invoice> // global::Common.RepositoryBase
        , IWritableRepository<Hotels.Invoice>, IValidateRepository/*DataStructureInfo RepositoryInterface Hotels.Invoice*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Hotels.Invoice*/

        public Invoice_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Hotels.Invoice*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Hotels.Invoice*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Hotels.Invoice[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Hotels_Invoice> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Hotels.Invoice*/
            return _executionContext.EntityFrameworkContext.Hotels_Invoice.AsNoTracking();
        }

        public void Save(IEnumerable<Hotels.Invoice> insertedNew, IEnumerable<Hotels.Invoice> updatedNew, IEnumerable<Hotels.Invoice> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Hotels.Invoice*/

            /*DataStructureInfo WritableOrm ArgumentValidation Hotels.Invoice*/

            /*DataStructureInfo WritableOrm Initialization Hotels.Invoice*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Hotels_Invoice> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_Invoice>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Hotels_Invoice> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_Invoice>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Hotels.Invoice*/

            /*DataStructureInfo WritableOrm ProcessedOldData Hotels.Invoice*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Hotels_Invoice.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Hotels.Reservation", @"ID", @"FK_Invoice_Reservation_ReservationID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Invoice,Property:ReservationID,Referenced:Hotels.Reservation";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Hotels.Item", @"InvoiceID", @"FK_Item_Invoice_InvoiceID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Item,Property:InvoiceID,Referenced:Hotels.Invoice";
                /*DataStructureInfo WritableOrm OnDatabaseError Hotels.Invoice*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Hotels.Invoice");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Hotels_Invoice> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Hotels.Invoice*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Hotels.Invoice*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Hotels.Invoice");

                /*DataStructureInfo WritableOrm AfterSave Hotels.Invoice*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new Hotels.Discount_MaxValueFilter()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_Discount_MaxValueFilter(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new Hotels.Discount_MinValueFilter()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_Discount_MinValueFilter(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Hotels.Invoice*/
            yield break;
        }

        public IQueryable<Common.Queryable.Hotels_Invoice> Filter(IQueryable<Common.Queryable.Hotels_Invoice> localSource, Hotels.Discount_MaxValueFilter localParameter)
        {
            Func<IQueryable<Common.Queryable.Hotels_Invoice>, Common.DomRepository, Hotels.Discount_MaxValueFilter/*ComposableFilterByInfo AdditionalParametersType Hotels.Invoice.'Hotels.Discount_MaxValueFilter'*/, IQueryable<Common.Queryable.Hotels_Invoice>> filterFunction =
            (items, repository, parameter) => { int limit = 1; return items.Where(item => item.Discount != null && item.Discount > limit); };

            /*ComposableFilterByInfo BeforeFilter Hotels.Invoice.'Hotels.Discount_MaxValueFilter'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Hotels.Invoice.'Hotels.Discount_MaxValueFilter'*/);
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_Discount_MaxValueFilter(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"Maximum value of {0} is {1}.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"Hotels.Discount_MaxValueFilter";
            metadata[@"Property"] = @"Discount";
            /*InvalidDataInfo ErrorMetadata Hotels.Invoice.'Hotels.Discount_MaxValueFilter'*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Discount", @"1" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Hotels.Invoice.'Hotels.Discount_MaxValueFilter'*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Hotels_Invoice> Filter(IQueryable<Common.Queryable.Hotels_Invoice> localSource, Hotels.Discount_MinValueFilter localParameter)
        {
            Func<IQueryable<Common.Queryable.Hotels_Invoice>, Common.DomRepository, Hotels.Discount_MinValueFilter/*ComposableFilterByInfo AdditionalParametersType Hotels.Invoice.'Hotels.Discount_MinValueFilter'*/, IQueryable<Common.Queryable.Hotels_Invoice>> filterFunction =
            (items, repository, parameter) => { int limit = 0; return items.Where(item => item.Discount != null && item.Discount < limit); };

            /*ComposableFilterByInfo BeforeFilter Hotels.Invoice.'Hotels.Discount_MinValueFilter'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Hotels.Invoice.'Hotels.Discount_MinValueFilter'*/);
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_Discount_MinValueFilter(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"Minimum value of {0} is {1}.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"Hotels.Discount_MinValueFilter";
            metadata[@"Property"] = @"Discount";
            /*InvalidDataInfo ErrorMetadata Hotels.Invoice.'Hotels.Discount_MinValueFilter'*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Discount", @"0" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Hotels.Invoice.'Hotels.Discount_MinValueFilter'*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public global::Hotels.Invoice[] Filter(Hotels.Discount_MaxValueFilter filter_Parameter)
        {
            Func<Common.DomRepository, Hotels.Discount_MaxValueFilter/*FilterByInfo AdditionalParametersType Hotels.Invoice.'Hotels.Discount_MaxValueFilter'*/, Hotels.Invoice[]> filter_Function =
                (repository, parameter) => repository.Hotels.Invoice.Filter(repository.Hotels.Invoice.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Hotels.Invoice.'Hotels.Discount_MaxValueFilter'*/);
        }

        public global::Hotels.Invoice[] Filter(Hotels.Discount_MinValueFilter filter_Parameter)
        {
            Func<Common.DomRepository, Hotels.Discount_MinValueFilter/*FilterByInfo AdditionalParametersType Hotels.Invoice.'Hotels.Discount_MinValueFilter'*/, Hotels.Invoice[]> filter_Function =
                (repository, parameter) => repository.Hotels.Invoice.Filter(repository.Hotels.Invoice.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Hotels.Invoice.'Hotels.Discount_MinValueFilter'*/);
        }

        /*DataStructureInfo RepositoryMembers Hotels.Invoice*/
    }

    /*DataStructureInfo RepositoryAttributes Hotels.Item*/
    public class Item_Repository : /*DataStructureInfo OverrideBaseType Hotels.Item*/ Common.OrmRepositoryBase<Common.Queryable.Hotels_Item, Hotels.Item> // Common.QueryableRepositoryBase<Common.Queryable.Hotels_Item, Hotels.Item> // Common.ReadableRepositoryBase<Hotels.Item> // global::Common.RepositoryBase
        , IWritableRepository<Hotels.Item>, IValidateRepository/*DataStructureInfo RepositoryInterface Hotels.Item*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Hotels.Item*/

        public Item_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Hotels.Item*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Hotels.Item*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Hotels.Item[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Hotels_Item> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Hotels.Item*/
            return _executionContext.EntityFrameworkContext.Hotels_Item.AsNoTracking();
        }

        public void Save(IEnumerable<Hotels.Item> insertedNew, IEnumerable<Hotels.Item> updatedNew, IEnumerable<Hotels.Item> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Hotels.Item*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Name != null && newItem.Name.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Item.Name", "256" },
                        "DataStructure:Hotels.Item,ID:" + invalidItem.ID.ToString() + ",Property:Name",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Hotels.Item*/

            /*DataStructureInfo WritableOrm Initialization Hotels.Item*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Hotels_Item> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_Item>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Hotels_Item> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Hotels_Item>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Hotels.Item*/

            /*DataStructureInfo WritableOrm ProcessedOldData Hotels.Item*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Hotels_Item.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Hotels.Good", @"ID", @"FK_Item_Good_GoodID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Item,Property:GoodID,Referenced:Hotels.Good";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Hotels.Invoice", @"ID", @"FK_Item_Invoice_InvoiceID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Hotels.Item,Property:InvoiceID,Referenced:Hotels.Invoice";
                /*DataStructureInfo WritableOrm OnDatabaseError Hotels.Item*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Hotels.Item");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Hotels_Item> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Hotels.Item*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Hotels.Item*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Hotels.Item");

                /*DataStructureInfo WritableOrm AfterSave Hotels.Item*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Hotels.Item*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Hotels.Item*/
    }

    /*ModuleInfo HelperNamespaceMembers Hotels*/
}

namespace Common._Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*ModuleInfo Using Common*/

    public class _ModuleRepository
    {
        private readonly Rhetos.Extensibility.INamedPlugins<IRepository> _repositories;

        public _ModuleRepository(Rhetos.Extensibility.INamedPlugins<IRepository> repositories)
        {
            _repositories = repositories;
        }

        private AutoCodeCache_Repository _AutoCodeCache_Repository;
        public AutoCodeCache_Repository AutoCodeCache { get { return _AutoCodeCache_Repository ?? (_AutoCodeCache_Repository = (AutoCodeCache_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.AutoCodeCache")); } }

        private FilterId_Repository _FilterId_Repository;
        public FilterId_Repository FilterId { get { return _FilterId_Repository ?? (_FilterId_Repository = (FilterId_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.FilterId")); } }

        private KeepSynchronizedMetadata_Repository _KeepSynchronizedMetadata_Repository;
        public KeepSynchronizedMetadata_Repository KeepSynchronizedMetadata { get { return _KeepSynchronizedMetadata_Repository ?? (_KeepSynchronizedMetadata_Repository = (KeepSynchronizedMetadata_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.KeepSynchronizedMetadata")); } }

        private ExclusiveLock_Repository _ExclusiveLock_Repository;
        public ExclusiveLock_Repository ExclusiveLock { get { return _ExclusiveLock_Repository ?? (_ExclusiveLock_Repository = (ExclusiveLock_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.ExclusiveLock")); } }

        private SetLock_Repository _SetLock_Repository;
        public SetLock_Repository SetLock { get { return _SetLock_Repository ?? (_SetLock_Repository = (SetLock_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.SetLock")); } }

        private ReleaseLock_Repository _ReleaseLock_Repository;
        public ReleaseLock_Repository ReleaseLock { get { return _ReleaseLock_Repository ?? (_ReleaseLock_Repository = (ReleaseLock_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.ReleaseLock")); } }

        private LogReader_Repository _LogReader_Repository;
        public LogReader_Repository LogReader { get { return _LogReader_Repository ?? (_LogReader_Repository = (LogReader_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.LogReader")); } }

        private LogRelatedItemReader_Repository _LogRelatedItemReader_Repository;
        public LogRelatedItemReader_Repository LogRelatedItemReader { get { return _LogRelatedItemReader_Repository ?? (_LogRelatedItemReader_Repository = (LogRelatedItemReader_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.LogRelatedItemReader")); } }

        private Log_Repository _Log_Repository;
        public Log_Repository Log { get { return _Log_Repository ?? (_Log_Repository = (Log_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Log")); } }

        private AddToLog_Repository _AddToLog_Repository;
        public AddToLog_Repository AddToLog { get { return _AddToLog_Repository ?? (_AddToLog_Repository = (AddToLog_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.AddToLog")); } }

        private LogRelatedItem_Repository _LogRelatedItem_Repository;
        public LogRelatedItem_Repository LogRelatedItem { get { return _LogRelatedItem_Repository ?? (_LogRelatedItem_Repository = (LogRelatedItem_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.LogRelatedItem")); } }

        private RelatedEventsSource_Repository _RelatedEventsSource_Repository;
        public RelatedEventsSource_Repository RelatedEventsSource { get { return _RelatedEventsSource_Repository ?? (_RelatedEventsSource_Repository = (RelatedEventsSource_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.RelatedEventsSource")); } }

        private Claim_Repository _Claim_Repository;
        public Claim_Repository Claim { get { return _Claim_Repository ?? (_Claim_Repository = (Claim_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Claim")); } }

        private MyClaim_Repository _MyClaim_Repository;
        public MyClaim_Repository MyClaim { get { return _MyClaim_Repository ?? (_MyClaim_Repository = (MyClaim_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.MyClaim")); } }

        private Principal_Repository _Principal_Repository;
        public Principal_Repository Principal { get { return _Principal_Repository ?? (_Principal_Repository = (Principal_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Principal")); } }

        private PrincipalHasRole_Repository _PrincipalHasRole_Repository;
        public PrincipalHasRole_Repository PrincipalHasRole { get { return _PrincipalHasRole_Repository ?? (_PrincipalHasRole_Repository = (PrincipalHasRole_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.PrincipalHasRole")); } }

        private Role_Repository _Role_Repository;
        public Role_Repository Role { get { return _Role_Repository ?? (_Role_Repository = (Role_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Role")); } }

        private RoleInheritsRole_Repository _RoleInheritsRole_Repository;
        public RoleInheritsRole_Repository RoleInheritsRole { get { return _RoleInheritsRole_Repository ?? (_RoleInheritsRole_Repository = (RoleInheritsRole_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.RoleInheritsRole")); } }

        private PrincipalPermission_Repository _PrincipalPermission_Repository;
        public PrincipalPermission_Repository PrincipalPermission { get { return _PrincipalPermission_Repository ?? (_PrincipalPermission_Repository = (PrincipalPermission_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.PrincipalPermission")); } }

        private RolePermission_Repository _RolePermission_Repository;
        public RolePermission_Repository RolePermission { get { return _RolePermission_Repository ?? (_RolePermission_Repository = (RolePermission_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.RolePermission")); } }

        /*ModuleInfo RepositoryMembers Common*/
    }

    /*DataStructureInfo RepositoryAttributes Common.AutoCodeCache*/
    public class AutoCodeCache_Repository : /*DataStructureInfo OverrideBaseType Common.AutoCodeCache*/ Common.OrmRepositoryBase<Common.Queryable.Common_AutoCodeCache, Common.AutoCodeCache> // Common.QueryableRepositoryBase<Common.Queryable.Common_AutoCodeCache, Common.AutoCodeCache> // Common.ReadableRepositoryBase<Common.AutoCodeCache> // global::Common.RepositoryBase
        , IWritableRepository<Common.AutoCodeCache>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.AutoCodeCache*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.AutoCodeCache*/

        public AutoCodeCache_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.AutoCodeCache*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.AutoCodeCache*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.AutoCodeCache[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_AutoCodeCache> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.AutoCodeCache*/
            return _executionContext.EntityFrameworkContext.Common_AutoCodeCache.AsNoTracking();
        }

        public void Save(IEnumerable<Common.AutoCodeCache> insertedNew, IEnumerable<Common.AutoCodeCache> updatedNew, IEnumerable<Common.AutoCodeCache> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.AutoCodeCache*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Entity != null && newItem.Entity.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "AutoCodeCache.Entity", "256" },
                        "DataStructure:Common.AutoCodeCache,ID:" + invalidItem.ID.ToString() + ",Property:Entity",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Property != null && newItem.Property.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "AutoCodeCache.Property", "256" },
                        "DataStructure:Common.AutoCodeCache,ID:" + invalidItem.ID.ToString() + ",Property:Property",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Grouping != null && newItem.Grouping.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "AutoCodeCache.Grouping", "256" },
                        "DataStructure:Common.AutoCodeCache,ID:" + invalidItem.ID.ToString() + ",Property:Grouping",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Prefix != null && newItem.Prefix.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "AutoCodeCache.Prefix", "256" },
                        "DataStructure:Common.AutoCodeCache,ID:" + invalidItem.ID.ToString() + ",Property:Prefix",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.AutoCodeCache*/

            /*DataStructureInfo WritableOrm Initialization Common.AutoCodeCache*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_AutoCodeCache> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_AutoCodeCache>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_AutoCodeCache> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_AutoCodeCache>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.AutoCodeCache*/

            /*DataStructureInfo WritableOrm ProcessedOldData Common.AutoCodeCache*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_AutoCodeCache.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.AutoCodeCache", @"IX_AutoCodeCache_Entity_Property_Grouping_Prefix"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.AutoCodeCache,Property:Entity Property Grouping Prefix";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.AutoCodeCache*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.AutoCodeCache");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_AutoCodeCache> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.AutoCodeCache*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.AutoCodeCache*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.AutoCodeCache");

                /*DataStructureInfo WritableOrm AfterSave Common.AutoCodeCache*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.AutoCodeCache*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.AutoCodeCache*/
    }

    /*DataStructureInfo RepositoryAttributes Common.FilterId*/
    public class FilterId_Repository : /*DataStructureInfo OverrideBaseType Common.FilterId*/ Common.OrmRepositoryBase<Common.Queryable.Common_FilterId, Common.FilterId> // Common.QueryableRepositoryBase<Common.Queryable.Common_FilterId, Common.FilterId> // Common.ReadableRepositoryBase<Common.FilterId> // global::Common.RepositoryBase
        , IWritableRepository<Common.FilterId>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.FilterId*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.FilterId*/

        public FilterId_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.FilterId*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.FilterId*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.FilterId[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_FilterId> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.FilterId*/
            return _executionContext.EntityFrameworkContext.Common_FilterId.AsNoTracking();
        }

        public void Save(IEnumerable<Common.FilterId> insertedNew, IEnumerable<Common.FilterId> updatedNew, IEnumerable<Common.FilterId> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.FilterId*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.FilterId*/

            /*DataStructureInfo WritableOrm Initialization Common.FilterId*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_FilterId> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_FilterId>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_FilterId> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_FilterId>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.FilterId*/

            /*DataStructureInfo WritableOrm ProcessedOldData Common.FilterId*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_FilterId.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		/*DataStructureInfo WritableOrm OnDatabaseError Common.FilterId*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.FilterId");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_FilterId> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.FilterId*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.FilterId*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.FilterId");

                /*DataStructureInfo WritableOrm AfterSave Common.FilterId*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.FilterId*/
            yield break;
        }

        /// <summary>
        /// Depending on the ids count, this method will return the list of IDs, or insert the ids to the database and return an SQL query that selects the ids.
        /// EF 6.1.3 has performance issues on Contains function with large lists. It seems to have O(n^2) time complexity.
        /// </summary>
        public IEnumerable<Guid> CreateQueryableFilterIds(IEnumerable<Guid> ids)
        {
            Rhetos.Utilities.CsUtility.Materialize(ref ids);

            if (ids.Count() < 200)
                return ids;

            var handle = Guid.NewGuid();
            string sqlInsertIdFormat = "INSERT INTO Common.FilterId (Handle, Value) VALUES ('" + SqlUtility.GuidToString(handle) + "', '{0}');";

            const int chunkSize = 1000; // Keeping a moderate SQL script size.
            for (int start = 0; start < ids.Count(); start += chunkSize)
            {
                string sqlInsertIds = string.Join("\r\n", ids.Skip(start).Take(chunkSize)
                        .Select(id => string.Format(sqlInsertIdFormat, SqlUtility.GuidToString(id))));
                _executionContext.SqlExecuter.ExecuteSql(sqlInsertIds);
            }

            // Delete temporary data when closing the connection. The data must remain in the database until the returned query is used.
            string deleteFilterIds = "DELETE FROM Common.FilterId WHERE Handle = " + SqlUtility.QuoteGuid(handle);
            _executionContext.PersistenceTransaction.BeforeClose += () =>
                {
                    try
                    {
                        _executionContext.SqlExecuter.ExecuteSql(deleteFilterIds);
                    }
                    catch
                    {
                        // Cleanup error may be ignored. The temporary data may be deleted on regular maintenance.
                    }
                };

            return Query().Where(filterId => filterId.Handle == handle).Select(filterId => filterId.Value.Value);
        }

        /*DataStructureInfo RepositoryMembers Common.FilterId*/
    }

    /*DataStructureInfo RepositoryAttributes Common.KeepSynchronizedMetadata*/
    public class KeepSynchronizedMetadata_Repository : /*DataStructureInfo OverrideBaseType Common.KeepSynchronizedMetadata*/ Common.OrmRepositoryBase<Common.Queryable.Common_KeepSynchronizedMetadata, Common.KeepSynchronizedMetadata> // Common.QueryableRepositoryBase<Common.Queryable.Common_KeepSynchronizedMetadata, Common.KeepSynchronizedMetadata> // Common.ReadableRepositoryBase<Common.KeepSynchronizedMetadata> // global::Common.RepositoryBase
        , IWritableRepository<Common.KeepSynchronizedMetadata>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.KeepSynchronizedMetadata*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.KeepSynchronizedMetadata*/

        public KeepSynchronizedMetadata_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.KeepSynchronizedMetadata*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.KeepSynchronizedMetadata*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.KeepSynchronizedMetadata[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_KeepSynchronizedMetadata> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.KeepSynchronizedMetadata*/
            return _executionContext.EntityFrameworkContext.Common_KeepSynchronizedMetadata.AsNoTracking();
        }

        public void Save(IEnumerable<Common.KeepSynchronizedMetadata> insertedNew, IEnumerable<Common.KeepSynchronizedMetadata> updatedNew, IEnumerable<Common.KeepSynchronizedMetadata> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.KeepSynchronizedMetadata*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Target != null && newItem.Target.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "KeepSynchronizedMetadata.Target", "256" },
                        "DataStructure:Common.KeepSynchronizedMetadata,ID:" + invalidItem.ID.ToString() + ",Property:Target",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Source != null && newItem.Source.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "KeepSynchronizedMetadata.Source", "256" },
                        "DataStructure:Common.KeepSynchronizedMetadata,ID:" + invalidItem.ID.ToString() + ",Property:Source",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.KeepSynchronizedMetadata*/

            /*DataStructureInfo WritableOrm Initialization Common.KeepSynchronizedMetadata*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_KeepSynchronizedMetadata> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_KeepSynchronizedMetadata>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_KeepSynchronizedMetadata> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_KeepSynchronizedMetadata>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.KeepSynchronizedMetadata*/

            /*DataStructureInfo WritableOrm ProcessedOldData Common.KeepSynchronizedMetadata*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_KeepSynchronizedMetadata.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		/*DataStructureInfo WritableOrm OnDatabaseError Common.KeepSynchronizedMetadata*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.KeepSynchronizedMetadata");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_KeepSynchronizedMetadata> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.KeepSynchronizedMetadata*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.KeepSynchronizedMetadata*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.KeepSynchronizedMetadata");

                /*DataStructureInfo WritableOrm AfterSave Common.KeepSynchronizedMetadata*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.KeepSynchronizedMetadata*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.KeepSynchronizedMetadata*/
    }

    /*DataStructureInfo RepositoryAttributes Common.ExclusiveLock*/
    public class ExclusiveLock_Repository : /*DataStructureInfo OverrideBaseType Common.ExclusiveLock*/ Common.OrmRepositoryBase<Common.Queryable.Common_ExclusiveLock, Common.ExclusiveLock> // Common.QueryableRepositoryBase<Common.Queryable.Common_ExclusiveLock, Common.ExclusiveLock> // Common.ReadableRepositoryBase<Common.ExclusiveLock> // global::Common.RepositoryBase
        , IWritableRepository<Common.ExclusiveLock>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.ExclusiveLock*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.ExclusiveLock*/

        public ExclusiveLock_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.ExclusiveLock*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.ExclusiveLock*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.ExclusiveLock[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_ExclusiveLock> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.ExclusiveLock*/
            return _executionContext.EntityFrameworkContext.Common_ExclusiveLock.AsNoTracking();
        }

        public void Save(IEnumerable<Common.ExclusiveLock> insertedNew, IEnumerable<Common.ExclusiveLock> updatedNew, IEnumerable<Common.ExclusiveLock> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.ExclusiveLock*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.ResourceType != null && newItem.ResourceType.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "ExclusiveLock.ResourceType", "256" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalidItem.ID.ToString() + ",Property:ResourceType",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.UserName != null && newItem.UserName.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "ExclusiveLock.UserName", "256" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalidItem.ID.ToString() + ",Property:UserName",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Workstation != null && newItem.Workstation.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "ExclusiveLock.Workstation", "256" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalidItem.ID.ToString() + ",Property:Workstation",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.ExclusiveLock*/

            /*DataStructureInfo WritableOrm Initialization Common.ExclusiveLock*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_ExclusiveLock> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_ExclusiveLock>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_ExclusiveLock> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_ExclusiveLock>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.ExclusiveLock*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ResourceType == null || string.IsNullOrWhiteSpace(item.ResourceType) /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.ResourceType*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "ResourceType" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:ResourceType", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ResourceID == null /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.ResourceID*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "ResourceID" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:ResourceID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.UserName == null || string.IsNullOrWhiteSpace(item.UserName) /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.UserName*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "UserName" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:UserName", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Workstation == null || string.IsNullOrWhiteSpace(item.Workstation) /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.Workstation*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "Workstation" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:Workstation", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.LockStart == null /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.LockStart*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "LockStart" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:LockStart", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.LockFinish == null /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.LockFinish*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "LockFinish" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:LockFinish", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.ExclusiveLock*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_ExclusiveLock.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.ExclusiveLock", @"IX_ExclusiveLock_ResourceID_ResourceType"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.ExclusiveLock,Property:ResourceID ResourceType";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.ExclusiveLock*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.ExclusiveLock");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_ExclusiveLock> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.ExclusiveLock*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.ExclusiveLock*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.ExclusiveLock");

                /*DataStructureInfo WritableOrm AfterSave Common.ExclusiveLock*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.ExclusiveLock*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.ExclusiveLock*/
    }

    /*DataStructureInfo RepositoryAttributes Common.SetLock*/
    public class SetLock_Repository : /*DataStructureInfo OverrideBaseType Common.SetLock*/ global::Common.RepositoryBase
        , IActionRepository/*DataStructureInfo RepositoryInterface Common.SetLock*/
    {
        private readonly Rhetos.Utilities.ILocalizer _localizer;
        /*DataStructureInfo RepositoryPrivateMembers Common.SetLock*/

        public SetLock_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ILocalizer _localizer/*DataStructureInfo RepositoryConstructorArguments Common.SetLock*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._localizer = _localizer;
            /*DataStructureInfo RepositoryConstructorCode Common.SetLock*/
        }

        public void Execute(Common.SetLock actionParameter)
        {
            Action<Common.SetLock, Common.DomRepository, IUserInfo/*DataStructureInfo AdditionalParametersType Common.SetLock*/> action_Object = (parameters, repository, userInfo) =>
        {
            var now = SqlUtility.GetDatabaseTime(_executionContext.SqlExecuter);

            var oldLock = repository.Common.ExclusiveLock.Query()
                .Where(itemLock =>
                    itemLock.ResourceType == parameters.ResourceType
                    && itemLock.ResourceID == parameters.ResourceID)
                .FirstOrDefault();
            
            if (oldLock == null)
                repository.Common.ExclusiveLock.Insert(new[] { new Common.ExclusiveLock
                    {
                        UserName = userInfo.UserName,
                        Workstation = userInfo.Workstation,
                        ResourceType = parameters.ResourceType,
                        ResourceID = parameters.ResourceID,
                        LockStart = now,
                        LockFinish = now.AddMinutes(15)
                    }});
            else if (oldLock.UserName == userInfo.UserName
                && oldLock.Workstation == userInfo.Workstation
                || oldLock.LockFinish < now)
                repository.Common.ExclusiveLock.Update(new[] { new Common.ExclusiveLock
                    {
                        ID = oldLock.ID,
                        UserName = userInfo.UserName,
                        Workstation = userInfo.Workstation,
                        ResourceType = parameters.ResourceType,
                        ResourceID = parameters.ResourceID,
                        LockStart = now,
                        LockFinish = now.AddMinutes(15)
                    }});
             else
             {
                string lockInfo = _localizer["Locked record {0}, ID {1}.", oldLock.ResourceType, oldLock.ResourceID];

                string errorInfo;
                if (oldLock.UserName.Equals(userInfo.UserName, StringComparison.InvariantCultureIgnoreCase))
                    errorInfo = _localizer["It is not allowed to enter the record at client workstation '{0}' because the data entry is in progress at workstation '{1}'.",
                        userInfo.Workstation, oldLock.Workstation];
                else
                    errorInfo = _localizer["It is not allowed to enter the record because the data entry is in progress by user '{0}'.",
                        oldLock.UserName];
                
                string localizedMessage = errorInfo + "\r\n" + lockInfo;
                throw new Rhetos.UserException(localizedMessage);
             }
        };

            bool allEffectsCompleted = false;
            try
            {
                /*ActionInfo BeforeAction Common.SetLock*/
                action_Object(actionParameter, _domRepository, _executionContext.UserInfo/*DataStructureInfo AdditionalParametersArgument Common.SetLock*/);
                /*ActionInfo AfterAction Common.SetLock*/
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        void IActionRepository.Execute(object actionParameter)
        {
            Execute((Common.SetLock) actionParameter);
        }

        /*DataStructureInfo RepositoryMembers Common.SetLock*/
    }

    /*DataStructureInfo RepositoryAttributes Common.ReleaseLock*/
    public class ReleaseLock_Repository : /*DataStructureInfo OverrideBaseType Common.ReleaseLock*/ global::Common.RepositoryBase
        , IActionRepository/*DataStructureInfo RepositoryInterface Common.ReleaseLock*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.ReleaseLock*/

        public ReleaseLock_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.ReleaseLock*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.ReleaseLock*/
        }

        public void Execute(Common.ReleaseLock actionParameter)
        {
            Action<Common.ReleaseLock, Common.DomRepository, IUserInfo/*DataStructureInfo AdditionalParametersType Common.ReleaseLock*/> action_Object = (parameters, repository, userInfo) =>
        {
            var myLock = repository.Common.ExclusiveLock.Query()
                .Where(itemLock =>
                    itemLock.ResourceType == parameters.ResourceType
                    && itemLock.ResourceID == parameters.ResourceID
                    && itemLock.UserName == userInfo.UserName
                    && itemLock.Workstation == userInfo.Workstation)
                .FirstOrDefault();

            if (myLock != null)
                repository.Common.ExclusiveLock.Delete(new[] { myLock });
        };

            bool allEffectsCompleted = false;
            try
            {
                /*ActionInfo BeforeAction Common.ReleaseLock*/
                action_Object(actionParameter, _domRepository, _executionContext.UserInfo/*DataStructureInfo AdditionalParametersArgument Common.ReleaseLock*/);
                /*ActionInfo AfterAction Common.ReleaseLock*/
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        void IActionRepository.Execute(object actionParameter)
        {
            Execute((Common.ReleaseLock) actionParameter);
        }

        /*DataStructureInfo RepositoryMembers Common.ReleaseLock*/
    }

    /*DataStructureInfo RepositoryAttributes Common.LogReader*/
    public class LogReader_Repository : /*DataStructureInfo OverrideBaseType Common.LogReader*/ Common.OrmRepositoryBase<Common.Queryable.Common_LogReader, Common.LogReader> // Common.QueryableRepositoryBase<Common.Queryable.Common_LogReader, Common.LogReader> // Common.ReadableRepositoryBase<Common.LogReader> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.LogReader*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.LogReader*/

        public LogReader_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.LogReader*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.LogReader*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.LogReader[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_LogReader> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.LogReader*/
            return _executionContext.EntityFrameworkContext.Common_LogReader.AsNoTracking();
        }

        /*DataStructureInfo RepositoryMembers Common.LogReader*/
    }

    /*DataStructureInfo RepositoryAttributes Common.LogRelatedItemReader*/
    public class LogRelatedItemReader_Repository : /*DataStructureInfo OverrideBaseType Common.LogRelatedItemReader*/ Common.OrmRepositoryBase<Common.Queryable.Common_LogRelatedItemReader, Common.LogRelatedItemReader> // Common.QueryableRepositoryBase<Common.Queryable.Common_LogRelatedItemReader, Common.LogRelatedItemReader> // Common.ReadableRepositoryBase<Common.LogRelatedItemReader> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.LogRelatedItemReader*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.LogRelatedItemReader*/

        public LogRelatedItemReader_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.LogRelatedItemReader*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.LogRelatedItemReader*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.LogRelatedItemReader[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_LogRelatedItemReader> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.LogRelatedItemReader*/
            return _executionContext.EntityFrameworkContext.Common_LogRelatedItemReader.AsNoTracking();
        }

        /*DataStructureInfo RepositoryMembers Common.LogRelatedItemReader*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Log*/
    public class Log_Repository : /*DataStructureInfo OverrideBaseType Common.Log*/ Common.OrmRepositoryBase<Common.Queryable.Common_Log, Common.Log> // Common.QueryableRepositoryBase<Common.Queryable.Common_Log, Common.Log> // Common.ReadableRepositoryBase<Common.Log> // global::Common.RepositoryBase
        , IWritableRepository<Common.Log>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Log*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Log*/

        public Log_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Log*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Log*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.Log[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_Log> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.Log*/
            return _executionContext.EntityFrameworkContext.Common_Log.AsNoTracking();
        }

        public void Save(IEnumerable<Common.Log> insertedNew, IEnumerable<Common.Log> updatedNew, IEnumerable<Common.Log> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Log*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.UserName != null && newItem.UserName.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.UserName", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:UserName",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Workstation != null && newItem.Workstation.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.Workstation", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:Workstation",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.ContextInfo != null && newItem.ContextInfo.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.ContextInfo", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:ContextInfo",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Action != null && newItem.Action.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.Action", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:Action",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.TableName != null && newItem.TableName.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.TableName", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:TableName",
                        null);
            }
            if (checkUserPermissions)
                throw new Rhetos.UserException(
                    "It is not allowed to directly modify {0}.", new[] { "Common.Log" }, null, null);
            /*DataStructureInfo WritableOrm ArgumentValidation Common.Log*/

            /*DataStructureInfo WritableOrm Initialization Common.Log*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_Log> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Log>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_Log> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Log>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            if (deletedIds.Count() > 0)
            {
                List<Common.LogRelatedItem> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.LogRelatedItem.Query()
                        .Where(child => child.LogID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.LogRelatedItem { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.LogRelatedItem.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Common.Log*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Created == null /*RequiredPropertyInfo OrCondition Common.Log.Created*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "Created" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:Created", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.UserName == null || string.IsNullOrWhiteSpace(item.UserName) /*RequiredPropertyInfo OrCondition Common.Log.UserName*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "UserName" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:UserName", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Workstation == null || string.IsNullOrWhiteSpace(item.Workstation) /*RequiredPropertyInfo OrCondition Common.Log.Workstation*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "Workstation" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:Workstation", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Action == null || string.IsNullOrWhiteSpace(item.Action) /*RequiredPropertyInfo OrCondition Common.Log.Action*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "Action" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:Action", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Log*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_Log.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.LogRelatedItem", @"LogID", @"FK_LogRelatedItem_Log_LogID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.LogRelatedItem,Property:LogID,Referenced:Common.Log";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.Log*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.Log");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Log> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Log*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Log*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Log");

                /*DataStructureInfo WritableOrm AfterSave Common.Log*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Log*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.Log*/
    }

    /*DataStructureInfo RepositoryAttributes Common.AddToLog*/
    public class AddToLog_Repository : /*DataStructureInfo OverrideBaseType Common.AddToLog*/ global::Common.RepositoryBase
        , IActionRepository/*DataStructureInfo RepositoryInterface Common.AddToLog*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.AddToLog*/

        public AddToLog_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.AddToLog*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.AddToLog*/
        }

        public void Execute(Common.AddToLog actionParameter)
        {
            Action<Common.AddToLog, Common.DomRepository, IUserInfo, Common.ExecutionContext/*DataStructureInfo AdditionalParametersType Common.AddToLog*/> action_Object = (parameter, repository, userInfo, context) =>
		{
			if (parameter.Action == null)
				throw new Rhetos.UserException("Parameter Action is required.");
			string sql = @"INSERT INTO Common.Log (Action, TableName, ItemId, Description)
                SELECT @p0, @p1, @p2, @p3";
			context.EntityFrameworkContext.Database.ExecuteSqlCommand(sql,
				parameter.Action,
				parameter.TableName,
				parameter.ItemId,
				parameter.Description);
		};

            bool allEffectsCompleted = false;
            try
            {
                /*ActionInfo BeforeAction Common.AddToLog*/
                action_Object(actionParameter, _domRepository, _executionContext.UserInfo, _executionContext/*DataStructureInfo AdditionalParametersArgument Common.AddToLog*/);
                /*ActionInfo AfterAction Common.AddToLog*/
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        void IActionRepository.Execute(object actionParameter)
        {
            Execute((Common.AddToLog) actionParameter);
        }

        /*DataStructureInfo RepositoryMembers Common.AddToLog*/
    }

    /*DataStructureInfo RepositoryAttributes Common.LogRelatedItem*/
    public class LogRelatedItem_Repository : /*DataStructureInfo OverrideBaseType Common.LogRelatedItem*/ Common.OrmRepositoryBase<Common.Queryable.Common_LogRelatedItem, Common.LogRelatedItem> // Common.QueryableRepositoryBase<Common.Queryable.Common_LogRelatedItem, Common.LogRelatedItem> // Common.ReadableRepositoryBase<Common.LogRelatedItem> // global::Common.RepositoryBase
        , IWritableRepository<Common.LogRelatedItem>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.LogRelatedItem*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.LogRelatedItem*/

        public LogRelatedItem_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.LogRelatedItem*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.LogRelatedItem*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.LogRelatedItem[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_LogRelatedItem> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.LogRelatedItem*/
            return _executionContext.EntityFrameworkContext.Common_LogRelatedItem.AsNoTracking();
        }

        public void Save(IEnumerable<Common.LogRelatedItem> insertedNew, IEnumerable<Common.LogRelatedItem> updatedNew, IEnumerable<Common.LogRelatedItem> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.LogRelatedItem*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.TableName != null && newItem.TableName.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "LogRelatedItem.TableName", "256" },
                        "DataStructure:Common.LogRelatedItem,ID:" + invalidItem.ID.ToString() + ",Property:TableName",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Relation != null && newItem.Relation.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "LogRelatedItem.Relation", "256" },
                        "DataStructure:Common.LogRelatedItem,ID:" + invalidItem.ID.ToString() + ",Property:Relation",
                        null);
            }
            if (checkUserPermissions)
                throw new Rhetos.UserException(
                    "It is not allowed to directly modify {0}.", new[] { "Common.LogRelatedItem" }, null, null);
            /*DataStructureInfo WritableOrm ArgumentValidation Common.LogRelatedItem*/

            /*DataStructureInfo WritableOrm Initialization Common.LogRelatedItem*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_LogRelatedItem> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_LogRelatedItem>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_LogRelatedItem> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_LogRelatedItem>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.LogRelatedItem*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.LogID == null /*RequiredPropertyInfo OrCondition Common.LogRelatedItem.Log*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.LogRelatedItem", "Log" },
                        "DataStructure:Common.LogRelatedItem,ID:" + invalid.ID.ToString() + ",Property:LogID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.LogRelatedItem*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_LogRelatedItem.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Log", @"ID", @"FK_LogRelatedItem_Log_LogID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.LogRelatedItem,Property:LogID,Referenced:Common.Log";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.LogRelatedItem*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.LogRelatedItem");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_LogRelatedItem> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.LogRelatedItem*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.LogRelatedItem*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.LogRelatedItem");

                /*DataStructureInfo WritableOrm AfterSave Common.LogRelatedItem*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredLog()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredLog(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.LogRelatedItem*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredLog(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredLog";
            metadata[@"Property"] = @"Log";
            /*InvalidDataInfo ErrorMetadata Common.LogRelatedItem.SystemRequiredLog*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.LogRelatedItem.Log" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.LogRelatedItem.SystemRequiredLog*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_LogRelatedItem> Filter(IQueryable<Common.Queryable.Common_LogRelatedItem> localSource, Common.SystemRequiredLog localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_LogRelatedItem>, Common.DomRepository, Common.SystemRequiredLog/*ComposableFilterByInfo AdditionalParametersType Common.LogRelatedItem.'Common.SystemRequiredLog'*/, IQueryable<Common.Queryable.Common_LogRelatedItem>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Log == null);

            /*ComposableFilterByInfo BeforeFilter Common.LogRelatedItem.'Common.SystemRequiredLog'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.LogRelatedItem.'Common.SystemRequiredLog'*/);
        }

        public global::Common.LogRelatedItem[] Filter(Common.SystemRequiredLog filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredLog/*FilterByInfo AdditionalParametersType Common.LogRelatedItem.'Common.SystemRequiredLog'*/, Common.LogRelatedItem[]> filter_Function =
                (repository, parameter) => repository.Common.LogRelatedItem.Filter(repository.Common.LogRelatedItem.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.LogRelatedItem.'Common.SystemRequiredLog'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.LogRelatedItem*/
    }

    /*DataStructureInfo RepositoryAttributes Common.RelatedEventsSource*/
    public class RelatedEventsSource_Repository : /*DataStructureInfo OverrideBaseType Common.RelatedEventsSource*/ Common.OrmRepositoryBase<Common.Queryable.Common_RelatedEventsSource, Common.RelatedEventsSource> // Common.QueryableRepositoryBase<Common.Queryable.Common_RelatedEventsSource, Common.RelatedEventsSource> // Common.ReadableRepositoryBase<Common.RelatedEventsSource> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.RelatedEventsSource*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.RelatedEventsSource*/

        public RelatedEventsSource_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.RelatedEventsSource*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.RelatedEventsSource*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.RelatedEventsSource[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_RelatedEventsSource> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.RelatedEventsSource*/
            return _executionContext.EntityFrameworkContext.Common_RelatedEventsSource.AsNoTracking();
        }

        /*DataStructureInfo RepositoryMembers Common.RelatedEventsSource*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Claim*/
    public class Claim_Repository : /*DataStructureInfo OverrideBaseType Common.Claim*/ Common.OrmRepositoryBase<Common.Queryable.Common_Claim, Common.Claim> // Common.QueryableRepositoryBase<Common.Queryable.Common_Claim, Common.Claim> // Common.ReadableRepositoryBase<Common.Claim> // global::Common.RepositoryBase
        , IWritableRepository<Common.Claim>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Claim*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Claim*/

        public Claim_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Claim*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Claim*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.Claim[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_Claim> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.Claim*/
            return _executionContext.EntityFrameworkContext.Common_Claim.AsNoTracking();
        }

        public void Save(IEnumerable<Common.Claim> insertedNew, IEnumerable<Common.Claim> updatedNew, IEnumerable<Common.Claim> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Claim*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.ClaimResource != null && newItem.ClaimResource.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Claim.ClaimResource", "256" },
                        "DataStructure:Common.Claim,ID:" + invalidItem.ID.ToString() + ",Property:ClaimResource",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.ClaimRight != null && newItem.ClaimRight.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Claim.ClaimRight", "256" },
                        "DataStructure:Common.Claim,ID:" + invalidItem.ID.ToString() + ",Property:ClaimRight",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.Claim*/

            /*DataStructureInfo WritableOrm Initialization Common.Claim*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_Claim> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Claim>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_Claim> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Claim>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            foreach (var newItem in insertedNew)
                if (newItem.Active == null)
                    newItem.Active = true;

            foreach (var change in updatedNew.Zip(updated, (newItem, oldItem) => new { newItem, oldItem }))
                if (change.newItem.Active == null)
                    change.newItem.Active = change.oldItem.Active ?? true;

            if (deletedIds.Count() > 0)
            {
                List<Common.PrincipalPermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.PrincipalPermission.Query()
                        .Where(child => child.ClaimID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.PrincipalPermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.PrincipalPermission.Delete(childItems);
            }

            if (deletedIds.Count() > 0)
            {
                List<Common.RolePermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.RolePermission.Query()
                        .Where(child => child.ClaimID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.RolePermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.RolePermission.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Common.Claim*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimResource == null || string.IsNullOrWhiteSpace(item.ClaimResource) /*RequiredPropertyInfo OrCondition Common.Claim.ClaimResource*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Claim", "ClaimResource" },
                        "DataStructure:Common.Claim,ID:" + invalid.ID.ToString() + ",Property:ClaimResource", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimRight == null || string.IsNullOrWhiteSpace(item.ClaimRight) /*RequiredPropertyInfo OrCondition Common.Claim.ClaimRight*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Claim", "ClaimRight" },
                        "DataStructure:Common.Claim,ID:" + invalid.ID.ToString() + ",Property:ClaimRight", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Claim*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_Claim.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalPermission", @"ClaimID", @"FK_PrincipalPermission_Claim_ClaimID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:ClaimID,Referenced:Common.Claim";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RolePermission", @"ClaimID", @"FK_RolePermission_Claim_ClaimID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:ClaimID,Referenced:Common.Claim";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.Claim", @"IX_Claim_ClaimResource_ClaimRight"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.Claim,Property:ClaimResource ClaimRight";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.Claim*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.Claim");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Claim> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Claim*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Claim*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Claim");

                /*DataStructureInfo WritableOrm AfterSave Common.Claim*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredActive()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredActive(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Claim*/
            yield break;
        }

        // Claims in use should be deactivated instead of deleted.
        public IEnumerable<Claim> Filter(IEnumerable<Claim> deleted, Rhetos.Dom.DefaultConcepts.DeactivateInsteadOfDelete parameter)
        {
            var deactivateClaimsId = new List<Guid>();
            var deletedClaimsId = new Lazy<List<Guid>>(() => deleted.Select(c => c.ID).ToList());

            {
                // Don't delete claims that are referenced from RolePermission:

                var permissionsQuery = _domRepository.Common.RolePermission.Query();

                List<Guid> deletedIds = deletedClaimsId.Value;
                if (deletedIds.Count < 1000) // If more than 1000 claims are deleted, it could be faster to load all permissions from database.
                    permissionsQuery = permissionsQuery.Where(p => deletedIds.Contains(p.Claim.ID));

                List<Guid> usedIds = permissionsQuery.Select(p => p.Claim.ID).Distinct().ToList();
                deactivateClaimsId.AddRange(usedIds);
            }
            
            {
                // Don't delete claims that are referenced from PrincipalPermission:

                var permissionsQuery = _domRepository.Common.PrincipalPermission.Query();

                List<Guid> deletedIds = deletedClaimsId.Value;
                if (deletedIds.Count < 1000) // If more than 1000 claims are deleted, it could be faster to load all permissions from database.
                    permissionsQuery = permissionsQuery.Where(p => deletedIds.Contains(p.Claim.ID));

                List<Guid> usedIds = permissionsQuery.Select(p => p.Claim.ID).Distinct().ToList();
                deactivateClaimsId.AddRange(usedIds);
            }
            /*DataStructureInfo DeactivateInsteadOfDelete Common.Claim*/

            var deactivateClaimsIdIndex = new HashSet<Guid>(deactivateClaimsId);
            return deleted.Where(item => deactivateClaimsIdIndex.Contains(item.ID)).ToList();
        }

        public IQueryable<Common.Queryable.Common_Claim> Filter(IQueryable<Common.Queryable.Common_Claim> localSource, Rhetos.Dom.DefaultConcepts.ActiveItems localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_Claim>, Common.DomRepository, Rhetos.Dom.DefaultConcepts.ActiveItems/*ComposableFilterByInfo AdditionalParametersType Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/, IQueryable<Common.Queryable.Common_Claim>> filterFunction =
            (items, repository, parameter) =>
                    {
                        if (parameter != null && parameter.ItemID.HasValue)
                            return items.Where(item => item.Active == null || item.Active.Value || item.ID == parameter.ItemID.Value);
                        else
                            return items.Where(item => item.Active == null || item.Active.Value);
                    };

            /*ComposableFilterByInfo BeforeFilter Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/);
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredActive(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredActive";
            metadata[@"Property"] = @"Active";
            /*InvalidDataInfo ErrorMetadata Common.Claim.SystemRequiredActive*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Bool Common.Claim.Active" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.Claim.SystemRequiredActive*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_Claim> Filter(IQueryable<Common.Queryable.Common_Claim> localSource, Common.SystemRequiredActive localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_Claim>, Common.DomRepository, Common.SystemRequiredActive/*ComposableFilterByInfo AdditionalParametersType Common.Claim.'Common.SystemRequiredActive'*/, IQueryable<Common.Queryable.Common_Claim>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Active == null);

            /*ComposableFilterByInfo BeforeFilter Common.Claim.'Common.SystemRequiredActive'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.Claim.'Common.SystemRequiredActive'*/);
        }

        public global::Common.Claim[] Filter(Rhetos.Dom.DefaultConcepts.ActiveItems filter_Parameter)
        {
            Func<Common.DomRepository, Rhetos.Dom.DefaultConcepts.ActiveItems/*FilterByInfo AdditionalParametersType Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/, Common.Claim[]> filter_Function =
                (repository, parameter) => repository.Common.Claim.Filter(repository.Common.Claim.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/);
        }

        public global::Common.Claim[] Filter(Common.SystemRequiredActive filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredActive/*FilterByInfo AdditionalParametersType Common.Claim.'Common.SystemRequiredActive'*/, Common.Claim[]> filter_Function =
                (repository, parameter) => repository.Common.Claim.Filter(repository.Common.Claim.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.Claim.'Common.SystemRequiredActive'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.Claim*/
    }

    /*DataStructureInfo RepositoryAttributes Common.MyClaim*/
    public class MyClaim_Repository : /*DataStructureInfo OverrideBaseType Common.MyClaim*/ Common.QueryableRepositoryBase<Common.Queryable.Common_MyClaim, Common.MyClaim> // Common.ReadableRepositoryBase<Common.MyClaim> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.MyClaim*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.MyClaim*/

        public MyClaim_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.MyClaim*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.MyClaim*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.MyClaim[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_MyClaim> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.MyClaim*/
            return Compute(_domRepository.Common.Claim.Query(), _domRepository/*DataStructureInfo AdditionalParametersArgument Common.MyClaim*/);
        }

        public readonly Func<IQueryable<Common.Queryable.Common_Claim>, Common.DomRepository/*DataStructureInfo AdditionalParametersType Common.MyClaim*/, IQueryable<Common.Queryable.Common_MyClaim>> Compute =
            (query, repository) =>
		{ throw new Rhetos.UserException("Reading Common.MyClaim without filter is not permitted. Use filter by Common.Claim or Common.Claim[]."); };

        public global::Common.MyClaim[] Filter(Common.Claim filter_Parameter)
        {
            Func<Common.DomRepository, Common.Claim, Common.ExecutionContext/*FilterByInfo AdditionalParametersType Common.MyClaim.'Common.Claim'*/, Common.MyClaim[]> filter_Function =
                (repository, parameter, executionContext) =>
			{
				var claim = repository.Common.Claim.Query().Where(item => item.ClaimResource == parameter.ClaimResource && item.ClaimRight == parameter.ClaimRight).SingleOrDefault();
				if (claim == null)
					throw new Rhetos.UserException("Claim {0}-{1} does not exist.",
						new[] { parameter.ClaimResource, parameter.ClaimRight }, null, null);
				
				return repository.Common.MyClaim.Filter(new[] { claim });
			};

            return filter_Function(_domRepository, filter_Parameter, _executionContext/*FilterByInfo AdditionalParametersArgument Common.MyClaim.'Common.Claim'*/);
        }

        public global::Common.MyClaim[] Filter(IEnumerable<Common.Claim> filter_Parameter)
        {
            Func<Common.DomRepository, IEnumerable<Common.Claim>, Common.ExecutionContext/*FilterByInfo AdditionalParametersType Common.MyClaim.'IEnumerable<Common.Claim>'*/, Common.MyClaim[]> filter_Function =
                (repository, claims, executionContext) =>
			{
                var securityClaims = claims.Select(c => new Rhetos.Security.Claim(c.ClaimResource, c.ClaimRight)).ToList();
                var authorizations = executionContext.AuthorizationManager.GetAuthorizations(securityClaims);
			
                return claims.Zip(authorizations, (claim, authorized) => new Common.MyClaim {
                        ID = claim.ID,
                        Applies = authorized
                    }).ToArray();
             };

            return filter_Function(_domRepository, filter_Parameter, _executionContext/*FilterByInfo AdditionalParametersArgument Common.MyClaim.'IEnumerable<Common.Claim>'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.MyClaim*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Principal*/
    public class Principal_Repository : /*DataStructureInfo OverrideBaseType Common.Principal*/ Common.OrmRepositoryBase<Common.Queryable.Common_Principal, Common.Principal> // Common.QueryableRepositoryBase<Common.Queryable.Common_Principal, Common.Principal> // Common.ReadableRepositoryBase<Common.Principal> // global::Common.RepositoryBase
        , IWritableRepository<Common.Principal>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Principal*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Principal*/

        public Principal_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Principal*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Principal*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.Principal[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_Principal> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.Principal*/
            return _executionContext.EntityFrameworkContext.Common_Principal.AsNoTracking();
        }

        public void Save(IEnumerable<Common.Principal> insertedNew, IEnumerable<Common.Principal> updatedNew, IEnumerable<Common.Principal> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Principal*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Name != null && newItem.Name.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Principal.Name", "256" },
                        "DataStructure:Common.Principal,ID:" + invalidItem.ID.ToString() + ",Property:Name",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.Principal*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                Name = item.Name/*LoadOldItemsInfo SelectProperties Common.Principal*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                Name = item.Name/*LoadOldItemsInfo SelectProperties Common.Principal*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.Principal*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_Principal> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Principal>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_Principal> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Principal>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            if (deletedIds.Count() > 0)
            {
                List<Common.PrincipalHasRole> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.PrincipalHasRole.Query()
                        .Where(child => child.PrincipalID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.PrincipalHasRole { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.PrincipalHasRole.Delete(childItems);
            }

            if (deletedIds.Count() > 0)
            {
                List<Common.PrincipalPermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.PrincipalPermission.Query()
                        .Where(child => child.PrincipalID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.PrincipalPermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.PrincipalPermission.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Common.Principal*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Name == null || string.IsNullOrWhiteSpace(item.Name) /*RequiredPropertyInfo OrCondition Common.Principal.Name*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Principal", "Name" },
                        "DataStructure:Common.Principal,ID:" + invalid.ID.ToString() + ",Property:Name", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Principal*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_Principal.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalHasRole", @"PrincipalID", @"FK_PrincipalHasRole_Principal_PrincipalID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:PrincipalID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalPermission", @"PrincipalID", @"FK_PrincipalPermission_Principal_PrincipalID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:PrincipalID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.Principal", @"IX_Principal_Name"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.Principal,Property:Name";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.Principal*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.Principal");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Principal> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var principalInfos = ((IEnumerable<Rhetos.Dom.DefaultConcepts.IPrincipal>)insertedNew).Concat(updatedNew)
                    .Concat(updatedOld.Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name }))
                    .Concat(deletedOld.Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name }));
                    _authorizationDataCache.ClearCachePrincipals(principalInfos);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Principal*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Principal*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Principal");

                /*DataStructureInfo WritableOrm AfterSave Common.Principal*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Principal*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.Principal*/
    }

    /*DataStructureInfo RepositoryAttributes Common.PrincipalHasRole*/
    public class PrincipalHasRole_Repository : /*DataStructureInfo OverrideBaseType Common.PrincipalHasRole*/ Common.OrmRepositoryBase<Common.Queryable.Common_PrincipalHasRole, Common.PrincipalHasRole> // Common.QueryableRepositoryBase<Common.Queryable.Common_PrincipalHasRole, Common.PrincipalHasRole> // Common.ReadableRepositoryBase<Common.PrincipalHasRole> // global::Common.RepositoryBase
        , IWritableRepository<Common.PrincipalHasRole>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.PrincipalHasRole*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.PrincipalHasRole*/

        public PrincipalHasRole_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.PrincipalHasRole*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.PrincipalHasRole*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.PrincipalHasRole[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_PrincipalHasRole> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.PrincipalHasRole*/
            return _executionContext.EntityFrameworkContext.Common_PrincipalHasRole.AsNoTracking();
        }

        public void Save(IEnumerable<Common.PrincipalHasRole> insertedNew, IEnumerable<Common.PrincipalHasRole> updatedNew, IEnumerable<Common.PrincipalHasRole> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.PrincipalHasRole*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.PrincipalHasRole*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalHasRole*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalHasRole*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.PrincipalHasRole*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_PrincipalHasRole> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_PrincipalHasRole>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_PrincipalHasRole> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_PrincipalHasRole>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.PrincipalHasRole*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.PrincipalID == null /*RequiredPropertyInfo OrCondition Common.PrincipalHasRole.Principal*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalHasRole", "Principal" },
                        "DataStructure:Common.PrincipalHasRole,ID:" + invalid.ID.ToString() + ",Property:PrincipalID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.RoleID == null /*RequiredPropertyInfo OrCondition Common.PrincipalHasRole.Role*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalHasRole", "Role" },
                        "DataStructure:Common.PrincipalHasRole,ID:" + invalid.ID.ToString() + ",Property:RoleID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.PrincipalHasRole*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_PrincipalHasRole.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Principal", @"ID", @"FK_PrincipalHasRole_Principal_PrincipalID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:PrincipalID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.PrincipalHasRole", @"IX_PrincipalHasRole_Principal_Role"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:Principal Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_PrincipalHasRole_Role_RoleID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:RoleID,Referenced:Common.Role";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.PrincipalHasRole*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.PrincipalHasRole");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_PrincipalHasRole> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var principalIds = insertedNew.Concat(updatedNew).Select(item => item.PrincipalID)
                        .Concat(updatedOld.Select(item => item.PrincipalID))
                        .Concat(deletedOld.Select(item => item.PrincipalID))
                        .Where(pid => pid != null).Select(pid => pid.Value)
                        .Distinct().ToList();
                    var principalInfos = _domRepository.Common.Principal.Query(principalIds)
                        .Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name });
                    _authorizationDataCache.ClearCachePrincipals(principalInfos);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.PrincipalHasRole*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.PrincipalHasRole*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.PrincipalHasRole");

                /*DataStructureInfo WritableOrm AfterSave Common.PrincipalHasRole*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredPrincipal()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredPrincipal(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.PrincipalHasRole*/
            yield break;
        }

        public IQueryable<Common.Queryable.Common_PrincipalHasRole> Query(Rhetos.Dom.DefaultConcepts.IPrincipal queryParameter)
        {
            /*QueryWithParameterInfo BeforeQuery Common.PrincipalHasRole.'Rhetos.Dom.DefaultConcepts.IPrincipal'*/
            Func<Rhetos.Dom.DefaultConcepts.IPrincipal, IQueryable<Common.Queryable.Common_PrincipalHasRole>> queryFunction = parameter => Query().Where(item => item.Principal.ID == parameter.ID);
            var queryResult = queryFunction(queryParameter);
            /*QueryWithParameterInfo AfterQuery Common.PrincipalHasRole.'Rhetos.Dom.DefaultConcepts.IPrincipal'*/
            return queryResult;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredPrincipal(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredPrincipal";
            metadata[@"Property"] = @"Principal";
            /*InvalidDataInfo ErrorMetadata Common.PrincipalHasRole.SystemRequiredPrincipal*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.PrincipalHasRole.Principal" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.PrincipalHasRole.SystemRequiredPrincipal*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_PrincipalHasRole> Filter(IQueryable<Common.Queryable.Common_PrincipalHasRole> localSource, Common.SystemRequiredPrincipal localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_PrincipalHasRole>, Common.DomRepository, Common.SystemRequiredPrincipal/*ComposableFilterByInfo AdditionalParametersType Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/, IQueryable<Common.Queryable.Common_PrincipalHasRole>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Principal == null);

            /*ComposableFilterByInfo BeforeFilter Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/);
        }

        public global::Common.PrincipalHasRole[] Filter(Common.SystemRequiredPrincipal filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredPrincipal/*FilterByInfo AdditionalParametersType Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/, Common.PrincipalHasRole[]> filter_Function =
                (repository, parameter) => repository.Common.PrincipalHasRole.Filter(repository.Common.PrincipalHasRole.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.PrincipalHasRole*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Role*/
    public class Role_Repository : /*DataStructureInfo OverrideBaseType Common.Role*/ Common.OrmRepositoryBase<Common.Queryable.Common_Role, Common.Role> // Common.QueryableRepositoryBase<Common.Queryable.Common_Role, Common.Role> // Common.ReadableRepositoryBase<Common.Role> // global::Common.RepositoryBase
        , IWritableRepository<Common.Role>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Role*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Role*/

        public Role_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Role*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Role*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.Role[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_Role> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.Role*/
            return _executionContext.EntityFrameworkContext.Common_Role.AsNoTracking();
        }

        public void Save(IEnumerable<Common.Role> insertedNew, IEnumerable<Common.Role> updatedNew, IEnumerable<Common.Role> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Role*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Name != null && newItem.Name.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Role.Name", "256" },
                        "DataStructure:Common.Role,ID:" + invalidItem.ID.ToString() + ",Property:Name",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.Role*/

            /*DataStructureInfo WritableOrm Initialization Common.Role*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_Role> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Role>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_Role> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Role>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            if (deletedIds.Count() > 0)
            {
                List<Common.RoleInheritsRole> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.RoleInheritsRole.Query()
                        .Where(child => child.UsersFromID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.RoleInheritsRole { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.RoleInheritsRole.Delete(childItems);
            }

            if (deletedIds.Count() > 0)
            {
                List<Common.RolePermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.RolePermission.Query()
                        .Where(child => child.RoleID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.RolePermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.RolePermission.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Common.Role*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Name == null || string.IsNullOrWhiteSpace(item.Name) /*RequiredPropertyInfo OrCondition Common.Role.Name*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Role", "Name" },
                        "DataStructure:Common.Role,ID:" + invalid.ID.ToString() + ",Property:Name", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Role*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_Role.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalHasRole", @"RoleID", @"FK_PrincipalHasRole_Role_RoleID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:RoleID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RoleInheritsRole", @"UsersFromID", @"FK_RoleInheritsRole_Role_UsersFromID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:UsersFromID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RoleInheritsRole", @"PermissionsFromID", @"FK_RoleInheritsRole_Role_PermissionsFromID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:PermissionsFromID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RolePermission", @"RoleID", @"FK_RolePermission_Role_RoleID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:RoleID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.Role", @"IX_Role_Name"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.Role,Property:Name";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.Role*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.Role");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Role> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var roleIds = insertedNew.Concat(updatedNew).Concat(deletedIds).Select(r => r.ID);
                    _authorizationDataCache.ClearCacheRoles(roleIds);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Role*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Role*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Role");

                /*DataStructureInfo WritableOrm AfterSave Common.Role*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Role*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.Role*/
    }

    /*DataStructureInfo RepositoryAttributes Common.RoleInheritsRole*/
    public class RoleInheritsRole_Repository : /*DataStructureInfo OverrideBaseType Common.RoleInheritsRole*/ Common.OrmRepositoryBase<Common.Queryable.Common_RoleInheritsRole, Common.RoleInheritsRole> // Common.QueryableRepositoryBase<Common.Queryable.Common_RoleInheritsRole, Common.RoleInheritsRole> // Common.ReadableRepositoryBase<Common.RoleInheritsRole> // global::Common.RepositoryBase
        , IWritableRepository<Common.RoleInheritsRole>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.RoleInheritsRole*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.RoleInheritsRole*/

        public RoleInheritsRole_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.RoleInheritsRole*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.RoleInheritsRole*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.RoleInheritsRole[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_RoleInheritsRole> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.RoleInheritsRole*/
            return _executionContext.EntityFrameworkContext.Common_RoleInheritsRole.AsNoTracking();
        }

        public void Save(IEnumerable<Common.RoleInheritsRole> insertedNew, IEnumerable<Common.RoleInheritsRole> updatedNew, IEnumerable<Common.RoleInheritsRole> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.RoleInheritsRole*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.RoleInheritsRole*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                UsersFromID = item.UsersFromID/*LoadOldItemsInfo SelectProperties Common.RoleInheritsRole*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                UsersFromID = item.UsersFromID/*LoadOldItemsInfo SelectProperties Common.RoleInheritsRole*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.RoleInheritsRole*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_RoleInheritsRole> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_RoleInheritsRole>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_RoleInheritsRole> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_RoleInheritsRole>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.RoleInheritsRole*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.UsersFromID == null /*RequiredPropertyInfo OrCondition Common.RoleInheritsRole.UsersFrom*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RoleInheritsRole", "UsersFrom" },
                        "DataStructure:Common.RoleInheritsRole,ID:" + invalid.ID.ToString() + ",Property:UsersFromID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.PermissionsFromID == null /*RequiredPropertyInfo OrCondition Common.RoleInheritsRole.PermissionsFrom*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RoleInheritsRole", "PermissionsFrom" },
                        "DataStructure:Common.RoleInheritsRole,ID:" + invalid.ID.ToString() + ",Property:PermissionsFromID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.RoleInheritsRole*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_RoleInheritsRole.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_RoleInheritsRole_Role_UsersFromID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:UsersFromID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_RoleInheritsRole_Role_PermissionsFromID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:PermissionsFromID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.RoleInheritsRole", @"IX_RoleInheritsRole_UsersFrom_PermissionsFrom"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:UsersFrom PermissionsFrom";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.RoleInheritsRole*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.RoleInheritsRole");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_RoleInheritsRole> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var roleIds = insertedNew.Concat(updatedNew).Select(item => item.UsersFromID)
                        .Concat(updatedOld.Select(item => item.UsersFromID))
                        .Concat(deletedOld.Select(item => item.UsersFromID))
                        .Where(rid => rid != null).Select(rid => rid.Value);
                    _authorizationDataCache.ClearCacheRoles(roleIds);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.RoleInheritsRole*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.RoleInheritsRole*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.RoleInheritsRole");

                /*DataStructureInfo WritableOrm AfterSave Common.RoleInheritsRole*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredUsersFrom()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredUsersFrom(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.RoleInheritsRole*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredUsersFrom(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredUsersFrom";
            metadata[@"Property"] = @"UsersFrom";
            /*InvalidDataInfo ErrorMetadata Common.RoleInheritsRole.SystemRequiredUsersFrom*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.RoleInheritsRole.UsersFrom" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.RoleInheritsRole.SystemRequiredUsersFrom*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_RoleInheritsRole> Filter(IQueryable<Common.Queryable.Common_RoleInheritsRole> localSource, Common.SystemRequiredUsersFrom localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_RoleInheritsRole>, Common.DomRepository, Common.SystemRequiredUsersFrom/*ComposableFilterByInfo AdditionalParametersType Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/, IQueryable<Common.Queryable.Common_RoleInheritsRole>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.UsersFrom == null);

            /*ComposableFilterByInfo BeforeFilter Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/);
        }

        public global::Common.RoleInheritsRole[] Filter(Common.SystemRequiredUsersFrom filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredUsersFrom/*FilterByInfo AdditionalParametersType Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/, Common.RoleInheritsRole[]> filter_Function =
                (repository, parameter) => repository.Common.RoleInheritsRole.Filter(repository.Common.RoleInheritsRole.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.RoleInheritsRole*/
    }

    /*DataStructureInfo RepositoryAttributes Common.PrincipalPermission*/
    public class PrincipalPermission_Repository : /*DataStructureInfo OverrideBaseType Common.PrincipalPermission*/ Common.OrmRepositoryBase<Common.Queryable.Common_PrincipalPermission, Common.PrincipalPermission> // Common.QueryableRepositoryBase<Common.Queryable.Common_PrincipalPermission, Common.PrincipalPermission> // Common.ReadableRepositoryBase<Common.PrincipalPermission> // global::Common.RepositoryBase
        , IWritableRepository<Common.PrincipalPermission>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.PrincipalPermission*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.PrincipalPermission*/

        public PrincipalPermission_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.PrincipalPermission*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.PrincipalPermission*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.PrincipalPermission[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_PrincipalPermission> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.PrincipalPermission*/
            return _executionContext.EntityFrameworkContext.Common_PrincipalPermission.AsNoTracking();
        }

        public void Save(IEnumerable<Common.PrincipalPermission> insertedNew, IEnumerable<Common.PrincipalPermission> updatedNew, IEnumerable<Common.PrincipalPermission> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.PrincipalPermission*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.PrincipalPermission*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalPermission*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalPermission*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.PrincipalPermission*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_PrincipalPermission> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_PrincipalPermission>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_PrincipalPermission> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_PrincipalPermission>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.PrincipalPermission*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.PrincipalID == null /*RequiredPropertyInfo OrCondition Common.PrincipalPermission.Principal*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalPermission", "Principal" },
                        "DataStructure:Common.PrincipalPermission,ID:" + invalid.ID.ToString() + ",Property:PrincipalID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimID == null /*RequiredPropertyInfo OrCondition Common.PrincipalPermission.Claim*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalPermission", "Claim" },
                        "DataStructure:Common.PrincipalPermission,ID:" + invalid.ID.ToString() + ",Property:ClaimID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.IsAuthorized == null /*RequiredPropertyInfo OrCondition Common.PrincipalPermission.IsAuthorized*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalPermission", "IsAuthorized" },
                        "DataStructure:Common.PrincipalPermission,ID:" + invalid.ID.ToString() + ",Property:IsAuthorized", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.PrincipalPermission*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_PrincipalPermission.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Principal", @"ID", @"FK_PrincipalPermission_Principal_PrincipalID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:PrincipalID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Claim", @"ID", @"FK_PrincipalPermission_Claim_ClaimID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:ClaimID,Referenced:Common.Claim";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.PrincipalPermission", @"IX_PrincipalPermission_Principal_Claim"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:Principal Claim";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.PrincipalPermission*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.PrincipalPermission");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_PrincipalPermission> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var principalIds = insertedNew.Concat(updatedNew).Select(item => item.PrincipalID)
                        .Concat(updatedOld.Select(item => item.PrincipalID))
                        .Concat(deletedOld.Select(item => item.PrincipalID))
                        .Where(pid => pid != null).Select(pid => pid.Value)
                        .Distinct().ToList();
                    var principalInfos = _domRepository.Common.Principal.Query(principalIds)
                        .Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name });
                    _authorizationDataCache.ClearCachePrincipals(principalInfos);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.PrincipalPermission*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.PrincipalPermission*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.PrincipalPermission");

                /*DataStructureInfo WritableOrm AfterSave Common.PrincipalPermission*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredPrincipal()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredPrincipal(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredClaim()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredClaim(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.PrincipalPermission*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredPrincipal(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredPrincipal";
            metadata[@"Property"] = @"Principal";
            /*InvalidDataInfo ErrorMetadata Common.PrincipalPermission.SystemRequiredPrincipal*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.PrincipalPermission.Principal" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.PrincipalPermission.SystemRequiredPrincipal*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredClaim(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredClaim";
            metadata[@"Property"] = @"Claim";
            /*InvalidDataInfo ErrorMetadata Common.PrincipalPermission.SystemRequiredClaim*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.PrincipalPermission.Claim" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.PrincipalPermission.SystemRequiredClaim*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_PrincipalPermission> Filter(IQueryable<Common.Queryable.Common_PrincipalPermission> localSource, Common.SystemRequiredPrincipal localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_PrincipalPermission>, Common.DomRepository, Common.SystemRequiredPrincipal/*ComposableFilterByInfo AdditionalParametersType Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/, IQueryable<Common.Queryable.Common_PrincipalPermission>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Principal == null);

            /*ComposableFilterByInfo BeforeFilter Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/);
        }

        public IQueryable<Common.Queryable.Common_PrincipalPermission> Filter(IQueryable<Common.Queryable.Common_PrincipalPermission> localSource, Common.SystemRequiredClaim localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_PrincipalPermission>, Common.DomRepository, Common.SystemRequiredClaim/*ComposableFilterByInfo AdditionalParametersType Common.PrincipalPermission.'Common.SystemRequiredClaim'*/, IQueryable<Common.Queryable.Common_PrincipalPermission>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Claim == null);

            /*ComposableFilterByInfo BeforeFilter Common.PrincipalPermission.'Common.SystemRequiredClaim'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.PrincipalPermission.'Common.SystemRequiredClaim'*/);
        }

        public global::Common.PrincipalPermission[] Filter(Common.SystemRequiredPrincipal filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredPrincipal/*FilterByInfo AdditionalParametersType Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/, Common.PrincipalPermission[]> filter_Function =
                (repository, parameter) => repository.Common.PrincipalPermission.Filter(repository.Common.PrincipalPermission.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/);
        }

        public global::Common.PrincipalPermission[] Filter(Common.SystemRequiredClaim filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredClaim/*FilterByInfo AdditionalParametersType Common.PrincipalPermission.'Common.SystemRequiredClaim'*/, Common.PrincipalPermission[]> filter_Function =
                (repository, parameter) => repository.Common.PrincipalPermission.Filter(repository.Common.PrincipalPermission.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.PrincipalPermission.'Common.SystemRequiredClaim'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.PrincipalPermission*/
    }

    /*DataStructureInfo RepositoryAttributes Common.RolePermission*/
    public class RolePermission_Repository : /*DataStructureInfo OverrideBaseType Common.RolePermission*/ Common.OrmRepositoryBase<Common.Queryable.Common_RolePermission, Common.RolePermission> // Common.QueryableRepositoryBase<Common.Queryable.Common_RolePermission, Common.RolePermission> // Common.ReadableRepositoryBase<Common.RolePermission> // global::Common.RepositoryBase
        , IWritableRepository<Common.RolePermission>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.RolePermission*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.RolePermission*/

        public RolePermission_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.RolePermission*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.RolePermission*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.RolePermission[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_RolePermission> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.RolePermission*/
            return _executionContext.EntityFrameworkContext.Common_RolePermission.AsNoTracking();
        }

        public void Save(IEnumerable<Common.RolePermission> insertedNew, IEnumerable<Common.RolePermission> updatedNew, IEnumerable<Common.RolePermission> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.RolePermission*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.RolePermission*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                RoleID = item.RoleID/*LoadOldItemsInfo SelectProperties Common.RolePermission*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                RoleID = item.RoleID/*LoadOldItemsInfo SelectProperties Common.RolePermission*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.RolePermission*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_RolePermission> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_RolePermission>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_RolePermission> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_RolePermission>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.RolePermission*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.RoleID == null /*RequiredPropertyInfo OrCondition Common.RolePermission.Role*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RolePermission", "Role" },
                        "DataStructure:Common.RolePermission,ID:" + invalid.ID.ToString() + ",Property:RoleID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimID == null /*RequiredPropertyInfo OrCondition Common.RolePermission.Claim*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RolePermission", "Claim" },
                        "DataStructure:Common.RolePermission,ID:" + invalid.ID.ToString() + ",Property:ClaimID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.IsAuthorized == null /*RequiredPropertyInfo OrCondition Common.RolePermission.IsAuthorized*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RolePermission", "IsAuthorized" },
                        "DataStructure:Common.RolePermission,ID:" + invalid.ID.ToString() + ",Property:IsAuthorized", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.RolePermission*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_RolePermission.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_RolePermission_Role_RoleID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:RoleID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Claim", @"ID", @"FK_RolePermission_Claim_ClaimID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:ClaimID,Referenced:Common.Claim";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.RolePermission", @"IX_RolePermission_Role_Claim"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:Role Claim";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.RolePermission*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.RolePermission");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_RolePermission> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var roleIds = insertedNew.Concat(updatedNew).Select(item => item.RoleID)
                        .Concat(updatedOld.Select(item => item.RoleID))
                        .Concat(deletedOld.Select(item => item.RoleID))
                        .Where(rid => rid != null).Select(rid => rid.Value);
                    _authorizationDataCache.ClearCacheRoles(roleIds);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.RolePermission*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.RolePermission*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.RolePermission");

                /*DataStructureInfo WritableOrm AfterSave Common.RolePermission*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredRole()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredRole(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredClaim()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredClaim(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.RolePermission*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredRole(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredRole";
            metadata[@"Property"] = @"Role";
            /*InvalidDataInfo ErrorMetadata Common.RolePermission.SystemRequiredRole*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.RolePermission.Role" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.RolePermission.SystemRequiredRole*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredClaim(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredClaim";
            metadata[@"Property"] = @"Claim";
            /*InvalidDataInfo ErrorMetadata Common.RolePermission.SystemRequiredClaim*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.RolePermission.Claim" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.RolePermission.SystemRequiredClaim*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_RolePermission> Filter(IQueryable<Common.Queryable.Common_RolePermission> localSource, Common.SystemRequiredRole localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_RolePermission>, Common.DomRepository, Common.SystemRequiredRole/*ComposableFilterByInfo AdditionalParametersType Common.RolePermission.'Common.SystemRequiredRole'*/, IQueryable<Common.Queryable.Common_RolePermission>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Role == null);

            /*ComposableFilterByInfo BeforeFilter Common.RolePermission.'Common.SystemRequiredRole'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.RolePermission.'Common.SystemRequiredRole'*/);
        }

        public IQueryable<Common.Queryable.Common_RolePermission> Filter(IQueryable<Common.Queryable.Common_RolePermission> localSource, Common.SystemRequiredClaim localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_RolePermission>, Common.DomRepository, Common.SystemRequiredClaim/*ComposableFilterByInfo AdditionalParametersType Common.RolePermission.'Common.SystemRequiredClaim'*/, IQueryable<Common.Queryable.Common_RolePermission>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Claim == null);

            /*ComposableFilterByInfo BeforeFilter Common.RolePermission.'Common.SystemRequiredClaim'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.RolePermission.'Common.SystemRequiredClaim'*/);
        }

        public global::Common.RolePermission[] Filter(Common.SystemRequiredRole filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredRole/*FilterByInfo AdditionalParametersType Common.RolePermission.'Common.SystemRequiredRole'*/, Common.RolePermission[]> filter_Function =
                (repository, parameter) => repository.Common.RolePermission.Filter(repository.Common.RolePermission.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.RolePermission.'Common.SystemRequiredRole'*/);
        }

        public global::Common.RolePermission[] Filter(Common.SystemRequiredClaim filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredClaim/*FilterByInfo AdditionalParametersType Common.RolePermission.'Common.SystemRequiredClaim'*/, Common.RolePermission[]> filter_Function =
                (repository, parameter) => repository.Common.RolePermission.Filter(repository.Common.RolePermission.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.RolePermission.'Common.SystemRequiredClaim'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.RolePermission*/
    }

    /*ModuleInfo HelperNamespaceMembers Common*/
}

/*RepositoryClasses*/