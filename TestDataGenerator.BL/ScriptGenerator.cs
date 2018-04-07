using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDataGenerator.Data;

namespace TestDataGenerator.BL
{
    public class ScriptGenerator : IScriptGenerator
    {
        public string CreateScript(int entityCount)
        {
            throw new NotImplementedException();
        }

        public UserEntity GenerateUser()
        {
            throw new NotImplementedException();
        }

        public string GetInsertLine()
        {
            throw new NotImplementedException();
        }

        public string GetValueLine(UserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
