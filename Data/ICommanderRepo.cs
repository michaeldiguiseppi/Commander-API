using Commander_API.Models;
using System.Collections.Generic;

namespace Commander_API.Data
{
    public interface ICommanderRepo
    {

        bool SaveChanges();

        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command command);

    }
}