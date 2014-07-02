using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Baski.Orm.Repositories
{
    public class RepositoryBase
    {
        public BaskiDatabase Db { get; set; }

        public RepositoryBase()
        {
            var cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["BaskiConnection"].ToString());
            cnn.Open();

            Db = BaskiDatabase.Init(cnn, commandTimeout: 2);
        }

    }
}
