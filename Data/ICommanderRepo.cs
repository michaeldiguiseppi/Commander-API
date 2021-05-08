using Commander_API.Models;
using System.Collections.Generic;

namespace Commander_API.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);

    }
}