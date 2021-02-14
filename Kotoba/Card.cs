using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // Pentru DataTable

namespace Kotoba
{
    public class Card
    {
        public int id, stage;
        public string front, back;
        public DateTime revision_time;

        public Card() { }

        public Card(DataRow row)
        {
            
            this.id = row.Field<int>("cardid");
            this.front = row.Field<string>("front");
            this.back = row.Field<string>("back");
            this.stage = row.Field<int>("stage");
            this.revision_time = row.Field<DateTime>("revision_time");
            
        }




    }
}
