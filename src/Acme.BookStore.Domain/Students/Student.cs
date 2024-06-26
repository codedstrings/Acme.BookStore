﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Students
{
    public class Student : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
    }
}
