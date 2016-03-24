using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.GData.Client;
using Google.GData.Extensions;
using Google.GData.Spreadsheets;
using SlackCommander.Web.Todo;

namespace SlackCommander.Web
{
    public class Reader
    {
        public Reader()
        {
            
        }

        public class scope
        {
            public string Id { get; set; }
            public string Text { get; set; }
            public List<TodoItem> Items { get; set; }
        }

        public class DataBase : List<scope>
        {

        }
    }
}
