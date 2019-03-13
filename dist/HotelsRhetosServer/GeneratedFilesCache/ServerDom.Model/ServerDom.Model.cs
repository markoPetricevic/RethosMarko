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

    /*ModuleInfo Using Common*/

    [DataContract]/*DataStructureInfo ClassAttributes Common.AutoCodeCache*/
    public class AutoCodeCache : EntityBase<Common.AutoCodeCache>/*Next DataStructureInfo ClassInterace Common.AutoCodeCache*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_AutoCodeCache ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_AutoCodeCache
            {
                ID = item.ID,
                Entity = item.Entity,
                Property = item.Property,
                Grouping = item.Grouping,
                Prefix = item.Prefix,
                MinDigits = item.MinDigits,
                LastCode = item.LastCode/*DataStructureInfo AssignSimpleProperty Common.AutoCodeCache*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Entity*/
        public string Entity { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Property*/
        public string Property { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Grouping*/
        public string Grouping { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Prefix*/
        public string Prefix { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.MinDigits*/
        public int? MinDigits { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.LastCode*/
        public int? LastCode { get; set; }
        /*DataStructureInfo ClassBody Common.AutoCodeCache*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.FilterId*/
    public class FilterId : EntityBase<Common.FilterId>, Rhetos.Dom.DefaultConcepts.ICommonFilterId/*Next DataStructureInfo ClassInterace Common.FilterId*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_FilterId ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_FilterId
            {
                ID = item.ID,
                Handle = item.Handle,
                Value = item.Value/*DataStructureInfo AssignSimpleProperty Common.FilterId*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.FilterId.Handle*/
        public Guid? Handle { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.FilterId.Value*/
        public Guid? Value { get; set; }
        /*DataStructureInfo ClassBody Common.FilterId*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.KeepSynchronizedMetadata*/
    public class KeepSynchronizedMetadata : EntityBase<Common.KeepSynchronizedMetadata>, Rhetos.Dom.DefaultConcepts.IKeepSynchronizedMetadata/*Next DataStructureInfo ClassInterace Common.KeepSynchronizedMetadata*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_KeepSynchronizedMetadata ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_KeepSynchronizedMetadata
            {
                ID = item.ID,
                Target = item.Target,
                Source = item.Source,
                Context = item.Context/*DataStructureInfo AssignSimpleProperty Common.KeepSynchronizedMetadata*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.KeepSynchronizedMetadata.Target*/
        public string Target { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.KeepSynchronizedMetadata.Source*/
        public string Source { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.KeepSynchronizedMetadata.Context*/
        public string Context { get; set; }
        /*DataStructureInfo ClassBody Common.KeepSynchronizedMetadata*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.ExclusiveLock*/
    public class ExclusiveLock : EntityBase<Common.ExclusiveLock>/*Next DataStructureInfo ClassInterace Common.ExclusiveLock*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_ExclusiveLock ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_ExclusiveLock
            {
                ID = item.ID,
                ResourceType = item.ResourceType,
                ResourceID = item.ResourceID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                LockStart = item.LockStart,
                LockFinish = item.LockFinish/*DataStructureInfo AssignSimpleProperty Common.ExclusiveLock*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.ResourceType*/
        public string ResourceType { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.ResourceID*/
        public Guid? ResourceID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.LockStart*/
        public DateTime? LockStart { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.LockFinish*/
        public DateTime? LockFinish { get; set; }
        /*DataStructureInfo ClassBody Common.ExclusiveLock*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SetLock*/
    public class SetLock/*DataStructureInfo ClassInterace Common.SetLock*/
    {
        [DataMember]/*PropertyInfo Attribute Common.SetLock.ResourceType*/
        public string ResourceType { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.SetLock.ResourceID*/
        public Guid? ResourceID { get; set; }
        /*DataStructureInfo ClassBody Common.SetLock*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.ReleaseLock*/
    public class ReleaseLock/*DataStructureInfo ClassInterace Common.ReleaseLock*/
    {
        [DataMember]/*PropertyInfo Attribute Common.ReleaseLock.ResourceType*/
        public string ResourceType { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ReleaseLock.ResourceID*/
        public Guid? ResourceID { get; set; }
        /*DataStructureInfo ClassBody Common.ReleaseLock*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.LogReader*/
    public class LogReader : EntityBase<Common.LogReader>/*Next DataStructureInfo ClassInterace Common.LogReader*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_LogReader ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_LogReader
            {
                ID = item.ID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.LogReader*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.LogReader.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.ContextInfo*/
        public string ContextInfo { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Description*/
        public string Description { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Created*/
        public DateTime? Created { get; set; }
        /*DataStructureInfo ClassBody Common.LogReader*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.LogRelatedItemReader*/
    public class LogRelatedItemReader : EntityBase<Common.LogRelatedItemReader>/*Next DataStructureInfo ClassInterace Common.LogRelatedItemReader*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_LogRelatedItemReader ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_LogRelatedItemReader
            {
                ID = item.ID,
                TableName = item.TableName,
                Relation = item.Relation,
                ItemId = item.ItemId,
                LogID = item.LogID/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItemReader*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.Relation*/
        public string Relation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.LogID*/
        public Guid? LogID { get; set; }
        /*DataStructureInfo ClassBody Common.LogRelatedItemReader*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Log*/
    public class Log : EntityBase<Common.Log>/*Next DataStructureInfo ClassInterace Common.Log*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Log ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Log
            {
                ID = item.ID,
                Created = item.Created,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description/*DataStructureInfo AssignSimpleProperty Common.Log*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Log.Created*/
        public DateTime? Created { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.ContextInfo*/
        public string ContextInfo { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.Description*/
        public string Description { get; set; }
        /*DataStructureInfo ClassBody Common.Log*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.AddToLog*/
    public class AddToLog/*DataStructureInfo ClassInterace Common.AddToLog*/
    {
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.Description*/
        public string Description { get; set; }
        /*DataStructureInfo ClassBody Common.AddToLog*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.LogRelatedItem*/
    public class LogRelatedItem : EntityBase<Common.LogRelatedItem>/*Next DataStructureInfo ClassInterace Common.LogRelatedItem*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_LogRelatedItem ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_LogRelatedItem
            {
                ID = item.ID,
                LogID = item.LogID,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Relation = item.Relation/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItem*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.LogID*/
        public Guid? LogID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.Relation*/
        public string Relation { get; set; }
        /*DataStructureInfo ClassBody Common.LogRelatedItem*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RelatedEventsSource*/
    public class RelatedEventsSource : EntityBase<Common.RelatedEventsSource>/*Next DataStructureInfo ClassInterace Common.RelatedEventsSource*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_RelatedEventsSource ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_RelatedEventsSource
            {
                ID = item.ID,
                LogID = item.LogID,
                Relation = item.Relation,
                RelatedToTable = item.RelatedToTable,
                RelatedToItem = item.RelatedToItem,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.RelatedEventsSource*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.LogID*/
        public Guid? LogID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Relation*/
        public string Relation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.RelatedToTable*/
        public string RelatedToTable { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.RelatedToItem*/
        public Guid? RelatedToItem { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.ContextInfo*/
        public string ContextInfo { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Description*/
        public string Description { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Created*/
        public DateTime? Created { get; set; }
        /*DataStructureInfo ClassBody Common.RelatedEventsSource*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Claim*/
    public class Claim : EntityBase<Common.Claim>, Rhetos.Dom.DefaultConcepts.IDeactivatable, Rhetos.Dom.DefaultConcepts.ICommonClaim/*Next DataStructureInfo ClassInterace Common.Claim*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Claim ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Claim
            {
                ID = item.ID,
                ClaimResource = item.ClaimResource,
                ClaimRight = item.ClaimRight,
                Active = item.Active/*DataStructureInfo AssignSimpleProperty Common.Claim*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Claim.ClaimResource*/
        public string ClaimResource { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Claim.ClaimRight*/
        public string ClaimRight { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Claim.Active*/
        public bool? Active { get; set; }
        /*DataStructureInfo ClassBody Common.Claim*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.MyClaim*/
    public class MyClaim : EntityBase<Common.MyClaim>/*Next DataStructureInfo ClassInterace Common.MyClaim*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_MyClaim ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_MyClaim
            {
                ID = item.ID,
                Applies = item.Applies/*DataStructureInfo AssignSimpleProperty Common.MyClaim*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.MyClaim.Applies*/
        public bool? Applies { get; set; }
        /*DataStructureInfo ClassBody Common.MyClaim*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Principal*/
    public class Principal : EntityBase<Common.Principal>, Rhetos.Dom.DefaultConcepts.IPrincipal/*Next DataStructureInfo ClassInterace Common.Principal*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Principal ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Principal
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Principal*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Principal.Name*/
        public string Name { get; set; }
        /*DataStructureInfo ClassBody Common.Principal*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.PrincipalHasRole*/
    public class PrincipalHasRole : EntityBase<Common.PrincipalHasRole>, Rhetos.Dom.DefaultConcepts.IPrincipalHasRole/*Next DataStructureInfo ClassInterace Common.PrincipalHasRole*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_PrincipalHasRole ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_PrincipalHasRole
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                RoleID = item.RoleID/*DataStructureInfo AssignSimpleProperty Common.PrincipalHasRole*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.PrincipalHasRole.PrincipalID*/
        public Guid? PrincipalID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.PrincipalHasRole.RoleID*/
        public Guid? RoleID { get; set; }
        /*DataStructureInfo ClassBody Common.PrincipalHasRole*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Role*/
    public class Role : EntityBase<Common.Role>, Rhetos.Dom.DefaultConcepts.IRole/*Next DataStructureInfo ClassInterace Common.Role*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Role ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Role
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Role*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Role.Name*/
        public string Name { get; set; }
        /*DataStructureInfo ClassBody Common.Role*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RoleInheritsRole*/
    public class RoleInheritsRole : EntityBase<Common.RoleInheritsRole>, Rhetos.Dom.DefaultConcepts.IRoleInheritsRole/*Next DataStructureInfo ClassInterace Common.RoleInheritsRole*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_RoleInheritsRole ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_RoleInheritsRole
            {
                ID = item.ID,
                UsersFromID = item.UsersFromID,
                PermissionsFromID = item.PermissionsFromID/*DataStructureInfo AssignSimpleProperty Common.RoleInheritsRole*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.RoleInheritsRole.UsersFromID*/
        public Guid? UsersFromID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RoleInheritsRole.PermissionsFromID*/
        public Guid? PermissionsFromID { get; set; }
        /*DataStructureInfo ClassBody Common.RoleInheritsRole*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.PrincipalPermission*/
    public class PrincipalPermission : EntityBase<Common.PrincipalPermission>, Rhetos.Dom.DefaultConcepts.IPrincipalPermission/*Next DataStructureInfo ClassInterace Common.PrincipalPermission*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_PrincipalPermission ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_PrincipalPermission
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.PrincipalPermission*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.PrincipalPermission.PrincipalID*/
        public Guid? PrincipalID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.PrincipalPermission.ClaimID*/
        public Guid? ClaimID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.PrincipalPermission.IsAuthorized*/
        public bool? IsAuthorized { get; set; }
        /*DataStructureInfo ClassBody Common.PrincipalPermission*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RolePermission*/
    public class RolePermission : EntityBase<Common.RolePermission>, Rhetos.Dom.DefaultConcepts.IRolePermission/*Next DataStructureInfo ClassInterace Common.RolePermission*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_RolePermission ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_RolePermission
            {
                ID = item.ID,
                RoleID = item.RoleID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.RolePermission*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.RolePermission.RoleID*/
        public Guid? RoleID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RolePermission.ClaimID*/
        public Guid? ClaimID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RolePermission.IsAuthorized*/
        public bool? IsAuthorized { get; set; }
        /*DataStructureInfo ClassBody Common.RolePermission*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RowPermissionsReadItems*/
    public class RowPermissionsReadItems/*DataStructureInfo ClassInterace Common.RowPermissionsReadItems*/
    {
        /*DataStructureInfo ClassBody Common.RowPermissionsReadItems*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RowPermissionsWriteItems*/
    public class RowPermissionsWriteItems/*DataStructureInfo ClassInterace Common.RowPermissionsWriteItems*/
    {
        /*DataStructureInfo ClassBody Common.RowPermissionsWriteItems*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredActive*/
    public class SystemRequiredActive/*DataStructureInfo ClassInterace Common.SystemRequiredActive*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredActive*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredLog*/
    public class SystemRequiredLog/*DataStructureInfo ClassInterace Common.SystemRequiredLog*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredLog*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredPrincipal*/
    public class SystemRequiredPrincipal/*DataStructureInfo ClassInterace Common.SystemRequiredPrincipal*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredPrincipal*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredUsersFrom*/
    public class SystemRequiredUsersFrom/*DataStructureInfo ClassInterace Common.SystemRequiredUsersFrom*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredUsersFrom*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredClaim*/
    public class SystemRequiredClaim/*DataStructureInfo ClassInterace Common.SystemRequiredClaim*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredClaim*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredRole*/
    public class SystemRequiredRole/*DataStructureInfo ClassInterace Common.SystemRequiredRole*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredRole*/
    }

    /*ModuleInfo Body Common*/
}

namespace Hotels
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

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.Hotel*/
    public class Hotel : EntityBase<Hotels.Hotel>/*Next DataStructureInfo ClassInterace Hotels.Hotel*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Hotels_Hotel ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Hotels_Hotel
            {
                ID = item.ID,
                Name = item.Name,
                Address = item.Address,
                Manager = item.Manager/*DataStructureInfo AssignSimpleProperty Hotels.Hotel*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Hotels.Hotel.Name*/
        public string Name { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.Hotel.Address*/
        public string Address { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.Hotel.Manager*/
        public string Manager { get; set; }
        /*DataStructureInfo ClassBody Hotels.Hotel*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.NameSearch*/
    public class NameSearch/*DataStructureInfo ClassInterace Hotels.NameSearch*/
    {
        [DataMember]/*PropertyInfo Attribute Hotels.NameSearch.Pattern*/
        public string Pattern { get; set; }
        /*DataStructureInfo ClassBody Hotels.NameSearch*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.Guest*/
    public class Guest : EntityBase<Hotels.Guest>/*Next DataStructureInfo ClassInterace Hotels.Guest*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Hotels_Guest ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Hotels_Guest
            {
                ID = item.ID,
                Name = item.Name,
                Surname = item.Surname,
                Phone = item.Phone,
                Email = item.Email/*DataStructureInfo AssignSimpleProperty Hotels.Guest*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Hotels.Guest.Name*/
        public string Name { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.Guest.Surname*/
        public string Surname { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.Guest.Phone*/
        public string Phone { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.Guest.Email*/
        public string Email { get; set; }
        /*DataStructureInfo ClassBody Hotels.Guest*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.RoomKind*/
    public class RoomKind : EntityBase<Hotels.RoomKind>/*Next DataStructureInfo ClassInterace Hotels.RoomKind*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Hotels_RoomKind ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Hotels_RoomKind
            {
                ID = item.ID,
                Name = item.Name,
                Price = item.Price/*DataStructureInfo AssignSimpleProperty Hotels.RoomKind*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Hotels.RoomKind.Name*/
        public string Name { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.RoomKind.Price*/
        public decimal? Price { get; set; }
        /*DataStructureInfo ClassBody Hotels.RoomKind*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.Room*/
    public class Room : EntityBase<Hotels.Room>/*Next DataStructureInfo ClassInterace Hotels.Room*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Hotels_Room ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Hotels_Room
            {
                ID = item.ID,
                RoomNumber = item.RoomNumber,
                HotelID = item.HotelID,
                RoomKindID = item.RoomKindID,
                Remark = item.Remark,
                VrijemeZadnjeIzmjene = item.VrijemeZadnjeIzmjene/*DataStructureInfo AssignSimpleProperty Hotels.Room*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Hotels.Room.RoomNumber*/
        public string RoomNumber { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.Room.HotelID*/
        public Guid? HotelID { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.Room.RoomKindID*/
        public Guid? RoomKindID { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.Room.Remark*/
        public string Remark { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.Room.VrijemeZadnjeIzmjene*/
        public DateTime? VrijemeZadnjeIzmjene { get; set; }
        /*DataStructureInfo ClassBody Hotels.Room*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.Good*/
    public class Good : EntityBase<Hotels.Good>/*Next DataStructureInfo ClassInterace Hotels.Good*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Hotels_Good ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Hotels_Good
            {
                ID = item.ID,
                Name = item.Name,
                Price = item.Price/*DataStructureInfo AssignSimpleProperty Hotels.Good*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Hotels.Good.Name*/
        public string Name { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.Good.Price*/
        public decimal? Price { get; set; }
        /*DataStructureInfo ClassBody Hotels.Good*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.GoodKind*/
    public class GoodKind : EntityBase<Hotels.GoodKind>/*Next DataStructureInfo ClassInterace Hotels.GoodKind*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Hotels_GoodKind ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Hotels_GoodKind
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Hotels.GoodKind*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Hotels.GoodKind.Name*/
        public string Name { get; set; }
        /*DataStructureInfo ClassBody Hotels.GoodKind*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.Service*/
    public class Service : EntityBase<Hotels.Service>/*Next DataStructureInfo ClassInterace Hotels.Service*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Hotels_Service ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Hotels_Service
            {
                ID = item.ID,
                GoodKindID = item.GoodKindID/*DataStructureInfo AssignSimpleProperty Hotels.Service*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Hotels.Service.GoodKindID*/
        public Guid? GoodKindID { get; set; }
        /*DataStructureInfo ClassBody Hotels.Service*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.Product*/
    public class Product : EntityBase<Hotels.Product>/*Next DataStructureInfo ClassInterace Hotels.Product*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Hotels_Product ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Hotels_Product
            {
                ID = item.ID,
                GoodKindID = item.GoodKindID/*DataStructureInfo AssignSimpleProperty Hotels.Product*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Hotels.Product.GoodKindID*/
        public Guid? GoodKindID { get; set; }
        /*DataStructureInfo ClassBody Hotels.Product*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.Reservation*/
    public class Reservation : EntityBase<Hotels.Reservation>/*Next DataStructureInfo ClassInterace Hotels.Reservation*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Hotels_Reservation ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Hotels_Reservation
            {
                ID = item.ID,
                DateFrom = item.DateFrom,
                DateTo = item.DateTo,
                GuestID = item.GuestID,
                RoomID = item.RoomID/*DataStructureInfo AssignSimpleProperty Hotels.Reservation*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Hotels.Reservation.DateFrom*/
        public DateTime? DateFrom { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.Reservation.DateTo*/
        public DateTime? DateTo { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.Reservation.GuestID*/
        public Guid? GuestID { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.Reservation.RoomID*/
        public Guid? RoomID { get; set; }
        /*DataStructureInfo ClassBody Hotels.Reservation*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.ReservationsForCertainRoom*/
    public class ReservationsForCertainRoom : EntityBase<Hotels.ReservationsForCertainRoom>/*Next DataStructureInfo ClassInterace Hotels.ReservationsForCertainRoom*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Hotels_ReservationsForCertainRoom ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Hotels_ReservationsForCertainRoom
            {
                ID = item.ID,
                NumberOfReservations = item.NumberOfReservations/*DataStructureInfo AssignSimpleProperty Hotels.ReservationsForCertainRoom*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Hotels.ReservationsForCertainRoom.NumberOfReservations*/
        public int? NumberOfReservations { get; set; }
        /*DataStructureInfo ClassBody Hotels.ReservationsForCertainRoom*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.RoomGrid*/
    public class RoomGrid : EntityBase<Hotels.RoomGrid>/*Next DataStructureInfo ClassInterace Hotels.RoomGrid*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Hotels_RoomGrid ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Hotels_RoomGrid
            {
                ID = item.ID,
                RoomNumber = item.RoomNumber,
                HotelName = item.HotelName,
                NumberOfReservations = item.NumberOfReservations/*DataStructureInfo AssignSimpleProperty Hotels.RoomGrid*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Hotels.RoomGrid.RoomNumber*/
        public string RoomNumber { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.RoomGrid.HotelName*/
        public string HotelName { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.RoomGrid.NumberOfReservations*/
        public int? NumberOfReservations { get; set; }
        /*DataStructureInfo ClassBody Hotels.RoomGrid*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.InsertViseSoba*/
    public class InsertViseSoba/*DataStructureInfo ClassInterace Hotels.InsertViseSoba*/
    {
        [DataMember]/*PropertyInfo Attribute Hotels.InsertViseSoba.RoomCount*/
        public int? RoomCount { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.InsertViseSoba.Remark*/
        public string Remark { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.InsertViseSoba.Prefix*/
        public string Prefix { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.InsertViseSoba.HotelID*/
        public Guid? HotelID { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.InsertViseSoba.RoomKindID*/
        public Guid? RoomKindID { get; set; }
        /*DataStructureInfo ClassBody Hotels.InsertViseSoba*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.Invoice*/
    public class Invoice : EntityBase<Hotels.Invoice>/*Next DataStructureInfo ClassInterace Hotels.Invoice*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Hotels_Invoice ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Hotels_Invoice
            {
                ID = item.ID,
                Amount = item.Amount,
                Discount = item.Discount,
                Payed = item.Payed,
                ReservationID = item.ReservationID/*DataStructureInfo AssignSimpleProperty Hotels.Invoice*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Hotels.Invoice.Amount*/
        public decimal? Amount { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.Invoice.Discount*/
        public int? Discount { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.Invoice.Payed*/
        public bool? Payed { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.Invoice.ReservationID*/
        public Guid? ReservationID { get; set; }
        /*DataStructureInfo ClassBody Hotels.Invoice*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.Item*/
    public class Item : EntityBase<Hotels.Item>/*Next DataStructureInfo ClassInterace Hotels.Item*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Hotels_Item ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Hotels_Item
            {
                ID = item.ID,
                Name = item.Name,
                GoodID = item.GoodID,
                InvoiceID = item.InvoiceID/*DataStructureInfo AssignSimpleProperty Hotels.Item*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Hotels.Item.Name*/
        public string Name { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.Item.GoodID*/
        public Guid? GoodID { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.Item.InvoiceID*/
        public Guid? InvoiceID { get; set; }
        /*DataStructureInfo ClassBody Hotels.Item*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.NumberOfRoomsWithoutLockMark*/
    public class NumberOfRoomsWithoutLockMark : EntityBase<Hotels.NumberOfRoomsWithoutLockMark>/*Next DataStructureInfo ClassInterace Hotels.NumberOfRoomsWithoutLockMark*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Hotels_NumberOfRoomsWithoutLockMark ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Hotels_NumberOfRoomsWithoutLockMark
            {
                ID = item.ID,
                NumberOfRooms = item.NumberOfRooms/*DataStructureInfo AssignSimpleProperty Hotels.NumberOfRoomsWithoutLockMark*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Hotels.NumberOfRoomsWithoutLockMark.NumberOfRooms*/
        public int? NumberOfRooms { get; set; }
        /*DataStructureInfo ClassBody Hotels.NumberOfRoomsWithoutLockMark*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.S1*/
    public class S1 : EntityBase<Hotels.S1>/*Next DataStructureInfo ClassInterace Hotels.S1*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Hotels_S1 ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Hotels_S1
            {
                ID = item.ID,
                Oznaka = item.Oznaka,
                Naziv = item.Naziv/*DataStructureInfo AssignSimpleProperty Hotels.S1*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Hotels.S1.Oznaka*/
        public string Oznaka { get; set; }
        [DataMember]/*PropertyInfo Attribute Hotels.S1.Naziv*/
        public string Naziv { get; set; }
        /*DataStructureInfo ClassBody Hotels.S1*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.Discount_MaxValueFilter*/
    public class Discount_MaxValueFilter/*DataStructureInfo ClassInterace Hotels.Discount_MaxValueFilter*/
    {
        /*DataStructureInfo ClassBody Hotels.Discount_MaxValueFilter*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.Discount_MinValueFilter*/
    public class Discount_MinValueFilter/*DataStructureInfo ClassInterace Hotels.Discount_MinValueFilter*/
    {
        /*DataStructureInfo ClassBody Hotels.Discount_MinValueFilter*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.Email_RegExMatchFilter*/
    public class Email_RegExMatchFilter/*DataStructureInfo ClassInterace Hotels.Email_RegExMatchFilter*/
    {
        /*DataStructureInfo ClassBody Hotels.Email_RegExMatchFilter*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.ContainsLockMark*/
    public class ContainsLockMark/*DataStructureInfo ClassInterace Hotels.ContainsLockMark*/
    {
        /*DataStructureInfo ClassBody Hotels.ContainsLockMark*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.SystemRequiredHotel*/
    public class SystemRequiredHotel/*DataStructureInfo ClassInterace Hotels.SystemRequiredHotel*/
    {
        /*DataStructureInfo ClassBody Hotels.SystemRequiredHotel*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.SystemRequiredRoomNumber*/
    public class SystemRequiredRoomNumber/*DataStructureInfo ClassInterace Hotels.SystemRequiredRoomNumber*/
    {
        /*DataStructureInfo ClassBody Hotels.SystemRequiredRoomNumber*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Hotels.SystemRequiredOznaka*/
    public class SystemRequiredOznaka/*DataStructureInfo ClassInterace Hotels.SystemRequiredOznaka*/
    {
        /*DataStructureInfo ClassBody Hotels.SystemRequiredOznaka*/
    }

    /*ModuleInfo Body Hotels*/
}

/*SimpleClasses*/

namespace Common.Queryable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*DataStructureInfo QueryableClassAttributes Common.AutoCodeCache*/
    public class Common_AutoCodeCache : global::Common.AutoCodeCache, IQueryableEntity<Common.AutoCodeCache>, System.IEquatable<Common_AutoCodeCache>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.AutoCodeCache*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.AutoCodeCache ToSimple()
        {
            var item = this;
            return new Common.AutoCodeCache
            {
                ID = item.ID,
                Entity = item.Entity,
                Property = item.Property,
                Grouping = item.Grouping,
                Prefix = item.Prefix,
                MinDigits = item.MinDigits,
                LastCode = item.LastCode/*DataStructureInfo AssignSimpleProperty Common.AutoCodeCache*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.AutoCodeCache*/

        public bool Equals(Common_AutoCodeCache other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.FilterId*/
    public class Common_FilterId : global::Common.FilterId, IQueryableEntity<Common.FilterId>, System.IEquatable<Common_FilterId>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.FilterId*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.FilterId ToSimple()
        {
            var item = this;
            return new Common.FilterId
            {
                ID = item.ID,
                Handle = item.Handle,
                Value = item.Value/*DataStructureInfo AssignSimpleProperty Common.FilterId*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.FilterId*/

        public bool Equals(Common_FilterId other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.KeepSynchronizedMetadata*/
    public class Common_KeepSynchronizedMetadata : global::Common.KeepSynchronizedMetadata, IQueryableEntity<Common.KeepSynchronizedMetadata>, System.IEquatable<Common_KeepSynchronizedMetadata>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.KeepSynchronizedMetadata*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.KeepSynchronizedMetadata ToSimple()
        {
            var item = this;
            return new Common.KeepSynchronizedMetadata
            {
                ID = item.ID,
                Target = item.Target,
                Source = item.Source,
                Context = item.Context/*DataStructureInfo AssignSimpleProperty Common.KeepSynchronizedMetadata*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.KeepSynchronizedMetadata*/

        public bool Equals(Common_KeepSynchronizedMetadata other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.ExclusiveLock*/
    public class Common_ExclusiveLock : global::Common.ExclusiveLock, IQueryableEntity<Common.ExclusiveLock>, System.IEquatable<Common_ExclusiveLock>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.ExclusiveLock*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.ExclusiveLock ToSimple()
        {
            var item = this;
            return new Common.ExclusiveLock
            {
                ID = item.ID,
                ResourceType = item.ResourceType,
                ResourceID = item.ResourceID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                LockStart = item.LockStart,
                LockFinish = item.LockFinish/*DataStructureInfo AssignSimpleProperty Common.ExclusiveLock*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.ExclusiveLock*/

        public bool Equals(Common_ExclusiveLock other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.LogReader*/
    public class Common_LogReader : global::Common.LogReader, IQueryableEntity<Common.LogReader>, System.IEquatable<Common_LogReader>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.LogReader*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.LogReader ToSimple()
        {
            var item = this;
            return new Common.LogReader
            {
                ID = item.ID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.LogReader*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.LogReader*/

        public bool Equals(Common_LogReader other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.LogRelatedItemReader*/
    public class Common_LogRelatedItemReader : global::Common.LogRelatedItemReader, IQueryableEntity<Common.LogRelatedItemReader>, System.IEquatable<Common_LogRelatedItemReader>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.LogRelatedItemReader*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.LogRelatedItemReader ToSimple()
        {
            var item = this;
            return new Common.LogRelatedItemReader
            {
                ID = item.ID,
                TableName = item.TableName,
                Relation = item.Relation,
                ItemId = item.ItemId,
                LogID = item.LogID/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItemReader*/
            };
        }

        private Common.Queryable.Common_Log _log;

        /*DataStructureQueryable PropertyAttribute Common.LogRelatedItemReader.Log*/
        public virtual Common.Queryable.Common_Log Log
        {
            get
            {
                /*DataStructureQueryable Getter Common.LogRelatedItemReader.Log*/
                return _log;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.LogRelatedItemReader.Log*/
                _log = value;
                LogID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.LogRelatedItemReader*/

        public bool Equals(Common_LogRelatedItemReader other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Log*/
    public class Common_Log : global::Common.Log, IQueryableEntity<Common.Log>, System.IEquatable<Common_Log>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Log*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Log ToSimple()
        {
            var item = this;
            return new Common.Log
            {
                ID = item.ID,
                Created = item.Created,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description/*DataStructureInfo AssignSimpleProperty Common.Log*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.Log*/

        public bool Equals(Common_Log other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.LogRelatedItem*/
    public class Common_LogRelatedItem : global::Common.LogRelatedItem, IQueryableEntity<Common.LogRelatedItem>, System.IEquatable<Common_LogRelatedItem>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.LogRelatedItem*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.LogRelatedItem ToSimple()
        {
            var item = this;
            return new Common.LogRelatedItem
            {
                ID = item.ID,
                LogID = item.LogID,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Relation = item.Relation/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItem*/
            };
        }

        private Common.Queryable.Common_Log _log;

        /*DataStructureQueryable PropertyAttribute Common.LogRelatedItem.Log*/
        public virtual Common.Queryable.Common_Log Log
        {
            get
            {
                /*DataStructureQueryable Getter Common.LogRelatedItem.Log*/
                return _log;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.LogRelatedItem.Log*/
                _log = value;
                LogID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.LogRelatedItem*/

        public bool Equals(Common_LogRelatedItem other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.RelatedEventsSource*/
    public class Common_RelatedEventsSource : global::Common.RelatedEventsSource, IQueryableEntity<Common.RelatedEventsSource>, System.IEquatable<Common_RelatedEventsSource>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.RelatedEventsSource*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.RelatedEventsSource ToSimple()
        {
            var item = this;
            return new Common.RelatedEventsSource
            {
                ID = item.ID,
                LogID = item.LogID,
                Relation = item.Relation,
                RelatedToTable = item.RelatedToTable,
                RelatedToItem = item.RelatedToItem,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.RelatedEventsSource*/
            };
        }

        private Common.Queryable.Common_LogReader _log;

        /*DataStructureQueryable PropertyAttribute Common.RelatedEventsSource.Log*/
        public virtual Common.Queryable.Common_LogReader Log
        {
            get
            {
                /*DataStructureQueryable Getter Common.RelatedEventsSource.Log*/
                return _log;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RelatedEventsSource.Log*/
                _log = value;
                LogID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.RelatedEventsSource*/

        public bool Equals(Common_RelatedEventsSource other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Claim*/
    public class Common_Claim : global::Common.Claim, IQueryableEntity<Common.Claim>, System.IEquatable<Common_Claim>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Claim*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Claim ToSimple()
        {
            var item = this;
            return new Common.Claim
            {
                ID = item.ID,
                ClaimResource = item.ClaimResource,
                ClaimRight = item.ClaimRight,
                Active = item.Active/*DataStructureInfo AssignSimpleProperty Common.Claim*/
            };
        }

        private Common.Queryable.Common_MyClaim _extension_MyClaim;

        /*DataStructureQueryable PropertyAttribute Common.Claim.Extension_MyClaim*/
        public virtual Common.Queryable.Common_MyClaim Extension_MyClaim
        {
            get
            {
                /*DataStructureQueryable Getter Common.Claim.Extension_MyClaim*/
                return _extension_MyClaim;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.Claim.Extension_MyClaim*/
                _extension_MyClaim = value;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.Claim*/

        public bool Equals(Common_Claim other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.MyClaim*/
    public class Common_MyClaim : global::Common.MyClaim, IQueryableEntity<Common.MyClaim>, System.IEquatable<Common_MyClaim>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.MyClaim*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.MyClaim ToSimple()
        {
            var item = this;
            return new Common.MyClaim
            {
                ID = item.ID,
                Applies = item.Applies/*DataStructureInfo AssignSimpleProperty Common.MyClaim*/
            };
        }

        private Common.Queryable.Common_Claim _base;

        /*DataStructureQueryable PropertyAttribute Common.MyClaim.Base*/
        public virtual Common.Queryable.Common_Claim Base
        {
            get
            {
                /*DataStructureQueryable Getter Common.MyClaim.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.MyClaim.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.MyClaim*/

        public bool Equals(Common_MyClaim other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Principal*/
    public class Common_Principal : global::Common.Principal, IQueryableEntity<Common.Principal>, System.IEquatable<Common_Principal>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Principal*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Principal ToSimple()
        {
            var item = this;
            return new Common.Principal
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Principal*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.Principal*/

        public bool Equals(Common_Principal other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.PrincipalHasRole*/
    public class Common_PrincipalHasRole : global::Common.PrincipalHasRole, IQueryableEntity<Common.PrincipalHasRole>, System.IEquatable<Common_PrincipalHasRole>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.PrincipalHasRole*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.PrincipalHasRole ToSimple()
        {
            var item = this;
            return new Common.PrincipalHasRole
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                RoleID = item.RoleID/*DataStructureInfo AssignSimpleProperty Common.PrincipalHasRole*/
            };
        }

        private Common.Queryable.Common_Principal _principal;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalHasRole.Principal*/
        public virtual Common.Queryable.Common_Principal Principal
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalHasRole.Principal*/
                return _principal;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalHasRole.Principal*/
                _principal = value;
                PrincipalID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Role _role;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalHasRole.Role*/
        public virtual Common.Queryable.Common_Role Role
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalHasRole.Role*/
                return _role;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalHasRole.Role*/
                _role = value;
                RoleID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.PrincipalHasRole*/

        public bool Equals(Common_PrincipalHasRole other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Role*/
    public class Common_Role : global::Common.Role, IQueryableEntity<Common.Role>, System.IEquatable<Common_Role>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Role*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Role ToSimple()
        {
            var item = this;
            return new Common.Role
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Role*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.Role*/

        public bool Equals(Common_Role other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.RoleInheritsRole*/
    public class Common_RoleInheritsRole : global::Common.RoleInheritsRole, IQueryableEntity<Common.RoleInheritsRole>, System.IEquatable<Common_RoleInheritsRole>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.RoleInheritsRole*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.RoleInheritsRole ToSimple()
        {
            var item = this;
            return new Common.RoleInheritsRole
            {
                ID = item.ID,
                UsersFromID = item.UsersFromID,
                PermissionsFromID = item.PermissionsFromID/*DataStructureInfo AssignSimpleProperty Common.RoleInheritsRole*/
            };
        }

        private Common.Queryable.Common_Role _usersFrom;

        /*DataStructureQueryable PropertyAttribute Common.RoleInheritsRole.UsersFrom*/
        public virtual Common.Queryable.Common_Role UsersFrom
        {
            get
            {
                /*DataStructureQueryable Getter Common.RoleInheritsRole.UsersFrom*/
                return _usersFrom;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RoleInheritsRole.UsersFrom*/
                _usersFrom = value;
                UsersFromID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Role _permissionsFrom;

        /*DataStructureQueryable PropertyAttribute Common.RoleInheritsRole.PermissionsFrom*/
        public virtual Common.Queryable.Common_Role PermissionsFrom
        {
            get
            {
                /*DataStructureQueryable Getter Common.RoleInheritsRole.PermissionsFrom*/
                return _permissionsFrom;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RoleInheritsRole.PermissionsFrom*/
                _permissionsFrom = value;
                PermissionsFromID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.RoleInheritsRole*/

        public bool Equals(Common_RoleInheritsRole other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.PrincipalPermission*/
    public class Common_PrincipalPermission : global::Common.PrincipalPermission, IQueryableEntity<Common.PrincipalPermission>, System.IEquatable<Common_PrincipalPermission>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.PrincipalPermission*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.PrincipalPermission ToSimple()
        {
            var item = this;
            return new Common.PrincipalPermission
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.PrincipalPermission*/
            };
        }

        private Common.Queryable.Common_Principal _principal;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalPermission.Principal*/
        public virtual Common.Queryable.Common_Principal Principal
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalPermission.Principal*/
                return _principal;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalPermission.Principal*/
                _principal = value;
                PrincipalID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Claim _claim;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalPermission.Claim*/
        public virtual Common.Queryable.Common_Claim Claim
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalPermission.Claim*/
                return _claim;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalPermission.Claim*/
                _claim = value;
                ClaimID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.PrincipalPermission*/

        public bool Equals(Common_PrincipalPermission other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.RolePermission*/
    public class Common_RolePermission : global::Common.RolePermission, IQueryableEntity<Common.RolePermission>, System.IEquatable<Common_RolePermission>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.RolePermission*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.RolePermission ToSimple()
        {
            var item = this;
            return new Common.RolePermission
            {
                ID = item.ID,
                RoleID = item.RoleID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.RolePermission*/
            };
        }

        private Common.Queryable.Common_Role _role;

        /*DataStructureQueryable PropertyAttribute Common.RolePermission.Role*/
        public virtual Common.Queryable.Common_Role Role
        {
            get
            {
                /*DataStructureQueryable Getter Common.RolePermission.Role*/
                return _role;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RolePermission.Role*/
                _role = value;
                RoleID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Claim _claim;

        /*DataStructureQueryable PropertyAttribute Common.RolePermission.Claim*/
        public virtual Common.Queryable.Common_Claim Claim
        {
            get
            {
                /*DataStructureQueryable Getter Common.RolePermission.Claim*/
                return _claim;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RolePermission.Claim*/
                _claim = value;
                ClaimID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.RolePermission*/

        public bool Equals(Common_RolePermission other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Hotels.Hotel*/
    public class Hotels_Hotel : global::Hotels.Hotel, IQueryableEntity<Hotels.Hotel>, System.IEquatable<Hotels_Hotel>, IDetachOverride/*DataStructureInfo QueryableClassInterace Hotels.Hotel*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Hotels.Hotel ToSimple()
        {
            var item = this;
            return new Hotels.Hotel
            {
                ID = item.ID,
                Name = item.Name,
                Address = item.Address,
                Manager = item.Manager/*DataStructureInfo AssignSimpleProperty Hotels.Hotel*/
            };
        }

        private Common.Queryable.Hotels_NumberOfRoomsWithoutLockMark _extension_NumberOfRoomsWithoutLockMark;

        /*DataStructureQueryable PropertyAttribute Hotels.Hotel.Extension_NumberOfRoomsWithoutLockMark*/
        public virtual Common.Queryable.Hotels_NumberOfRoomsWithoutLockMark Extension_NumberOfRoomsWithoutLockMark
        {
            get
            {
                /*DataStructureQueryable Getter Hotels.Hotel.Extension_NumberOfRoomsWithoutLockMark*/
                return _extension_NumberOfRoomsWithoutLockMark;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Hotels.Hotel.Extension_NumberOfRoomsWithoutLockMark*/
                _extension_NumberOfRoomsWithoutLockMark = value;
            }
        }

        /*DataStructureInfo QueryableClassMembers Hotels.Hotel*/

        public bool Equals(Hotels_Hotel other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Hotels.Guest*/
    public class Hotels_Guest : global::Hotels.Guest, IQueryableEntity<Hotels.Guest>, System.IEquatable<Hotels_Guest>, IDetachOverride/*DataStructureInfo QueryableClassInterace Hotels.Guest*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Hotels.Guest ToSimple()
        {
            var item = this;
            return new Hotels.Guest
            {
                ID = item.ID,
                Name = item.Name,
                Surname = item.Surname,
                Phone = item.Phone,
                Email = item.Email/*DataStructureInfo AssignSimpleProperty Hotels.Guest*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Hotels.Guest*/

        public bool Equals(Hotels_Guest other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Hotels.RoomKind*/
    public class Hotels_RoomKind : global::Hotels.RoomKind, IQueryableEntity<Hotels.RoomKind>, System.IEquatable<Hotels_RoomKind>, IDetachOverride/*DataStructureInfo QueryableClassInterace Hotels.RoomKind*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Hotels.RoomKind ToSimple()
        {
            var item = this;
            return new Hotels.RoomKind
            {
                ID = item.ID,
                Name = item.Name,
                Price = item.Price/*DataStructureInfo AssignSimpleProperty Hotels.RoomKind*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Hotels.RoomKind*/

        public bool Equals(Hotels_RoomKind other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Hotels.Room*/
    public class Hotels_Room : global::Hotels.Room, IQueryableEntity<Hotels.Room>, System.IEquatable<Hotels_Room>, IDetachOverride/*DataStructureInfo QueryableClassInterace Hotels.Room*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Hotels.Room ToSimple()
        {
            var item = this;
            return new Hotels.Room
            {
                ID = item.ID,
                RoomNumber = item.RoomNumber,
                HotelID = item.HotelID,
                RoomKindID = item.RoomKindID,
                Remark = item.Remark,
                VrijemeZadnjeIzmjene = item.VrijemeZadnjeIzmjene/*DataStructureInfo AssignSimpleProperty Hotels.Room*/
            };
        }

        private Common.Queryable.Hotels_Hotel _hotel;

        /*DataStructureQueryable PropertyAttribute Hotels.Room.Hotel*/
        public virtual Common.Queryable.Hotels_Hotel Hotel
        {
            get
            {
                /*DataStructureQueryable Getter Hotels.Room.Hotel*/
                return _hotel;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Hotels.Room.Hotel*/
                _hotel = value;
                HotelID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Hotels_RoomKind _roomKind;

        /*DataStructureQueryable PropertyAttribute Hotels.Room.RoomKind*/
        public virtual Common.Queryable.Hotels_RoomKind RoomKind
        {
            get
            {
                /*DataStructureQueryable Getter Hotels.Room.RoomKind*/
                return _roomKind;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Hotels.Room.RoomKind*/
                _roomKind = value;
                RoomKindID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Hotels_ReservationsForCertainRoom _extension_ReservationsForCertainRoom;

        /*DataStructureQueryable PropertyAttribute Hotels.Room.Extension_ReservationsForCertainRoom*/
        public virtual Common.Queryable.Hotels_ReservationsForCertainRoom Extension_ReservationsForCertainRoom
        {
            get
            {
                /*DataStructureQueryable Getter Hotels.Room.Extension_ReservationsForCertainRoom*/
                return _extension_ReservationsForCertainRoom;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Hotels.Room.Extension_ReservationsForCertainRoom*/
                _extension_ReservationsForCertainRoom = value;
            }
        }

        private Common.Queryable.Hotels_RoomGrid _extension_RoomGrid;

        /*DataStructureQueryable PropertyAttribute Hotels.Room.Extension_RoomGrid*/
        public virtual Common.Queryable.Hotels_RoomGrid Extension_RoomGrid
        {
            get
            {
                /*DataStructureQueryable Getter Hotels.Room.Extension_RoomGrid*/
                return _extension_RoomGrid;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Hotels.Room.Extension_RoomGrid*/
                _extension_RoomGrid = value;
            }
        }

        /*DataStructureInfo QueryableClassMembers Hotels.Room*/

        public bool Equals(Hotels_Room other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Hotels.Good*/
    public class Hotels_Good : global::Hotels.Good, IQueryableEntity<Hotels.Good>, System.IEquatable<Hotels_Good>, IDetachOverride/*DataStructureInfo QueryableClassInterace Hotels.Good*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Hotels.Good ToSimple()
        {
            var item = this;
            return new Hotels.Good
            {
                ID = item.ID,
                Name = item.Name,
                Price = item.Price/*DataStructureInfo AssignSimpleProperty Hotels.Good*/
            };
        }

        private Common.Queryable.Hotels_Service _extension_Service;

        /*DataStructureQueryable PropertyAttribute Hotels.Good.Extension_Service*/
        public virtual Common.Queryable.Hotels_Service Extension_Service
        {
            get
            {
                /*DataStructureQueryable Getter Hotels.Good.Extension_Service*/
                return _extension_Service;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Hotels.Good.Extension_Service*/
                _extension_Service = value;
            }
        }

        private Common.Queryable.Hotels_Product _extension_Product;

        /*DataStructureQueryable PropertyAttribute Hotels.Good.Extension_Product*/
        public virtual Common.Queryable.Hotels_Product Extension_Product
        {
            get
            {
                /*DataStructureQueryable Getter Hotels.Good.Extension_Product*/
                return _extension_Product;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Hotels.Good.Extension_Product*/
                _extension_Product = value;
            }
        }

        /*DataStructureInfo QueryableClassMembers Hotels.Good*/

        public bool Equals(Hotels_Good other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Hotels.GoodKind*/
    public class Hotels_GoodKind : global::Hotels.GoodKind, IQueryableEntity<Hotels.GoodKind>, System.IEquatable<Hotels_GoodKind>, IDetachOverride/*DataStructureInfo QueryableClassInterace Hotels.GoodKind*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Hotels.GoodKind ToSimple()
        {
            var item = this;
            return new Hotels.GoodKind
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Hotels.GoodKind*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Hotels.GoodKind*/

        public bool Equals(Hotels_GoodKind other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Hotels.Service*/
    public class Hotels_Service : global::Hotels.Service, IQueryableEntity<Hotels.Service>, System.IEquatable<Hotels_Service>, IDetachOverride/*DataStructureInfo QueryableClassInterace Hotels.Service*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Hotels.Service ToSimple()
        {
            var item = this;
            return new Hotels.Service
            {
                ID = item.ID,
                GoodKindID = item.GoodKindID/*DataStructureInfo AssignSimpleProperty Hotels.Service*/
            };
        }

        private Common.Queryable.Hotels_GoodKind _goodKind;

        /*DataStructureQueryable PropertyAttribute Hotels.Service.GoodKind*/
        public virtual Common.Queryable.Hotels_GoodKind GoodKind
        {
            get
            {
                /*DataStructureQueryable Getter Hotels.Service.GoodKind*/
                return _goodKind;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Hotels.Service.GoodKind*/
                _goodKind = value;
                GoodKindID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Hotels_Good _base;

        /*DataStructureQueryable PropertyAttribute Hotels.Service.Base*/
        public virtual Common.Queryable.Hotels_Good Base
        {
            get
            {
                /*DataStructureQueryable Getter Hotels.Service.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Hotels.Service.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Hotels.Service*/

        public bool Equals(Hotels_Service other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Hotels.Product*/
    public class Hotels_Product : global::Hotels.Product, IQueryableEntity<Hotels.Product>, System.IEquatable<Hotels_Product>, IDetachOverride/*DataStructureInfo QueryableClassInterace Hotels.Product*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Hotels.Product ToSimple()
        {
            var item = this;
            return new Hotels.Product
            {
                ID = item.ID,
                GoodKindID = item.GoodKindID/*DataStructureInfo AssignSimpleProperty Hotels.Product*/
            };
        }

        private Common.Queryable.Hotels_GoodKind _goodKind;

        /*DataStructureQueryable PropertyAttribute Hotels.Product.GoodKind*/
        public virtual Common.Queryable.Hotels_GoodKind GoodKind
        {
            get
            {
                /*DataStructureQueryable Getter Hotels.Product.GoodKind*/
                return _goodKind;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Hotels.Product.GoodKind*/
                _goodKind = value;
                GoodKindID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Hotels_Good _base;

        /*DataStructureQueryable PropertyAttribute Hotels.Product.Base*/
        public virtual Common.Queryable.Hotels_Good Base
        {
            get
            {
                /*DataStructureQueryable Getter Hotels.Product.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Hotels.Product.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Hotels.Product*/

        public bool Equals(Hotels_Product other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Hotels.Reservation*/
    public class Hotels_Reservation : global::Hotels.Reservation, IQueryableEntity<Hotels.Reservation>, System.IEquatable<Hotels_Reservation>, IDetachOverride/*DataStructureInfo QueryableClassInterace Hotels.Reservation*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Hotels.Reservation ToSimple()
        {
            var item = this;
            return new Hotels.Reservation
            {
                ID = item.ID,
                DateFrom = item.DateFrom,
                DateTo = item.DateTo,
                GuestID = item.GuestID,
                RoomID = item.RoomID/*DataStructureInfo AssignSimpleProperty Hotels.Reservation*/
            };
        }

        private Common.Queryable.Hotels_Guest _guest;

        /*DataStructureQueryable PropertyAttribute Hotels.Reservation.Guest*/
        public virtual Common.Queryable.Hotels_Guest Guest
        {
            get
            {
                /*DataStructureQueryable Getter Hotels.Reservation.Guest*/
                return _guest;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Hotels.Reservation.Guest*/
                _guest = value;
                GuestID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Hotels_Room _room;

        /*DataStructureQueryable PropertyAttribute Hotels.Reservation.Room*/
        public virtual Common.Queryable.Hotels_Room Room
        {
            get
            {
                /*DataStructureQueryable Getter Hotels.Reservation.Room*/
                return _room;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Hotels.Reservation.Room*/
                _room = value;
                RoomID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Hotels.Reservation*/

        public bool Equals(Hotels_Reservation other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Hotels.ReservationsForCertainRoom*/
    public class Hotels_ReservationsForCertainRoom : global::Hotels.ReservationsForCertainRoom, IQueryableEntity<Hotels.ReservationsForCertainRoom>, System.IEquatable<Hotels_ReservationsForCertainRoom>, IDetachOverride/*DataStructureInfo QueryableClassInterace Hotels.ReservationsForCertainRoom*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Hotels.ReservationsForCertainRoom ToSimple()
        {
            var item = this;
            return new Hotels.ReservationsForCertainRoom
            {
                ID = item.ID,
                NumberOfReservations = item.NumberOfReservations/*DataStructureInfo AssignSimpleProperty Hotels.ReservationsForCertainRoom*/
            };
        }

        private Common.Queryable.Hotels_Room _base;

        /*DataStructureQueryable PropertyAttribute Hotels.ReservationsForCertainRoom.Base*/
        public virtual Common.Queryable.Hotels_Room Base
        {
            get
            {
                /*DataStructureQueryable Getter Hotels.ReservationsForCertainRoom.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Hotels.ReservationsForCertainRoom.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Hotels.ReservationsForCertainRoom*/

        public bool Equals(Hotels_ReservationsForCertainRoom other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Hotels.RoomGrid*/
    public class Hotels_RoomGrid : global::Hotels.RoomGrid, IQueryableEntity<Hotels.RoomGrid>, System.IEquatable<Hotels_RoomGrid>, IDetachOverride/*DataStructureInfo QueryableClassInterace Hotels.RoomGrid*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Hotels.RoomGrid ToSimple()
        {
            var item = this;
            return new Hotels.RoomGrid
            {
                ID = item.ID,
                RoomNumber = item.RoomNumber,
                HotelName = item.HotelName,
                NumberOfReservations = item.NumberOfReservations/*DataStructureInfo AssignSimpleProperty Hotels.RoomGrid*/
            };
        }

        private Common.Queryable.Hotels_Room _base;

        /*DataStructureQueryable PropertyAttribute Hotels.RoomGrid.Base*/
        public virtual Common.Queryable.Hotels_Room Base
        {
            get
            {
                /*DataStructureQueryable Getter Hotels.RoomGrid.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Hotels.RoomGrid.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Hotels.RoomGrid*/

        public bool Equals(Hotels_RoomGrid other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Hotels.Invoice*/
    public class Hotels_Invoice : global::Hotels.Invoice, IQueryableEntity<Hotels.Invoice>, System.IEquatable<Hotels_Invoice>, IDetachOverride/*DataStructureInfo QueryableClassInterace Hotels.Invoice*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Hotels.Invoice ToSimple()
        {
            var item = this;
            return new Hotels.Invoice
            {
                ID = item.ID,
                Amount = item.Amount,
                Discount = item.Discount,
                Payed = item.Payed,
                ReservationID = item.ReservationID/*DataStructureInfo AssignSimpleProperty Hotels.Invoice*/
            };
        }

        private Common.Queryable.Hotels_Reservation _reservation;

        /*DataStructureQueryable PropertyAttribute Hotels.Invoice.Reservation*/
        public virtual Common.Queryable.Hotels_Reservation Reservation
        {
            get
            {
                /*DataStructureQueryable Getter Hotels.Invoice.Reservation*/
                return _reservation;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Hotels.Invoice.Reservation*/
                _reservation = value;
                ReservationID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Hotels.Invoice*/

        public bool Equals(Hotels_Invoice other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Hotels.Item*/
    public class Hotels_Item : global::Hotels.Item, IQueryableEntity<Hotels.Item>, System.IEquatable<Hotels_Item>, IDetachOverride/*DataStructureInfo QueryableClassInterace Hotels.Item*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Hotels.Item ToSimple()
        {
            var item = this;
            return new Hotels.Item
            {
                ID = item.ID,
                Name = item.Name,
                GoodID = item.GoodID,
                InvoiceID = item.InvoiceID/*DataStructureInfo AssignSimpleProperty Hotels.Item*/
            };
        }

        private Common.Queryable.Hotels_Good _good;

        /*DataStructureQueryable PropertyAttribute Hotels.Item.Good*/
        public virtual Common.Queryable.Hotels_Good Good
        {
            get
            {
                /*DataStructureQueryable Getter Hotels.Item.Good*/
                return _good;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Hotels.Item.Good*/
                _good = value;
                GoodID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Hotels_Invoice _invoice;

        /*DataStructureQueryable PropertyAttribute Hotels.Item.Invoice*/
        public virtual Common.Queryable.Hotels_Invoice Invoice
        {
            get
            {
                /*DataStructureQueryable Getter Hotels.Item.Invoice*/
                return _invoice;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Hotels.Item.Invoice*/
                _invoice = value;
                InvoiceID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Hotels.Item*/

        public bool Equals(Hotels_Item other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Hotels.NumberOfRoomsWithoutLockMark*/
    public class Hotels_NumberOfRoomsWithoutLockMark : global::Hotels.NumberOfRoomsWithoutLockMark, IQueryableEntity<Hotels.NumberOfRoomsWithoutLockMark>, System.IEquatable<Hotels_NumberOfRoomsWithoutLockMark>, IDetachOverride/*DataStructureInfo QueryableClassInterace Hotels.NumberOfRoomsWithoutLockMark*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Hotels.NumberOfRoomsWithoutLockMark ToSimple()
        {
            var item = this;
            return new Hotels.NumberOfRoomsWithoutLockMark
            {
                ID = item.ID,
                NumberOfRooms = item.NumberOfRooms/*DataStructureInfo AssignSimpleProperty Hotels.NumberOfRoomsWithoutLockMark*/
            };
        }

        private Common.Queryable.Hotels_Hotel _base;

        /*DataStructureQueryable PropertyAttribute Hotels.NumberOfRoomsWithoutLockMark.Base*/
        public virtual Common.Queryable.Hotels_Hotel Base
        {
            get
            {
                /*DataStructureQueryable Getter Hotels.NumberOfRoomsWithoutLockMark.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Hotels.NumberOfRoomsWithoutLockMark.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Hotels.NumberOfRoomsWithoutLockMark*/

        public bool Equals(Hotels_NumberOfRoomsWithoutLockMark other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Hotels.S1*/
    public class Hotels_S1 : global::Hotels.S1, IQueryableEntity<Hotels.S1>, System.IEquatable<Hotels_S1>, IDetachOverride/*DataStructureInfo QueryableClassInterace Hotels.S1*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Hotels.S1 ToSimple()
        {
            var item = this;
            return new Hotels.S1
            {
                ID = item.ID,
                Oznaka = item.Oznaka,
                Naziv = item.Naziv/*DataStructureInfo AssignSimpleProperty Hotels.S1*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Hotels.S1*/

        public bool Equals(Hotels_S1 other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*CommonQueryableMemebers*/
}

namespace Rhetos.Dom.DefaultConcepts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    public static class QueryExtensions
    {
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.AutoCodeCache> ToSimple(this IQueryable<Common.Queryable.Common_AutoCodeCache> query)
        {
            return query.Select(item => new Common.AutoCodeCache
            {
                ID = item.ID,
                Entity = item.Entity,
                Property = item.Property,
                Grouping = item.Grouping,
                Prefix = item.Prefix,
                MinDigits = item.MinDigits,
                LastCode = item.LastCode/*DataStructureInfo AssignSimpleProperty Common.AutoCodeCache*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.FilterId> ToSimple(this IQueryable<Common.Queryable.Common_FilterId> query)
        {
            return query.Select(item => new Common.FilterId
            {
                ID = item.ID,
                Handle = item.Handle,
                Value = item.Value/*DataStructureInfo AssignSimpleProperty Common.FilterId*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.KeepSynchronizedMetadata> ToSimple(this IQueryable<Common.Queryable.Common_KeepSynchronizedMetadata> query)
        {
            return query.Select(item => new Common.KeepSynchronizedMetadata
            {
                ID = item.ID,
                Target = item.Target,
                Source = item.Source,
                Context = item.Context/*DataStructureInfo AssignSimpleProperty Common.KeepSynchronizedMetadata*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.ExclusiveLock> ToSimple(this IQueryable<Common.Queryable.Common_ExclusiveLock> query)
        {
            return query.Select(item => new Common.ExclusiveLock
            {
                ID = item.ID,
                ResourceType = item.ResourceType,
                ResourceID = item.ResourceID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                LockStart = item.LockStart,
                LockFinish = item.LockFinish/*DataStructureInfo AssignSimpleProperty Common.ExclusiveLock*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.LogReader> ToSimple(this IQueryable<Common.Queryable.Common_LogReader> query)
        {
            return query.Select(item => new Common.LogReader
            {
                ID = item.ID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.LogReader*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.LogRelatedItemReader> ToSimple(this IQueryable<Common.Queryable.Common_LogRelatedItemReader> query)
        {
            return query.Select(item => new Common.LogRelatedItemReader
            {
                ID = item.ID,
                TableName = item.TableName,
                Relation = item.Relation,
                ItemId = item.ItemId,
                LogID = item.LogID/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItemReader*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Log> ToSimple(this IQueryable<Common.Queryable.Common_Log> query)
        {
            return query.Select(item => new Common.Log
            {
                ID = item.ID,
                Created = item.Created,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description/*DataStructureInfo AssignSimpleProperty Common.Log*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.LogRelatedItem> ToSimple(this IQueryable<Common.Queryable.Common_LogRelatedItem> query)
        {
            return query.Select(item => new Common.LogRelatedItem
            {
                ID = item.ID,
                LogID = item.LogID,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Relation = item.Relation/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItem*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.RelatedEventsSource> ToSimple(this IQueryable<Common.Queryable.Common_RelatedEventsSource> query)
        {
            return query.Select(item => new Common.RelatedEventsSource
            {
                ID = item.ID,
                LogID = item.LogID,
                Relation = item.Relation,
                RelatedToTable = item.RelatedToTable,
                RelatedToItem = item.RelatedToItem,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.RelatedEventsSource*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Claim> ToSimple(this IQueryable<Common.Queryable.Common_Claim> query)
        {
            return query.Select(item => new Common.Claim
            {
                ID = item.ID,
                ClaimResource = item.ClaimResource,
                ClaimRight = item.ClaimRight,
                Active = item.Active/*DataStructureInfo AssignSimpleProperty Common.Claim*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.MyClaim> ToSimple(this IQueryable<Common.Queryable.Common_MyClaim> query)
        {
            return query.Select(item => new Common.MyClaim
            {
                ID = item.ID,
                Applies = item.Applies/*DataStructureInfo AssignSimpleProperty Common.MyClaim*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Principal> ToSimple(this IQueryable<Common.Queryable.Common_Principal> query)
        {
            return query.Select(item => new Common.Principal
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Principal*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.PrincipalHasRole> ToSimple(this IQueryable<Common.Queryable.Common_PrincipalHasRole> query)
        {
            return query.Select(item => new Common.PrincipalHasRole
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                RoleID = item.RoleID/*DataStructureInfo AssignSimpleProperty Common.PrincipalHasRole*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Role> ToSimple(this IQueryable<Common.Queryable.Common_Role> query)
        {
            return query.Select(item => new Common.Role
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Role*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.RoleInheritsRole> ToSimple(this IQueryable<Common.Queryable.Common_RoleInheritsRole> query)
        {
            return query.Select(item => new Common.RoleInheritsRole
            {
                ID = item.ID,
                UsersFromID = item.UsersFromID,
                PermissionsFromID = item.PermissionsFromID/*DataStructureInfo AssignSimpleProperty Common.RoleInheritsRole*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.PrincipalPermission> ToSimple(this IQueryable<Common.Queryable.Common_PrincipalPermission> query)
        {
            return query.Select(item => new Common.PrincipalPermission
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.PrincipalPermission*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.RolePermission> ToSimple(this IQueryable<Common.Queryable.Common_RolePermission> query)
        {
            return query.Select(item => new Common.RolePermission
            {
                ID = item.ID,
                RoleID = item.RoleID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.RolePermission*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Hotels.Hotel> ToSimple(this IQueryable<Common.Queryable.Hotels_Hotel> query)
        {
            return query.Select(item => new Hotels.Hotel
            {
                ID = item.ID,
                Name = item.Name,
                Address = item.Address,
                Manager = item.Manager/*DataStructureInfo AssignSimpleProperty Hotels.Hotel*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Hotels.Guest> ToSimple(this IQueryable<Common.Queryable.Hotels_Guest> query)
        {
            return query.Select(item => new Hotels.Guest
            {
                ID = item.ID,
                Name = item.Name,
                Surname = item.Surname,
                Phone = item.Phone,
                Email = item.Email/*DataStructureInfo AssignSimpleProperty Hotels.Guest*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Hotels.RoomKind> ToSimple(this IQueryable<Common.Queryable.Hotels_RoomKind> query)
        {
            return query.Select(item => new Hotels.RoomKind
            {
                ID = item.ID,
                Name = item.Name,
                Price = item.Price/*DataStructureInfo AssignSimpleProperty Hotels.RoomKind*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Hotels.Room> ToSimple(this IQueryable<Common.Queryable.Hotels_Room> query)
        {
            return query.Select(item => new Hotels.Room
            {
                ID = item.ID,
                RoomNumber = item.RoomNumber,
                HotelID = item.HotelID,
                RoomKindID = item.RoomKindID,
                Remark = item.Remark,
                VrijemeZadnjeIzmjene = item.VrijemeZadnjeIzmjene/*DataStructureInfo AssignSimpleProperty Hotels.Room*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Hotels.Good> ToSimple(this IQueryable<Common.Queryable.Hotels_Good> query)
        {
            return query.Select(item => new Hotels.Good
            {
                ID = item.ID,
                Name = item.Name,
                Price = item.Price/*DataStructureInfo AssignSimpleProperty Hotels.Good*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Hotels.GoodKind> ToSimple(this IQueryable<Common.Queryable.Hotels_GoodKind> query)
        {
            return query.Select(item => new Hotels.GoodKind
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Hotels.GoodKind*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Hotels.Service> ToSimple(this IQueryable<Common.Queryable.Hotels_Service> query)
        {
            return query.Select(item => new Hotels.Service
            {
                ID = item.ID,
                GoodKindID = item.GoodKindID/*DataStructureInfo AssignSimpleProperty Hotels.Service*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Hotels.Product> ToSimple(this IQueryable<Common.Queryable.Hotels_Product> query)
        {
            return query.Select(item => new Hotels.Product
            {
                ID = item.ID,
                GoodKindID = item.GoodKindID/*DataStructureInfo AssignSimpleProperty Hotels.Product*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Hotels.Reservation> ToSimple(this IQueryable<Common.Queryable.Hotels_Reservation> query)
        {
            return query.Select(item => new Hotels.Reservation
            {
                ID = item.ID,
                DateFrom = item.DateFrom,
                DateTo = item.DateTo,
                GuestID = item.GuestID,
                RoomID = item.RoomID/*DataStructureInfo AssignSimpleProperty Hotels.Reservation*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Hotels.ReservationsForCertainRoom> ToSimple(this IQueryable<Common.Queryable.Hotels_ReservationsForCertainRoom> query)
        {
            return query.Select(item => new Hotels.ReservationsForCertainRoom
            {
                ID = item.ID,
                NumberOfReservations = item.NumberOfReservations/*DataStructureInfo AssignSimpleProperty Hotels.ReservationsForCertainRoom*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Hotels.RoomGrid> ToSimple(this IQueryable<Common.Queryable.Hotels_RoomGrid> query)
        {
            return query.Select(item => new Hotels.RoomGrid
            {
                ID = item.ID,
                RoomNumber = item.RoomNumber,
                HotelName = item.HotelName,
                NumberOfReservations = item.NumberOfReservations/*DataStructureInfo AssignSimpleProperty Hotels.RoomGrid*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Hotels.Invoice> ToSimple(this IQueryable<Common.Queryable.Hotels_Invoice> query)
        {
            return query.Select(item => new Hotels.Invoice
            {
                ID = item.ID,
                Amount = item.Amount,
                Discount = item.Discount,
                Payed = item.Payed,
                ReservationID = item.ReservationID/*DataStructureInfo AssignSimpleProperty Hotels.Invoice*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Hotels.Item> ToSimple(this IQueryable<Common.Queryable.Hotels_Item> query)
        {
            return query.Select(item => new Hotels.Item
            {
                ID = item.ID,
                Name = item.Name,
                GoodID = item.GoodID,
                InvoiceID = item.InvoiceID/*DataStructureInfo AssignSimpleProperty Hotels.Item*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Hotels.NumberOfRoomsWithoutLockMark> ToSimple(this IQueryable<Common.Queryable.Hotels_NumberOfRoomsWithoutLockMark> query)
        {
            return query.Select(item => new Hotels.NumberOfRoomsWithoutLockMark
            {
                ID = item.ID,
                NumberOfRooms = item.NumberOfRooms/*DataStructureInfo AssignSimpleProperty Hotels.NumberOfRoomsWithoutLockMark*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Hotels.S1> ToSimple(this IQueryable<Common.Queryable.Hotels_S1> query)
        {
            return query.Select(item => new Hotels.S1
            {
                ID = item.ID,
                Oznaka = item.Oznaka,
                Naziv = item.Naziv/*DataStructureInfo AssignSimpleProperty Hotels.S1*/
            });
        }
        /*QueryExtensionsMembers*/

        /// <summary>
        /// A specific overload of the 'ToSimple' method cannot be targeted from a generic method using generic type.
        /// This method uses reflection instead to find the specific 'ToSimple' method.
        /// </summary>
        public static IQueryable<TEntity> GenericToSimple<TEntity>(this IQueryable<IEntity> i)
            where TEntity : class, IEntity
	    {
            var method = typeof(QueryExtensions).GetMethod("ToSimple", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public, null, new Type[] { i.GetType() }, null);
            if (method == null)
                throw new Rhetos.FrameworkException("Cannot find 'ToSimple' method for argument type '" + i.GetType().ToString() + "'.");
            return (IQueryable<TEntity>)Rhetos.Utilities.ExceptionsUtility.InvokeEx(method, null, new object[] { i });
        }

        /// <summary>Converts the objects to simple object and the IEnumerable to List or Array, if not already.</summary>
        public static void LoadSimpleObjects<TEntity>(ref IEnumerable<TEntity> items)
            where TEntity: class, IEntity
        {
            var query = items as IQueryable<IQueryableEntity<TEntity>>;
            var navigationItems = items as IEnumerable<IQueryableEntity<TEntity>>;

            if (query != null)
                items = query.GenericToSimple<TEntity>().ToList(); // The IQueryable function allows ORM optimizations.
            else if (navigationItems != null)
                items = navigationItems.Select(item => item.ToSimple()).ToList();
            else
            {
                Rhetos.Utilities.CsUtility.Materialize(ref items);
                var itemsList = (IList<TEntity>)items;
                for (int i = 0; i < itemsList.Count(); i++)
                {
                    var navigationItem = itemsList[i] as IQueryableEntity<TEntity>;
                    if (navigationItem != null)
                        itemsList[i] = navigationItem.ToSimple();
                }
            }
        }
    }
}