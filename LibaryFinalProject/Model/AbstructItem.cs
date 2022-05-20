using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// cucu
// another clever commentary
namespace LibaryFinalProject.Model
{
    public abstract class AbstructItem
    {
        private string title;
        public AbstructItem(string title) => this.title = title;
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

    }
}
