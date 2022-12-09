using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    internal class Paper
    {
        public string Workname { get; set; }
        public string person { get; set; }
        public DateTime pubdate { get; set; }

        public Paper(string Workname, string Person, DateTime Pubdate) // Конструктор с параметрами.
        {
            this.Workname = Workname;
            person = Person;
            pubdate = Pubdate; 
        }
        public Paper() : this("Workname", "Person", new DateTime(2022, 12, 1)) // Конструктор без парпаметров для инициализации
        {

        }
        private string ToFullString()
        {
            return Workname + " " + person + "" + pubdate;
        }
    }
}
