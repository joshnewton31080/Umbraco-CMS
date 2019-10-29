﻿using System.Collections.Generic;
using Umbraco.Core.Models;

namespace Umbraco.Core.Persistence.Repositories
{
    public interface IRelationRepository : IReadWriteQueryRepository<int, IRelation>
    {
        /// <summary>
        /// Deletes all relations for a parent for any specified relation type alias
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="relationTypeAliases">
        /// A list of relation types to match for deletion, if none are specified then all relations for this parent id are deleted
        /// </param>
        void DeleteByParent(int parentId, params string[] relationTypeAliases);
    }
}
