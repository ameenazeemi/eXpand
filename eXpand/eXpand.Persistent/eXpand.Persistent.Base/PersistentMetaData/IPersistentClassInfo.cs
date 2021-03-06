using System.Collections.Generic;
using System;

namespace eXpand.Persistent.Base.PersistentMetaData {
    public interface IPersistentClassInfo:IPersistentTemplatedTypeInfo {
        string BaseTypeFullName { get; set; }
        string MergedObjectFullName { get; set; }
        IList<IPersistentMemberInfo> OwnMembers { get; }
        IList<IInterfaceInfo> Interfaces { get; }
        Type GetDefaultBaseClass();
        IPersistentAssemblyInfo PersistentAssemblyInfo { get; set; }
    }
}