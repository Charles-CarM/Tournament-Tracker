using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }
        public static void IntializeConnections(bool database, bool textFiles)
        {
            Connections = new List<IDataConnection>();

            if(database)
            {
                //TODO - Create the SQL Connection
            }
            if(textFiles) 
            {
                //TODO - Create the Text Connection
            }
        }
    }
}
