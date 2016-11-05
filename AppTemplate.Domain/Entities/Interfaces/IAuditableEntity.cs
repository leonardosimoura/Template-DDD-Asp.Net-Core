using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTemplate.Domain.Entities.Interfaces
{
    public interface IAuditableEntity
    {

        object Id { get; }
        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }
        DateTime DeletedDate { get; set; }
        int CreatedByKey { get; set; }
        int UpdatedByKey { get; set; }
        int DeletedByKey { get; set; }
    }
}
