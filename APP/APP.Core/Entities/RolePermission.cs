using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Core.Entities
{
    public class RolePermission
    {
        // BaseColumns 
        public Guid Id { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public Guid CreatedBy { get; set; }

        public DateTime ModifiedOn { get; set; } = DateTime.UtcNow;

        public Guid ModifiedBy { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        // AdditionalColumns

        public List<UserRole> Role { get; set; } = [];
    }
}
