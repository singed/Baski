using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baski.Orm.Model;
using Dapper;

namespace Baski.Orm
{
    public class BaskiDatabase : Database<BaskiDatabase>
    {
        public Table<Article> Articles { get; set; }
    }
}
