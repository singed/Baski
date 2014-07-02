using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Baski.Authentication;
using Baski.Orm;
using Baski.Orm.Repositories;

namespace Baski.Controllers
{
    public class BaseController : Controller
    {
        private RepositoryBase _repository;
        private IAccountService _accountService;
        private MembershipUser _user;

        public BaskiDatabase Repository {
            get
            {
                _repository = _repository ?? new RepositoryBase();
                return _repository.Db;
            }
        }

        public IAccountService AccountService
        {
            get
            {
                _accountService = _accountService ?? new AccountService(new ModelStateWrapper(ModelState));
                return _accountService;
            }
        }
	}
}