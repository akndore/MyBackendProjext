using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
       private IUserDal _userdal;
        public UserManager(IUserDal userDal)
        {
            _userdal = userDal;
        }
        public void Add(User user)
        {
            _userdal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userdal.Get(x => x.Email == email);
        }

        public List<Role> GetUserRoles(User user)
        {
            return _userdal.GetRoles(user);
        }
    }
}
