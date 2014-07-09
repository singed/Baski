using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baski.Orm.Models;

namespace Baski.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<Article> Articles { get; set; }
    }
}
