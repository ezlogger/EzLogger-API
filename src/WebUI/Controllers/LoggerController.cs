using BoardPACLogger.Application.Common.Models;
using BoardPACLogger.Application.Logs.Commands.AddLog;
using BoardPACLogger.Application.Logs.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BoardPACLogger.WebUI.Controllers
{
    public class LoggerController : ApiControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<int>> Add(AddLogItemCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet]
        public async Task<ActionResult<PaginatedList<LogItemDto>>> GetTodoItemsWithPagination([FromQuery] GetLogsWithPaginationQuery query)
        {
            return await Mediator.Send(query);
        }
    }
}
