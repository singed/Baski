using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baski.Authentication;
using Baski.Orm;
using Baski.Orm.Repositories;

namespace Baski.Areas.Admin.Controllers
{
    [CustomAuthorize(Roles = "Administrator")]
    public class AdminBaseController : Controller
    {
        private RepositoryBase _repository;
        public BaskiDatabase Repository
        {
            get
            {
                _repository = _repository ?? new RepositoryBase();
                return _repository.Db;
            }
        }

	}
}