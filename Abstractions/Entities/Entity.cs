using Domain.Abstractions.Notifications;
using Infra.Data.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;

namespace Domain.Abstractions.Entity
{
    public abstract class Entity : IEntity<long>
    {
        public virtual long Id { get; protected set; }
        public virtual DateTime CreatedDate { get; protected set; }

        public Entity()
        {
            this.CreatedDate = DateTime.Now;
        }

        public Entity(DateTime createdDate)
        {
            this.CreatedDate = DateTime.Now;
        }

        #region Notifications

        [NotMapped]
        private List<DomainNotification> _notifications;

        [NotMapped, JsonIgnore]
        public IEnumerable<DomainNotification> Notifications { get => this._notifications?.AsReadOnly(); }

        [NotMapped, JsonIgnore]
        public bool Invalid { get => this._notifications != null ? this._notifications.Any() : false; }

        [NotMapped, JsonIgnore]
        public bool Valid { get => this._notifications != null ? !this._notifications.Any() : true; }

        public void AddNotification(string mensagem)
        {
            if (this._notifications == null)
                this._notifications = new List<DomainNotification>();

            this._notifications.Add(new DomainNotification(GetType().Name, mensagem));
        }

        #endregion
    }
}
