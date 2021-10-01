using BoardPACLogger.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardPACLogger.Domain.Entities
{
    public class Log : AuditableEntity
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public DateTime LogTime { get; set; }
    }
}
