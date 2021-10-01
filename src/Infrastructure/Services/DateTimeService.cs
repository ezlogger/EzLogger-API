using BoardPACLogger.Application.Common.Interfaces;
using System;

namespace BoardPACLogger.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
