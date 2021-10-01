using BoardPACLogger.Application.Common.Interfaces;
using BoardPACLogger.Application.TodoItems.Commands.CreateTodoItem;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BoardPACLogger.Domain.Entities;

namespace BoardPACLogger.Application.Logs.Commands.AddLog
{
    public class AddLogItemCommand : IRequest<int>
    {
        public string Message { get; set; }
        public string Type { get; set; }
        public DateTime LogTime { get; set; }
    }

    public class AddLogItemCommandHandler : IRequestHandler<AddLogItemCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public AddLogItemCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(AddLogItemCommand request, CancellationToken cancellationToken)
        {
            var entity = new Log
            {
                Message = request.Message,
                Type = request.Type,
                LogTime = request.LogTime
            };

            _context.Logs.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
