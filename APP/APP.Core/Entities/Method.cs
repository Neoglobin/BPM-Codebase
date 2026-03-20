using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Core.Entities
{
    public class Method
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

        public string MethodCode {  get; set; } = string.Empty;

        public Guid ParentClassId { get; set; }

        public ClassEntity? ParentClass { get; set; }

        public List<Method> InvokesMethod { get; set; } = [];

        public List<Method> InvokesFromMethod { get; set; } = [];

        public int Rating { get; set; } = 0;

        public string Purpose { get; set; } = string.Empty;

        public string Suggestion { get; set; } = string.Empty;
    }
}
