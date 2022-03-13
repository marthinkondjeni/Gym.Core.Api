// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Gym.Core.Api.Models.Equipments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Core.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Equipment> Equipments { get; set; }

        public async ValueTask<Equipment> InsertEquipmentAsync(Equipment equipment)
        {
            using var broker = new StorageBroker(this.configuration);
            EntityEntry<Equipment> equipmentEntityEntry = await broker.Equipments.AddAsync(entity: equipment);
            await broker.SaveChangesAsync();

            return equipmentEntityEntry.Entity;
        }

        public IQueryable<Equipment> SelectAllEquipments() => this.Equipments;

        public async ValueTask<Equipment> SelectEquipmentByIdAsync(Guid equipmentId)
        {
            using var broker = new StorageBroker(this.configuration);
            broker.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            return await Equipments.FindAsync(equipmentId);
        }

        public async ValueTask<Equipment> UpdateEquipmentAsync(Equipment equipment)
        {
            using var broker = new StorageBroker(this.configuration);
            EntityEntry<Equipment> equipmentEntityEntry = broker.Equipments.Update(entity: equipment);
            await broker.SaveChangesAsync();

            return equipmentEntityEntry.Entity;
        }

        public async ValueTask<Equipment> DeleteEquipmentAsync(Equipment equipment)
        {
            using var broker = new StorageBroker(this.configuration);
            EntityEntry<Equipment> equipmentEntityEntry = broker.Equipments.Remove(entity: equipment);
            await broker.SaveChangesAsync();

            return equipmentEntityEntry.Entity;
        }
    }
}
