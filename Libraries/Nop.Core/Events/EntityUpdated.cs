﻿
using Nop.Domain;

namespace Nop.Core.Events
{
    /// <summary>
    /// A container for entities that are updated.
    /// 用于更新实体的容器。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EntityUpdated<T> where T : BaseEntity
    {
        public EntityUpdated(T entity)
        {
            this.Entity = entity;
        }

        public T Entity { get; private set; }
    }
}
