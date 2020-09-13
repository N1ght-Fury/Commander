using System.Collections.Generic;
using Commander.Models;

//No longer needed

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Test1", Line = "Yay1", Platform = "Linux" },
                new Command { Id = 1, HowTo = "Test2", Line = "Yay2", Platform = "MacOS" },
                new Command { Id = 2, HowTo = "Test3", Line = "Yay3", Platform = "Windows" },
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Test", Line = "Yay", Platform = "Pan" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}