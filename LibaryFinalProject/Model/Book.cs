using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//!!!
// very important commentary
namespace LibaryFinalProject.Model
{
    public class Book : AbstructItem
    {
        public string Author { get; set; }
        public string ISBN { get; set; }
        public Book() : base("Default") => ISBN = Guid.NewGuid().ToString();

        public Book(string title) : base(title) => ISBN = Guid.NewGuid().ToString();

    }
}
