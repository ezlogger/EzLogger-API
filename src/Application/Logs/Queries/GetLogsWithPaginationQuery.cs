using AutoMapper;
using AutoMapper.QueryableExtensions;
using BoardPACLogger.Application.Common.Interfaces;
using BoardPACLogger.Application.Common.Mappings;
using BoardPACLogger.Application.Common.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BoardPACLogger.Application.Logs.Queries
{

    public class GetLogsWithPaginationQuery : IRequest<PaginatedList<LogItemDto>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; } 
    }

    public class GetLogsWithPaginationQueryHandler : IRequestHandler<GetLogsWithPaginationQuery, PaginatedList<LogItemDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetLogsWithPaginationQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedList<LogItemDto>> Handle(GetLogsWithPaginationQuery request, CancellationToken cancellationToken)
        {
            var logs = await _context.Logs
                .OrderBy(x => x.LogTime)
                .ProjectTo<LogItemDto>(_mapper.ConfigurationProvider)
                .PaginatedListAsync(request.PageNumber, request.PageSize);

            return logs;
        }
    }
}
