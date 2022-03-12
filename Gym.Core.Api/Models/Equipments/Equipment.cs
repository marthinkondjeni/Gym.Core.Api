// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Core.Api.Models.Equipments
{
    public class Equipment
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset PurchaseDate { get; set; }
    }
}
