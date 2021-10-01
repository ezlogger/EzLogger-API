using BoardPACLogger.Application.Common.Mappings;
using BoardPACLogger.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardPACLogger.Application.Logs.Queries
{
    public class LogItemDto : IMapFrom<Log>
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public DateTime LogTime { get; set; }
    }
}
