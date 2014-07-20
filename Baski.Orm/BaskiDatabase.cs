using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baski.Orm.Models;
using Dapper;

namespace Baski.Orm
{
    public class BaskiDatabase : Database<BaskiDatabase>
    {
        public Table<Article> Articles { get; set; }
        public Table<Player> Players { get; set; }
        public Table<Game> Games { get; set; }
        public Table<Statistic> Statistics { get; set; }
        public Table<Widget> Widgets { get; set; }
    }
}
