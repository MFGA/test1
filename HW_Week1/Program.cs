using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;


namespace HW_Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticketfile;
            StringBuilder ticketcontent = new StringBuilder();
            ticketcontent.AppendLine("TicketID, Summary, Status, Priority, Submitter, Assigned, Watching");
            ticketcontent.AppendLine("1,This is a bug ticket,Open, High,Drew Kjell,Jane Doe, Drew Kjell|John Smith|Bill Jones");
            string csvpath = Tickets.cvs;
            File.AppendAllText(csvpath, ticketcontent.ToString());



        }
    }
}
