using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baski.Orm.Model
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public bool HasVideo { get; set; }
        public DateTime DateTime { get; set; }
        public string ResoruceUrl { get; set; }
    }
}
