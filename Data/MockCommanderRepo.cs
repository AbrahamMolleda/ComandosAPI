/*using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commmands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform ="Kettle & Pan"},
                new Command { Id = 1, HowTo = "Cut Bread", Line = "Get a Knife", Platform ="Knife $ chopping board"},
                new Command { Id = 2, HowTo = "Make cup of tea", Line = "Place teabag in cup", Platform ="Kettle & cup"}
            };
            return commmands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle & Pan"};
        }
    }
}
*/